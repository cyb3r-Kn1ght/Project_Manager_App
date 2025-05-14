using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Manager_App
{
    public partial class project_manager : UserControl
    {
        public string currentProjectName{get;set;} = "Project Alpha";
        public project_manager()
        {
            InitializeComponent();
            LoadProjectName();
            LoadTasks();  // Load tasks when the control is created
            button_member.Click += Button_member_Click;
        }

        private void Button_member_Click(object sender, EventArgs e)
        {
            // Tạo và hiển thị memberlist
            memberlist memberListControl = new memberlist(currentProjectName);
            Main mainForm = (Main)Application.OpenForms["Main"];
            mainForm.LoadUC(memberListControl);
        }
        private void LoadProjectName()
        {
            try
            {
                string connectionString = "Server=localhost\\SQLEXPRESS;Database=ProjectManagerDB;Trusted_Connection=True;Encrypt=False";
                string query = "SELECT ProjectName FROM Projects WHERE ProjectName = @currentProjectName";  // You can change this query if needed

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@currentProjectName", currentProjectName);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        label_ProjectName.Text = dt.Rows[0]["ProjectName"].ToString(); // Set project name to label_ProjectName
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi kết nối SQL Server: {ex.Message}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTasks()
        {
            try
            {
                string connectionString = "Server=localhost\\SQLEXPRESS;Database=ProjectManagerDB;Trusted_Connection=True;Encrypt=False";
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

                        // Add task to corresponding section based on task status
                        if (taskStatus == "Pending")
                        {
                            taskControl.BackColor = Color.LightCoral;  // Set color for "Việc cần làm"
                        }
                        else if (taskStatus == "In Progress")
                        {
                            taskControl.BackColor = Color.Yellow;  // Set color for "Đang thực hiện" 
                        }
                        else if (taskStatus == "Completed")
                        {
                            taskControl.BackColor = Color.LightGreen;  // Set color for "Đã hoàn thành"
                        }
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
                string connectionString = "Server=localhost\\SQLEXPRESS;Database=ProjectManagerDB;Trusted_Connection=True;Encrypt=False";
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
