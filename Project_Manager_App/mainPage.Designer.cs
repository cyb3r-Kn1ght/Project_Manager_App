namespace Project_Manager_App
{
    partial class mainPage
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel_DisplayHeader = new Panel();
            label_title = new Label();
            panel1 = new Panel();
            tab_Project1 = new tab_Project();
            panel3 = new Panel();
            tab_Project3 = new tab_Project();
            panel4 = new Panel();
            tab_Project4 = new tab_Project();
            panel2 = new Panel();
            tab_Project2 = new tab_Project();
            headerUserControl1 = new headerUserControl();
            tableLayoutPanel1.SuspendLayout();
            panel_DisplayHeader.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel_DisplayHeader, 0, 0);
            tableLayoutPanel1.Controls.Add(label_title, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(panel3, 0, 3);
            tableLayoutPanel1.Controls.Add(panel4, 1, 3);
            tableLayoutPanel1.Controls.Add(panel2, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(250, 708);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel_DisplayHeader
            // 
            tableLayoutPanel1.SetColumnSpan(panel_DisplayHeader, 2);
            panel_DisplayHeader.Controls.Add(headerUserControl1);
            panel_DisplayHeader.Dock = DockStyle.Fill;
            panel_DisplayHeader.Location = new Point(3, 3);
            panel_DisplayHeader.Name = "panel_DisplayHeader";
            panel_DisplayHeader.Size = new Size(244, 74);
            panel_DisplayHeader.TabIndex = 0;
            // 
            // label_title
            // 
            label_title.Anchor = AnchorStyles.Left;
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_title.Location = new Point(3, 80);
            label_title.Name = "label_title";
            label_title.Size = new Size(117, 59);
            label_title.TabIndex = 1;
            label_title.Text = "Dự án hiện tại ";
            // 
            // panel1
            // 
            panel1.Controls.Add(tab_Project1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(119, 278);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint_1;
            // 
            // tab_Project1
            // 
            tab_Project1.Dock = DockStyle.Fill;
            tab_Project1.Location = new Point(0, 0);
            tab_Project1.Margin = new Padding(4, 4, 4, 4);
            tab_Project1.Name = "tab_Project1";
            tab_Project1.Progress = 0;
            tab_Project1.ProjectImage = null;
            tab_Project1.ProjectTitle = null;
            tab_Project1.Size = new Size(119, 278);
            tab_Project1.TabIndex = 0;
            tab_Project1.UserID = 0;
            tab_Project1.Load += tab_Project1_Load_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(tab_Project3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 426);
            panel3.Name = "panel3";
            panel3.Size = new Size(119, 279);
            panel3.TabIndex = 4;
            // 
            // tab_Project3
            // 
            tab_Project3.Dock = DockStyle.Fill;
            tab_Project3.Location = new Point(0, 0);
            tab_Project3.Margin = new Padding(4, 4, 4, 4);
            tab_Project3.Name = "tab_Project3";
            tab_Project3.Progress = 0;
            tab_Project3.ProjectImage = null;
            tab_Project3.ProjectTitle = null;
            tab_Project3.Size = new Size(119, 279);
            tab_Project3.TabIndex = 0;
            tab_Project3.UserID = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(tab_Project4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(128, 426);
            panel4.Name = "panel4";
            panel4.Size = new Size(119, 279);
            panel4.TabIndex = 5;
            // 
            // tab_Project4
            // 
            tab_Project4.Dock = DockStyle.Fill;
            tab_Project4.Location = new Point(0, 0);
            tab_Project4.Margin = new Padding(4, 4, 4, 4);
            tab_Project4.Name = "tab_Project4";
            tab_Project4.Progress = 0;
            tab_Project4.ProjectImage = null;
            tab_Project4.ProjectTitle = null;
            tab_Project4.Size = new Size(119, 279);
            tab_Project4.TabIndex = 0;
            tab_Project4.UserID = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(tab_Project2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(128, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(119, 278);
            panel2.TabIndex = 6;
            // 
            // tab_Project2
            // 
            tab_Project2.Dock = DockStyle.Fill;
            tab_Project2.Location = new Point(0, 0);
            tab_Project2.Margin = new Padding(4, 4, 4, 4);
            tab_Project2.Name = "tab_Project2";
            tab_Project2.Progress = 0;
            tab_Project2.ProjectImage = null;
            tab_Project2.ProjectTitle = null;
            tab_Project2.Size = new Size(119, 278);
            tab_Project2.TabIndex = 0;
            tab_Project2.UserID = 0;
            // 
            // headerUserControl1
            // 
            headerUserControl1.BackColor = Color.DeepSkyBlue;
            headerUserControl1.Dock = DockStyle.Fill;
            headerUserControl1.Location = new Point(0, 0);
            headerUserControl1.MainForm = null;
            headerUserControl1.Name = "headerUserControl1";
            headerUserControl1.Size = new Size(1045, 74);
            headerUserControl1.TabIndex = 0;
            // 
            // mainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "mainPage";
            Size = new Size(250, 708);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel_DisplayHeader.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel_DisplayHeader;
        private Label label_title;
        public Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private tab_Project tab_Project3;
        private tab_Project tab_Project4;
        private Panel panel2;
        private tab_Project tab_Project2;
        private tab_Project tab_Project1;
        private headerUserControl headerUserControl1;
    }
}
