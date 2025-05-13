namespace Project_Manager_App
{
    partial class createProject
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
            btn_create = new Button();
            dateTimePicker_end = new DateTimePicker();
            dateTimePicker_start = new DateTimePicker();
            txt_description = new TextBox();
            txt_projectName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_backButton).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox_backButton);
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
            label1.Text = "Tạo dự án mới";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox_backButton
            // 
            pictureBox_backButton.Image = Properties.Resources.arrow_back_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            pictureBox_backButton.Location = new Point(3, 3);
            pictureBox_backButton.Name = "pictureBox_backButton";
            pictureBox_backButton.Size = new Size(48, 48);
            pictureBox_backButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_backButton.TabIndex = 1;
            pictureBox_backButton.TabStop = false;
            pictureBox_backButton.Click += pictureBox_backButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_create);
            panel2.Controls.Add(dateTimePicker_end);
            panel2.Controls.Add(dateTimePicker_start);
            panel2.Controls.Add(txt_description);
            panel2.Controls.Add(txt_projectName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(12, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(915, 549);
            panel2.TabIndex = 1;
            // 
            // btn_create
            // 
            btn_create.Location = new Point(389, 480);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(137, 29);
            btn_create.TabIndex = 8;
            btn_create.Text = "Tạo dự án";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // dateTimePicker_end
            // 
            dateTimePicker_end.Location = new Point(389, 400);
            dateTimePicker_end.Name = "dateTimePicker_end";
            dateTimePicker_end.Size = new Size(250, 27);
            dateTimePicker_end.TabIndex = 7;
            // 
            // dateTimePicker_start
            // 
            dateTimePicker_start.Location = new Point(389, 320);
            dateTimePicker_start.Name = "dateTimePicker_start";
            dateTimePicker_start.Size = new Size(250, 27);
            dateTimePicker_start.TabIndex = 6;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(389, 160);
            txt_description.Multiline = true;
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(500, 120);
            txt_description.TabIndex = 5;
            // 
            // txt_projectName
            // 
            txt_projectName.Location = new Point(389, 80);
            txt_projectName.Name = "txt_projectName";
            txt_projectName.Size = new Size(500, 27);
            txt_projectName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 405);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày kết thúc:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 325);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 163);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Mô tả:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 83);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 0;
            label5.Text = "Tên dự án:";
            // 
            // createProject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "createProject";
            Size = new Size(939, 620);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_backButton).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox_backButton;
        private Panel panel2;
        private Button btn_create;
        private DateTimePicker dateTimePicker_end;
        private DateTimePicker dateTimePicker_start;
        private TextBox txt_description;
        private TextBox txt_projectName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
    }
} 