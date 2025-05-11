using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Manager_App.Models;


namespace Project_Manager_App
{
    public partial class tab_Project : UserControl
    {

        public string ProjectTitle { get; set; }
        public Image ProjectImage { get; set; }
        public int Progress { get; set; }

        public tab_Project()
        {
            InitializeComponent();
        }

        // Hàm để load dữ liệu và cập nhật giao diện
        public void LoadData(ProjectData projectData)
        {
            // Gán dữ liệu từ ProjectData vào các thành phần giao diện
            label_nameProject.Text = projectData.Title;
            pic_Project.Image = Image.FromFile(projectData.ImagePath);
            processBarofProject.Value = projectData.Progress;
        }

        private void img_Project_Click(object sender, EventArgs e)
        {

        }

        private void label_NameofProject_Click(object sender, EventArgs e)
        {

        }

        private void processBarofProject_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_Project_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_nameProject_Click(object sender, EventArgs e)
        {

        }
    }
}
