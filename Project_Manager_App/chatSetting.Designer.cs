namespace Project_Manager_App
{
    partial class chatSetting
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox_backButton = new PictureBox();
            groupInfo = new GroupBox();
            txt_manager = new TextBox();
            txt_description = new TextBox();
            txt_groupName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupMemberList = new GroupBox();
            memberList = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderRole = new ColumnHeader();
            panel4 = new Panel();
            btn_addMember = new Button();
            panel5 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button2 = new Button();
            groupBox3 = new GroupBox();
            rdbtn_onlyMentions = new RadioButton();
            rdbtn_muteAll = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_backButton).BeginInit();
            groupInfo.SuspendLayout();
            groupMemberList.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox_backButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1291, 44);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(65, 13);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 1;
            label1.Text = "Chat setting";
            // 
            // pictureBox_backButton
            // 
            pictureBox_backButton.Image = Properties.Resources.arrow_back_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            pictureBox_backButton.Location = new Point(3, 3);
            pictureBox_backButton.Name = "pictureBox_backButton";
            pictureBox_backButton.Size = new Size(56, 37);
            pictureBox_backButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_backButton.TabIndex = 1;
            pictureBox_backButton.TabStop = false;
            // 
            // groupInfo
            // 
            groupInfo.Controls.Add(txt_manager);
            groupInfo.Controls.Add(txt_description);
            groupInfo.Controls.Add(txt_groupName);
            groupInfo.Controls.Add(label4);
            groupInfo.Controls.Add(label3);
            groupInfo.Controls.Add(label2);
            groupInfo.Dock = DockStyle.Fill;
            groupInfo.Location = new Point(3, 53);
            groupInfo.Name = "groupInfo";
            groupInfo.Size = new Size(1291, 124);
            groupInfo.TabIndex = 0;
            groupInfo.TabStop = false;
            groupInfo.Text = "Group Info";
            // 
            // txt_manager
            // 
            txt_manager.Location = new Point(126, 86);
            txt_manager.Name = "txt_manager";
            txt_manager.ReadOnly = true;
            txt_manager.Size = new Size(688, 27);
            txt_manager.TabIndex = 5;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(126, 53);
            txt_description.Name = "txt_description";
            txt_description.ReadOnly = true;
            txt_description.Size = new Size(688, 27);
            txt_description.TabIndex = 4;
            // 
            // txt_groupName
            // 
            txt_groupName.Location = new Point(126, 20);
            txt_groupName.Name = "txt_groupName";
            txt_groupName.ReadOnly = true;
            txt_groupName.Size = new Size(688, 27);
            txt_groupName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 85);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 2;
            label4.Text = "Manager: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 52);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 1;
            label3.Text = "Description: ";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 23);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 0;
            label2.Text = "Group name: ";
            // 
            // groupMemberList
            // 
            groupMemberList.Controls.Add(memberList);
            groupMemberList.Controls.Add(panel4);
            groupMemberList.Dock = DockStyle.Fill;
            groupMemberList.Location = new Point(3, 183);
            groupMemberList.Name = "groupMemberList";
            groupMemberList.Size = new Size(1291, 176);
            groupMemberList.TabIndex = 0;
            groupMemberList.TabStop = false;
            groupMemberList.Text = "Group member";
            // 
            // memberList
            // 
            memberList.BorderStyle = BorderStyle.FixedSingle;
            memberList.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderRole });
            memberList.Dock = DockStyle.Fill;
            memberList.FullRowSelect = true;
            memberList.GridLines = true;
            memberList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            memberList.Location = new Point(3, 23);
            memberList.MultiSelect = false;
            memberList.Name = "memberList";
            memberList.Size = new Size(1285, 150);
            memberList.TabIndex = 0;
            memberList.UseCompatibleStateImageBehavior = false;
            memberList.View = View.Details;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 200;
            // 
            // columnHeaderRole
            // 
            columnHeaderRole.Text = "Role";
            columnHeaderRole.Width = 1400;
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 262);
            panel4.Name = "panel4";
            panel4.Size = new Size(838, 93);
            panel4.TabIndex = 3;
            // 
            // btn_addMember
            // 
            btn_addMember.Dock = DockStyle.Left;
            btn_addMember.Location = new Point(3, 365);
            btn_addMember.Name = "btn_addMember";
            btn_addMember.Size = new Size(176, 44);
            btn_addMember.TabIndex = 1;
            btn_addMember.Text = "Add member";
            btn_addMember.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Location = new Point(3, 433);
            panel5.Name = "panel5";
            panel5.Size = new Size(838, 43);
            panel5.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button2, 0, 5);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 4);
            tableLayoutPanel1.Controls.Add(btn_addMember, 0, 3);
            tableLayoutPanel1.Controls.Add(groupInfo, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupMemberList, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 103F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.Size = new Size(1297, 561);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.Location = new Point(3, 518);
            button2.Name = "button2";
            button2.Size = new Size(182, 40);
            button2.TabIndex = 7;
            button2.Text = "Leave";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdbtn_onlyMentions);
            groupBox3.Controls.Add(rdbtn_muteAll);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 415);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1291, 97);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Notifications";
            // 
            // rdbtn_onlyMentions
            // 
            rdbtn_onlyMentions.AutoSize = true;
            rdbtn_onlyMentions.Location = new Point(16, 56);
            rdbtn_onlyMentions.Name = "rdbtn_onlyMentions";
            rdbtn_onlyMentions.Size = new Size(139, 24);
            rdbtn_onlyMentions.TabIndex = 1;
            rdbtn_onlyMentions.TabStop = true;
            rdbtn_onlyMentions.Text = "Only @mentions";
            rdbtn_onlyMentions.UseVisualStyleBackColor = true;
            // 
            // rdbtn_muteAll
            // 
            rdbtn_muteAll.AutoSize = true;
            rdbtn_muteAll.Location = new Point(16, 26);
            rdbtn_muteAll.Name = "rdbtn_muteAll";
            rdbtn_muteAll.Size = new Size(170, 24);
            rdbtn_muteAll.TabIndex = 0;
            rdbtn_muteAll.TabStop = true;
            rdbtn_muteAll.Text = "Mute all notifications";
            rdbtn_muteAll.UseVisualStyleBackColor = true;
            // 
            // chatSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel5);
            Name = "chatSetting";
            Size = new Size(1297, 561);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_backButton).EndInit();
            groupInfo.ResumeLayout(false);
            groupInfo.PerformLayout();
            groupMemberList.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox_backButton;
        private Label label1;
        private GroupBox groupInfo;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_groupName;
        private TextBox txt_manager;
        private TextBox txt_description;
        private GroupBox groupMemberList;
        private Button btn_addMember;
        private ListView memberList;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderRole;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox3;
        private RadioButton rdbtn_onlyMentions;
        private RadioButton rdbtn_muteAll;
        private Button button2;
    }
}
