namespace Project_Manager_App
{
    partial class member
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
            label_name = new Label();
            label_role = new Label();
            SuspendLayout();
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_name.Location = new Point(44, 22);
            label_name.Name = "label_name";
            label_name.Size = new Size(124, 32);
            label_name.TabIndex = 0;
            label_name.Text = "Họ và tên";
            // 
            // label_role
            // 
            label_role.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_role.AutoSize = true;
            label_role.Location = new Point(883, 28);
            label_role.Name = "label_role";
            label_role.Size = new Size(63, 25);
            label_role.TabIndex = 1;
            label_role.Text = "Vai trò";
            // 
            // member
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            Controls.Add(label_role);
            Controls.Add(label_name);
            Name = "member";
            Size = new Size(1050, 81);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_name;
        private Label label_role;
    }
}
