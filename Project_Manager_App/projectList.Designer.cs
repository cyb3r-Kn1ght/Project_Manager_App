namespace Project_Manager_App
{
    partial class projectList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            btn_createProject = new Button();
            projectListView = new ListView();
            ProjectName = new ColumnHeader();
            Description = new ColumnHeader();
            StartDate = new ColumnHeader();
            EndDate = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_createProject);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 53);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(455, 14);
            label1.Name = "label1";
            label1.Size = new Size(357, 25);
            label1.TabIndex = 0;
            label1.Text = "Danh sách dự án";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_createProject
            // 
            btn_createProject.Location = new Point(12, 12);
            btn_createProject.Name = "btn_createProject";
            btn_createProject.Size = new Size(137, 29);
            btn_createProject.TabIndex = 1;
            btn_createProject.Text = "Tạo dự án mới";
            btn_createProject.UseVisualStyleBackColor = true;
            btn_createProject.Click += btn_createProject_Click;
            // 
            // projectListView
            // 
            projectListView.Columns.AddRange(new ColumnHeader[] { ProjectName, Description, StartDate, EndDate });
            projectListView.FullRowSelect = true;
            projectListView.GridLines = true;
            projectListView.Location = new Point(12, 59);
            projectListView.MultiSelect = false;
            projectListView.Name = "projectListView";
            projectListView.Size = new Size(915, 549);
            projectListView.TabIndex = 1;
            projectListView.UseCompatibleStateImageBehavior = false;
            projectListView.View = View.Details;
            projectListView.DoubleClick += projectListView_DoubleClick;
            // 
            // ProjectName
            // 
            ProjectName.Text = "Tên dự án";
            ProjectName.Width = 200;
            // 
            // Description
            // 
            Description.Text = "Mô tả";
            Description.Width = 400;
            // 
            // StartDate
            // 
            StartDate.Text = "Ngày bắt đầu";
            StartDate.Width = 150;
            // 
            // EndDate
            // 
            EndDate.Text = "Ngày kết thúc";
            EndDate.Width = 150;
            // 
            // projectList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(projectListView);
            Controls.Add(panel1);
            Name = "projectList";
            Size = new Size(939, 620);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn_createProject;
        private ListView projectListView;
        private ColumnHeader ProjectName;
        private ColumnHeader Description;
        private ColumnHeader StartDate;
        private ColumnHeader EndDate;
    }
} 