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
            panel1 = new Panel();
            display_Name = new Panel();
            avtUser = new PictureBox();
            label1 = new Label();
            listBox1 = new ListBox();
            display_password = new ListBox();
            password_title = new Label();
            btn_change_avt = new Button();
            btn_change_password = new Button();
            btn_Remove_Acc = new Button();
            display_Name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avtUser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 70);
            panel1.TabIndex = 0;
            // 
            // display_Name
            // 
            display_Name.Controls.Add(btn_Remove_Acc);
            display_Name.Controls.Add(btn_change_password);
            display_Name.Controls.Add(btn_change_avt);
            display_Name.Controls.Add(display_password);
            display_Name.Controls.Add(password_title);
            display_Name.Controls.Add(listBox1);
            display_Name.Controls.Add(label1);
            display_Name.Controls.Add(avtUser);
            display_Name.Dock = DockStyle.Fill;
            display_Name.ForeColor = SystemColors.ControlText;
            display_Name.Location = new Point(0, 70);
            display_Name.Name = "display_Name";
            display_Name.Size = new Size(845, 427);
            display_Name.TabIndex = 1;
            // 
            // avtUser
            // 
            avtUser.Image = (Image)resources.GetObject("avtUser.Image");
            avtUser.Location = new Point(354, 8);
            avtUser.Margin = new Padding(50, 5, 50, 3);
            avtUser.Name = "avtUser";
            avtUser.Size = new Size(120, 120);
            avtUser.SizeMode = PictureBoxSizeMode.StretchImage;
            avtUser.TabIndex = 0;
            avtUser.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 152);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 1;
            label1.Text = "Username: ";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Control;
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "No1hiz9" });
            listBox1.Location = new Point(368, 152);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(204, 24);
            listBox1.TabIndex = 2;
            // 
            // display_password
            // 
            display_password.BackColor = SystemColors.Control;
            display_password.FormattingEnabled = true;
            display_password.Items.AddRange(new object[] { "***************" });
            display_password.Location = new Point(368, 200);
            display_password.Name = "display_password";
            display_password.Size = new Size(204, 24);
            display_password.TabIndex = 4;
            // 
            // password_title
            // 
            password_title.AutoSize = true;
            password_title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_title.Location = new Point(254, 196);
            password_title.Name = "password_title";
            password_title.Size = new Size(97, 28);
            password_title.TabIndex = 3;
            password_title.Text = "Password:";
            // 
            // btn_change_avt
            // 
            btn_change_avt.Location = new Point(254, 252);
            btn_change_avt.Name = "btn_change_avt";
            btn_change_avt.Size = new Size(318, 35);
            btn_change_avt.TabIndex = 5;
            btn_change_avt.Text = "Change Avatar";
            btn_change_avt.UseVisualStyleBackColor = true;
            // 
            // btn_change_password
            // 
            btn_change_password.Location = new Point(254, 304);
            btn_change_password.Name = "btn_change_password";
            btn_change_password.Size = new Size(318, 35);
            btn_change_password.TabIndex = 6;
            btn_change_password.Text = "Change Password";
            btn_change_password.UseVisualStyleBackColor = true;
            // 
            // btn_Remove_Acc
            // 
            btn_Remove_Acc.BackColor = Color.IndianRed;
            btn_Remove_Acc.FlatAppearance.BorderSize = 0;
            btn_Remove_Acc.Location = new Point(254, 356);
            btn_Remove_Acc.Name = "btn_Remove_Acc";
            btn_Remove_Acc.Size = new Size(318, 35);
            btn_Remove_Acc.TabIndex = 7;
            btn_Remove_Acc.Text = "Remove Account";
            btn_Remove_Acc.UseVisualStyleBackColor = false;
            // 
            // settingUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(display_Name);
            Controls.Add(panel1);
            Name = "settingUser";
            Size = new Size(845, 497);
            display_Name.ResumeLayout(false);
            display_Name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avtUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel display_Name;
        private PictureBox avtUser;
        private Label label1;
        private ListBox listBox1;
        private ListBox display_password;
        private Label password_title;
        private Button btn_Remove_Acc;
        private Button btn_change_password;
        private Button btn_change_avt;
    }
}
