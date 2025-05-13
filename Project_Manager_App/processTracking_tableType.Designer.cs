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
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            pictureBox_filterButton = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            tableLayoutPanel2 = new TableLayoutPanel();
            projectList = new ComboBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            taskTable = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_backButton).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_filterButton).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox_backButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1025, 44);
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
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(1025, 104);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 318F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.8452F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.1548F));
            tableLayoutPanel3.Controls.Add(label3, 1, 0);
            tableLayoutPanel3.Controls.Add(dateTimePicker2, 2, 0);
            tableLayoutPanel3.Controls.Add(pictureBox_filterButton, 3, 0);
            tableLayoutPanel3.Controls.Add(dateTimePicker1, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 56);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1022, 45);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(335, 12);
            label3.Name = "label3";
            label3.Size = new Size(23, 20);
            label3.TabIndex = 4;
            label3.Text = "to";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.None;
            dateTimePicker2.Location = new Point(401, 9);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(271, 27);
            dateTimePicker2.TabIndex = 8;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // pictureBox_filterButton
            // 
            pictureBox_filterButton.Anchor = AnchorStyles.Left;
            pictureBox_filterButton.BackColor = SystemColors.Control;
            pictureBox_filterButton.Image = Properties.Resources.filter_alt_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            pictureBox_filterButton.Location = new Point(700, 9);
            pictureBox_filterButton.Name = "pictureBox_filterButton";
            pictureBox_filterButton.Size = new Size(36, 27);
            pictureBox_filterButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_filterButton.TabIndex = 9;
            pictureBox_filterButton.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(22, 9);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(273, 27);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3902435F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.60976F));
            tableLayoutPanel2.Controls.Add(projectList, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1025, 50);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // projectList
            // 
            projectList.Anchor = AnchorStyles.Left;
            projectList.FormattingEnabled = true;
            projectList.Location = new Point(130, 11);
            projectList.Name = "projectList";
            projectList.Size = new Size(683, 28);
            projectList.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.Location = new Point(24, 12);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 0;
            label2.Text = "Chọn dự án: ";
            label2.Click += label2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(taskTable, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1031, 546);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // taskTable
            // 
            taskTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            taskTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            taskTable.Dock = DockStyle.Fill;
            taskTable.Location = new Point(3, 163);
            taskTable.Name = "taskTable";
            taskTable.RowHeadersWidth = 51;
            taskTable.Size = new Size(1025, 380);
            taskTable.TabIndex = 4;
            // 
            // processTracking_tableType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "processTracking_tableType";
            Size = new Size(1031, 546);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_backButton).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_filterButton).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)taskTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private ComboBox projectList;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView taskTable;
        private PictureBox pictureBox_backButton;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox_filterButton;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
