using System;
using System.Windows.Forms;

namespace Project_Manager_App
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            var loginForm = new Login_Form();
            LoadUC(loginForm);
        }

        public void LoadUC(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }
    }
}
