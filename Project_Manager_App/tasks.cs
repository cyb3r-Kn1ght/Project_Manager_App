using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Manager_App
{
    // 1. Định nghĩa enum ba trạng thái
    public enum TaskStatus
    {
        NeedToDo,
        IsDoing,
        Done
    }

    public partial class tasks : UserControl
    {
        // 2. Field lưu trạng thái
        private TaskStatus status;
        public event EventHandler TaskClicked;

        public tasks()
        {
            InitializeComponent();
            // 3. Mặc định khi thêm control mới sẽ ở trạng thái NeedToDo
            Status = TaskStatus.NeedToDo;
            label_Title.Click += (s, e) => TaskClicked?.Invoke(this, EventArgs.Empty);
        }

        // 4. Các property hiển thị trên giao diện
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

        // 5. (Tùy chọn) property đánh dấu đã hoàn thành
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsCompleted
        {
            get => !label_Title.Enabled;
            set
            {
                label_Title.Enabled = !value;
                label_hour.Enabled = !value;
                label_day.Enabled = !value;
                // Đồng bộ màu sắc với Status nếu muốn
                panel1.BackColor = value
                    ? Color.LightCyan
                    : Color.Cyan;
            }
        }

        // 6. Property ẩn khỏi Designer để quản lý Status từ code
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TaskStatus Status
        {
            get => status;
            set
            {
                status = value;
                UpdateStatusVisual();
            }
        }

        // 7. Cập nhật màu panel1 theo trạng thái
        private void UpdateStatusVisual()
        {
            switch (status)
            {
                case TaskStatus.NeedToDo:
                    panel1.BackColor = Color.SkyBlue;
                    break;
                case TaskStatus.IsDoing:
                    panel1.BackColor = Color.Orange;
                    break;
                case TaskStatus.Done:
                    panel1.BackColor = Color.LightGreen;
                    break;
            }
        }
    }
}
