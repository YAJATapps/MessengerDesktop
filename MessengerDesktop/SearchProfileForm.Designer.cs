namespace MessengerDesktop
{
    partial class SearchProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchProfileForm));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTextBox.Location = new System.Drawing.Point(12, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Search profiles...";
            this.searchTextBox.Size = new System.Drawing.Size(250, 35);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchFlowPanel
            // 
            this.searchFlowPanel.AutoScroll = true;
            this.searchFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.searchFlowPanel.Location = new System.Drawing.Point(12, 53);
            this.searchFlowPanel.Name = "searchFlowPanel";
            this.searchFlowPanel.Size = new System.Drawing.Size(250, 277);
            this.searchFlowPanel.TabIndex = 1;
            this.searchFlowPanel.WrapContents = false;
            // 
            // SearchProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 342);
            this.Controls.Add(this.searchFlowPanel);
            this.Controls.Add(this.searchTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchProfileForm";
            this.Text = "Search Profile";
            this.Load += new System.EventHandler(this.SearchProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox searchTextBox;
        private FlowLayoutPanel searchFlowPanel;
    }
}