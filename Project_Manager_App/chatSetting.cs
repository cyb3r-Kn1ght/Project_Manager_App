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
        private readonly int UserId;
        private int currentProjectId = -1;
        public event Action OnBackToGroupChat;

        public chatSetting(int userId)
        {
            UserId = userId;
            InitializeComponent();
            pictureBox_backButton.Click += pictureBox_backButton_Click;
            btn_addMember.Click += btn_addMember_Click;
            button2.Click += button2_Click;
        }

        private void pictureBox_backButton_Click(object sender, EventArgs e)
        {
            var groupChat = new projectGroupChat(UserId);

            var mainForm = this.FindForm() as Main;
            if (mainForm != null)
            {
                mainForm.LoadUC(groupChat);
            }
        }

        private void btn_addMember_Click(object sender, EventArgs e)
        {
            // Implement add member functionality
            MessageBox.Show("Add member functionality will be implemented here");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Implement leave group functionality
            if (MessageBox.Show("Are you sure you want to leave this group?", "Confirm", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LeaveGroup();
            }
        }

        private void LeaveGroup()
        {
            if (currentProjectId == -1) return;
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=newProjectManagerApp;Integrated Security=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"DELETE FROM ProjectMembers WHERE ProjectId = @ProjectId AND UserId = @UserId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProjectId", currentProjectId);
                        cmd.Parameters.AddWithValue("@UserId", UserId);
                        cmd.ExecuteNonQuery();
                    }
                }
                OnBackToGroupChat?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error leaving group: " + ex.Message);
            }
        }

        public void LoadGroupInfo(int projectId)
        {
            if (projectId == -1) return;
            
            currentProjectId = projectId;
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=newProjectManagerApp;Integrated Security=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Kiểm tra quyền truy cập
                    string accessQuery = @"SELECT COUNT(*) FROM ProjectMembers WHERE ProjectId = @ProjectId AND UserId = @UserId";
                    using (SqlCommand cmd = new SqlCommand(accessQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProjectId", projectId);
                        cmd.Parameters.AddWithValue("@UserId", UserId);
                        int accessCount = (int)cmd.ExecuteScalar();
                        if (accessCount == 0)
                        {
                            MessageBox.Show("You don't have access to this project's settings.");
                            OnBackToGroupChat?.Invoke();
                            return;
                        }
                    }

                    // Lấy thông tin project
                    string infoQuery = @"SELECT p.ProjectName, p.Leader, u.Username
                                         FROM Projects p
                                         LEFT JOIN Users u ON p.Leader = u.UserId
                                         WHERE p.ProjectId = @ProjectId";
                    using (SqlCommand cmd = new SqlCommand(infoQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProjectId", projectId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_groupName.Text = reader.GetString(0);
                                txt_manager.Text = reader.IsDBNull(2) ? "Unknown" : reader.GetString(2);
                            }
                            else
                            {
                                txt_groupName.Text = "";
                                txt_manager.Text = "";
                            }
                        }
                    }

                    // Lấy danh sách thành viên
                    string memberQuery = @"
                        SELECT u.Username, u.Role, u.UserId,
                            CASE WHEN p.Leader = u.UserId THEN N'Leader' ELSE u.Role END as MemberRole
                        FROM ProjectMembers pm
                        JOIN Users u ON pm.UserId = u.UserId
                        JOIN Projects p ON pm.ProjectId = p.ProjectId
                        WHERE pm.ProjectId = @ProjectId
                        ORDER BY 
                            CASE WHEN p.Leader = u.UserId THEN 1 ELSE 2 END,
                            u.Username";
                    using (SqlCommand cmd = new SqlCommand(memberQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProjectId", projectId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            memberList.Items.Clear();
                            int count = 0;
                            while (reader.Read())
                            {
                                string name = reader.GetString(0);
                                string role = reader.GetString(3);
                                int memberId = reader.GetInt32(2);
                                var item = new ListViewItem(new[] { name, role });
                                item.Tag = memberId;
                                memberList.Items.Add(item);
                                count++;
                            }
                            if (count == 0)
                            {
                                MessageBox.Show("Không có thành viên nào trong dự án này!");
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
