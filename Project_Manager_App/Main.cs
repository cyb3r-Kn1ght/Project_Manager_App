using System;
using System.Windows.Forms;

namespace Project_Manager_App
{
    public partial class Main : Form
    {
        private projectGroupChat pgc;
        private chatSetting chatSettingUC;

        public Main()
        {
            InitializeComponent();

            pgc = new projectGroupChat();
            pgc.OnOpenChatSetting += OpenChatSetting;

            LoadUserControl(pgc);
        }

        public void LoadUserControl(UserControl uc)
        {
            this.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void OpenChatSetting(int projectId)
        {
            if (chatSettingUC == null)
            {
                chatSettingUC = new chatSetting();
                chatSettingUC.OnBackToChat += () => {
                    this.Controls.Clear();
                    this.Controls.Add(pgc);
                };
            }
            chatSettingUC.LoadGroupInfo(projectId);
            LoadUserControl(chatSettingUC);
        }
    }
}
