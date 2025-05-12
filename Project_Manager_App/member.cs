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
    // member.cs
    public partial class member : UserControl
    {
        public member()
        {
            InitializeComponent();
            label_name.Click += Label_name_Click; // Đăng ký sự kiện click cho label_name
        }

        // Thuộc tính cho Username
        public string Username
        {
            get { return label_name.Text; }
            set { label_name.Text = value; }
        }

        // Thuộc tính cho Role
        public string Role
        {
            get { return label_role.Text; }
            set { label_role.Text = value; }
        }

        private void Label_name_Click(object sender, EventArgs e)
        {
            // Khi nhấn vào label_name, hiển thị member_details của member đó
            member_details memberDetailsControl = new member_details();
            memberDetailsControl.ShowMemberDetails(Username);  // Truyền Username vào phương thức ShowMemberDetails

            // Tìm form chính để load member_details
            Main mainForm = (Main)Application.OpenForms["Main"];
            mainForm.LoadUserControl(memberDetailsControl);  // Quay lại UserControl trong Main
        }
    }

}
