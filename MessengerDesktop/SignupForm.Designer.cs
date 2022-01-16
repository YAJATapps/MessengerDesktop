namespace MessengerDesktop
{
    partial class SignupForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(15, 17);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.PlaceholderText = "Username";
            this.userTextBox.Size = new System.Drawing.Size(272, 23);
            this.userTextBox.TabIndex = 2;
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.Location = new System.Drawing.Point(15, 46);
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.PlaceholderText = "Password";
            this.pwdTextBox.Size = new System.Drawing.Size(272, 23);
            this.pwdTextBox.TabIndex = 3;
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(15, 89);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(272, 23);
            this.signupButton.TabIndex = 4;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 126);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.pwdTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignupForm";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox userTextBox;
        private TextBox pwdTextBox;
        private Button signupButton;
    }
}