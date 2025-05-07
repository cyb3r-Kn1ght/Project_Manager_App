namespace Project_Manager_App
{
    partial class FirstPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPage));
            headerUserConrtrol = new Panel();
            headerUserControl1 = new headerUserControl();
            content_Panel = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lb_project = new Label();
            processBar = new CircularProgressBar_NET5.CircularProgressBar();
            circularProgressBar1 = new CircularProgressBar_NET5.CircularProgressBar();
            headerUserConrtrol.SuspendLayout();
            content_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // headerUserConrtrol
            // 
            headerUserConrtrol.Controls.Add(headerUserControl1);
            headerUserConrtrol.Dock = DockStyle.Top;
            headerUserConrtrol.Location = new Point(0, 0);
            headerUserConrtrol.Name = "headerUserConrtrol";
            headerUserConrtrol.Size = new Size(843, 70);
            headerUserConrtrol.TabIndex = 0;
            // 
            // headerUserControl1
            // 
            headerUserControl1.BackColor = Color.Cyan;
            headerUserControl1.Location = new Point(0, 0);
            headerUserControl1.Name = "headerUserControl1";
            headerUserControl1.Size = new Size(843, 70);
            headerUserControl1.TabIndex = 0;
            // 
            // content_Panel
            // 
            content_Panel.BackColor = SystemColors.ControlLight;
            content_Panel.Controls.Add(circularProgressBar1);
            content_Panel.Controls.Add(processBar);
            content_Panel.Controls.Add(label2);
            content_Panel.Controls.Add(label1);
            content_Panel.Controls.Add(pictureBox2);
            content_Panel.Controls.Add(pictureBox1);
            content_Panel.Controls.Add(lb_project);
            content_Panel.Dock = DockStyle.Fill;
            content_Panel.Location = new Point(0, 70);
            content_Panel.Name = "content_Panel";
            content_Panel.Size = new Size(843, 415);
            content_Panel.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(525, 275);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 4;
            label2.Text = "Dự án: Fine-tune AI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 275);
            label1.Name = "label1";
            label1.Size = new Size(213, 25);
            label1.TabIndex = 3;
            label1.Text = "Dự án: Kinh tế thị trường ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(497, 71);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(304, 188);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lb_project
            // 
            lb_project.AutoSize = true;
            lb_project.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_project.Location = new Point(28, 20);
            lb_project.Name = "lb_project";
            lb_project.Size = new Size(171, 31);
            lb_project.TabIndex = 0;
            lb_project.Text = "Dự án hiện tại ";
            // 
            // processBar
            // 
            processBar.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            processBar.AnimationSpeed = 500;
            processBar.BackColor = Color.Transparent;
            processBar.Font = new Font("Segoe UI", 72F, FontStyle.Bold);
            processBar.ForeColor = Color.FromArgb(64, 64, 64);
            processBar.InnerColor = SystemColors.ControlLight;
            processBar.InnerMargin = 2;
            processBar.InnerWidth = -1;
            processBar.Location = new Point(238, 265);
            processBar.MarqueeAnimationSpeed = 2000;
            processBar.Name = "processBar";
            processBar.OuterColor = Color.Black;
            processBar.OuterMargin = -25;
            processBar.OuterWidth = 26;
            processBar.ProgressColor = Color.DodgerBlue;
            processBar.ProgressWidth = 5;
            processBar.SecondaryFont = new Font("Segoe UI", 36F);
            processBar.Size = new Size(50, 49);
            processBar.StartAngle = 270;
            processBar.Style = ProgressBarStyle.Continuous;
            processBar.SubscriptColor = Color.FromArgb(166, 166, 166);
            processBar.SubscriptMargin = new Padding(10, -35, 0, 0);
            processBar.SubscriptText = ".23";
            processBar.SuperscriptColor = Color.FromArgb(166, 166, 166);
            processBar.SuperscriptMargin = new Padding(10, 35, 0, 0);
            processBar.SuperscriptText = "°C";
            processBar.TabIndex = 5;
            processBar.TextMargin = new Padding(8, 8, 0, 0);
            processBar.Value = 68;
            // 
            // circularProgressBar1
            // 
            circularProgressBar1.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            circularProgressBar1.AnimationSpeed = 500;
            circularProgressBar1.BackColor = Color.Transparent;
            circularProgressBar1.Font = new Font("Segoe UI", 72F, FontStyle.Bold);
            circularProgressBar1.ForeColor = Color.FromArgb(64, 64, 64);
            circularProgressBar1.InnerColor = SystemColors.ControlLight;
            circularProgressBar1.InnerMargin = 2;
            circularProgressBar1.InnerWidth = -1;
            circularProgressBar1.Location = new Point(717, 265);
            circularProgressBar1.MarqueeAnimationSpeed = 2000;
            circularProgressBar1.Name = "circularProgressBar1";
            circularProgressBar1.OuterColor = Color.Black;
            circularProgressBar1.OuterMargin = -25;
            circularProgressBar1.OuterWidth = 26;
            circularProgressBar1.ProgressColor = Color.DodgerBlue;
            circularProgressBar1.ProgressWidth = 5;
            circularProgressBar1.SecondaryFont = new Font("Segoe UI", 36F);
            circularProgressBar1.Size = new Size(50, 49);
            circularProgressBar1.StartAngle = 270;
            circularProgressBar1.Style = ProgressBarStyle.Continuous;
            circularProgressBar1.SubscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar1.SubscriptMargin = new Padding(10, -35, 0, 0);
            circularProgressBar1.SubscriptText = ".23";
            circularProgressBar1.SuperscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar1.SuperscriptMargin = new Padding(10, 35, 0, 0);
            circularProgressBar1.SuperscriptText = "°C";
            circularProgressBar1.TabIndex = 6;
            circularProgressBar1.TextMargin = new Padding(8, 8, 0, 0);
            circularProgressBar1.Value = 68;
            // 
            // FirstPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(content_Panel);
            Controls.Add(headerUserConrtrol);
            Name = "FirstPage";
            Size = new Size(843, 485);
            headerUserConrtrol.ResumeLayout(false);
            content_Panel.ResumeLayout(false);
            content_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerUserConrtrol;
        private headerUserControl headerUserControl1;
        private Panel content_Panel;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lb_project;
        private CircularProgressBar_NET5.CircularProgressBar processBar;
        private CircularProgressBar_NET5.CircularProgressBar circularProgressBar1;
    }
}
