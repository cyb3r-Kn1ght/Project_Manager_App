using System;
using System.Windows.Forms;

namespace Project_Manager_App
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            var pm = new project_manager();

            LoadUserControl(pm);
        }
    }
}
