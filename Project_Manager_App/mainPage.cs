using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;

using System.Configuration;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;



namespace Project_Manager_App
{
    public partial class mainPage : UserControl
    {
        private int _userId;

        public mainPage(int userId)
        {
            InitializeComponent();
            _userId = userId;

            headerUserControl1.MainForm = this.ParentForm as Main;

            LoadUserInfoToHeader(userId);

            var connString = AppConfig.GetConnectionString("DefaultConnection");
            using (var conn = new SqlConnection(connString))
            {
                conn.Open(); // Mở kết nối 
                var sql = @"SELECT p.ProjectName, p.ImageNameofProject
                FROM Projects p
                INNER JOIN ProjectMembers pm ON p.ProjectId = pm.ProjectId
                WHERE pm.UserId = @UserId";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        var list = new List<(string ProjectName, string ImagePath)>();
                        while (reader.Read())
                        {
                            var projectName = reader.GetString(0);
                            var imagePath = reader.GetString(1);
                            list.Add((projectName, imagePath));
                        }
                        // Xử lý list ở đây 
                        var panels = new[] { panel1, panel2, panel3, panel4 };
                        for (int i = 0; i < list.Count && i < panels.Length; i++)
                        {
                            var project = list[i];
                            var projectUC = new tab_Project();
                            projectUC.UserID = _userId;
                            projectUC.SetProject(project.ProjectName, project.ImagePath);

                            panels[i].Controls.Clear(); // Xóa control cũ nếu có
                            panels[i].Controls.Add(projectUC);
                        }

                        // Nếu có ít hơn 4 dự án, thêm các điều khiển trống
                        for (int i = list.Count; i < panels.Length; i++)
                        {
                            var emptyUC = new tab_Project();
                            emptyUC.HideProgressBar();
                            emptyUC.Dock = DockStyle.Fill; // Đảm bảo UC rỗng cũng co giãn đầy panel
                            panels[i].Controls.Clear();
                            panels[i].Controls.Add(emptyUC);
                        }
                    }
                }
            }
            
        }

        public void SetMainFormForHeader(Main mainForm)
        {
            headerUserControl1.MainForm = mainForm;
        }
        private void LoadUserInfoToHeader(int userId)
        {
            var connString = AppConfig.GetConnectionString("DefaultConnection");
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                var sql = "SELECT UserName, Role, UserId FROM Users WHERE UserId = @UserId";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string userName = reader.GetString(0);
                            string role = reader.GetString(1);
                            int userId_truyendi = reader.GetInt32(2);

                            // Gọi phương thức trong headerUserControl để cập nhật tên người dùng
                            headerUserControl1.SetUserInfo(userName, role, userId_truyendi);
                        }
                    }
                }
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tab_Project1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
