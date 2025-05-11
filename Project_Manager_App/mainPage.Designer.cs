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
            headerUserControl1 = new headerUserControl();
            label_title = new Label();
            panel1 = new Panel();
            tab_Project1 = new tab_Project();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel_DisplayHeader.SuspendLayout();
            panel1.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(panel2, 1, 2);
            tableLayoutPanel1.Controls.Add(panel3, 0, 3);
            tableLayoutPanel1.Controls.Add(panel4, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1051, 708);
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
            panel_DisplayHeader.Size = new Size(1045, 74);
            panel_DisplayHeader.TabIndex = 0;
            // 
            // headerUserControl1
            // 
            headerUserControl1.BackColor = Color.DeepSkyBlue;
            headerUserControl1.Dock = DockStyle.Fill;
            headerUserControl1.Location = new Point(0, 0);
            headerUserControl1.Name = "headerUserControl1";
            headerUserControl1.Size = new Size(1045, 74);
            headerUserControl1.TabIndex = 0;
            // 
            // label_title
            // 
            label_title.Anchor = AnchorStyles.Left;
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_title.Location = new Point(3, 90);
            label_title.Name = "label_title";
            label_title.Size = new Size(199, 38);
            label_title.TabIndex = 1;
            label_title.Text = "Dự án hiện tại ";
            // 
            // panel1
            // 
            panel1.Controls.Add(tab_Project1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 278);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint_1;
            // 
            // tab_Project1
            // 
            tab_Project1.Dock = DockStyle.Fill;
            tab_Project1.Location = new Point(0, 0);
            tab_Project1.Name = "tab_Project1";
            tab_Project1.Progress = 0;
            tab_Project1.ProjectImage = null;
            tab_Project1.ProjectTitle = null;
            tab_Project1.Size = new Size(519, 278);
            tab_Project1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(528, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(520, 278);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 426);
            panel3.Name = "panel3";
            panel3.Size = new Size(519, 279);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(528, 426);
            panel4.Name = "panel4";
            panel4.Size = new Size(520, 279);
            panel4.TabIndex = 5;
            // 
            // mainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "mainPage";
            Size = new Size(1051, 708);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel_DisplayHeader.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel_DisplayHeader;
        private headerUserControl headerUserControl1;
        private Label label_title;
        public Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private tab_Project tab_Project1;
    }
}
