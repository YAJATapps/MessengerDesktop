namespace MessengerDesktop
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.menuFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.messageList = new System.Windows.Forms.FlowLayoutPanel();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.contactLabel = new System.Windows.Forms.Label();
            this.chatSendPanel = new System.Windows.Forms.Panel();
            this.sendButton = new System.Windows.Forms.PictureBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.messagePanel.SuspendLayout();
            this.chatSendPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendButton)).BeginInit();
            this.SuspendLayout();
            // 
            // menuFlowPanel
            // 
            this.menuFlowPanel.AutoScroll = true;
            this.menuFlowPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.menuFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.menuFlowPanel.Name = "menuFlowPanel";
            this.menuFlowPanel.Size = new System.Drawing.Size(200, 450);
            this.menuFlowPanel.TabIndex = 0;
            this.menuFlowPanel.WrapContents = false;
            // 
            // messageList
            // 
            this.messageList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageList.AutoScroll = true;
            this.messageList.BackColor = System.Drawing.SystemColors.Window;
            this.messageList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.messageList.Location = new System.Drawing.Point(3, 43);
            this.messageList.Name = "messageList";
            this.messageList.Size = new System.Drawing.Size(594, 364);
            this.messageList.TabIndex = 1;
            this.messageList.WrapContents = false;
            // 
            // messagePanel
            // 
            this.messagePanel.Controls.Add(this.contactLabel);
            this.messagePanel.Controls.Add(this.chatSendPanel);
            this.messagePanel.Controls.Add(this.messageList);
            this.messagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagePanel.Location = new System.Drawing.Point(200, 0);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(600, 450);
            this.messagePanel.TabIndex = 2;
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactLabel.Location = new System.Drawing.Point(0, 0);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(68, 30);
            this.contactLabel.TabIndex = 3;
            this.contactLabel.Text = "label1";
            // 
            // chatSendPanel
            // 
            this.chatSendPanel.Controls.Add(this.sendButton);
            this.chatSendPanel.Controls.Add(this.messageTextBox);
            this.chatSendPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chatSendPanel.Location = new System.Drawing.Point(0, 409);
            this.chatSendPanel.Name = "chatSendPanel";
            this.chatSendPanel.Size = new System.Drawing.Size(600, 41);
            this.chatSendPanel.TabIndex = 2;
            // 
            // sendButton
            // 
            this.sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sendButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.sendButton.Image = ((System.Drawing.Image)(resources.GetObject("sendButton.Image")));
            this.sendButton.Location = new System.Drawing.Point(562, 0);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(38, 41);
            this.sendButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.sendButton.TabIndex = 1;
            this.sendButton.TabStop = false;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageTextBox.Location = new System.Drawing.Point(0, 0);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(551, 35);
            this.messageTextBox.TabIndex = 0;
            this.messageTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageTextBox_KeyDown);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.menuFlowPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatForm";
            this.Text = "Messenger";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.chatSendPanel.ResumeLayout(false);
            this.chatSendPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel menuFlowPanel;
        private FlowLayoutPanel messageList;
        private Panel messagePanel;
        private Label contactLabel;
        private Panel chatSendPanel;
        private PictureBox sendButton;
        private TextBox messageTextBox;
    }
}