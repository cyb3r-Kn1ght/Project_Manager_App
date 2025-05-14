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
using Project_Manager_App;

namespace Project_Manager_App
{
    public partial class processTracking_tableType : UserControl
    {
        public processTracking_tableType()
        {
            InitializeComponent();
            projectList.SelectionChangeCommitted += projectList_SelectionChangeCommitted;
            LoadProjects();
            // Select first project and load its tasks
            if (projectList.Items.Count > 0)
            {
                projectList.SelectedIndex = 0;
                LoadTasks(1, null, null);
            }
        }

        private void taskTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox_filterButton_Click(object sender, EventArgs e)
        {
            if (projectList.SelectedValue != null)
            {
                if (int.TryParse(projectList.SelectedValue.ToString(), out int projectId))
                {
                    DateTime fromDate = dateTimePicker1.Value.Date;
                    DateTime toDate = dateTimePicker2.Value.Date;
                    LoadTasks(projectId, fromDate, toDate);
                }
            }
        }

        private void LoadProjects()
        {
            try
            {
                string connectionString = "Server=localhost\\SQLEXPRESS;Database=newProjectManagerApp;Trusted_Connection=True;";
                string query = "SELECT ProjectId, ProjectName FROM Projects";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    projectList.DataSource = dt;
                    projectList.DisplayMember = "ProjectName";
                    projectList.ValueMember = "ProjectId";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi kết nối SQL Server: {ex.Message}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTasks(int projectId, DateTime? fromDate = null, DateTime? toDate = null)
        {
            try
            {
                string connectionString = "Server=localhost\\SQLEXPRESS;Database=newProjectManagerApp;Trusted_Connection=True;";
                string query = @"
                    SELECT t.Content AS 'Nội dung',
                           t.Begin_date AS 'Ngày bắt đầu',
                           t.Finish_date AS 'Ngày kết thúc',
                           t.taskStatus AS 'Trạng thái'
                    FROM Tasks t
                    WHERE t.ProjectId = @ProjectId
                          AND (@FromDate IS NULL OR t.Begin_date >= @FromDate)
                          AND (@ToDate IS NULL OR t.Finish_date <= @ToDate)
                    ORDER BY t.Begin_date";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProjectId", projectId);
                    cmd.Parameters.AddWithValue("@FromDate", (object?)fromDate ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ToDate", (object?)toDate ?? DBNull.Value);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    taskTable.DataSource = dt;

                    if (taskTable.Columns["Ngày bắt đầu"] != null)
                        taskTable.Columns["Ngày bắt đầu"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    if (taskTable.Columns["Ngày kết thúc"] != null)
                        taskTable.Columns["Ngày kết thúc"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi khi tải tasks: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void projectList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (projectList.SelectedValue != null)
            {
                if (int.TryParse(projectList.SelectedValue.ToString(), out int projectId))
                {
                    LoadTasks(projectId, null, null);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_filterButton_Click_1(object sender, EventArgs e)
        {
            if (projectList.SelectedValue != null)
            {
                if (int.TryParse(projectList.SelectedValue.ToString(), out int projectId))
                {
                    DateTime fromDate = dateTimePicker1.Value.Date;
                    DateTime toDate = dateTimePicker2.Value.Date;
                    LoadTasks(projectId, fromDate, toDate);
                }
            }
        }
    }
}
