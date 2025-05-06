namespace Project_Manager_App
{
    partial class processTracking_tableType
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
            pictureBox_backButton = new PictureBox();
            panel2 = new Panel();
            taskTable = new DataGridView();
            Task = new DataGridViewTextBoxColumn();
            BeginDate = new DataGridViewTextBoxColumn();
            FinishDate = new DataGridViewTextBoxColumn();
            Progress = new DataGridViewTextBoxColumn();
            label2 = new Label();
            projectList = new ComboBox();
            pictureBox_filterButton = new PictureBox();
            btn_changeMode = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_backButton).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_filterButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox_backButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 46);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(54, 8);
            label1.Name = "label1";
            label1.Size = new Size(168, 38);
            label1.TabIndex = 0;
            label1.Text = "Process Tracking";
            label1.UseMnemonic = false;
            // 
            // pictureBox_backButton
            // 
            pictureBox_backButton.Image = Properties.Resources.arrow_back_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            pictureBox_backButton.Location = new Point(3, 3);
            pictureBox_backButton.Name = "pictureBox_backButton";
            pictureBox_backButton.Size = new Size(45, 38);
            pictureBox_backButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_backButton.TabIndex = 4;
            pictureBox_backButton.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_changeMode);
            panel2.Controls.Add(pictureBox_filterButton);
            panel2.Controls.Add(projectList);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(883, 60);
            panel2.TabIndex = 1;
            // 
            // taskTable
            // 
            taskTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            taskTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            taskTable.Columns.AddRange(new DataGridViewColumn[] { Task, BeginDate, FinishDate, Progress });
            taskTable.Dock = DockStyle.Bottom;
            taskTable.Location = new Point(0, 108);
            taskTable.Name = "taskTable";
            taskTable.RowHeadersWidth = 51;
            taskTable.Size = new Size(884, 438);
            taskTable.TabIndex = 3;
            taskTable.CellContentClick += taskTable_CellContentClick;
            // 
            // Task
            // 
            Task.HeaderText = "Task";
            Task.MinimumWidth = 6;
            Task.Name = "Task";
            // 
            // BeginDate
            // 
            BeginDate.HeaderText = "Begin date";
            BeginDate.MinimumWidth = 6;
            BeginDate.Name = "BeginDate";
            // 
            // FinishDate
            // 
            FinishDate.HeaderText = "Finish date";
            FinishDate.MinimumWidth = 6;
            FinishDate.Name = "FinishDate";
            // 
            // Progress
            // 
            Progress.HeaderText = "Progress";
            Progress.MinimumWidth = 6;
            Progress.Name = "Progress";
            // 
            // label2
            // 
            label2.Location = new Point(13, 16);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 0;
            label2.Text = "Chọn dự án: ";
            // 
            // projectList
            // 
            projectList.FormattingEnabled = true;
            projectList.Location = new Point(108, 13);
            projectList.Name = "projectList";
            projectList.Size = new Size(151, 28);
            projectList.TabIndex = 4;
            // 
            // pictureBox_filterButton
            // 
            pictureBox_filterButton.BackColor = SystemColors.Control;
            pictureBox_filterButton.Image = Properties.Resources.filter_alt_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            pictureBox_filterButton.Location = new Point(308, 13);
            pictureBox_filterButton.Name = "pictureBox_filterButton";
            pictureBox_filterButton.Size = new Size(41, 30);
            pictureBox_filterButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_filterButton.TabIndex = 5;
            pictureBox_filterButton.TabStop = false;
            pictureBox_filterButton.Click += pictureBox_filterButton_Click;
            // 
            // btn_changeMode
            // 
            btn_changeMode.Location = new Point(377, 14);
            btn_changeMode.Name = "btn_changeMode";
            btn_changeMode.Size = new Size(137, 29);
            btn_changeMode.TabIndex = 6;
            btn_changeMode.Text = "Biểu đồ Gantt";
            btn_changeMode.UseVisualStyleBackColor = true;
            // 
            // processTracking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(taskTable);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "processTracking";
            Size = new Size(884, 546);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_backButton).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)taskTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_filterButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView taskTable;
        private DataGridViewTextBoxColumn Task;
        private DataGridViewTextBoxColumn BeginDate;
        private DataGridViewTextBoxColumn FinishDate;
        private DataGridViewTextBoxColumn Progress;
        private PictureBox pictureBox_backButton;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox_filterButton;
        private ComboBox projectList;
        private Button btn_changeMode;
    }
}
