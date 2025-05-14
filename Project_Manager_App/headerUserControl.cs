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
using Microsoft.VisualBasic.ApplicationServices;

namespace Project_Manager_App
{
    public partial class headerUserControl : UserControl
    {
        public headerUserControl()
        {
            InitializeComponent();
        }


        int userId = 0; // Biến để lưu trữ userId
        public void SetUserInfo(string userName, string role, int user_ID)
        {
            // Giả sử bạn có label_UserName trong headerUserControl
            Username.Text = userName;
            roleOfUser.Text = role;

            userId = user_ID; // Lưu trữ userId
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public Main MainForm { get; set; } // Property tham chiếu đến form Main

        private void btn_setting_Click(object sender, EventArgs e)
        {
            if (MainForm == null)
            {
                MessageBox.Show("MainForm chưa được thiết lập đúng cách!");
                return;
            }

            string userName = Username.Text;
            string role = roleOfUser.Text;

            // Tạo settingUser UserControl mới
            var settingUC = new settingUser();
            settingUC.SetUserInfo(userName, role);
            settingUC.UserId = userId; // Truyền userId
            settingUC.MainForm = MainForm; // Truyền MainForm

            // Gọi LoadUC của Main để thay thế toàn bộ panel
            MainForm.LoadUC(settingUC);
        }
    }
}