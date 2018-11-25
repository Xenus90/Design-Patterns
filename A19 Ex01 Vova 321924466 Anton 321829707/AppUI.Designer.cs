namespace A19_Ex01_Vova_321924466_Anton_321829707
{
    partial class AppUI
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
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxUserEmail = new System.Windows.Forms.TextBox();
            this.groupBoxUserInfo = new System.Windows.Forms.GroupBox();
            this.textBoxUserHometown = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonUserDoPost = new System.Windows.Forms.Button();
            this.textBoxUserPost = new System.Windows.Forms.TextBox();
            this.groupBoxPostArea = new System.Windows.Forms.GroupBox();
            this.groupBoxUserFriends = new System.Windows.Forms.GroupBox();
            this.buttonUserFriendFindBy = new System.Windows.Forms.Button();
            this.buttonUserFriendsFind = new System.Windows.Forms.Button();
            this.listBoxUserFriends = new System.Windows.Forms.ListBox();
            this.pictureBoxUserFriend = new System.Windows.Forms.PictureBox();
            this.buttonGetFriendsLikedPages = new System.Windows.Forms.Button();
            this.groupBoxFriendsLikedPages = new System.Windows.Forms.GroupBox();
            this.textBoxLikedPageURL = new System.Windows.Forms.TextBox();
            this.groupBoxFriendsLikedPagesWithPictures = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.groupBoxUserInfo.SuspendLayout();
            this.groupBoxPostArea.SuspendLayout();
            this.groupBoxUserFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserFriend)).BeginInit();
            this.groupBoxFriendsLikedPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogIn.BackColor = System.Drawing.Color.Green;
            this.buttonLogIn.ForeColor = System.Drawing.Color.White;
            this.buttonLogIn.Location = new System.Drawing.Point(550, 516);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(58, 33);
            this.buttonLogIn.TabIndex = 0;
            this.buttonLogIn.Text = "Login";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUser.Location = new System.Drawing.Point(15, 19);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(209, 202);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 1;
            this.pictureBoxUser.TabStop = false;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogOut.BackColor = System.Drawing.Color.Red;
            this.buttonLogOut.ForeColor = System.Drawing.Color.White;
            this.buttonLogOut.Location = new System.Drawing.Point(614, 516);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(58, 33);
            this.buttonLogOut.TabIndex = 2;
            this.buttonLogOut.Text = "Logout";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(15, 234);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.ReadOnly = true;
            this.textBoxUserName.Size = new System.Drawing.Size(163, 20);
            this.textBoxUserName.TabIndex = 3;
            this.textBoxUserName.Text = "User name";
            // 
            // textBoxUserEmail
            // 
            this.textBoxUserEmail.Location = new System.Drawing.Point(15, 260);
            this.textBoxUserEmail.Name = "textBoxUserEmail";
            this.textBoxUserEmail.ReadOnly = true;
            this.textBoxUserEmail.Size = new System.Drawing.Size(163, 20);
            this.textBoxUserEmail.TabIndex = 5;
            this.textBoxUserEmail.Text = "Email";
            // 
            // groupBoxUserInfo
            // 
            this.groupBoxUserInfo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBoxUserInfo.Controls.Add(this.textBoxUserHometown);
            this.groupBoxUserInfo.Controls.Add(this.pictureBoxUser);
            this.groupBoxUserInfo.Controls.Add(this.textBoxUserEmail);
            this.groupBoxUserInfo.Controls.Add(this.textBoxUserName);
            this.groupBoxUserInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUserInfo.Name = "groupBoxUserInfo";
            this.groupBoxUserInfo.Size = new System.Drawing.Size(239, 326);
            this.groupBoxUserInfo.TabIndex = 6;
            this.groupBoxUserInfo.TabStop = false;
            this.groupBoxUserInfo.Text = "User Info";
            // 
            // textBoxUserHometown
            // 
            this.textBoxUserHometown.Location = new System.Drawing.Point(15, 286);
            this.textBoxUserHometown.Name = "textBoxUserHometown";
            this.textBoxUserHometown.ReadOnly = true;
            this.textBoxUserHometown.Size = new System.Drawing.Size(163, 20);
            this.textBoxUserHometown.TabIndex = 6;
            this.textBoxUserHometown.Text = "Hometown";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.BackColor = System.Drawing.Color.IndianRed;
            this.richTextBox1.Location = new System.Drawing.Point(12, 507);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(239, 42);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "Note: This application have created settings file at \"C:\\FacebookApp\".";
            // 
            // buttonUserDoPost
            // 
            this.buttonUserDoPost.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonUserDoPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserDoPost.ForeColor = System.Drawing.Color.White;
            this.buttonUserDoPost.Location = new System.Drawing.Point(184, 103);
            this.buttonUserDoPost.Name = "buttonUserDoPost";
            this.buttonUserDoPost.Size = new System.Drawing.Size(49, 48);
            this.buttonUserDoPost.TabIndex = 8;
            this.buttonUserDoPost.Text = "Post it!";
            this.buttonUserDoPost.UseVisualStyleBackColor = false;
            this.buttonUserDoPost.Click += new System.EventHandler(this.buttonUserDoPost_Click);
            // 
            // textBoxUserPost
            // 
            this.textBoxUserPost.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxUserPost.Location = new System.Drawing.Point(6, 19);
            this.textBoxUserPost.Multiline = true;
            this.textBoxUserPost.Name = "textBoxUserPost";
            this.textBoxUserPost.Size = new System.Drawing.Size(172, 132);
            this.textBoxUserPost.TabIndex = 9;
            this.textBoxUserPost.Text = "Have some thoughts?";
            this.textBoxUserPost.Click += new System.EventHandler(this.textBoxUserPost_Click);
            // 
            // groupBoxPostArea
            // 
            this.groupBoxPostArea.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBoxPostArea.Controls.Add(this.buttonUserDoPost);
            this.groupBoxPostArea.Controls.Add(this.textBoxUserPost);
            this.groupBoxPostArea.Location = new System.Drawing.Point(12, 344);
            this.groupBoxPostArea.Name = "groupBoxPostArea";
            this.groupBoxPostArea.Size = new System.Drawing.Size(239, 157);
            this.groupBoxPostArea.TabIndex = 10;
            this.groupBoxPostArea.TabStop = false;
            this.groupBoxPostArea.Text = "Post Area";
            // 
            // groupBoxUserFriends
            // 
            this.groupBoxUserFriends.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBoxUserFriends.Controls.Add(this.buttonUserFriendFindBy);
            this.groupBoxUserFriends.Controls.Add(this.buttonUserFriendsFind);
            this.groupBoxUserFriends.Controls.Add(this.listBoxUserFriends);
            this.groupBoxUserFriends.Location = new System.Drawing.Point(257, 12);
            this.groupBoxUserFriends.Name = "groupBoxUserFriends";
            this.groupBoxUserFriends.Size = new System.Drawing.Size(200, 326);
            this.groupBoxUserFriends.TabIndex = 11;
            this.groupBoxUserFriends.TabStop = false;
            this.groupBoxUserFriends.Text = "User Friends";
            // 
            // buttonUserFriendFindBy
            // 
            this.buttonUserFriendFindBy.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonUserFriendFindBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserFriendFindBy.ForeColor = System.Drawing.Color.White;
            this.buttonUserFriendFindBy.Location = new System.Drawing.Point(112, 272);
            this.buttonUserFriendFindBy.Name = "buttonUserFriendFindBy";
            this.buttonUserFriendFindBy.Size = new System.Drawing.Size(82, 48);
            this.buttonUserFriendFindBy.TabIndex = 11;
            this.buttonUserFriendFindBy.Text = "Find friend by...";
            this.buttonUserFriendFindBy.UseVisualStyleBackColor = false;
            this.buttonUserFriendFindBy.Click += new System.EventHandler(this.buttonUserFriendFindBy_Click);
            // 
            // buttonUserFriendsFind
            // 
            this.buttonUserFriendsFind.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonUserFriendsFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserFriendsFind.ForeColor = System.Drawing.Color.White;
            this.buttonUserFriendsFind.Location = new System.Drawing.Point(112, 220);
            this.buttonUserFriendsFind.Name = "buttonUserFriendsFind";
            this.buttonUserFriendsFind.Size = new System.Drawing.Size(82, 48);
            this.buttonUserFriendsFind.TabIndex = 10;
            this.buttonUserFriendsFind.Text = "See my friends!";
            this.buttonUserFriendsFind.UseVisualStyleBackColor = false;
            this.buttonUserFriendsFind.Click += new System.EventHandler(this.buttonUserFriendsFind_Click);
            // 
            // listBoxUserFriends
            // 
            this.listBoxUserFriends.BackColor = System.Drawing.Color.Gainsboro;
            this.listBoxUserFriends.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxUserFriends.FormattingEnabled = true;
            this.listBoxUserFriends.Location = new System.Drawing.Point(6, 19);
            this.listBoxUserFriends.Name = "listBoxUserFriends";
            this.listBoxUserFriends.Size = new System.Drawing.Size(188, 195);
            this.listBoxUserFriends.Sorted = true;
            this.listBoxUserFriends.TabIndex = 0;
            this.listBoxUserFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxUserFriends_SelectedIndexChanged);
            // 
            // pictureBoxUserFriend
            // 
            this.pictureBoxUserFriend.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBoxUserFriend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUserFriend.Location = new System.Drawing.Point(263, 232);
            this.pictureBoxUserFriend.Name = "pictureBoxUserFriend";
            this.pictureBoxUserFriend.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxUserFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserFriend.TabIndex = 7;
            this.pictureBoxUserFriend.TabStop = false;
            // 
            // buttonGetFriendsLikedPages
            // 
            this.buttonGetFriendsLikedPages.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonGetFriendsLikedPages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetFriendsLikedPages.ForeColor = System.Drawing.Color.White;
            this.buttonGetFriendsLikedPages.Location = new System.Drawing.Point(6, 19);
            this.buttonGetFriendsLikedPages.Name = "buttonGetFriendsLikedPages";
            this.buttonGetFriendsLikedPages.Size = new System.Drawing.Size(188, 31);
            this.buttonGetFriendsLikedPages.TabIndex = 10;
            this.buttonGetFriendsLikedPages.Text = "Get friend\'s random liked pages!";
            this.buttonGetFriendsLikedPages.UseVisualStyleBackColor = false;
            this.buttonGetFriendsLikedPages.Click += new System.EventHandler(this.buttonGetFriendsLikedPages_Click);
            // 
            // groupBoxFriendsLikedPages
            // 
            this.groupBoxFriendsLikedPages.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBoxFriendsLikedPages.Controls.Add(this.textBoxLikedPageURL);
            this.groupBoxFriendsLikedPages.Controls.Add(this.groupBoxFriendsLikedPagesWithPictures);
            this.groupBoxFriendsLikedPages.Controls.Add(this.buttonGetFriendsLikedPages);
            this.groupBoxFriendsLikedPages.Location = new System.Drawing.Point(463, 12);
            this.groupBoxFriendsLikedPages.Name = "groupBoxFriendsLikedPages";
            this.groupBoxFriendsLikedPages.Size = new System.Drawing.Size(200, 326);
            this.groupBoxFriendsLikedPages.TabIndex = 12;
            this.groupBoxFriendsLikedPages.TabStop = false;
            this.groupBoxFriendsLikedPages.Text = "Friend\'s Liked Pages";
            // 
            // textBoxLikedPageURL
            // 
            this.textBoxLikedPageURL.Location = new System.Drawing.Point(6, 300);
            this.textBoxLikedPageURL.Name = "textBoxLikedPageURL";
            this.textBoxLikedPageURL.ReadOnly = true;
            this.textBoxLikedPageURL.Size = new System.Drawing.Size(188, 20);
            this.textBoxLikedPageURL.TabIndex = 12;
            // 
            // groupBoxFriendsLikedPagesWithPictures
            // 
            this.groupBoxFriendsLikedPagesWithPictures.Location = new System.Drawing.Point(9, 56);
            this.groupBoxFriendsLikedPagesWithPictures.Name = "groupBoxFriendsLikedPagesWithPictures";
            this.groupBoxFriendsLikedPagesWithPictures.Size = new System.Drawing.Size(185, 238);
            this.groupBoxFriendsLikedPagesWithPictures.TabIndex = 11;
            this.groupBoxFriendsLikedPagesWithPictures.TabStop = false;
            this.groupBoxFriendsLikedPagesWithPictures.Text = "Friend\'s Liked Pages with pictures";
            // 
            // AppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.groupBoxFriendsLikedPages);
            this.Controls.Add(this.pictureBoxUserFriend);
            this.Controls.Add(this.groupBoxUserFriends);
            this.Controls.Add(this.groupBoxPostArea);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBoxUserInfo);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonLogIn);
            this.Name = "AppUI";
            this.Text = "DesignPatternsApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.groupBoxUserInfo.ResumeLayout(false);
            this.groupBoxUserInfo.PerformLayout();
            this.groupBoxPostArea.ResumeLayout(false);
            this.groupBoxPostArea.PerformLayout();
            this.groupBoxUserFriends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserFriend)).EndInit();
            this.groupBoxFriendsLikedPages.ResumeLayout(false);
            this.groupBoxFriendsLikedPages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxUserEmail;
        private System.Windows.Forms.GroupBox groupBoxUserInfo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxUserHometown;
        private System.Windows.Forms.Button buttonUserDoPost;
        private System.Windows.Forms.TextBox textBoxUserPost;
        private System.Windows.Forms.GroupBox groupBoxPostArea;
        private System.Windows.Forms.GroupBox groupBoxUserFriends;
        private System.Windows.Forms.ListBox listBoxUserFriends;
        private System.Windows.Forms.Button buttonUserFriendsFind;
        private System.Windows.Forms.PictureBox pictureBoxUserFriend;
        private System.Windows.Forms.Button buttonGetFriendsLikedPages;
        private System.Windows.Forms.GroupBox groupBoxFriendsLikedPages;
        private System.Windows.Forms.Button buttonUserFriendFindBy;
        private System.Windows.Forms.TextBox textBoxLikedPageURL;
        private System.Windows.Forms.GroupBox groupBoxFriendsLikedPagesWithPictures;
    }
}

