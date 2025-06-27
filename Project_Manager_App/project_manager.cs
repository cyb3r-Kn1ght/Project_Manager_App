using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Manager_App
{
    public partial class project_manager : UserControl
    {
        public string currentProjectName
        {
            get { return label_ProjectName.Text; }
            set { label_ProjectName.Text = value; }
        }
        public int userID
        {
            get;
            set;
        }
        public project_manager()
        {
            InitializeComponent();
            LoadTasks();  
            button_member.Click += Button_member_Click;
            pictureBox1.Click += PictureBox1_Click; // Đăng ký sự kiện click cho pictureBox1
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            mainPage mainPageControl = new mainPage(this.userID);

            Main mainForm = (Main)Application.OpenForms["Main"];
            mainForm.LoadUC(mainPageControl);  // Gọi phương thức LoadUserControl trong Main
        }
        private void Button_member_Click(object sender, EventArgs e)
        {
            // Tạo và hiển thị memberlist
            memberlist memberListControl = new memberlist(currentProjectName, userID); // Truyền userID vào memberlist
            Main mainForm = (Main)Application.OpenForms["Main"];
            mainForm.LoadUC(memberListControl);
        }
        private void LoadTasks()
        {
            try
            {
                string connectionString = "Server=localhost\\MSSQLDEV;Database=ProjectManagerDB;Integrated Security=True;";
                string query = "SELECT TaskId, Content, taskStatus, Finish_date FROM Tasks WHERE ProjectId = (SELECT ProjectId FROM Projects WHERE ProjectName = @currentProjectName)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@currentProjectName", currentProjectName);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Clear existing controls in flowTaskList
                    flowTaskList.Controls.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        string taskStatus = row["taskStatus"].ToString();
                        string content = row["Content"].ToString();
                        DateTime finishDate = Convert.ToDateTime(row["Finish_date"]);
                        string remainingTime = (finishDate > DateTime.Now)
                            ? $"Còn lại {finishDate.Subtract(DateTime.Now).Days} ngày"
                            : "Quá hạn";

                        // Create task control
                        tasks taskControl = new tasks();

                        // Set task details using properties in tasks control
                        taskControl.TaskTitle = content;  // Set the task content
                        taskControl.TaskDay = finishDate.ToString("dd/MM/yyyy");  // Set the finish date
                        taskControl.TaskHour = remainingTime;  // Set the remaining time or "Overdue"
                        taskControl.ProjectName = currentProjectName;  // Set the project name
                        taskControl.userID = this.userID;

                        flowTaskList.Controls.Add(taskControl);  // Add the task control to the flow layout panel
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi kết nối SQL Server: {ex.Message}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handlers for button clicks to filter tasks by status
        private void button_havetodo_Click(object sender, EventArgs e)
        {
            LoadTasksByStatus("Pending");
        }

        private void button_IsDoing_Click(object sender, EventArgs e)
        {
            LoadTasksByStatus("In Progress");
        }

        private void button_Finished_Click(object sender, EventArgs e)
        {
            LoadTasksByStatus("Completed");
        }

        // Method to load tasks by their status
        private void LoadTasksByStatus(string status)
        {
            // Clear the current task list
            flowTaskList.Controls.Clear();

            try
            {
                string connectionString = "Server=localhost\\MSSQLDEV;Database=ProjectManagerDB;Integrated Security=True;";
                string query = "SELECT TaskId, Content, taskStatus, Finish_date FROM Tasks WHERE ProjectId = (SELECT ProjectId FROM Projects WHERE ProjectName = @currentProjectName) AND taskStatus = @status";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@status", status);
                    adapter.SelectCommand.Parameters.AddWithValue("@currentProjectName", currentProjectName);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        string taskStatus = row["taskStatus"].ToString();
                        string content = row["Content"].ToString();
                        DateTime finishDate = Convert.ToDateTime(row["Finish_date"]);
                        string remainingTime = (finishDate > DateTime.Now) ? $"Còn lại {finishDate.Subtract(DateTime.Now).Days} ngày" : "Quá hạn";

                        // Create task control
                        tasks taskControl = new tasks();

                        // Set task details using properties in tasks control
                        taskControl.TaskTitle = content;  // Set task content
                        taskControl.TaskDay = finishDate.ToString("dd/MM/yyyy");  // Set finish date
                        taskControl.TaskHour = remainingTime;  // Set remaining time
                        taskControl.ProjectName = currentProjectName;  // Set project name
                        taskControl.userID = this.userID;  // Set user ID

                        flowTaskList.Controls.Add(taskControl);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi kết nối SQL Server: {ex.Message}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
