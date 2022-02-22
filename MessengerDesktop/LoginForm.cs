namespace MessengerDesktop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            string username = userTextBox.Text;
            string password = pwdTextBox.Text;

            if (username == null || password == null)
                return;

            HttpClient client = new HttpClient();

            // The url for messenger API
            var apiUrl = ChatForm.appUrl + "/api/v1/users/login?user=" + username + "&pwd=" + password;

            var response = await client.PostAsync(apiUrl, null);

            var responseString = await response.Content.ReadAsStringAsync();

            if (responseString.Contains("true"))
            {
                // Open the chat form and close the login form
                ChatForm chatForm = new ChatForm();
                chatForm.username = username;
                this.Hide();
                chatForm.ShowDialog();
                this.Close();
            }
            else
            {
                // Show error message when authentication fails
                MessageBox.Show("Wrong username or password!");
            }

        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = newAccountLabel;
            this.AcceptButton = loginButton;
        }
    }
}