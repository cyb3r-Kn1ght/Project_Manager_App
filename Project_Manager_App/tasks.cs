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
    public partial class tasks: UserControl
    {
        public tasks()
        {
            InitializeComponent();
        }

        public string TaskTitle
        {
            get => label_Title.Text;
            set => label_Title.Text = value;
        }

        public string TaskTime
        {
            get => label_hour.Text;
            set => label_hour.Text = value;
        }

        public string TaskDate
        {
            get => label_day.Text;
            set => label_day.Text = value;
        }

        public bool IsCompleted
        {
            get => !label_Title.Enabled;
            set
            {
                label_Title.Enabled = !value;
                label_hour.Enabled = !value;
                label_day.Enabled = !value;
                this.BackColor = value ? Color.LightCyan : Color.Cyan;
            }
        }
    }
}
