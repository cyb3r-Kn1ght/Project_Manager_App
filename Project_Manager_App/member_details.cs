using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Sử dụng Microsoft.Data.SqlClient thay vì System.Data.SqlClient

namespace Project_Manager_App
{
    // member_details.cs
    public partial class member_details : UserControl
    {
        public member_details()
        {
            InitializeComponent();
            pictureBox1.Click += PictureBox_back_Click;  // Thêm sự kiện click cho pictureBox_back để quay lại memberlist
        }

        public void ShowMemberDetails(string username)
        {
            try
            {
                string connectionString = "Server=localhost\\SQLEXPRESS;Database=ProjectManagerDB;Trusted_Connection=True;Encrypt=False";
                string query = @"SELECT u.Username, u.Sex, u.PhoneNumber, u.Role, u.Email, u.Address 
                             FROM Users u 
                             WHERE u.Username = @username";  // Truy vấn thông tin thành viên theo Username

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@username", username);  // Truyền username vào query
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        // Cập nhật các label và richTextBox với thông tin thành viên
                        label_name.Text = dt.Rows[0]["Username"].ToString();
                        label_sex.Text = dt.Rows[0]["Sex"].ToString();
                        label_phone.Text = dt.Rows[0]["PhoneNumber"].ToString();
                        label_role.Text = dt.Rows[0]["Role"].ToString();
                        label_email.Text = dt.Rows[0]["Email"].ToString();
                        label_address.Text = dt.Rows[0]["Address"].ToString();

                        // Cập nhật các richTextBox
                        string allProjects = GetAllProjects(username);
                        string ToDos = GetTasksByStatus(username, "Pending");
                        string inProgressTasks = GetTasksByStatus(username, "In Progress");
                        string completedTasks = GetTasksByStatus(username, "Completed");

                        // Gán vào richTextBox
                        richTextBox_AllProject.Text = allProjects;
                        richTextBox_ToDo.Text = ToDos;
                        richTextBox_Doing.Text = inProgressTasks;
                        richTextBox_Done.Text = completedTasks;

                        // Kiểm tra nếu richTextBox trống, thì hiển thị "Không có task nào"
                        if (string.IsNullOrEmpty(allProjects))
                            richTextBox_AllProject.Text = "Không có task nào";
                        if (string.IsNullOrEmpty(ToDos))
                            richTextBox_ToDo.Text = "Không có task nào";
                        if (string.IsNullOrEmpty(inProgressTasks))
                            richTextBox_Doing.Text = "Không có task nào";
                        if (string.IsNullOrEmpty(completedTasks))
                            richTextBox_Done.Text = "Không có task nào";

                        richTextBox_AllProject.ReadOnly = true;
                        richTextBox_ToDo.ReadOnly = true;
                        richTextBox_Doing.ReadOnly = true;
                        richTextBox_Done.ReadOnly = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi kết nối SQL Server: {ex.Message}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetAllProjects(string username)
        {
            // Lấy tất cả các dự án mà member tham gia
            string allProjects = string.Empty;
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ProjectManagerDB;Trusted_Connection=True;Encrypt=False";
            string query = @"SELECT p.ProjectName 
                         FROM Projects p
                         INNER JOIN ProjectMembers pm ON p.ProjectId = pm.ProjectId
                         INNER JOIN Users u ON pm.UserId = u.UserId
                         WHERE u.Username = @username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@username", username);  // Truyền username vào query
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    allProjects += row["ProjectName"].ToString() + ", ";
                }
            }

            return allProjects.TrimEnd(new char[] { ',', ' ' });
        }

        // member_details.cs

        private string GetTasksByStatus(string username, string status)
        {
            // Lấy danh sách tasks mà member tham gia và đảm nhiệm (User_Assume)
            string tasks = string.Empty;
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ProjectManagerDB;Trusted_Connection=True;Encrypt=False";
            string query = @"SELECT p.ProjectName, t.Content, t.Finish_date 
                     FROM Tasks t
                     INNER JOIN Projects p ON t.ProjectId = p.ProjectId
                     INNER JOIN ProjectMembers pm ON p.ProjectId = pm.ProjectId
                     INNER JOIN Users u ON pm.UserId = u.UserId
                     WHERE u.Username = @username AND t.taskStatus = @status AND t.User_Assume = u.UserId";  // Thêm điều kiện t.User_Assume = u.UserId

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@username", username);
                adapter.SelectCommand.Parameters.AddWithValue("@status", status);  // Truyền status vào query
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string remainingTime = (Convert.ToDateTime(row["Finish_date"]) > DateTime.Now)
                        ? $"Còn lại {Convert.ToDateTime(row["Finish_date"]).Subtract(DateTime.Now).Days} ngày"
                        : "Đã quá hạn";

                    tasks += $"{row["ProjectName"]} > {row["Content"]} > {remainingTime}\n";
                }
            }

            return tasks;
        }


        private void PictureBox_back_Click(object sender, EventArgs e)
        {
            // Khi nhấn vào pictureBox_back, quay lại memberlist của đúng project
            Main mainForm = (Main)Application.OpenForms["Main"];
            var memberListControl = new memberlist("Project Alpha");  // Tạo lại memberlist với đúng tên project
            mainForm.LoadUserControl(memberListControl);  // Gọi phương thức LoadUserControl trong Main để quay lại memberlist
        }
    }

}
