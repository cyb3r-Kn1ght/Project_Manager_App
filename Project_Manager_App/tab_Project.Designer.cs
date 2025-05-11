namespace Project_Manager_App
{
    partial class tab_Project
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pic_Project = new PictureBox();
            label_nameProject = new Label();
            processBarofProject = new CircularProgressBar_NET5.CircularProgressBar();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Project).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1061, 594);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.98492F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3100853F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.6248817F));
            tableLayoutPanel1.Controls.Add(pic_Project, 1, 1);
            tableLayoutPanel1.Controls.Add(label_nameProject, 1, 2);
            tableLayoutPanel1.Controls.Add(processBarofProject, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.8451176F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.121212F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1061, 594);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // pic_Project
            // 
            tableLayoutPanel1.SetColumnSpan(pic_Project, 2);
            pic_Project.Dock = DockStyle.Fill;
            pic_Project.Location = new Point(162, 62);
            pic_Project.Name = "pic_Project";
            pic_Project.Size = new Size(708, 291);
            pic_Project.TabIndex = 0;
            pic_Project.TabStop = false;
            pic_Project.Click += pic_Project_Click;
            // 
            // label_nameProject
            // 
            label_nameProject.AutoSize = true;
            label_nameProject.Dock = DockStyle.Fill;
            label_nameProject.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_nameProject.Location = new Point(164, 356);
            label_nameProject.Margin = new Padding(5, 0, 3, 0);
            label_nameProject.Name = "label_nameProject";
            tableLayoutPanel1.SetRowSpan(label_nameProject, 2);
            label_nameProject.Size = new Size(586, 178);
            label_nameProject.TabIndex = 1;
            label_nameProject.Text = "Name_of_Project";
            label_nameProject.Click += label_nameProject_Click;
            // 
            // processBarofProject
            // 
            processBarofProject.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            processBarofProject.AnimationSpeed = 500;
            processBarofProject.BackColor = Color.Transparent;
            processBarofProject.Dock = DockStyle.Fill;
            processBarofProject.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            processBarofProject.ForeColor = Color.FromArgb(64, 64, 64);
            processBarofProject.InnerColor = SystemColors.ControlLight;
            processBarofProject.InnerMargin = 2;
            processBarofProject.InnerWidth = -1;
            processBarofProject.Location = new Point(756, 359);
            processBarofProject.MarqueeAnimationSpeed = 2000;
            processBarofProject.Name = "processBarofProject";
            processBarofProject.OuterColor = Color.Black;
            processBarofProject.OuterMargin = -25;
            processBarofProject.OuterWidth = 26;
            processBarofProject.ProgressColor = Color.DodgerBlue;
            processBarofProject.ProgressWidth = 5;
            processBarofProject.SecondaryFont = new Font("Segoe UI", 36F);
            processBarofProject.Size = new Size(114, 100);
            processBarofProject.StartAngle = 270;
            processBarofProject.Style = ProgressBarStyle.Continuous;
            processBarofProject.SubscriptColor = Color.FromArgb(166, 166, 166);
            processBarofProject.SubscriptMargin = new Padding(10, -35, 0, 0);
            processBarofProject.SubscriptText = "";
            processBarofProject.SuperscriptColor = Color.FromArgb(166, 166, 166);
            processBarofProject.SuperscriptMargin = new Padding(10, 35, 0, 0);
            processBarofProject.SuperscriptText = "";
            processBarofProject.TabIndex = 13;
            processBarofProject.Text = "89%";
            processBarofProject.TextMargin = new Padding(8, 8, 0, 0);
            processBarofProject.Value = 68;
            // 
            // tab_Project
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "tab_Project";
            Size = new Size(1061, 594);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Project).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pic_Project;
        private Label label_nameProject;
        private CircularProgressBar_NET5.CircularProgressBar processBarofProject;
    }
}
