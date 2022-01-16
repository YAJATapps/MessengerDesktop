using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessengerDesktop
{
    public partial class SearchProfileForm : Form
    {

        // The user id
        public string uid { get; set; }

        // The id for clicked profile
        public string clickedProfileId { get; set; }

        // The name for clicked profile
        public string clickedProfileName { get; set; }

        public SearchProfileForm()
        {
            InitializeComponent();
        }

        private void SearchProfileForm_Load(object sender, EventArgs e)
        {
            handleTextChange("");
        }

        async void handleTextChange(string text) {
            // Clear current items
            searchFlowPanel.Controls.Clear();

            HttpClient client = new HttpClient();

            // The url for messenger API
            var apiUrl = System.Environment.GetEnvironmentVariable("APP_API_URL") + "/api/v1/users/find?user=" + text;

            var response = await client.PostAsync(apiUrl, null);

            var responseString = await response.Content.ReadAsStringAsync();

            // The list for contacted users
            List<User> result = JsonConvert.DeserializeObject<List<User>>(responseString);

            var users = new List<string>();

            // Add button for each user
            foreach (var user in result)
            {
                if (users.Contains(user.name) || user.id.Equals(uid))
                    continue;

                Button button = new Button();
                button.Text = user.name;
                button.Tag = user.id;
                button.Width = searchFlowPanel.Width - 24;
                button.Click += new EventHandler(this.clickProfileButton);

                users.Add(user.name);

                searchFlowPanel.Controls.Add(button);
            }
        }


        // Handle when chat contact is clicked
        async void clickProfileButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            clickedProfileId = (string) button.Tag;
            clickedProfileName = (string) button.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Represents a user with name and id
        public class User
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            handleTextChange(textBox.Text);
        }
    }
}
