namespace MessengerDesktop
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.newAccountLabel = new System.Windows.Forms.Label();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.appLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(3, 3);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.PlaceholderText = "Username";
            this.userTextBox.Size = new System.Drawing.Size(272, 23);
            this.userTextBox.TabIndex = 0;
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.Location = new System.Drawing.Point(3, 32);
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.PlaceholderText = "Password";
            this.pwdTextBox.Size = new System.Drawing.Size(272, 23);
            this.pwdTextBox.TabIndex = 1;
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(3, 167);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(272, 23);
            this.signupButton.TabIndex = 3;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = true;
            // 
            // newAccountLabel
            // 
            this.newAccountLabel.Location = new System.Drawing.Point(3, 139);
            this.newAccountLabel.Name = "newAccountLabel";
            this.newAccountLabel.Size = new System.Drawing.Size(272, 15);
            this.newAccountLabel.TabIndex = 4;
            this.newAccountLabel.Text = "Create a new account";
            this.newAccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividerLabel
            // 
            this.dividerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dividerLabel.Location = new System.Drawing.Point(3, 115);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(272, 2);
            this.dividerLabel.TabIndex = 5;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(3, 75);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(272, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.appLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 70);
            this.panel1.TabIndex = 8;
            // 
            // appLabel
            // 
            this.appLabel.AutoSize = true;
            this.appLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appLabel.Location = new System.Drawing.Point(108, 20);
            this.appLabel.Name = "appLabel";
            this.appLabel.Size = new System.Drawing.Size(114, 30);
            this.appLabel.TabIndex = 1;
            this.appLabel.Text = "Messenger";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.userTextBox);
            this.controlPanel.Controls.Add(this.pwdTextBox);
            this.controlPanel.Controls.Add(this.signupButton);
            this.controlPanel.Controls.Add(this.newAccountLabel);
            this.controlPanel.Controls.Add(this.dividerLabel);
            this.controlPanel.Controls.Add(this.loginButton);
            this.controlPanel.Location = new System.Drawing.Point(12, 113);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(278, 201);
            this.controlPanel.TabIndex = 9;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 326);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox userTextBox;
        private TextBox pwdTextBox;
        private Button signupButton;
        private Label newAccountLabel;
        private Label dividerLabel;
        private Button loginButton;
        private Panel panel1;
        private Label appLabel;
        private PictureBox pictureBox1;
        private Panel controlPanel;
    }
}