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
        // 1. Danh sách sample tasks
        private readonly List<tasks> allTasks;

        public project_manager()
        {
            InitializeComponent();

            // 2. Khởi tạo sample data (sau này thay bằng dữ liệu từ DB)
            allTasks = new List<tasks>
            {
                new tasks
                {
                    TaskTitle = "Lập kế hoạch dự án",
                    TaskDate  = DateTime.Today.ToString("dd/MM/yyyy"),
                    TaskTime  = "09:00",
                    Status    = TaskStatus.NeedToDo
                },
                new tasks
                {
                    TaskTitle = "Thiết kế giao diện",
                    TaskDate  = DateTime.Today.ToString("dd/MM/yyyy"),
                    TaskTime  = "11:00",
                    Status    = TaskStatus.NeedToDo
                },
                new tasks
                {
                    TaskTitle = "Phát triển module A",
                    TaskDate  = DateTime.Today.ToString("dd/MM/yyyy"),
                    TaskTime  = "14:00",
                    Status    = TaskStatus.IsDoing
                },
                new tasks
                {
                    TaskTitle = "Tối ưu hiệu năng",
                    TaskDate  = DateTime.Today.ToString("dd/MM/yyyy"),
                    TaskTime  = "16:30",
                    Status    = TaskStatus.IsDoing
                },
                new tasks
                {
                    TaskTitle = "Kiểm thử và bàn giao",
                    TaskDate  = DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy"),
                    TaskTime  = "15:00",
                    Status    = TaskStatus.Done
                },
                new tasks
                {
                    TaskTitle = "Hoàn thiện báo cáo",
                    TaskDate  = DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy"),
                    TaskTime  = "17:30",
                    Status    = TaskStatus.Done
                }
            };

            // 3. Gắn event cho các nút
            button_havetodo.Click += (s, e) => ShowTasks(TaskStatus.NeedToDo);
            button_IsDoing.Click += (s, e) => ShowTasks(TaskStatus.IsDoing);
            button_Finished.Click += (s, e) => ShowTasks(TaskStatus.Done);

            button_member.Click += (s, e) =>
            {
                var ml = new memberlist
                {
                    Dock = DockStyle.Fill
                };
                // Load memberlist lên Form chính
                (this.FindForm() as Main)?.LoadUserControl(ml);
            };

            // 4. Mặc định hiển thị "Việc cần làm"
            ShowTasks(TaskStatus.NeedToDo);
        }

        // Hàm lọc và render tasks lên flowTaskList
        private void ShowTasks(TaskStatus filterStatus)
        {
            // 1) Clear và highlight lại menu
            flowTaskList.Controls.Clear();

            // 2) Lọc và add từng task
            foreach (var t in allTasks.Where(x => x.Status == filterStatus))
            {

                // tránh đăng ký nhiều lần
                t.TaskClicked -= OnTaskClicked;
                t.TaskClicked += OnTaskClicked;

                flowTaskList.Controls.Add(t);
            }
        }

        private void OnTaskClicked(object sender, EventArgs e)
        {
            var t = sender as tasks;
            if (t == null) return;

            // 3) Tạo detail và truyền data
            var detail = new TaskDetail
            {
                ProjectName = t.TaskTitle,
                Deadline = $"{t.TaskTime} – {t.TaskDate}"
            };
            detail.Dock = DockStyle.Fill;

            // 4) Load lên Main
            (this.FindForm() as Main)?.LoadUserControl(detail);
        }


    }
}
