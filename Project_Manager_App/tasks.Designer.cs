namespace Project_Manager_App
{
    partial class tasks
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
            panel1 = new Panel();
            label_day = new Label();
            label_hour = new Label();
            label_Title = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label_day);
            panel1.Controls.Add(label_hour);
            panel1.Controls.Add(label_Title);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 95);
            panel1.TabIndex = 2;
            // 
            // label_day
            // 
            label_day.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_day.AutoSize = true;
            label_day.Location = new Point(773, 14);
            label_day.Name = "label_day";
            label_day.Size = new Size(43, 25);
            label_day.TabIndex = 3;
            label_day.Text = "Day";
            // 
            // label_hour
            // 
            label_hour.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_hour.AutoSize = true;
            label_hour.Location = new Point(773, 48);
            label_hour.Name = "label_hour";
            label_hour.Size = new Size(52, 25);
            label_hour.TabIndex = 2;
            label_hour.Text = "Hour";
            // 
            // label_Title
            // 
            label_Title.AutoSize = true;
            label_Title.Cursor = Cursors.Hand;
            label_Title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Title.Location = new Point(47, 29);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(98, 32);
            label_Title.TabIndex = 0;
            label_Title.Text = "Tiêu đề";
            // 
            // tasks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "tasks";
            Size = new Size(955, 95);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_day;
        private Label label_hour;
        private Label label_Title;
    }
}
