﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MessengerDesktop
{
    public partial class ChatForm : Form
    {
        // The user name
        public string username { get; set; }

        // The user id
        public string uid { get; set; }


        // The selected id
        public string tid { get; set; }

        private List<string> profileIdList = new List<string>();

        public static string appUrl = System.Environment.GetEnvironmentVariable("APP_API_URL");

        public ChatForm()
        {
            InitializeComponent();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            loadContacts();
        }

        private async void loadContacts()
        {
            HttpClient client = new HttpClient();

            // The url for messenger API
            var apiUrl = appUrl + "/api/v1/users/id?user=" + username;

            var response = await client.PostAsync(apiUrl, null);

            var responseString = await response.Content.ReadAsStringAsync();

            uid = responseString.Substring(1, responseString.Length - 2);

            loadMenu();
        }

        // Load the menu with search profiles options and contacts
        private async void loadMenu()
        {
            // The button for search profiles above the chats
            Label label = new Label();
            label.Text = "Search profiles";
            label.BackColor = Color.FromArgb(204, 204, 204);
            label.ForeColor = Color.Black;
            label.Height = label.PreferredHeight * 2;
            label.Width = menuFlowPanel.Width - 20;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Margin = new Padding(10, 10, 10, 10);
            label.Click += new EventHandler(this.clickSearchProfile);

            // Add the button to list
            menuFlowPanel.Controls.Add(label);


            HttpClient client = new HttpClient();

            // The url for messenger API
            var apiUrl = appUrl + "/api/v1/users/contacts?user=" + uid;

            var response = await client.PostAsync(apiUrl, null);

            var responseString = await response.Content.ReadAsStringAsync();

            // The list for contacted users
            List<User> result = JsonConvert.DeserializeObject<List<User>>(responseString);

            // Add button for each user
            foreach (var user in result)
            {
                Button button = new Button();
                button.Text = user.name;
                button.Tag = user.id;
                profileIdList.Add(user.id);
                button.Width = menuFlowPanel.Width - 20;
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Margin = new Padding(10, 4, 10, 4);
                button.Click += new EventHandler(this.clickChatButton);

                menuFlowPanel.Controls.Add(button);
            }

            // Add the text informing that no chat is currently selected
            Label noMessagelabel = new Label();
            noMessagelabel.Text = "No message profile selected. Select from the messsages view or send someone a new message.";
            noMessagelabel.Font = new System.Drawing.Font(label.Font.Name, 24F);
            noMessagelabel.MinimumSize = new Size(messageList.Width, label.PreferredHeight);
            noMessagelabel.AutoSize = true;
            noMessagelabel.TextAlign = ContentAlignment.MiddleCenter;
            noMessagelabel.Margin = new Padding(0, 100, 0, 0);
            messageList.Controls.Add(noMessagelabel);
        }

        // Fetch the messages for the currently selected user
        async void loadMessagesIntoPanel()
        {


            // Clear current items
            messageList.Controls.Clear();

            HttpClient client = new HttpClient();

            // The url for messenger API
            var apiUrl = appUrl + "/api/v1/messages/list?frm=" + uid + "&to=" + tid;

            var response = await client.PostAsync(apiUrl, null);

            var responseString = await response.Content.ReadAsStringAsync();


            // The list for messages
            List<Message> result = JsonConvert.DeserializeObject<List<Message>>(responseString);
            foreach (var message in result)
            {
                Label label = new Label();
                label.Text = message.msg;
                // Sent message, aligned right
                if (message.sent.Contains("true"))
                {
                    label.BackColor = Color.Aqua;
                    label.Dock = DockStyle.Right;
                    label.Font = new System.Drawing.Font(label.Font.Name, 16F);
                    label.MinimumSize = new Size((int)(messageList.Width * 0.85), label.PreferredHeight);
                    label.AutoSize = true;
                    label.TextAlign = ContentAlignment.MiddleRight;
                    label.Margin = new Padding(10, 6, 10, 6);
                }
                else
                {
                    label.BackColor = Color.Gray;
                    label.Font = new System.Drawing.Font(label.Font.Name, 16F);
                    label.MinimumSize = new Size((int)(messageList.Width * 0.85), label.PreferredHeight);
                    label.AutoSize = true;
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.Margin = new Padding(10, 6, 10, 6);
                }

                messageList.Controls.Add(label);
            }
        }

        // Handle when chat contact is clicked
        async void clickChatButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            contactLabel.Text = button.Text;
            tid = (string)button.Tag;

            loadMessagesIntoPanel();

            sendButton.Click += new EventHandler(this.clickSendMessage);
        }

        // Handle when search profile label is clicked
        async void clickSearchProfile(object sender, EventArgs e)
        {
            using (var form = new SearchProfileForm())
            {
                form.uid = uid;
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string clickedProfileId = form.clickedProfileId;

                    contactLabel.Text = form.clickedProfileName;
                    tid = clickedProfileId;

                    loadMessagesIntoPanel();

                    sendButton.Click += new EventHandler(this.clickSendMessage);

                    if (!profileIdList.Contains(tid))
                    {
                        Button button = new Button();
                        button.Text = form.clickedProfileName;
                        button.Tag = tid;
                        profileIdList.Add(tid);
                        button.Width = menuFlowPanel.Width - 20;
                        button.TextAlign = ContentAlignment.MiddleCenter;
                        button.Margin = new Padding(10, 4, 10, 4);
                        button.Click += new EventHandler(this.clickChatButton);

                        menuFlowPanel.Controls.Add(button);
                    }

                }
            }
        }

        // Handle when chat contact is clicked
        async void clickSendMessage(object sender, EventArgs e)
        {
            // Content of the message text box
            var newMessage = messageTextBox.Text;
            if (newMessage != null)
            {
                HttpClient client = new HttpClient();

                // The url for messenger API
                var apiUrl = appUrl + "/api/v1/messages/add?frm=" + uid + "&to=" + tid + "&msg=" + newMessage;

                var response = await client.PostAsync(apiUrl, null);

                var responseString = await response.Content.ReadAsStringAsync();

                // Message added
                if (responseString.Contains("addedMessage"))
                {
                    // Set the message text box to empty
                    messageTextBox.Text = "";

                    // Reload the messages
                    loadMessagesIntoPanel();
                }
            }
        }

        // Press enter in the message input box to send message
        private void messageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                clickSendMessage(sender, e);
            }
        }

        // Represents a user with name and id
        public class User
        {
            public string id { get; set; }
            public string name { get; set; }
        }


        // Represents a message with its content (msg) and whether it was sent boolean (or received if false)
        public class Message
        {
            public string msg { get; set; }
            public string sent { get; set; }
        }

    }
}
