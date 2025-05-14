namespace Project_Manager_App
{
    partial class settingUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingUser));
            display_Name = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            title_btn_back = new Label();
            btn_back = new Button();
            btn_Remove_Acc = new Button();
            btn_detail_User = new Button();
            btn_change_password = new Button();
            btn_change_avt = new Button();
            lb_titleName = new Label();
            password_title = new Label();
            avtUser = new PictureBox();
            lb_username = new Label();
            lb_password = new Label();
            display_Name.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avtUser).BeginInit();
            SuspendLayout();
            // 
            // display_Name
            // 
            display_Name.Controls.Add(tableLayoutPanel1);
            display_Name.Dock = DockStyle.Fill;
            display_Name.ForeColor = SystemColors.ControlText;
            display_Name.Location = new Point(0, 0);
            display_Name.Name = "display_Name";
            display_Name.Size = new Size(845, 497);
            display_Name.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0236969F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.6872063F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.2654037F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0236969F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_Remove_Acc, 1, 7);
            tableLayoutPanel1.Controls.Add(btn_detail_User, 1, 4);
            tableLayoutPanel1.Controls.Add(btn_change_password, 1, 6);
            tableLayoutPanel1.Controls.Add(btn_change_avt, 1, 5);
            tableLayoutPanel1.Controls.Add(lb_titleName, 1, 2);
            tableLayoutPanel1.Controls.Add(password_title, 1, 3);
            tableLayoutPanel1.Controls.Add(avtUser, 1, 1);
            tableLayoutPanel1.Controls.Add(lb_username, 2, 2);
            tableLayoutPanel1.Controls.Add(lb_password, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(845, 497);
            tableLayoutPanel1.TabIndex = 9;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel1
            // 
            tableLayoutPanel1.SetColumnSpan(panel1, 4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(839, 43);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Controls.Add(title_btn_back);
            panel2.Controls.Add(btn_back);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(839, 43);
            panel2.TabIndex = 0;
            // 
            // title_btn_back
            // 
            title_btn_back.Anchor = AnchorStyles.Left;
            title_btn_back.AutoSize = true;
            title_btn_back.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title_btn_back.Location = new Point(81, -3);
            title_btn_back.Name = "title_btn_back";
            title_btn_back.Size = new Size(101, 46);
            title_btn_back.TabIndex = 9;
            title_btn_back.Text = "BACK";
            title_btn_back.TextAlign = ContentAlignment.MiddleLeft;
            title_btn_back.Click += title_btn_back_Click;
            // 
            // btn_back
            // 
            btn_back.Anchor = AnchorStyles.Left;
            btn_back.BackColor = Color.Transparent;
            btn_back.Cursor = Cursors.Hand;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Image = (Image)resources.GetObject("btn_back.Image");
            btn_back.Location = new Point(3, 0);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(121, 43);
            btn_back.TabIndex = 8;
            btn_back.TabStop = false;
            btn_back.Text = "\r\n";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click_1;
            // 
            // btn_Remove_Acc
            // 
            btn_Remove_Acc.BackColor = Color.IndianRed;
            tableLayoutPanel1.SetColumnSpan(btn_Remove_Acc, 2);
            btn_Remove_Acc.Dock = DockStyle.Fill;
            btn_Remove_Acc.FlatAppearance.BorderSize = 0;
            btn_Remove_Acc.Location = new Point(172, 446);
            btn_Remove_Acc.Name = "btn_Remove_Acc";
            btn_Remove_Acc.Size = new Size(500, 48);
            btn_Remove_Acc.TabIndex = 7;
            btn_Remove_Acc.Text = "Remove Account";
            btn_Remove_Acc.UseVisualStyleBackColor = false;
            // 
            // btn_detail_User
            // 
            tableLayoutPanel1.SetColumnSpan(btn_detail_User, 2);
            btn_detail_User.Dock = DockStyle.Fill;
            btn_detail_User.Location = new Point(172, 299);
            btn_detail_User.Name = "btn_detail_User";
            btn_detail_User.Size = new Size(500, 43);
            btn_detail_User.TabIndex = 8;
            btn_detail_User.Text = "Detail";
            btn_detail_User.UseVisualStyleBackColor = true;
            btn_detail_User.Click += btn_detail_User_Click;
            // 
            // btn_change_password
            // 
            tableLayoutPanel1.SetColumnSpan(btn_change_password, 2);
            btn_change_password.Dock = DockStyle.Fill;
            btn_change_password.Location = new Point(172, 397);
            btn_change_password.Name = "btn_change_password";
            btn_change_password.Size = new Size(500, 43);
            btn_change_password.TabIndex = 6;
            btn_change_password.Text = "Change Password";
            btn_change_password.UseVisualStyleBackColor = true;
            btn_change_password.Click += btn_change_password_Click;
            // 
            // btn_change_avt
            // 
            tableLayoutPanel1.SetColumnSpan(btn_change_avt, 2);
            btn_change_avt.Dock = DockStyle.Fill;
            btn_change_avt.Location = new Point(172, 348);
            btn_change_avt.Name = "btn_change_avt";
            btn_change_avt.Size = new Size(500, 43);
            btn_change_avt.TabIndex = 5;
            btn_change_avt.Text = "Change Avatar";
            btn_change_avt.UseVisualStyleBackColor = true;
            // 
            // lb_titleName
            // 
            lb_titleName.AutoSize = true;
            lb_titleName.Dock = DockStyle.Fill;
            lb_titleName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_titleName.Location = new Point(172, 198);
            lb_titleName.Name = "lb_titleName";
            lb_titleName.Size = new Size(253, 49);
            lb_titleName.TabIndex = 1;
            lb_titleName.Text = "Username: ";
            lb_titleName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // password_title
            // 
            password_title.AutoSize = true;
            password_title.Dock = DockStyle.Fill;
            password_title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            password_title.Location = new Point(172, 247);
            password_title.Name = "password_title";
            password_title.Size = new Size(253, 49);
            password_title.TabIndex = 3;
            password_title.Text = "Password:";
            password_title.TextAlign = ContentAlignment.MiddleRight;
            // 
            // avtUser
            // 
            tableLayoutPanel1.SetColumnSpan(avtUser, 2);
            avtUser.Dock = DockStyle.Fill;
            avtUser.Image = (Image)resources.GetObject("avtUser.Image");
            avtUser.Location = new Point(219, 54);
            avtUser.Margin = new Padding(50, 5, 50, 3);
            avtUser.Name = "avtUser";
            avtUser.Size = new Size(406, 141);
            avtUser.SizeMode = PictureBoxSizeMode.Zoom;
            avtUser.TabIndex = 0;
            avtUser.TabStop = false;
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.Dock = DockStyle.Fill;
            lb_username.Location = new Point(431, 198);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(241, 49);
            lb_username.TabIndex = 9;
            lb_username.Text = "User_name";
            lb_username.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Dock = DockStyle.Fill;
            lb_password.Location = new Point(431, 247);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(241, 49);
            lb_password.TabIndex = 10;
            lb_password.Text = "***********";
            lb_password.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // settingUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(display_Name);
            Name = "settingUser";
            Size = new Size(845, 497);
            display_Name.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avtUser).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel display_Name;
        private PictureBox avtUser;
        private Label label1;
        private Label password_title;
        private Button btn_Remove_Acc;
        private Button btn_change_password;
        private Button btn_change_avt;
        private Button btn_detail_User;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label lb_username;
        private Label lb_password;
        private Label lb_titleName;
        private Button btn_back;
        private Label title_btn_back;
    }
}
