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
            this.friendsReligion_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxOfFriends
            // 
            this.ListBoxOfFriends.BackColor = System.Drawing.Color.Gainsboro;
            this.ListBoxOfFriends.FormattingEnabled = true;
            this.ListBoxOfFriends.ItemHeight = 20;
            this.ListBoxOfFriends.Location = new System.Drawing.Point(18, 18);
            this.ListBoxOfFriends.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListBoxOfFriends.Name = "ListBoxOfFriends";
            this.ListBoxOfFriends.Size = new System.Drawing.Size(271, 264);
            this.ListBoxOfFriends.TabIndex = 0;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(18, 294);
            this.CityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(271, 26);
            this.CityTextBox.TabIndex = 1;
            this.CityTextBox.Text = "Type city to see who is there";
            this.CityTextBox.Click += new System.EventHandler(this.CityTextBox_Click);
            // 
            // findFriendsButton
            // 
            this.findFriendsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.findFriendsButton.ForeColor = System.Drawing.Color.White;
            this.findFriendsButton.Location = new System.Drawing.Point(18, 334);
            this.findFriendsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findFriendsButton.Name = "findFriendsButton";
            this.findFriendsButton.Size = new System.Drawing.Size(118, 114);
            this.findFriendsButton.TabIndex = 2;
            this.findFriendsButton.Text = "Friends in the given city";
            this.findFriendsButton.UseVisualStyleBackColor = false;
            this.findFriendsButton.Click += new System.EventHandler(this.findFriendsButton_Click);
            // 
            // singleFriendsButton
            // 
            this.singleFriendsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.singleFriendsButton.ForeColor = System.Drawing.Color.White;
            this.singleFriendsButton.Location = new System.Drawing.Point(172, 334);
            this.singleFriendsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.singleFriendsButton.Name = "singleFriendsButton";
            this.singleFriendsButton.Size = new System.Drawing.Size(118, 114);
            this.singleFriendsButton.TabIndex = 3;
            this.singleFriendsButton.Text = "Check who is single";
            this.singleFriendsButton.UseVisualStyleBackColor = false;
            this.singleFriendsButton.Click += new System.EventHandler(this.findFriendsFromMyBirthCountry_Click);
            // 
            // friendsReligion_Btn
            // 
            this.friendsReligion_Btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.friendsReligion_Btn.ForeColor = System.Drawing.Color.White;
            this.friendsReligion_Btn.Location = new System.Drawing.Point(72, 457);
            this.friendsReligion_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.friendsReligion_Btn.Name = "friendsReligion_Btn";
            this.friendsReligion_Btn.Size = new System.Drawing.Size(158, 58);
            this.friendsReligion_Btn.TabIndex = 4;
            this.friendsReligion_Btn.Text = "See your friends religion";
            this.friendsReligion_Btn.UseVisualStyleBackColor = false;
            this.friendsReligion_Btn.Click += new System.EventHandler(this.friendsReligion_Click);
            // 
            // FriendsByRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(308, 525);
            this.Controls.Add(this.friendsReligion_Btn);
            this.Controls.Add(this.singleFriendsButton);
            this.Controls.Add(this.findFriendsButton);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.ListBoxOfFriends);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button friendsReligion_Btn;
    }
}