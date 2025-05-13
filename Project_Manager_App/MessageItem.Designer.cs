namespace Project_Manager_App
{
    partial class MessageItem
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
            lblTime = new Label();
            lblSender = new Label();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(3, 5);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(42, 20);
            lblTime.TabIndex = 0;
            lblTime.Text = "Time";
            // 
            // lblSender
            // 
            lblSender.AutoSize = true;
            lblSender.Location = new Point(100, 5);
            lblSender.Name = "lblSender";
            lblSender.Size = new Size(55, 20);
            lblSender.TabIndex = 1;
            lblSender.Text = "Sender";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(200, 5);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(67, 20);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Message";
            // 
            // MessageItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblMessage);
            Controls.Add(lblSender);
            Controls.Add(lblTime);
            Name = "MessageItem";
            Size = new Size(539, 30);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private Label lblSender;
        private Label lblMessage;
    }
}
