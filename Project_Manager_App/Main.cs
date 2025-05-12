using System;
using System.Windows.Forms;

namespace Project_Manager_App
{
    // Main.cs  
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            var pm = new project_manager();
            LoadUserControl((UserControl)pm);  // Explicitly cast to UserControl to resolve ambiguity  
        }
    }

}
