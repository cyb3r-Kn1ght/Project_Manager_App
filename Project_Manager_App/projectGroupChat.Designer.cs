namespace Project_Manager_App
{
    partial class projectGroupChat
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
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                CleanupResources();
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
            label1 = new Label();
            pictureBox_settingButton = new PictureBox();
            pictureBox_backButton = new PictureBox();
            pictureBox_sendButton = new PictureBox();
            pictureBox_attachButton = new PictureBox();
            txt_messageBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            listView1 = new ListView();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_settingButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_backButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_sendButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_attachButton).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox_settingButton);
            panel1.Controls.Add(pictureBox_backButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 54);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(57, 14);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 0;
            label1.Text = "Chat";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox_settingButton
            // 
            pictureBox_settingButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox_settingButton.Image = Properties.Resources.settings_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            pictureBox_settingButton.Location = new Point(862, 5);
            pictureBox_settingButton.Name = "pictureBox_settingButton";
            pictureBox_settingButton.Size = new Size(46, 45);
            pictureBox_settingButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_settingButton.TabIndex = 4;
            pictureBox_settingButton.TabStop = false;
            pictureBox_settingButton.Click += pictureBox_settingButton_Click_1;
            // 
            // pictureBox_backButton
            // 
            pictureBox_backButton.Image = Properties.Resources.arrow_back_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            pictureBox_backButton.Location = new Point(3, 3);
            pictureBox_backButton.Name = "pictureBox_backButton";
            pictureBox_backButton.Size = new Size(48, 48);
            pictureBox_backButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_backButton.TabIndex = 1;
            pictureBox_backButton.TabStop = false;
            pictureBox_backButton.Click += pictureBox_backButton_Click;
            // 
            // pictureBox_sendButton
            // 
            pictureBox_sendButton.Anchor = AnchorStyles.None;
            pictureBox_sendButton.Image = Properties.Resources.send_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            pictureBox_sendButton.Location = new Point(869, 8);
            pictureBox_sendButton.Name = "pictureBox_sendButton";
            pictureBox_sendButton.Size = new Size(55, 47);
            pictureBox_sendButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_sendButton.TabIndex = 3;
            pictureBox_sendButton.TabStop = false;
            // 
            // pictureBox_attachButton
            // 
            pictureBox_attachButton.Anchor = AnchorStyles.None;
            pictureBox_attachButton.Image = Properties.Resources.attachment_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            pictureBox_attachButton.Location = new Point(7, 8);
            pictureBox_attachButton.Name = "pictureBox_attachButton";
            pictureBox_attachButton.Size = new Size(48, 47);
            pictureBox_attachButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_attachButton.TabIndex = 2;
            pictureBox_attachButton.TabStop = false;
            // 
            // txt_messageBox
            // 
            txt_messageBox.Dock = DockStyle.Fill;
            txt_messageBox.Location = new Point(65, 3);
            txt_messageBox.Multiline = true;
            txt_messageBox.Name = "txt_messageBox";
            txt_messageBox.Size = new Size(793, 58);
            txt_messageBox.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.Size = new Size(939, 546);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.653801F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.3462F));
            tableLayoutPanel3.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel3.Controls.Add(listView1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 63);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(933, 410);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(288, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(642, 404);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.WrapContents = false;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(279, 404);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.200929F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.79907F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 71F));
            tableLayoutPanel2.Controls.Add(pictureBox_attachButton, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBox_sendButton, 2, 0);
            tableLayoutPanel2.Controls.Add(txt_messageBox, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 479);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(933, 64);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // projectGroupChat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "projectGroupChat";
            Size = new Size(939, 546);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_settingButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_backButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_sendButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_attachButton).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox_backButton;
        private TextBox txt_messageBox;
        private PictureBox pictureBox_settingButton;
        private PictureBox pictureBox_sendButton;
        private PictureBox pictureBox_attachButton;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private ListView listView1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
