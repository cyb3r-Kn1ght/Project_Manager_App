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
    public partial class project_manager : UserControl
    {
        public project_manager()
        {
            InitializeComponent();

            tasks task1 = new tasks
            {
                TaskTitle = "Xây dựng UI/UX",
                TaskTime = "23:00",
                TaskDate = "15/04/2025"
            };

            flowTaskList.Controls.Add(task1);
        }
    }
}
