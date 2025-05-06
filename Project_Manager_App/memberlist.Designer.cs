namespace Project_Manager_App
{
    partial class memberlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(memberlist));
            panel1 = new Panel();
            label_Memberlist = new Label();
            pictureBox_back = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_back).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(pictureBox_back);
            panel1.Controls.Add(label_Memberlist);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1238, 49);
            panel1.TabIndex = 0;
            // 
            // label_Memberlist
            // 
            label_Memberlist.AutoSize = true;
            label_Memberlist.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Memberlist.Location = new Point(186, 0);
            label_Memberlist.Name = "label_Memberlist";
            label_Memberlist.Size = new Size(162, 38);
            label_Memberlist.TabIndex = 1;
            label_Memberlist.Text = "Thành viên";
            // 
            // pictureBox_back
            // 
            pictureBox_back.Cursor = Cursors.Hand;
            pictureBox_back.Image = (Image)resources.GetObject("pictureBox_back.Image");
            pictureBox_back.Location = new Point(0, 0);
            pictureBox_back.Name = "pictureBox_back";
            pictureBox_back.Size = new Size(138, 49);
            pictureBox_back.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_back.TabIndex = 4;
            pictureBox_back.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 49);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1238, 696);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // memberlist
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "memberlist";
            Size = new Size(1238, 745);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_back).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_Memberlist;
        private PictureBox pictureBox_back;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
