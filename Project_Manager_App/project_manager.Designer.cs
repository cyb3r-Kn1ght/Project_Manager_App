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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(project_manager));
            panel_Menu = new Panel();
            button_havetodo = new Button();
            button_member = new Button();
            button_Finished = new Button();
            button_IsDoing = new Button();
            flowTaskList = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label_ProjectName = new Label();
            panel_Menu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_Menu
            // 
            panel_Menu.BackColor = Color.LightSkyBlue;
            panel_Menu.Controls.Add(button_havetodo);
            panel_Menu.Controls.Add(button_member);
            panel_Menu.Controls.Add(button_Finished);
            panel_Menu.Controls.Add(button_IsDoing);
            panel_Menu.Dock = DockStyle.Left;
            panel_Menu.Location = new Point(0, 50);
            panel_Menu.Name = "panel_Menu";
            panel_Menu.Size = new Size(219, 668);
            panel_Menu.TabIndex = 0;
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
            button_havetodo.Click += button_havetodo_Click;
            // 
            // button_member
            // 
            button_member.Cursor = Cursors.Hand;
            button_member.Dock = DockStyle.Bottom;
            button_member.FlatAppearance.BorderSize = 0;
            button_member.FlatStyle = FlatStyle.Flat;
            button_member.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_member.Location = new Point(0, 629);
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
            button_Finished.Click += button_Finished_Click;
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
            button_IsDoing.Click += button_IsDoing_Click;
            // 
            // flowTaskList
            // 
            flowTaskList.BackColor = SystemColors.Control;
            flowTaskList.Dock = DockStyle.Fill;
            flowTaskList.Location = new Point(219, 50);
            flowTaskList.Name = "flowTaskList";
            flowTaskList.Size = new Size(1042, 668);
            flowTaskList.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label_ProjectName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1261, 50);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label_ProjectName
            // 
            label_ProjectName.AutoSize = true;
            label_ProjectName.BackColor = Color.DeepSkyBlue;
            label_ProjectName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ProjectName.Location = new Point(185, 3);
            label_ProjectName.Name = "label_ProjectName";
            label_ProjectName.Size = new Size(72, 38);
            label_ProjectName.TabIndex = 1;
            label_ProjectName.Text = "ABC";
            // 
            // project_manager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            Controls.Add(flowTaskList);
            Controls.Add(panel_Menu);
            Controls.Add(panel1);
            Name = "project_manager";
            Size = new Size(1261, 718);
            panel_Menu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Menu;
        private Button button_Finished;
        private Button button_IsDoing;
        private Button button_havetodo;
        private FlowLayoutPanel flowTaskList;
        private Button button_member;
        private Panel panel1;
        private Label label_ProjectName;
        private PictureBox pictureBox1;
    }
}
