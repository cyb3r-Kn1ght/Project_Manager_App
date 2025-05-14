using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;


namespace Project_Manager_App
{
    public partial class Login_Form : UserControl
    {

        

        public Login_Form()
        {
            InitializeComponent();
        }


        private bool Check_Login(string username, string password)
        {
            var connString = AppConfig.GetConnectionString("DefaultConnection");
            //string connString = "Server=localhost\\SQLEXPRESS;Database=newProjectManagerApp;Trusted_Connection=True;";
            using (var conn = new SqlConnection(connString))
            {
               conn.Open();
        var sql = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
        using (var cmd = new SqlCommand(sql, conn))
        {
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password); // Nếu mật khẩu đã mã hóa, cần mã hóa trước khi so sánh

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void panel_Display_Paint(object sender, PaintEventArgs e)
        {

        }



        private void processTracking_tableType1_Load(object sender, EventArgs e)
        {

        }


 
        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private int GetUserId(string username)
        {
            var connString = AppConfig.GetConnectionString("DefaultConnection");
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                var sql = "SELECT UserId FROM Users WHERE Username = @username";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            // kiem tra dang nhap thanh cong 
            if (Check_Login(txt_Username.Text, txt_password.Text))
            {
                int userId = GetUserId(txt_Username.Text);
                var mainPage = new mainPage(userId);
                var mainForm = this.ParentForm as Main;

                // Sử dụng phương thức public để thiết lập MainForm
                mainPage.SetMainFormForHeader(mainForm);
                mainForm?.LoadUC(mainPage);
            }

            else
            {
                MessageBox.Show("Login failed. Please check your username and password.");
            }
        }

  


        private void txt_Username_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
