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
using System.Reflection;
using Project_Manager_App.Models;
using Project_Manager_App.Services;

namespace Project_Manager_App
{
    public partial class mainPage : UserControl
    {


        public mainPage()
        {
            InitializeComponent();
            LoadProjectsForUser(1); // Ví dụ: UserId = 1

        }

        private void LoadProjectsForUser(int userId)
        {
            // Lấy danh sách dự án từ cơ sở dữ liệu
            var projectDataList = ProjectService.GetProjectsByUserId(userId);

            // Danh sách các panel để phân phối dự án
            var panels = new List<Panel> { panel1, panel2, panel3, panel4 };

            // Xóa các control cũ trong tất cả các panel
            foreach (var panel in panels)
            {
                panel.Controls.Clear();
            }

            // Phân phối các dự án vào các panel
            for (int i = 0; i < projectDataList.Count; i++)
            {
                var projectData = projectDataList[i];
                var projectTab = new tab_Project();
                projectTab.LoadData(projectData); // Gọi hàm LoadData để truyền dữ liệu
                projectTab.Dock = DockStyle.Top; // Đặt Dock để xếp chồng các tab trong panel

                // Thêm vào panel tương ứng (theo thứ tự)
                var targetPanel = panels[i % panels.Count];
                targetPanel.Controls.Add(projectTab);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tab_Project1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
