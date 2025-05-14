using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace Project_Manager_App
{


    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            /*
           TEST AREA

            /*
             TEST AREA
          var pm = new project_manager();

            LoadUserControl(pm);
            */
           
            var loginForm = new Login_Form();
            LoadUC(loginForm);

        }

        public void LoadUC(UserControl uc)
        {
            // Giả sử bạn có 1 Panel tên là panelMain để chứa các UserControl
            panelMain.Controls.Clear();         // Xóa UC hiện tại (nếu có)
            uc.Dock = DockStyle.Fill;           // Cho UC chiếm toàn bộ panel
            panelMain.Controls.Add(uc);         // Thêm UC mới vào
        }





        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    
    
    }
}
