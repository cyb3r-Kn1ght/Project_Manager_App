namespace Project_Manager_App
{
    partial class processTracking
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
            panel3 = new Panel();
            btn_changeMode = new Button();
            pictureBox_filterButton = new PictureBox();
            projectList = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_backButton).BeginInit();
            panel3.SuspendLayout();
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
            pictureBox_backButton.Click += pictureBox_backButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_changeMode);
            panel3.Controls.Add(pictureBox_filterButton);
            panel3.Controls.Add(projectList);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(883, 60);
            panel3.TabIndex = 2;
            // 
            // btn_changeMode
            // 
            btn_changeMode.Location = new Point(377, 14);
            btn_changeMode.Name = "btn_changeMode";
            btn_changeMode.Size = new Size(137, 29);
            btn_changeMode.TabIndex = 6;
            btn_changeMode.Text = "Dạng bảng";
            btn_changeMode.UseVisualStyleBackColor = true;
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
            // 
            // projectList
            // 
            projectList.FormattingEnabled = true;
            projectList.Location = new Point(108, 13);
            projectList.Name = "projectList";
            projectList.Size = new Size(151, 28);
            projectList.TabIndex = 4;
            // 
            // label2
            // 
            label2.Location = new Point(13, 16);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 0;
            label2.Text = "Chọn dự án: ";
            // 
            // processTracking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "processTracking";
            Size = new Size(884, 546);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_backButton).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_filterButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox_backButton;
        private Label label1;
        private Panel panel3;
        private Button btn_changeMode;
        private PictureBox pictureBox_filterButton;
        private ComboBox projectList;
        private Label label2;
    }
}
