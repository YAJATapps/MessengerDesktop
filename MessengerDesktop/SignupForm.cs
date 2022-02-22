using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace MessengerDesktop
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private async void signupButton_Click(object sender, EventArgs e)
        {
            string username = userTextBox.Text;
            string password = pwdTextBox.Text;

            if (username == null || password == null)
                return;

            HttpClient client = new HttpClient();

            // The url for messenger API
            var apiUrl = ChatForm.appUrl + "/api/v1/users/add?user=" + username + "&pwd=" + password;

            var response = await client.PostAsync(apiUrl, null);

            var responseString = await response.Content.ReadAsStringAsync();

            if (responseString.Contains("addedUser")) {
                MessageBox.Show("Added user");
            }
            else if (responseString.Contains("alreadyExists"))
            {
                MessageBox.Show("User already exists");
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

            this.Close();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = signupButton;
            this.AcceptButton = signupButton;
        }
    }
}
