namespace Project_Manager_App
{
    partial class TaskDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskDetail));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel_descript = new Panel();
            richTextBox_Descript = new RichTextBox();
            label_Descript = new Label();
            panel_header = new Panel();
            pictureBox1 = new PictureBox();
            label_ProjectName = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel_joblist = new Panel();
            label_joblist = new Label();
            checkedListBox_joblist = new CheckedListBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel_newActivity = new Panel();
            richTextBox_newActivity = new RichTextBox();
            label_newactivity = new Label();
            panel_member = new Panel();
            richTextBox_member = new RichTextBox();
            label_member = new Label();
            panel_file = new Panel();
            label_file = new Label();
            richTextBox_file = new RichTextBox();
            panel_deadline = new Panel();
            richTextBox_Deadline = new RichTextBox();
            label_Deadline = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel_descript.SuspendLayout();
            panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel_joblist.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel_newActivity.SuspendLayout();
            panel_member.SuspendLayout();
            panel_file.SuspendLayout();
            panel_deadline.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel_descript, 0, 1);
            tableLayoutPanel1.Controls.Add(panel_header, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.043478F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.95652F));
            tableLayoutPanel1.Size = new Size(1316, 775);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // panel_descript
            // 
            panel_descript.BackColor = Color.DeepSkyBlue;
            panel_descript.Controls.Add(richTextBox_Descript);
            panel_descript.Controls.Add(label_Descript);
            panel_descript.Dock = DockStyle.Fill;
            panel_descript.Location = new Point(3, 53);
            panel_descript.Name = "panel_descript";
            panel_descript.Size = new Size(1310, 88);
            panel_descript.TabIndex = 1;
            // 
            // richTextBox_Descript
            // 
            richTextBox_Descript.BackColor = Color.DeepSkyBlue;
            richTextBox_Descript.BorderStyle = BorderStyle.None;
            richTextBox_Descript.Location = new Point(8, 28);
            richTextBox_Descript.Name = "richTextBox_Descript";
            richTextBox_Descript.ReadOnly = true;
            richTextBox_Descript.Size = new Size(1264, 56);
            richTextBox_Descript.TabIndex = 1;
            richTextBox_Descript.TabStop = false;
            richTextBox_Descript.Text = "Nội dung mô tả";
            // 
            // label_Descript
            // 
            label_Descript.AutoSize = true;
            label_Descript.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Descript.Location = new Point(0, 0);
            label_Descript.Name = "label_Descript";
            label_Descript.Size = new Size(62, 25);
            label_Descript.TabIndex = 0;
            label_Descript.Text = "Mô tả";
            // 
            // panel_header
            // 
            panel_header.BackColor = Color.DeepSkyBlue;
            panel_header.Controls.Add(pictureBox1);
            panel_header.Controls.Add(label_ProjectName);
            panel_header.Dock = DockStyle.Fill;
            panel_header.Location = new Point(3, 3);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(1310, 44);
            panel_header.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label_ProjectName
            // 
            label_ProjectName.AutoSize = true;
            label_ProjectName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ProjectName.Location = new Point(163, 1);
            label_ProjectName.Name = "label_ProjectName";
            label_ProjectName.Size = new Size(174, 38);
            label_ProjectName.TabIndex = 0;
            label_ProjectName.Text = "Chi tiết task";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Controls.Add(panel_joblist, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 147);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1310, 625);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel_joblist
            // 
            panel_joblist.BackColor = Color.DeepSkyBlue;
            panel_joblist.Controls.Add(label_joblist);
            panel_joblist.Controls.Add(checkedListBox_joblist);
            panel_joblist.Dock = DockStyle.Fill;
            panel_joblist.Location = new Point(396, 3);
            panel_joblist.Name = "panel_joblist";
            panel_joblist.Size = new Size(911, 619);
            panel_joblist.TabIndex = 10;
            // 
            // label_joblist
            // 
            label_joblist.AutoSize = true;
            label_joblist.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_joblist.Location = new Point(29, 28);
            label_joblist.Name = "label_joblist";
            label_joblist.Size = new Size(139, 25);
            label_joblist.TabIndex = 1;
            label_joblist.Text = "Danh sách việc";
            // 
            // checkedListBox_joblist
            // 
            checkedListBox_joblist.BackColor = Color.DeepSkyBlue;
            checkedListBox_joblist.BorderStyle = BorderStyle.None;
            checkedListBox_joblist.FormattingEnabled = true;
            checkedListBox_joblist.Location = new Point(86, 61);
            checkedListBox_joblist.Name = "checkedListBox_joblist";
            checkedListBox_joblist.Size = new Size(792, 532);
            checkedListBox_joblist.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel_newActivity, 0, 3);
            tableLayoutPanel3.Controls.Add(panel_member, 0, 2);
            tableLayoutPanel3.Controls.Add(panel_file, 0, 1);
            tableLayoutPanel3.Controls.Add(panel_deadline, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 38.0952377F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.0476189F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(387, 619);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel_newActivity
            // 
            panel_newActivity.BackColor = Color.DeepSkyBlue;
            panel_newActivity.Controls.Add(richTextBox_newActivity);
            panel_newActivity.Controls.Add(label_newactivity);
            panel_newActivity.Dock = DockStyle.Fill;
            panel_newActivity.Location = new Point(3, 443);
            panel_newActivity.Name = "panel_newActivity";
            panel_newActivity.Size = new Size(381, 173);
            panel_newActivity.TabIndex = 5;
            // 
            // richTextBox_newActivity
            // 
            richTextBox_newActivity.BackColor = Color.DeepSkyBlue;
            richTextBox_newActivity.BorderStyle = BorderStyle.None;
            richTextBox_newActivity.Location = new Point(2, 28);
            richTextBox_newActivity.Name = "richTextBox_newActivity";
            richTextBox_newActivity.ReadOnly = true;
            richTextBox_newActivity.Size = new Size(376, 139);
            richTextBox_newActivity.TabIndex = 1;
            richTextBox_newActivity.TabStop = false;
            richTextBox_newActivity.Text = "Hoạt động mới nhất ở đây";
            // 
            // label_newactivity
            // 
            label_newactivity.AutoSize = true;
            label_newactivity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_newactivity.Location = new Point(0, 0);
            label_newactivity.Name = "label_newactivity";
            label_newactivity.Size = new Size(153, 25);
            label_newactivity.TabIndex = 0;
            label_newactivity.Text = "Thời gian còn lại";
            // 
            // panel_member
            // 
            panel_member.BackColor = Color.DeepSkyBlue;
            panel_member.Controls.Add(richTextBox_member);
            panel_member.Controls.Add(label_member);
            panel_member.Dock = DockStyle.Fill;
            panel_member.Location = new Point(3, 326);
            panel_member.Name = "panel_member";
            panel_member.Size = new Size(381, 111);
            panel_member.TabIndex = 4;
            // 
            // richTextBox_member
            // 
            richTextBox_member.BackColor = Color.DeepSkyBlue;
            richTextBox_member.BorderStyle = BorderStyle.None;
            richTextBox_member.Location = new Point(3, 28);
            richTextBox_member.Name = "richTextBox_member";
            richTextBox_member.ReadOnly = true;
            richTextBox_member.Size = new Size(375, 78);
            richTextBox_member.TabIndex = 8;
            richTextBox_member.TabStop = false;
            richTextBox_member.Text = "Các thành viên";
            // 
            // label_member
            // 
            label_member.AutoSize = true;
            label_member.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_member.Location = new Point(0, 0);
            label_member.Name = "label_member";
            label_member.Size = new Size(207, 25);
            label_member.TabIndex = 0;
            label_member.Text = "Thành viên đảm nhiệm";
            // 
            // panel_file
            // 
            panel_file.BackColor = Color.DeepSkyBlue;
            panel_file.Controls.Add(label_file);
            panel_file.Controls.Add(richTextBox_file);
            panel_file.Dock = DockStyle.Fill;
            panel_file.Location = new Point(3, 91);
            panel_file.Name = "panel_file";
            panel_file.Size = new Size(381, 229);
            panel_file.TabIndex = 3;
            // 
            // label_file
            // 
            label_file.AutoSize = true;
            label_file.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_file.Location = new Point(0, 0);
            label_file.Name = "label_file";
            label_file.Size = new Size(125, 25);
            label_file.TabIndex = 6;
            label_file.Text = "File đính kèm";
            // 
            // richTextBox_file
            // 
            richTextBox_file.BackColor = Color.DeepSkyBlue;
            richTextBox_file.BorderStyle = BorderStyle.None;
            richTextBox_file.Location = new Point(2, 28);
            richTextBox_file.Name = "richTextBox_file";
            richTextBox_file.ReadOnly = true;
            richTextBox_file.Size = new Size(376, 194);
            richTextBox_file.TabIndex = 7;
            richTextBox_file.TabStop = false;
            richTextBox_file.Text = "Các file đính kèm";
            // 
            // panel_deadline
            // 
            panel_deadline.BackColor = Color.DeepSkyBlue;
            panel_deadline.Controls.Add(richTextBox_Deadline);
            panel_deadline.Controls.Add(label_Deadline);
            panel_deadline.Dock = DockStyle.Fill;
            panel_deadline.Location = new Point(3, 3);
            panel_deadline.Name = "panel_deadline";
            panel_deadline.Size = new Size(381, 82);
            panel_deadline.TabIndex = 2;
            // 
            // richTextBox_Deadline
            // 
            richTextBox_Deadline.BackColor = Color.DeepSkyBlue;
            richTextBox_Deadline.BorderStyle = BorderStyle.None;
            richTextBox_Deadline.Location = new Point(3, 28);
            richTextBox_Deadline.Name = "richTextBox_Deadline";
            richTextBox_Deadline.ReadOnly = true;
            richTextBox_Deadline.Size = new Size(375, 49);
            richTextBox_Deadline.TabIndex = 6;
            richTextBox_Deadline.TabStop = false;
            richTextBox_Deadline.Text = "Thời gian Deadline";
            // 
            // label_Deadline
            // 
            label_Deadline.AutoSize = true;
            label_Deadline.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Deadline.Location = new Point(0, 0);
            label_Deadline.Name = "label_Deadline";
            label_Deadline.Size = new Size(87, 25);
            label_Deadline.TabIndex = 0;
            label_Deadline.Text = "Deadline";
            // 
            // TaskDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "TaskDetail";
            Size = new Size(1316, 775);
            tableLayoutPanel1.ResumeLayout(false);
            panel_descript.ResumeLayout(false);
            panel_descript.PerformLayout();
            panel_header.ResumeLayout(false);
            panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel_joblist.ResumeLayout(false);
            panel_joblist.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel_newActivity.ResumeLayout(false);
            panel_newActivity.PerformLayout();
            panel_member.ResumeLayout(false);
            panel_member.PerformLayout();
            panel_file.ResumeLayout(false);
            panel_file.PerformLayout();
            panel_deadline.ResumeLayout(false);
            panel_deadline.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel7;
        private Panel panel8;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel_header;
        private PictureBox pictureBox1;
        private Label label_ProjectName;
        private Panel panel_descript;
        private RichTextBox richTextBox_Descript;
        private Label label_Descript;
        private Panel panel_deadline;
        private RichTextBox richTextBox_Deadline;
        private Label label_Deadline;
        private Panel panel_file;
        private Label label_file;
        private RichTextBox richTextBox_file;
        private Panel panel_member;
        private RichTextBox richTextBox_member;
        private Label label_member;
        private Panel panel_newActivity;
        private RichTextBox richTextBox_newActivity;
        private Label label_newactivity;
        private Panel panel_joblist;
        private Label label_joblist;
        private CheckedListBox checkedListBox_joblist;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}
