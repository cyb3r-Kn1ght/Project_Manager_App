using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Manager_App
{
    public partial class MessageItem : UserControl
    {
        public MessageItem()
        {
            InitializeComponent();
        }

        public void SetMessageData(DateTime time, string sender, string message)
        {
            lblTime.Text = time.ToString("HH:mm:ss");
            lblSender.Text = sender;
            lblMessage.Text = message;
        }
    }
}
