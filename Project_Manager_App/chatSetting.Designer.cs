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
            panel2 = new Panel();
            groupInfo = new GroupBox();
            txt_manager = new TextBox();
            txt_description = new TextBox();
            txt_groupName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            groupMemberList = new GroupBox();
            btn_addMember = new Button();
            memberList = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderRole = new ColumnHeader();
            panel4 = new Panel();
            groupBox3 = new GroupBox();
            rdbtn_onlyMentions = new RadioButton();
            rdbtn_muteAll = new RadioButton();
            panel5 = new Panel();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_backButton).BeginInit();
            panel2.SuspendLayout();
            groupInfo.SuspendLayout();
            panel3.SuspendLayout();
            groupMemberList.SuspendLayout();
            panel4.SuspendLayout();
            groupBox3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox_backButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 53);
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
            pictureBox_backButton.Size = new Size(56, 47);
            pictureBox_backButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_backButton.TabIndex = 1;
            pictureBox_backButton.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupInfo);
            panel2.Location = new Point(3, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(838, 125);
            panel2.TabIndex = 1;
            // 
            // groupInfo
            // 
            groupInfo.Controls.Add(txt_manager);
            groupInfo.Controls.Add(txt_description);
            groupInfo.Controls.Add(txt_groupName);
            groupInfo.Controls.Add(label4);
            groupInfo.Controls.Add(label3);
            groupInfo.Controls.Add(label2);
            groupInfo.Location = new Point(3, 3);
            groupInfo.Name = "groupInfo";
            groupInfo.Size = new Size(835, 119);
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
            // panel3
            // 
            panel3.Controls.Add(groupMemberList);
            panel3.Location = new Point(3, 187);
            panel3.Name = "panel3";
            panel3.Size = new Size(838, 240);
            panel3.TabIndex = 2;
            // 
            // groupMemberList
            // 
            groupMemberList.Controls.Add(btn_addMember);
            groupMemberList.Controls.Add(memberList);
            groupMemberList.Location = new Point(3, 3);
            groupMemberList.Name = "groupMemberList";
            groupMemberList.Size = new Size(832, 256);
            groupMemberList.TabIndex = 0;
            groupMemberList.TabStop = false;
            groupMemberList.Text = "Group member";
            // 
            // button1
            // 
            btn_addMember.Location = new Point(3, 208);
            btn_addMember.Name = "btn_addMember";
            btn_addMember.Size = new Size(176, 29);
            btn_addMember.TabIndex = 1;
            btn_addMember.Text = "Add member";
            btn_addMember.UseVisualStyleBackColor = true;
            // 
            // memberList
            // 
            memberList.BorderStyle = BorderStyle.FixedSingle;
            memberList.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderRole });
            memberList.FullRowSelect = true;
            memberList.GridLines = true;
            memberList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            memberList.Location = new Point(6, 26);
            memberList.MultiSelect = false;
            memberList.Name = "memberList";
            memberList.Size = new Size(820, 168);
            memberList.TabIndex = 0;
            memberList.UseCompatibleStateImageBehavior = false;
            memberList.View = View.Details;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 100;
            // 
            // columnHeaderRole
            // 
            columnHeaderRole.Text = "Role";
            columnHeaderRole.Width = 200;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox3);
            panel4.Location = new Point(3, 452);
            panel4.Name = "panel4";
            panel4.Size = new Size(838, 93);
            panel4.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdbtn_onlyMentions);
            groupBox3.Controls.Add(rdbtn_muteAll);
            groupBox3.Location = new Point(6, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(826, 90);
            groupBox3.TabIndex = 0;
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
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Location = new Point(0, 551);
            panel5.Name = "panel5";
            panel5.Size = new Size(838, 43);
            panel5.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(6, 11);
            button2.Name = "button2";
            button2.Size = new Size(182, 29);
            button2.TabIndex = 0;
            button2.Text = "Leave";
            button2.UseVisualStyleBackColor = true;
            // 
            // chatSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "chatSetting";
            Size = new Size(844, 597);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_backButton).EndInit();
            panel2.ResumeLayout(false);
            groupInfo.ResumeLayout(false);
            groupInfo.PerformLayout();
            panel3.ResumeLayout(false);
            groupMemberList.ResumeLayout(false);
            panel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox_backButton;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
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
        private GroupBox groupBox3;
        private RadioButton rdbtn_onlyMentions;
        private RadioButton rdbtn_muteAll;
        private Button button2;
    }
}
