using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Manager_App
{
    public partial class TaskDetail : UserControl
    {
        public TaskDetail()
        {
            InitializeComponent();
            pictureBox1.Cursor = Cursors.Hand;  // (nếu chưa có)
            pictureBox1.Click += PictureBox1_Click;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            // Tìm form chính và load lại project_manager
            var main = this.FindForm() as Main;
            if (main != null)
            {
                main.LoadUserControl(new project_manager());
            }
        }
        public string ProjectName
        {
            get => label_ProjectName.Text;
            set => label_ProjectName.Text = value;
        }
        public string Deadline
        {
            get => richTextBox_Deadline.Text;
            set => richTextBox_Deadline.Text = value;
        }
        private void TaskDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
