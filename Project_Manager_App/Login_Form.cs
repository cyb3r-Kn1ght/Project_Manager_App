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

        private void Connect2Server()
        {
            try
            {
                string connectionString = "Server=26.198.131.10,1433;Database=Proj_Management;User Id=Luan1;Password=luan123;TrustServerCertificate=True";
                string query = "SELECT ProjectId, ProjectName FROM Project";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi kết nối SQL Server: {ex.Message}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public Login_Form()
        {
            InitializeComponent();
            Connect2Server();
        }


        private bool Check_Login(string username, string password)
        {
            if (username == "No1hiz9" /*cho nay nap data vao la xong*/ && password == "memaybeo"/*cho nay nap data vao la xong*/)
            {
                return true;
            }
            return false;
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

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            // kiem tra dang nhap thanh cong 
            if (Check_Login(txt_Username.Text, txt_password.Text))
            {
                var mainPage = new mainPage();
                var mainForm = this.ParentForm as Main;
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
