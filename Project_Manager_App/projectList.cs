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
    public partial class projectList : UserControl
    {
        private int currentUserId;

        public projectList(int userId = 0)
        {
            InitializeComponent();
            currentUserId = userId;
            LoadProjects();
        }

        private void LoadProjects()
        {
            try
            {
                string connectionString = "Server=localhost\\SQLEXPRESS;Database=Proj_Management;Trusted_Connection=True;";
                string query = @"
                    SELECT p.ProjectId, p.ProjectName, p.Description, p.StartDate, p.EndDate
                    FROM Project p
                    INNER JOIN ProjectMember pm ON p.ProjectId = pm.ProjectId
                    WHERE pm.UserId = @UserId
                    ORDER BY p.StartDate DESC";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", currentUserId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    projectListView.Items.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["ProjectName"].ToString());
                        item.SubItems.Add(row["Description"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(row["StartDate"]).ToString("dd/MM/yyyy"));
                        item.SubItems.Add(Convert.ToDateTime(row["EndDate"]).ToString("dd/MM/yyyy"));
                        item.Tag = row["ProjectId"];
                        projectListView.Items.Add(item);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách dự án: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void projectListView_DoubleClick(object sender, EventArgs e)
        {
            if (projectListView.SelectedItems.Count > 0)
            {
                var mainForm = this.FindForm() as Main;
                if (mainForm != null)
                {
                    mainForm.LoadUserControl(new projectGroupChat());
                }
            }
        }

        private void btn_createProject_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Main;
            if (mainForm != null)
            {
                mainForm.LoadUserControl(new createProject(currentUserId));
            }
        }
    }
} 