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



-- THÊM VÀO DATA CỦA USERS

INSERT INTO Users
  (Username, Password, Avatar, Email, Sex, PhoneNumber, Address, Role)
VALUES ( 'No1hiz9' , 'memaybeo', 'dhuit.jpg', '23520896@gm.uit.edu.vn', 'Male','0912345678', '130/7 Duong so 8', 'ADMIN' );

INSERT INTO Users
  (Username, Password, Avatar, Email, Sex, PhoneNumber, Address, Role)
VALUES ( 'OB2U' , 'HEHEHE@', 'dhuit.jpg', '23520968@gm.uit.edu.vn', 'Male','0912345666', '130/7 Duong so 12', 'MEMBER' );

INSERT INTO Users
  (Username, Password, Avatar, Email, Sex, PhoneNumber, Address, Role)
VALUES ( 'NamKey' , 'NamKey...', 'dhuit.jpg', '23529996@gm.uit.edu.vn', 'Male','0913345678', '130/7 Duong so 11', 'MANAGER' );

INSERT INTO Users
  (Username, Password, Avatar, Email, Sex, PhoneNumber, Address, Role)
VALUES ( 'De No1hiz9' , 'memaybeolaro', 'dhuit.jpg', '23521896@gm.uit.edu.vn', 'Female','0999345678', '130/7 Duong so 5', 'GUEST' );

SELECT * FROM Users 



-- THÊM VÀO DATA CỦA 
/*
	- 5. Bảng ProjectMembers (quan hệ N–N Users ↔ Projects)
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

*/

-- TẠO RA CÁC DỰ ÁN 

INSERT  INTO Projects 
(Leader, ProjectName, ImageNameofProject, FileAttached)
VALUES (1, 'Kinh te tai chinh', 'tai-xuong.jpg', 'NONE')


INSERT  INTO Projects 
(Leader, ProjectName, ImageNameofProject, FileAttached)
VALUES (1, 'AI', 'kham-pha-tri-tue-nhan-tao-ai-la-gi-va-tai-sao-no-quan-trong1.jpg', 'NONE')


INSERT  INTO Projects 
(Leader, ProjectName, ImageNameofProject, FileAttached)
VALUES (2, 'Code Web', 'Lam-dep-code.jpg', 'NONE')


INSERT  INTO Projects 
(Leader, ProjectName, ImageNameofProject, FileAttached)
VALUES (3, 'Hack Nasa with HTML', 'nasa-server-hack.jpg', 'NONE')




-- THÊM THÀNH VIÊN VÀO DỰ ÁN  
INSERT INTO ProjectMembers
VALUES ( 4 , 1);
INSERT INTO ProjectMembers
VALUES ( 4 , 2);
INSERT INTO ProjectMembers
VALUES ( 4 , 3);
INSERT INTO ProjectMembers
VALUES ( 4 , 4);

INSERT INTO ProjectMembers
VALUES ( 6, 1);
INSERT INTO ProjectMembers
VALUES ( 6, 2);

INSERT INTO ProjectMembers
VALUES ( 7, 1);
INSERT INTO ProjectMembers
VALUES ( 7, 2);
INSERT INTO ProjectMembers
VALUES ( 7, 3);


INSERT INTO ProjectMembers
VALUES ( 8, 1);



SELECT * FROM ProjectMembers