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
    // TaskDetail.cs
    public partial class TaskDetail : UserControl
    {
        public TaskDetail()
        {
            InitializeComponent();
            pictureBox1.Click += PictureBox1_Click; // Đăng ký sự kiện click cho pictureBox1
        }

        // Phương thức để hiển thị chi tiết task
        public void ShowTaskDetail(string taskTitle, string taskDay, string taskHour)
        {
            // Thiết lập thông tin vào các RichTextBox
            richTextBox_Descript.Text = taskTitle;  // Hiển thị nội dung (Content)
            richTextBox_Deadline.Text = taskDay;    // Hiển thị Deadline (Finish_date)
            richTextBox_newActivity.Text = taskHour; // Hiển thị Remaining Time (Thời gian còn lại)

            // Lấy thông tin thành viên từ User_Assume
            int userId = GetUserIdFromTask(taskTitle);  // Sử dụng TaskTitle để lấy User_Assume
            string username = GetUsernameFromUserId(userId);
            richTextBox_member.Text = username;  // Hiển thị Username
        }

        // Lấy UserId từ Task (tìm kiếm trong bảng Tasks)
        private int GetUserIdFromTask(string taskTitle)
        {
            int userId = -1;
            // Truy vấn cơ sở dữ liệu để lấy User_Assume của Task
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ProjectManagerDB;Trusted_Connection=True;Encrypt=False";
            string query = "SELECT User_Assume FROM Tasks WHERE Content = @taskTitle";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@taskTitle", taskTitle);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    userId = Convert.ToInt32(dt.Rows[0]["User_Assume"]);
                }
            }

            return userId;
        }

        // Lấy Username từ UserId
        private string GetUsernameFromUserId(int userId)
        {
            string username = string.Empty;
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ProjectManagerDB;Trusted_Connection=True;Encrypt=False";
            string query = "SELECT Username FROM Users WHERE UserId = @userId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@userId", userId);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = dt.Rows[0]["Username"].ToString();
                }
            }

            return username;
        }

        void PictureBox1_Click(object sender, EventArgs e)
        {
            // Tìm form chính để load lại giao diện
            Main mainForm = (Main)Application.OpenForms["Main"];
            mainForm.LoadUserControl(new project_manager());  // Gọi phương thức LoadUserControl trong Main
        }
    }

}
