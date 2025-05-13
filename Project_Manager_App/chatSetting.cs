using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Manager_App
{
    public partial class chatSetting : UserControl
    {
        public event Action OnBackToChat;

        public chatSetting()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_backButton_Click(object sender, EventArgs e)
        {
            if (OnBackToChat != null)
                OnBackToChat();
        }

        public void LoadGroupInfo(int projectId)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=newProjectManagerApp;Trusted_Connection=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Lấy thông tin project
                    string query = @"
                        SELECT p.ProjectName, p.Leader, u.Username, p.ImageNameofProject, p.FileAttached
                        FROM Projects p
                        LEFT JOIN Users u ON p.Leader = u.UserId
                        WHERE p.ProjectId = @ProjectId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProjectId", projectId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_groupName.Text = reader.GetString(0);
                                txt_manager.Text = reader.IsDBNull(2) ? "Unknown" : reader.GetString(2);
                                // Bạn có thể load thêm các trường khác nếu muốn
                            }
                        }
                    }

                    // Lấy mô tả (nếu có cột mô tả, nếu không thì bỏ qua)
                    // txt_description.Text = ...;

                    // Lấy danh sách thành viên
                    string memberQuery = @"
                        SELECT u.Username, u.Role
                        FROM ProjectMembers pm
                        JOIN Users u ON pm.UserId = u.UserId
                        WHERE pm.ProjectId = @ProjectId";
                    using (SqlCommand cmd = new SqlCommand(memberQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProjectId", projectId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            memberList.Items.Clear();
                            while (reader.Read())
                            {
                                string name = reader.GetString(0);
                                string role = reader.GetString(1);
                                var item = new ListViewItem(new[] { name, role });
                                memberList.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading group info: " + ex.Message);
            }
        }
    }
}
