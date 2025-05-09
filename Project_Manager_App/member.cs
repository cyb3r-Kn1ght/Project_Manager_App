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
    public partial class member: UserControl
    {
        public member()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MemberName
        {
            get => label_name.Text;
            set => label_name.Text = value;
        }

        // Property để set vai trò
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MemberRole
        {
            get => label_role.Text;
            set => label_role.Text = value;
        }
    }
}
