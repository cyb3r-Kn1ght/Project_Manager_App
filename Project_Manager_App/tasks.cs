using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Manager_App
{

    public partial class tasks : UserControl
    {
        private string projectName;
        public string ProjectName
        {
            get => projectName;
            set => projectName = value;
        }

        public int userID { get; set; } // Thuộc tính cho TaskId
        public tasks()
        {
            InitializeComponent();
            label_Title.Click += Label_Title_Click;
        }

        public string TaskTitle
        {
            get { return label_Title.Text; }
            set { label_Title.Text = value; }
        }

        // Thuộc tính cho Ngày Task
        public string TaskDay
        {
            get { return label_day.Text; }
            set { label_day.Text = value; }
        }

        // Thuộc tính cho Giờ Task
        public string TaskHour
        {
            get { return label_hour.Text; }
            set { label_hour.Text = value; }
        }

        private void Label_Title_Click(object sender, EventArgs e)
        {
            // Lấy thông tin task từ control
            string taskTitle = TaskTitle;
            string taskDay = TaskDay;
            string taskHour = TaskHour;

            // Tạo và hiển thị TaskDetail
            TaskDetail taskDetailControl = new TaskDetail(this.projectName);
            taskDetailControl.ShowTaskDetail(taskTitle, taskDay, taskHour);
            taskDetailControl.userID = this.userID; // Truyền userID vào TaskDetail

            // Tìm form chính để load TaskDetail
            Main mainForm = (Main)Application.OpenForms["Main"];
            mainForm.LoadUC(taskDetailControl);  // Gọi phương thức LoadUserControl trong Main
        }
    }
}
