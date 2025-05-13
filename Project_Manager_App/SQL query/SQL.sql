-- 1. Tạo Database và chọn sử dụng
CREATE DATABASE newProjectManagerApp;
GO
USE newProjectManagerApp;
GO

-- 2. Drop các bảng nếu đã tồn tại (theo thứ tự phụ thuộc)
IF OBJECT_ID('dbo.Messages', 'U') IS NOT NULL DROP TABLE dbo.Messages;
GO
IF OBJECT_ID('dbo.Chats', 'U') IS NOT NULL DROP TABLE dbo.Chats;
GO
IF OBJECT_ID('dbo.Tasks', 'U') IS NOT NULL DROP TABLE dbo.Tasks;
GO
IF OBJECT_ID('dbo.ProjectMembers', 'U') IS NOT NULL DROP TABLE dbo.ProjectMembers;
GO
IF OBJECT_ID('dbo.Projects', 'U') IS NOT NULL DROP TABLE dbo.Projects;
GO
IF OBJECT_ID('dbo.Users', 'U') IS NOT NULL DROP TABLE dbo.Users;
GO

-- 3. Bảng Users
CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL,
    Avatar VARCHAR(255) NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    Sex VARCHAR(10) NULL
      CHECK (Sex IN ('Male','Female','Other')),
    PhoneNumber VARCHAR(20) NULL,
    Address VARCHAR(255) NULL,
    Role VARCHAR(50) NOT NULL
);
GO

-- 4. Bảng Projects
CREATE TABLE Projects (
    ProjectId INT IDENTITY(1,1) PRIMARY KEY,
    Leader INT NOT NULL,
    ProjectName VARCHAR(100) NOT NULL,
    ImageNameofProject VARCHAR(255) NULL,
    FileAttached VARCHAR(255) NULL,
    CONSTRAINT FK_Projects_Leader FOREIGN KEY (Leader)
        REFERENCES Users(UserId)
        ON DELETE NO ACTION    -- không tự động xóa khi User bị xoá
        -- ON UPDATE NO ACTION là mặc định
);
GO

-- 5. Bảng ProjectMembers (quan hệ N–N Users ↔ Projects)
CREATE TABLE ProjectMembers (
    ProjectId INT NOT NULL,
    UserId    INT NOT NULL,
    PRIMARY KEY (ProjectId, UserId),
    CONSTRAINT FK_PM_Projects FOREIGN KEY (ProjectId)
        REFERENCES Projects(ProjectId)
        ON DELETE CASCADE,     -- khi Project bị xoá, xoá hết các dòng liên quan
    CONSTRAINT FK_PM_Users FOREIGN KEY (UserId)
        REFERENCES Users(UserId)
        ON DELETE NO ACTION    -- khi User bị xoá, giữ nguyên bản ghi để không tạo đa đường cascade
);
GO

-- 6. Bảng Tasks
CREATE TABLE Tasks (
    TaskId INT IDENTITY(1,1) PRIMARY KEY,
    ProjectId INT NOT NULL,
    User_Assume INT NULL,
    Content NVARCHAR(MAX) NOT NULL,
    Begin_date DATE NOT NULL,
    Finish_date DATE NOT NULL,
    taskStatus VARCHAR(20) NOT NULL
      DEFAULT 'Pending'
      CHECK (taskStatus IN ('Pending','InProgress','Completed','Cancelled')),
    CONSTRAINT FK_Tasks_Projects FOREIGN KEY (ProjectId)
        REFERENCES Projects(ProjectId)
        ON DELETE CASCADE,     -- khi Project bị xoá, xoá luôn Tasks
    CONSTRAINT FK_Tasks_Users FOREIGN KEY (User_Assume)
        REFERENCES Users(UserId)
        ON DELETE SET NULL     -- khi User bị xoá, set NULL thay vì cascade
);
GO

-- 7. Bảng Chats
CREATE TABLE Chats (
    ChatId INT IDENTITY(1,1) PRIMARY KEY,
    ProjectId INT NOT NULL,
    CONSTRAINT FK_Chats_Projects FOREIGN KEY (ProjectId)
        REFERENCES Projects(ProjectId)
        ON DELETE CASCADE     -- khi Project bị xoá, xoá luôn Chats
);
GO

-- 8. Bảng Messages
CREATE TABLE Messages (
    MessageId INT IDENTITY(1,1) PRIMARY KEY,
    ChatId INT NOT NULL,
    MessageTime DATETIME2 NOT NULL
      DEFAULT SYSUTCDATETIME(),
    Message NVARCHAR(MAX) NOT NULL,
    Sender INT NULL,
    CONSTRAINT FK_Messages_Chats FOREIGN KEY (ChatId)
        REFERENCES Chats(ChatId)
        ON DELETE CASCADE,    -- khi Chat bị xoá, xoá luôn Messages
    CONSTRAINT FK_Messages_Users FOREIGN KEY (Sender)
        REFERENCES Users(UserId)
        ON DELETE SET NULL    -- khi User bị xoá, set NULL Sender
);
GO

-- Dữ liệu mẫu
-- Users
INSERT INTO Users (Username, Password, Avatar, Email, Sex, PhoneNumber, Address, Role)
VALUES 
('alice', 'password123', NULL, 'alice@example.com', 'Female', '1234567890', 'Hanoi', 'Developer'),
('bob', 'password123', NULL, 'bob@example.com', 'Male', '0987654321', 'HCM', 'Manager'),
('charlie', 'password123', NULL, 'charlie@example.com', 'Male', '0123456789', 'Danang', 'Tester'),
('diana', 'password123', NULL, 'diana@example.com', 'Female', '0432981123', 'Hue', 'Developer'),
('eric', 'password123', NULL, 'eric@example.com', 'Male', '0234981123', 'Can Tho', 'Scrum Master'),
('frank', 'password123', NULL, 'frank@example.com', 'Male', '0349981123', 'Nha Trang', 'DevOps'),
('grace', 'password123', NULL, 'grace@example.com', 'Female', '0541981123', 'Hanoi', 'Designer'),
('helen', 'password123', NULL, 'helen@example.com', 'Female', '0632981123', 'HCM', 'BA'),
('ian', 'password123', NULL, 'ian@example.com', 'Male', '0932981123', 'HCM', 'QA'),
('jack', 'password123', NULL, 'jack@example.com', 'Male', '0772981123', 'Hue', 'PM');

-- Projects
INSERT INTO Projects (Leader, ProjectName, ImageNameofProject, FileAttached)
VALUES 
(2, 'Project A', NULL, NULL),
(10, 'Project B', NULL, NULL),
(2, 'Project C', NULL, NULL),
(5, 'Project D', NULL, NULL),
(1, 'Project E', NULL, NULL);

-- ProjectMembers
INSERT INTO ProjectMembers (ProjectId, UserId)
VALUES 
(1, 1), (1, 2), (1, 3), (1, 4),
(2, 2), (2, 5), (2, 6), (2, 7),
(3, 1), (3, 8), (3, 9), (3, 10),
(4, 5), (4, 3), (4, 6),
(5, 1), (5, 4), (5, 9);

-- Tasks
INSERT INTO Tasks (ProjectId, User_Assume, Content, Begin_date, Finish_date, taskStatus)
VALUES 
(1, 1, N'Build backend API', '2025-05-01', '2025-05-20', 'InProgress'),
(1, 3, N'Test login module', '2025-05-03', '2025-05-15', 'Pending'),
(2, 5, N'Configure CI/CD pipeline', '2025-05-05', '2025-05-25', 'InProgress'),
(2, 6, N'Deploy to staging', '2025-05-07', '2025-05-20', 'Pending'),
(3, 8, N'Create UI mockups', '2025-05-01', '2025-05-10', 'Completed'),
(4, 5, N'Set up project structure', '2025-04-25', '2025-05-05', 'Completed'),
(5, 4, N'Write unit tests', '2025-05-02', '2025-05-15', 'Pending'),
(5, NULL, N'Review documentation', '2025-05-10', '2025-05-20', 'Pending');

-- Chats
INSERT INTO Chats (ProjectId)
VALUES (1), (2), (3), (4), (5);

-- Messages
INSERT INTO Messages (ChatId, MessageTime, Message, Sender)
VALUES
(1, GETDATE(), N'Hey team, let's start the sprint.', 2),
(1, GETDATE(), N'I will handle the API.', 1),
(2, GETDATE(), N'Deployment completed.', 6),
(2, GETDATE(), N'Pipeline needs review.', 5),
(3, GETDATE(), N'Mockups ready for feedback.', 8),
(4, GETDATE(), N'Initial setup done.', 5),
(5, GETDATE(), N'Tests will be done by Friday.', 4),
(5, GETDATE(), N'Please update documentation.', NULL);

