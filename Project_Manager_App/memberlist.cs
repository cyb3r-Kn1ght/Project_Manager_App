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
    // memberlist.cs
    public partial class memberlist : UserControl
    {
        private string projectName;

        public memberlist(string projectName)
        {
            InitializeComponent();
            this.projectName = projectName;  // Lưu tên dự án
            LoadProjectMembers();  // Gọi phương thức để load thành viên
            pictureBox_back.Click += PictureBox_back_Click;  // Đăng ký sự kiện click cho pictureBox_back
        }

        private void LoadProjectMembers()
        {
            try
            {
                string connectionString = "Server=localhost\\SQLEXPRESS;Database=ProjectManagerDB;Trusted_Connection=True;Encrypt=False";
                string query = @"SELECT u.Username, u.Role 
                             FROM Users u
                             INNER JOIN ProjectMembers pm ON u.UserId = pm.UserId
                             INNER JOIN Projects p ON p.ProjectId = pm.ProjectId
                             WHERE p.ProjectName = @projectName";  // Dùng projectName thay vì giá trị hằng

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@projectName", projectName);  // Truyền tên dự án vào query
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Clear existing controls in flowLayoutPanel1
                    flowLayoutPanel1.Controls.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        string username = row["Username"].ToString();
                        string role = row["Role"].ToString();

                        // Tạo mới member control cho mỗi thành viên
                        member memberControl = new member();
                        memberControl.Username = username;  // Sử dụng thuộc tính Username
                        memberControl.Role = role;          // Sử dụng thuộc tính Role

                        // Thêm memberControl vào flowLayoutPanel1
                        flowLayoutPanel1.Controls.Add(memberControl);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi kết nối SQL Server: {ex.Message}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PictureBox_back_Click(object sender, EventArgs e)
        {
            // Khi nhấn vào pictureBox_back, quay lại project_manager
            Main mainForm = (Main)Application.OpenForms["Main"];
            var pm = new project_manager();  // Tạo lại project_manager
            mainForm.LoadUC(pm);    // Gọi phương thức LoadUserControl trong Main để quay lại project_manager
        }

    }
}
