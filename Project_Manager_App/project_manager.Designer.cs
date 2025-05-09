namespace Project_Manager_App
{
    partial class project_manager
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
            panel_Menu = new Panel();
            button_member = new Button();
            button_Finished = new Button();
            button_IsDoing = new Button();
            button_havetodo = new Button();
            label_ProjectName = new Label();
            flowTaskList = new FlowLayoutPanel();
            panel_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Menu
            // 
            panel_Menu.BackColor = Color.DeepSkyBlue;
            panel_Menu.Controls.Add(button_member);
            panel_Menu.Controls.Add(button_Finished);
            panel_Menu.Controls.Add(button_IsDoing);
            panel_Menu.Controls.Add(button_havetodo);
            panel_Menu.Controls.Add(label_ProjectName);
            panel_Menu.Dock = DockStyle.Left;
            panel_Menu.Location = new Point(0, 0);
            panel_Menu.Name = "panel_Menu";
            panel_Menu.Size = new Size(219, 718);
            panel_Menu.TabIndex = 0;
            // 
            // button_member
            // 
            button_member.Cursor = Cursors.Hand;
            button_member.Dock = DockStyle.Bottom;
            button_member.FlatAppearance.BorderSize = 0;
            button_member.FlatStyle = FlatStyle.Flat;
            button_member.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_member.Location = new Point(0, 679);
            button_member.Name = "button_member";
            button_member.Size = new Size(219, 39);
            button_member.TabIndex = 2;
            button_member.Text = "Thành viên";
            button_member.UseVisualStyleBackColor = true;
            // 
            // button_Finished
            // 
            button_Finished.Cursor = Cursors.Hand;
            button_Finished.FlatAppearance.BorderSize = 0;
            button_Finished.FlatStyle = FlatStyle.Flat;
            button_Finished.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Finished.Location = new Point(0, 167);
            button_Finished.Margin = new Padding(0);
            button_Finished.Name = "button_Finished";
            button_Finished.Size = new Size(219, 58);
            button_Finished.TabIndex = 2;
            button_Finished.Text = "Đã hoàn thành";
            button_Finished.UseVisualStyleBackColor = true;
            // 
            // button_IsDoing
            // 
            button_IsDoing.Cursor = Cursors.Hand;
            button_IsDoing.FlatAppearance.BorderSize = 0;
            button_IsDoing.FlatStyle = FlatStyle.Flat;
            button_IsDoing.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_IsDoing.Location = new Point(0, 109);
            button_IsDoing.Margin = new Padding(0);
            button_IsDoing.Name = "button_IsDoing";
            button_IsDoing.Size = new Size(219, 58);
            button_IsDoing.TabIndex = 2;
            button_IsDoing.Text = "Đang thực hiện";
            button_IsDoing.UseVisualStyleBackColor = true;
            // 
            // button_havetodo
            // 
            button_havetodo.Cursor = Cursors.Hand;
            button_havetodo.FlatAppearance.BorderSize = 0;
            button_havetodo.FlatStyle = FlatStyle.Flat;
            button_havetodo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_havetodo.Location = new Point(0, 51);
            button_havetodo.Margin = new Padding(0);
            button_havetodo.Name = "button_havetodo";
            button_havetodo.Size = new Size(219, 58);
            button_havetodo.TabIndex = 1;
            button_havetodo.Text = "Việc cần làm";
            button_havetodo.UseVisualStyleBackColor = true;
            // 
            // label_ProjectName
            // 
            label_ProjectName.AutoSize = true;
            label_ProjectName.BackColor = Color.DeepSkyBlue;
            label_ProjectName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ProjectName.Location = new Point(12, 9);
            label_ProjectName.Name = "label_ProjectName";
            label_ProjectName.Size = new Size(61, 32);
            label_ProjectName.TabIndex = 0;
            label_ProjectName.Text = "ABC";
            // 
            // flowTaskList
            // 
            flowTaskList.BackColor = SystemColors.Control;
            flowTaskList.Dock = DockStyle.Fill;
            flowTaskList.Location = new Point(219, 0);
            flowTaskList.Name = "flowTaskList";
            flowTaskList.Size = new Size(1042, 718);
            flowTaskList.TabIndex = 1;
            // 
            // project_manager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            Controls.Add(flowTaskList);
            Controls.Add(panel_Menu);
            Name = "project_manager";
            Size = new Size(1261, 718);
            panel_Menu.ResumeLayout(false);
            panel_Menu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Menu;
        private Button button_Finished;
        private Button button_IsDoing;
        private Button button_havetodo;
        private Label label_ProjectName;
        private FlowLayoutPanel flowTaskList;
        private Button button_member;
    }
}
