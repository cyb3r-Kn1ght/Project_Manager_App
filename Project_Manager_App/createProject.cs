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
    public partial class createProject : UserControl
    {
        private int currentUserId;

        public createProject(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            pictureBox_backButton.Click += pictureBox_backButton_Click;
            btn_create.Click += btn_create_Click;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_projectName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên dự án", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dateTimePicker_start.Value >= dateTimePicker_end.Value)
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string connectionString = "Server=localhost\\SQLEXPRESS;Database=Proj_Management;Trusted_Connection=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Insert project
                            string insertProjectQuery = @"
                                INSERT INTO Project (ProjectName, Description, StartDate, EndDate)
                                VALUES (@ProjectName, @Description, @StartDate, @EndDate);
                                SELECT SCOPE_IDENTITY();";

                            SqlCommand cmd = new SqlCommand(insertProjectQuery, conn, transaction);
                            cmd.Parameters.AddWithValue("@ProjectName", txt_projectName.Text.Trim());
                            cmd.Parameters.AddWithValue("@Description", txt_description.Text.Trim());
                            cmd.Parameters.AddWithValue("@StartDate", dateTimePicker_start.Value);
                            cmd.Parameters.AddWithValue("@EndDate", dateTimePicker_end.Value);

                            int projectId = Convert.ToInt32(cmd.ExecuteScalar());

                            // Add creator as project member
                            string insertMemberQuery = @"
                                INSERT INTO ProjectMember (ProjectId, UserId, Role)
                                VALUES (@ProjectId, @UserId, 'Manager')";

                            cmd = new SqlCommand(insertMemberQuery, conn, transaction);
                            cmd.Parameters.AddWithValue("@ProjectId", projectId);
                            cmd.Parameters.AddWithValue("@UserId", currentUserId);
                            cmd.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("Tạo dự án thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Return to project list
                            var mainForm = this.FindForm() as Main;
                            if (mainForm != null)
                            {
                                mainForm.LoadUserControl(new projectList(currentUserId));
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi khi tạo dự án: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox_backButton_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Main;
            if (mainForm != null)
            {
                mainForm.LoadUserControl(new projectList(currentUserId));
            }
        }
    }
} 