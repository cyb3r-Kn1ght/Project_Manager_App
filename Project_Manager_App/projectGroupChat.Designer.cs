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
            label1 = new Label();
            pictureBox_settingButton = new PictureBox();
            pictureBox_backButton = new PictureBox();
            splitContainer1 = new SplitContainer();
            groupList = new ListView();
            Group = new ColumnHeader();
            panel2 = new Panel();
            chatBox = new FlowLayoutPanel();
            panel3 = new Panel();
            pictureBox_sendButton = new PictureBox();
            pictureBox_attachButton = new PictureBox();
            txt_messageBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_settingButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_backButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_sendButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_attachButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox_settingButton);
            panel1.Controls.Add(pictureBox_backButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 53);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(455, 14);
            label1.Name = "label1";
            label1.Size = new Size(357, 25);
            label1.TabIndex = 0;
            label1.Text = "Dự án A";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox_settingButton
            // 
            pictureBox_settingButton.Image = Properties.Resources.settings_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            pictureBox_settingButton.Location = new Point(890, 3);
            pictureBox_settingButton.Name = "pictureBox_settingButton";
            pictureBox_settingButton.Size = new Size(46, 45);
            pictureBox_settingButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_settingButton.TabIndex = 4;
            pictureBox_settingButton.TabStop = false;
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
            // splitContainer1
            // 
            splitContainer1.Location = new Point(3, 59);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupList);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(chatBox);
            splitContainer1.Size = new Size(936, 457);
            splitContainer1.SplitterDistance = 312;
            splitContainer1.TabIndex = 2;
            // 
            // groupList
            // 
            groupList.BorderStyle = BorderStyle.FixedSingle;
            groupList.Columns.AddRange(new ColumnHeader[] { Group });
            groupList.FullRowSelect = true;
            groupList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            groupList.Location = new Point(3, 3);
            groupList.MultiSelect = false;
            groupList.Name = "groupList";
            groupList.Size = new Size(306, 451);
            groupList.TabIndex = 0;
            groupList.UseCompatibleStateImageBehavior = false;
            groupList.View = View.Details;
            // 
            // Group
            // 
            Group.Text = "Group";
            Group.TextAlign = HorizontalAlignment.Center;
            Group.Width = 300;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 463);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 61);
            panel2.TabIndex = 0;
            // 
            // chatBox
            // 
            chatBox.Location = new Point(3, 3);
            chatBox.Name = "chatBox";
            chatBox.Size = new Size(614, 451);
            chatBox.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox_sendButton);
            panel3.Controls.Add(pictureBox_attachButton);
            panel3.Controls.Add(txt_messageBox);
            panel3.Location = new Point(3, 522);
            panel3.Name = "panel3";
            panel3.Size = new Size(936, 95);
            panel3.TabIndex = 3;
            // 
            // pictureBox_sendButton
            // 
            pictureBox_sendButton.Image = Properties.Resources.send_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            pictureBox_sendButton.Location = new Point(853, 26);
            pictureBox_sendButton.Name = "pictureBox_sendButton";
            pictureBox_sendButton.Size = new Size(55, 47);
            pictureBox_sendButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_sendButton.TabIndex = 3;
            pictureBox_sendButton.TabStop = false;
            // 
            // pictureBox_attachButton
            // 
            pictureBox_attachButton.Image = Properties.Resources.attachment_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            pictureBox_attachButton.Location = new Point(17, 26);
            pictureBox_attachButton.Name = "pictureBox_attachButton";
            pictureBox_attachButton.Size = new Size(48, 47);
            pictureBox_attachButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_attachButton.TabIndex = 2;
            pictureBox_attachButton.TabStop = false;
            // 
            // txt_messageBox
            // 
            txt_messageBox.Location = new Point(89, 26);
            txt_messageBox.Multiline = true;
            txt_messageBox.Name = "txt_messageBox";
            txt_messageBox.Size = new Size(736, 47);
            txt_messageBox.TabIndex = 1;
            // 
            // projectGroupChat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "projectGroupChat";
            Size = new Size(939, 620);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_settingButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_backButton).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_sendButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_attachButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox_backButton;
        private SplitContainer splitContainer1;
        private Panel panel2;
        private ListView groupList;
        private Panel panel3;
        private TextBox txt_messageBox;
        private PictureBox pictureBox_settingButton;
        private PictureBox pictureBox_sendButton;
        private PictureBox pictureBox_attachButton;
        private Label label1;
        private FlowLayoutPanel chatBox;
        private ColumnHeader Group;
    }
}
