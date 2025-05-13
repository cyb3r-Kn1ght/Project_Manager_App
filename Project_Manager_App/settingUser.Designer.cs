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
            btn_back = new Button();
            btn_Remove_Acc = new Button();
            btn_detail_User = new Button();
            btn_change_password = new Button();
            btn_change_avt = new Button();
            label1 = new Label();
            ltb_Username = new ListBox();
            password_title = new Label();
            ltb_password = new ListBox();
            avtUser = new PictureBox();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.5917168F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.28994F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_Remove_Acc, 1, 7);
            tableLayoutPanel1.Controls.Add(btn_detail_User, 1, 4);
            tableLayoutPanel1.Controls.Add(btn_change_password, 1, 6);
            tableLayoutPanel1.Controls.Add(btn_change_avt, 1, 5);
            tableLayoutPanel1.Controls.Add(label1, 1, 2);
            tableLayoutPanel1.Controls.Add(ltb_Username, 2, 2);
            tableLayoutPanel1.Controls.Add(password_title, 1, 3);
            tableLayoutPanel1.Controls.Add(ltb_password, 2, 3);
            tableLayoutPanel1.Controls.Add(avtUser, 1, 1);
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
            panel2.Controls.Add(btn_back);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(839, 43);
            panel2.TabIndex = 0;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Transparent;
            btn_back.Cursor = Cursors.Hand;
            btn_back.Image = (Image)resources.GetObject("btn_back.Image");
            btn_back.Location = new Point(3, 3);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(125, 37);
            btn_back.TabIndex = 0;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 198);
            label1.Name = "label1";
            label1.Size = new Size(168, 49);
            label1.TabIndex = 1;
            label1.Text = "Username: ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ltb_Username
            // 
            ltb_Username.BackColor = SystemColors.Control;
            ltb_Username.Dock = DockStyle.Fill;
            ltb_Username.FormattingEnabled = true;
            ltb_Username.Items.AddRange(new object[] { "No1hiz9" });
            ltb_Username.Location = new Point(346, 201);
            ltb_Username.Name = "ltb_Username";
            ltb_Username.Size = new Size(326, 43);
            ltb_Username.TabIndex = 2;
            ltb_Username.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // password_title
            // 
            password_title.AutoSize = true;
            password_title.Dock = DockStyle.Fill;
            password_title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            password_title.Location = new Point(172, 247);
            password_title.Name = "password_title";
            password_title.Size = new Size(168, 49);
            password_title.TabIndex = 3;
            password_title.Text = "Password:";
            password_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ltb_password
            // 
            ltb_password.BackColor = SystemColors.Control;
            ltb_password.Dock = DockStyle.Fill;
            ltb_password.FormattingEnabled = true;
            ltb_password.Items.AddRange(new object[] { "***************" });
            ltb_password.Location = new Point(346, 250);
            ltb_password.Name = "ltb_password";
            ltb_password.Size = new Size(326, 43);
            ltb_password.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)avtUser).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel display_Name;
        private PictureBox avtUser;
        private Label label1;
        private ListBox ltb_Username;
        private ListBox ltb_password;
        private Label password_title;
        private Button btn_Remove_Acc;
        private Button btn_change_password;
        private Button btn_change_avt;
        private Button btn_detail_User;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Button btn_back;
    }
}
