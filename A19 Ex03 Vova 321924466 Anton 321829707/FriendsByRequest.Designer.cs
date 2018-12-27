namespace A19_Ex03_Vova_321924466_Anton_321829707
{
    partial class FriendsByRequest
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
            this.ListBoxOfFriends = new System.Windows.Forms.ListBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.findFriendsButton = new System.Windows.Forms.Button();
            this.singleFriendsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxOfFriends
            // 
            this.ListBoxOfFriends.BackColor = System.Drawing.Color.Gainsboro;
            this.ListBoxOfFriends.FormattingEnabled = true;
            this.ListBoxOfFriends.Location = new System.Drawing.Point(12, 12);
            this.ListBoxOfFriends.Name = "ListBoxOfFriends";
            this.ListBoxOfFriends.Size = new System.Drawing.Size(182, 173);
            this.ListBoxOfFriends.TabIndex = 0;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(12, 191);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(182, 20);
            this.CityTextBox.TabIndex = 1;
            this.CityTextBox.Text = "Type city to see who is there";
            this.CityTextBox.Click += new System.EventHandler(this.CityTextBox_Click);
            // 
            // findFriendsButton
            // 
            this.findFriendsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.findFriendsButton.ForeColor = System.Drawing.Color.White;
            this.findFriendsButton.Location = new System.Drawing.Point(12, 217);
            this.findFriendsButton.Name = "findFriendsButton";
            this.findFriendsButton.Size = new System.Drawing.Size(79, 74);
            this.findFriendsButton.TabIndex = 2;
            this.findFriendsButton.Text = "Friends in the given city";
            this.findFriendsButton.UseVisualStyleBackColor = false;
            this.findFriendsButton.Click += new System.EventHandler(this.findFriendsButton_Click);
            // 
            // singleFriendsButton
            // 
            this.singleFriendsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.singleFriendsButton.ForeColor = System.Drawing.Color.White;
            this.singleFriendsButton.Location = new System.Drawing.Point(115, 217);
            this.singleFriendsButton.Name = "singleFriendsButton";
            this.singleFriendsButton.Size = new System.Drawing.Size(79, 74);
            this.singleFriendsButton.TabIndex = 3;
            this.singleFriendsButton.Text = "Check who is single";
            this.singleFriendsButton.UseVisualStyleBackColor = false;
            this.singleFriendsButton.Click += new System.EventHandler(this.findFriendsFromMyBirthCountry_Click);
            // 
            // FriendsByRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(205, 295);
            this.Controls.Add(this.singleFriendsButton);
            this.Controls.Add(this.findFriendsButton);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.ListBoxOfFriends);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FriendsByRequest";
            this.ShowInTaskbar = false;
            this.Text = "FriendsLocationByLocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxOfFriends;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Button findFriendsButton;
        private System.Windows.Forms.Button singleFriendsButton;
    }
}