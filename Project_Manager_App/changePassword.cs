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
    public partial class changePassword : UserControl
    {
        public changePassword()
        {
            InitializeComponent();
        }
        public int UserId { get; set; }
        private void txt_new_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_title_resetpassword_Click(object sender, EventArgs e)
        {

        }

        private void lb_title_change_password_Click(object sender, EventArgs e)
        {

        }

        private void lb_change_password_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Main;
            if (mainForm != null)
            {
                var mainPage_UC = new mainPage(UserId);
                // Luôn gọi SetMainFormForHeader sau khi tạo
                mainPage_UC.SetMainFormForHeader(mainForm);
                mainForm.LoadUC(mainPage_UC);
            }
        }
    }
}
