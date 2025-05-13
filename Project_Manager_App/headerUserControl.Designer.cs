namespace Project_Manager_App
{
    partial class headerUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(headerUserControl));
            avtUser = new PictureBox();
            Username = new Label();
            roleOfUser = new Label();
            btn_setting = new Button();
            btn_group = new Button();
            btn_add = new Button();
            btn_search = new Button();
            ((System.ComponentModel.ISupportInitialize)avtUser).BeginInit();
            SuspendLayout();
            // 
            // avtUser
            // 
            avtUser.Dock = DockStyle.Left;
            avtUser.Image = Properties.Resources.dhuit;
            avtUser.Location = new Point(0, 0);
            avtUser.Name = "avtUser";
            avtUser.Size = new Size(70, 80);
            avtUser.SizeMode = PictureBoxSizeMode.StretchImage;
            avtUser.TabIndex = 0;
            avtUser.TabStop = false;
            // 
            // Username
            // 
            Username.Anchor = AnchorStyles.Left;
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.Location = new Point(84, 10);
            Username.Name = "Username";
            Username.Size = new Size(106, 28);
            Username.TabIndex = 1;
            Username.Text = "Username";
            Username.Click += Username_Click;
            // 
            // roleOfUser
            // 
            roleOfUser.Anchor = AnchorStyles.Left;
            roleOfUser.AutoSize = true;
            roleOfUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roleOfUser.Location = new Point(84, 38);
            roleOfUser.Name = "roleOfUser";
            roleOfUser.Size = new Size(111, 23);
            roleOfUser.TabIndex = 2;
            roleOfUser.Text = "Role_of_User";
            roleOfUser.Click += label2_Click;
            // 
            // btn_setting
            // 
            btn_setting.Anchor = AnchorStyles.Right;
            btn_setting.BackColor = Color.Transparent;
            btn_setting.Cursor = Cursors.Hand;
            btn_setting.FlatAppearance.BorderSize = 0;
            btn_setting.FlatStyle = FlatStyle.Flat;
            btn_setting.Image = (Image)resources.GetObject("btn_setting.Image");
            btn_setting.Location = new Point(903, 10);
            btn_setting.Name = "btn_setting";
            btn_setting.Size = new Size(73, 60);
            btn_setting.TabIndex = 7;
            btn_setting.TabStop = false;
            btn_setting.Text = "\r\n";
            btn_setting.UseVisualStyleBackColor = false;
            btn_setting.Click += btn_setting_Click;
            // 
            // btn_group
            // 
            btn_group.Anchor = AnchorStyles.Right;
            btn_group.BackColor = Color.Transparent;
            btn_group.Cursor = Cursors.Hand;
            btn_group.FlatAppearance.BorderSize = 0;
            btn_group.FlatStyle = FlatStyle.Flat;
            btn_group.Image = (Image)resources.GetObject("btn_group.Image");
            btn_group.Location = new Point(813, 10);
            btn_group.Name = "btn_group";
            btn_group.Size = new Size(70, 60);
            btn_group.TabIndex = 8;
            btn_group.TabStop = false;
            btn_group.Text = "\r\n";
            btn_group.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            btn_add.Anchor = AnchorStyles.Right;
            btn_add.BackColor = Color.Transparent;
            btn_add.Cursor = Cursors.Hand;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Image = (Image)resources.GetObject("btn_add.Image");
            btn_add.Location = new Point(718, 10);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(73, 60);
            btn_add.TabIndex = 9;
            btn_add.TabStop = false;
            btn_add.Text = "\r\n";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_search
            // 
            btn_search.Anchor = AnchorStyles.Right;
            btn_search.BackColor = Color.Transparent;
            btn_search.Cursor = Cursors.Hand;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Image = (Image)resources.GetObject("btn_search.Image");
            btn_search.Location = new Point(629, 10);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(73, 60);
            btn_search.TabIndex = 10;
            btn_search.TabStop = false;
            btn_search.Text = "\r\n";
            btn_search.UseVisualStyleBackColor = false;
            // 
            // headerUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            Controls.Add(btn_search);
            Controls.Add(btn_add);
            Controls.Add(btn_group);
            Controls.Add(btn_setting);
            Controls.Add(roleOfUser);
            Controls.Add(Username);
            Controls.Add(avtUser);
            Name = "headerUserControl";
            Size = new Size(996, 80);
            ((System.ComponentModel.ISupportInitialize)avtUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox avtUser;
        private Label Username;
        private Label roleOfUser;
        private Button btn_setting;
        private Button btn_group;
        private Button btn_add;
        private Button btn_search;
    }
}
