namespace Project_Manager_App
{
    partial class changePassword
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
            Label lb_confirm_password;
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lb_current_password = new Label();
            lb_new_password = new Label();
            btn_confirm = new Button();
            txt_currnet_password = new TextBox();
            txt_new_password = new TextBox();
            txt_confirm_password = new TextBox();
            lb_title_change_pass = new Label();
            lb_confirm_password = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lb_confirm_password
            // 
            lb_confirm_password.AutoSize = true;
            lb_confirm_password.Dock = DockStyle.Fill;
            lb_confirm_password.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_confirm_password.Location = new Point(123, 202);
            lb_confirm_password.Name = "lb_confirm_password";
            lb_confirm_password.Size = new Size(114, 110);
            lb_confirm_password.TabIndex = 3;
            lb_confirm_password.Text = "Confirm password\r\n\r\n";
            lb_confirm_password.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.AppWorkspace;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1016, 517);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(206, 54);
            panel1.Name = "panel1";
            tableLayoutPanel1.SetRowSpan(panel1, 5);
            panel1.Size = new Size(602, 405);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.Control;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(lb_current_password, 1, 1);
            tableLayoutPanel2.Controls.Add(lb_new_password, 1, 2);
            tableLayoutPanel2.Controls.Add(lb_confirm_password, 1, 3);
            tableLayoutPanel2.Controls.Add(btn_confirm, 1, 4);
            tableLayoutPanel2.Controls.Add(txt_currnet_password, 2, 1);
            tableLayoutPanel2.Controls.Add(txt_confirm_password, 2, 3);
            tableLayoutPanel2.Controls.Add(lb_title_change_pass, 0, 0);
            tableLayoutPanel2.Controls.Add(txt_new_password, 2, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.1604939F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3456793F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.37037F));
            tableLayoutPanel2.Size = new Size(602, 405);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lb_current_password
            // 
            lb_current_password.AutoSize = true;
            lb_current_password.Dock = DockStyle.Fill;
            lb_current_password.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_current_password.Location = new Point(123, 40);
            lb_current_password.Name = "lb_current_password";
            lb_current_password.Size = new Size(114, 81);
            lb_current_password.TabIndex = 1;
            lb_current_password.Text = "Current password";
            lb_current_password.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_new_password
            // 
            lb_new_password.AutoSize = true;
            lb_new_password.Dock = DockStyle.Fill;
            lb_new_password.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_new_password.Location = new Point(123, 121);
            lb_new_password.Name = "lb_new_password";
            lb_new_password.Size = new Size(114, 81);
            lb_new_password.TabIndex = 2;
            lb_new_password.Text = "New password";
            lb_new_password.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_confirm
            // 
            tableLayoutPanel2.SetColumnSpan(btn_confirm, 2);
            btn_confirm.Dock = DockStyle.Fill;
            btn_confirm.Location = new Point(123, 315);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(354, 44);
            btn_confirm.TabIndex = 4;
            btn_confirm.Text = "Confirm";
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // txt_currnet_password
            // 
            txt_currnet_password.Anchor = AnchorStyles.Left;
            txt_currnet_password.Location = new Point(243, 67);
            txt_currnet_password.Name = "txt_currnet_password";
            txt_currnet_password.Size = new Size(234, 27);
            txt_currnet_password.TabIndex = 5;
            // 
            // txt_new_password
            // 
            txt_new_password.Anchor = AnchorStyles.Left;
            txt_new_password.Location = new Point(243, 148);
            txt_new_password.Name = "txt_new_password";
            txt_new_password.Size = new Size(234, 27);
            txt_new_password.TabIndex = 6;
            // 
            // txt_confirm_password
            // 
            txt_confirm_password.Anchor = AnchorStyles.Left;
            txt_confirm_password.Location = new Point(243, 243);
            txt_confirm_password.Name = "txt_confirm_password";
            txt_confirm_password.Size = new Size(234, 27);
            txt_confirm_password.TabIndex = 7;
            // 
            // lb_title_change_pass
            // 
            lb_title_change_pass.AutoSize = true;
            lb_title_change_pass.BackColor = Color.DeepSkyBlue;
            tableLayoutPanel2.SetColumnSpan(lb_title_change_pass, 4);
            lb_title_change_pass.Dock = DockStyle.Fill;
            lb_title_change_pass.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_title_change_pass.Location = new Point(3, 0);
            lb_title_change_pass.Name = "lb_title_change_pass";
            lb_title_change_pass.Size = new Size(596, 40);
            lb_title_change_pass.TabIndex = 8;
            lb_title_change_pass.Text = "Change Password";
            lb_title_change_pass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // changePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "changePassword";
            Size = new Size(1016, 517);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lb_current_password;
        private Label lb_new_password;
        private Button btn_confirm;
        private TextBox txt_currnet_password;
        private TextBox txt_new_password;
        private TextBox txt_confirm_password;
        private Label lb_title_change_pass;
    }
}
