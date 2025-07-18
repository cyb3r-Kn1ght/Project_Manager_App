﻿using System;
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
    public partial class tab_Project : UserControl
    {

        public string ProjectTitle { get; set; }
        public Image ProjectImage { get; set; }
        public int Progress { get; set; }

        public tab_Project()
        {
            InitializeComponent();
        }

        public void HideProgressBar()
        {
            processBarofProject.Visible = false;
        }

        public void SetProject(string projectName, string imagePath)
        {
            label_nameProject.Text = projectName;
            string fullPath = Path.Combine(Application.StartupPath, "Resources", imagePath);
            pic_Project.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Project.Image = Image.FromFile(fullPath);
            this.Dock = DockStyle.Fill;
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

        private void processBarofProject_Click_1(object sender, EventArgs e)
        {

        }
    }
}
