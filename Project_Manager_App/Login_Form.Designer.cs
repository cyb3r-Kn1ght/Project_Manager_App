namespace Project_Manager_App
{
    partial class Login_Form
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            btn_Login = new Button();
            txt_Username = new TextBox();
            txt_password = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(348, 87);
            label1.Name = "label1";
            label1.Size = new Size(162, 62);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.kindpng_5527945;
            pictureBox1.Location = new Point(385, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.person_24dp_00BFFF_FILL0_wght400_GRAD0_opsz24;
            pictureBox2.Location = new Point(223, 189);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Cursor = Cursors.No;
            panel1.Location = new Point(223, 241);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 1);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Cursor = Cursors.No;
            panel2.Location = new Point(223, 343);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 1);
            panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.vpn_key_24dp_00BFFF_FILL0_wght400_GRAD0_opsz24;
            pictureBox3.Location = new Point(223, 295);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.DeepSkyBlue;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login.ForeColor = SystemColors.Window;
            btn_Login.Location = new Point(223, 394);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(400, 50);
            btn_Login.TabIndex = 6;
            btn_Login.Text = "LOGIN";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += button1_Click;
            // 
            // txt_Username
            // 
            txt_Username.BorderStyle = BorderStyle.None;
            txt_Username.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Username.Location = new Point(273, 189);
            txt_Username.Multiline = true;
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(350, 46);
            txt_Username.TabIndex = 7;
            // 
            // txt_password
            // 
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(273, 291);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(350, 46);
            txt_password.TabIndex = 8;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(txt_password);
            Controls.Add(txt_Username);
            Controls.Add(btn_Login);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = Color.DeepSkyBlue;
            Name = "Login_Form";
            Size = new Size(843, 485);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Button btn_Login;
        private TextBox txt_Username;
        private TextBox txt_password;
    }
}
