using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Manager_App
{
    public partial class settingUser : UserControl
    {
        public settingUser()
        {
            InitializeComponent();
        }

        public int UserId { get; set; }
        public void SetUserInfo(string userName, string role)
        {
            lb_username.Text = userName;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_detail_User_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public Main MainForm { get; set; }
        private void btn_back_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            if (MainForm == null)
            {
                MessageBox.Show("MainForm is null!");
                return;
            }

            if (UserId == 0)
            {
                MessageBox.Show($"UserId không hợp lệ: {UserId}");
                return;
            }

            // Tạo mainPage mới với UserId đã lưu
            var mainPage = new mainPage(UserId);

            // Đảm bảo headerUserControl trong mainPage có MainForm
            mainPage.SetMainFormForHeader(MainForm);

            // Chuyển đổi UserControl hiển thị
            MainForm.LoadUC(mainPage);
        }

        private void title_btn_back_Click(object sender, EventArgs e)
        {

        }

        private void btn_change_password_Click(object sender, EventArgs e)
        {
            var changePassword_uc = new changePassword();
            changePassword_uc.UserId = this.UserId; // Gán UserId hiện tại
            MainForm.LoadUC(changePassword_uc);

        }
    }
}
