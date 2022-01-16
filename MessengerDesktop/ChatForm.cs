using System;
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
            var apiUrl = System.Environment.GetEnvironmentVariable("APP_API_URL") + "/api/v1/users/id?user=" + username;

            var response = await client.PostAsync(apiUrl, null);

            var responseString = await response.Content.ReadAsStringAsync();

            uid = responseString.Substring(1, responseString.Length-2);

            loadMenu();
        }

        private async void loadMenu()
        {
            HttpClient client = new HttpClient();

            // The url for messenger API
            var apiUrl = System.Environment.GetEnvironmentVariable("APP_API_URL") + "/api/v1/users/contacts?user=" + uid;
     
            var response = await client.PostAsync(apiUrl, null);

            var responseString = await response.Content.ReadAsStringAsync();

            // The list for contacted users
            List<User> result = JsonConvert.DeserializeObject<List<User>>(responseString);

            // Add button for each user
            foreach (var user in result) {
                Button button = new Button();
                button.Text = user.name;
                button.Tag = user.id;
                button.Width = menuFlowPanel.Width - 24;
                button.Click += new EventHandler(this.clickChatButton);
               
                menuFlowPanel.Controls.Add(button);
            }
        }

        // Handle when chat contact is clicked
        async void clickChatButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            contactLabel.Text = button.Text;
            tid = (string) button.Tag;

            loadMessagesIntoPanel();

            sendButton.Click += new EventHandler(this.sendMessageButton);
        }

        // Fetch the messages for the currently selected user
        async void loadMessagesIntoPanel()
        {
            // Clear current items
            messageList.Controls.Clear();

            HttpClient client = new HttpClient();

            // The url for messenger API
            var apiUrl = System.Environment.GetEnvironmentVariable("APP_API_URL") + "/api/v1/messages/list?frm=" + uid + "&to=" + tid;

            var response = await client.PostAsync(apiUrl, null);

            var responseString = await response.Content.ReadAsStringAsync();


            // The list for messages
            List<Message> result = JsonConvert.DeserializeObject<List<Message>>(responseString);
            foreach (var message in result)
            {
                Label label = new Label();
                label.Text = message.msg;
                if (message.sent.Contains("true"))
                {
                    label.BackColor = Color.Aqua;
                    label.Dock = DockStyle.Right;
                    label.Margin = new Padding(label.Width * 2, 0, 0, 0);
                }
                else
                    label.BackColor = Color.Gray;

                messageList.Controls.Add(label);
            }
        }


        // Handle when chat contact is clicked
        async void sendMessageButton(object sender, EventArgs e)
        {
            var newMessage = messageTextBox.Text;
            if (newMessage != null) {
                HttpClient client = new HttpClient();

                // The url for messenger API
                var apiUrl = System.Environment.GetEnvironmentVariable("APP_API_URL") + "/api/v1/messages/add?frm=" + uid + "&to=" + tid + "&msg=" + newMessage;

                var response = await client.PostAsync(apiUrl, null);

                var responseString = await response.Content.ReadAsStringAsync();

                if (responseString.Contains("addedMessage"))
                {
                    messageTextBox.Text = "";

                    loadMessagesIntoPanel();
                }
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
