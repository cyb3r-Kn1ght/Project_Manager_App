using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Project_Manager_App
{
    public partial class projectGroupChat : UserControl
    {
        private string senderName = "User"; // Temporary sender name
        public int selectedProjectId = -1;
        public event Action<int> OnOpenChatSetting;

        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        private bool isConnected = false;
        private int currentChatId = -1;

        public projectGroupChat()
        {
            InitializeComponent();
            listView1.View = View.List;
            LoadProjects();
            pictureBox_sendButton.Click += PictureBox_sendButton_Click;
            pictureBox_attachButton.Click += PictureBox_attachButton_Click;
            pictureBox_backButton.Click += pictureBox_backButton_Click;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            pictureBox_settingButton.Click += pictureBox_settingButton_Click_1;

            // Connect to chat server
            ConnectToServer();
        }

        private void ConnectToServer()
        {
            try
            {
                client = new TcpClient();
                client.Connect("127.0.0.1", 5000);
                stream = client.GetStream();
                isConnected = true;

                // Send username first
                byte[] usernameBytes = Encoding.UTF8.GetBytes(senderName);
                stream.Write(usernameBytes, 0, usernameBytes.Length);

                // Start receiving messages in a separate thread
                receiveThread = new Thread(ReceiveMessages);
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to chat server: " + ex.Message);
            }
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            while (isConnected)
            {
                try
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break; // Server disconnected

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    // Parse message format: "Sender: Message"
                    string[] parts = message.Split(new string[] { ": " }, StringSplitOptions.None);
                    if (parts.Length == 2)
                    {
                        string sender = parts[0];
                        string content = parts[1];
                        AddMessageToUI(DateTime.Now, sender, content);
                        
                        // Save received message to database
                        SaveMessageToDatabase(sender, content);
                    }
                }
                catch (Exception ex)
                {
                    if (isConnected)
                    {
                        MessageBox.Show("Error receiving message: " + ex.Message);
                    }
                    break;
                }
            }
        }

        private void AddMessageToUI(DateTime time, string sender, string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<DateTime, string, string>(AddMessageToUI), time, sender, message);
                return;
            }

            MessageItem messageItem = new MessageItem();
            messageItem.SetMessageData(time, sender, message);
            flowLayoutPanel1.Controls.Add(messageItem);
            flowLayoutPanel1.ScrollControlIntoView(messageItem);
        }

        private void PictureBox_sendButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_messageBox.Text) || !isConnected)
                return;

            try
            {
                byte[] messageBytes = Encoding.UTF8.GetBytes(txt_messageBox.Text);
                stream.Write(messageBytes, 0, messageBytes.Length);
                txt_messageBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending message: " + ex.Message);
            }
        }

        private void PictureBox_attachButton_Click(object sender, EventArgs e)
        {
            // Implement file attachment functionality
        }

        private void pictureBox_backButton_Click(object sender, EventArgs e)
        {
            // Handle navigation back
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                selectedProjectId = (int)item.Tag;
                LoadMessagesByProject(selectedProjectId);
            }
        }

        private void LoadMessagesByProject(int projectId)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=newProjectManagerApp;Trusted_Connection=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // First, get or create ChatId for this project
                    string chatQuery = @"
                        SELECT ChatId FROM Chats WHERE ProjectId = @ProjectId;
                        IF @@ROWCOUNT = 0
                        BEGIN
                            INSERT INTO Chats (ProjectId) VALUES (@ProjectId);
                            SELECT SCOPE_IDENTITY();
                        END";
                    using (SqlCommand cmd = new SqlCommand(chatQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProjectId", projectId);
                        currentChatId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Then load messages
                    string messageQuery = @"
                        SELECT m.MessageTime, u.Username, m.Message
                        FROM Messages m
                        LEFT JOIN Users u ON m.Sender = u.UserId
                        WHERE m.ChatId = @ChatId
                        ORDER BY m.MessageTime";
                    using (SqlCommand cmd = new SqlCommand(messageQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ChatId", currentChatId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            flowLayoutPanel1.Controls.Clear();
                            while (reader.Read())
                            {
                                DateTime time = reader.GetDateTime(0);
                                string sender = reader.IsDBNull(1) ? "Unknown" : reader.GetString(1);
                                string message = reader.GetString(2);
                                AddMessageToUI(time, sender, message);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading messages: " + ex.Message);
            }
        }

        private void SaveMessageToDatabase(string sender, string message)
        {
            if (currentChatId == -1) return;

            string connectionString = "Server=localhost\\SQLEXPRESS;Database=newProjectManagerApp;Trusted_Connection=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO Messages (ChatId, MessageTime, Message, Sender)
                        SELECT @ChatId, @MessageTime, @Message, UserId
                        FROM Users
                        WHERE Username = @Sender";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ChatId", currentChatId);
                        cmd.Parameters.AddWithValue("@MessageTime", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Message", message);
                        cmd.Parameters.AddWithValue("@Sender", sender);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving message to database: " + ex.Message);
            }
        }

        private void LoadProjects()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=newProjectManagerApp;Trusted_Connection=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ProjectId, ProjectName FROM Projects";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            listView1.Items.Clear();
                            while (reader.Read())
                            {
                                int projectId = reader.GetInt32(0);
                                string projectName = reader.GetString(1);

                                ListViewItem item = new ListViewItem(projectName);
                                item.Tag = projectId;
                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading projects: " + ex.Message);
            }
        }

        private void pictureBox_settingButton_Click_1(object sender, EventArgs e)
        {
            if (selectedProjectId > 0 && OnOpenChatSetting != null)
                OnOpenChatSetting(selectedProjectId);
        }

        private void CleanupResources()
        {
            isConnected = false;
            stream?.Close();
            client?.Close();
        }
    }
}
