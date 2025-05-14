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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel_formLogin = new Panel();
            txt_password = new TextBox();
            txt_Username = new TextBox();
            btn_Login = new Button();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            tableLayoutPanel1.SuspendLayout();
            panel_formLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panel_formLogin, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(718, 559);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // panel_formLogin
            // 
            panel_formLogin.BackColor = SystemColors.ButtonFace;
            panel_formLogin.Controls.Add(txt_password);
            panel_formLogin.Controls.Add(txt_Username);
            panel_formLogin.Controls.Add(btn_Login);
            panel_formLogin.Controls.Add(panel2);
            panel_formLogin.Controls.Add(pictureBox3);
            panel_formLogin.Controls.Add(panel3);
            panel_formLogin.Controls.Add(pictureBox2);
            panel_formLogin.Controls.Add(pictureBox1);
            panel_formLogin.Controls.Add(label1);
            panel_formLogin.Dock = DockStyle.Fill;
            panel_formLogin.Location = new Point(146, 58);
            panel_formLogin.Name = "panel_formLogin";
            panel_formLogin.Size = new Size(424, 441);
            panel_formLogin.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Anchor = AnchorStyles.None;
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(100, 284);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(300, 46);
            txt_password.TabIndex = 54;
            txt_password.TextChanged += txt_password_TextChanged_1;
            // 
            // txt_Username
            // 
            txt_Username.Anchor = AnchorStyles.None;
            txt_Username.BorderStyle = BorderStyle.None;
            txt_Username.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Username.Location = new Point(100, 177);
            txt_Username.Multiline = true;
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(300, 46);
            txt_Username.TabIndex = 53;
            txt_Username.TextChanged += txt_Username_TextChanged_1;
            // 
            // btn_Login
            // 
            btn_Login.Anchor = AnchorStyles.None;
            btn_Login.BackColor = Color.DeepSkyBlue;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login.ForeColor = SystemColors.Window;
            btn_Login.Location = new Point(50, 363);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(350, 50);
            btn_Login.TabIndex = 52;
            btn_Login.Text = "LOGIN";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click_1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Cursor = Cursors.No;
            panel2.Location = new Point(50, 332);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 1);
            panel2.TabIndex = 51;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = Properties.Resources.vpn_key_24dp_00BFFF_FILL0_wght400_GRAD0_opsz24;
            pictureBox3.Location = new Point(50, 284);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 50;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.DeepSkyBlue;
            panel3.Cursor = Cursors.No;
            panel3.Location = new Point(50, 231);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 1);
            panel3.TabIndex = 49;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.person_24dp_00BFFF_FILL0_wght400_GRAD0_opsz24;
            pictureBox2.Location = new Point(50, 179);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.kindpng_5527945;
            pictureBox1.Location = new Point(183, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(146, 78);
            label1.Name = "label1";
            label1.Size = new Size(162, 62);
            label1.TabIndex = 46;
            label1.Text = "LOGIN";
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(tableLayoutPanel1);
            ForeColor = Color.DeepSkyBlue;
            Name = "Login_Form";
            Size = new Size(718, 559);
            tableLayoutPanel1.ResumeLayout(false);
            panel_formLogin.ResumeLayout(false);
            panel_formLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel_formLogin;
        private TextBox txt_password;
        private TextBox txt_Username;
        private Button btn_Login;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Panel panel3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}
