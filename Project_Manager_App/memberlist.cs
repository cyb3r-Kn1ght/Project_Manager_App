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
    public partial class memberlist: UserControl
    {
        public memberlist()
        {
            InitializeComponent();

            // 1) Chuột thế hiện clickable
            pictureBox_back.Cursor = Cursors.Hand;

            // 2) Bắt sự kiện Click để quay về project_manager
            pictureBox_back.Click += PictureBox_back_Click;

            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;

            // 2) Tạo và render sample members
            LoadSampleMembers();
        }

        private void PictureBox_back_Click(object sender, EventArgs e)
        {
            // Tìm form chính và load lại project_manager
            if (this.FindForm() is Main main)
            {
                main.LoadUserControl(new project_manager());
            }
        }
        private void LoadSampleMembers()
        {
            // Danh sách mẫu
            var samples = new List<member>
            {
                new member { MemberName = "Lê Minh",           MemberRole = "Nhóm trưởng" },
                new member { MemberName = "Nguyễn Gia Luân",   MemberRole = "Thành viên"  },
                new member { MemberName = "Lương Hoàng Long",  MemberRole = "Thành viên"  }
            };

            flowLayoutPanel1.Controls.Clear();

            foreach (var m in samples)
            {
                flowLayoutPanel1.Controls.Add(m);
            }
        }
    }
}
