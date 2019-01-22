namespace A19_Ex03_Vova_321924466_Anton_321829707
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
            this.components = new System.ComponentModel.Container();
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
            this.textBoxFriendsEmail = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxFriendsHometown = new System.Windows.Forms.TextBox();
            this.buttonUserFriendsFind = new System.Windows.Forms.Button();
            this.textBoxFriendsFullName = new System.Windows.Forms.TextBox();
            this.buttonUserFriendFindBy = new System.Windows.Forms.Button();
            this.listBoxUserFriends = new System.Windows.Forms.ListBox();
            this.buttonGetFriendsLikedPages = new System.Windows.Forms.Button();
            this.groupBoxFriendsLikedPages = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSortAlgorithms = new System.Windows.Forms.ComboBox();
            this.groupBoxFriendsLikedPagesWithPictures = new System.Windows.Forms.GroupBox();
            this.comboBoxThemeColor = new System.Windows.Forms.ComboBox();
            this.groupBoxThemeColor = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.groupBoxUserInfo.SuspendLayout();
            this.groupBoxPostArea.SuspendLayout();
            this.groupBoxUserFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.groupBoxFriendsLikedPages.SuspendLayout();
            this.groupBoxThemeColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogIn.BackColor = System.Drawing.Color.Green;
            this.buttonLogIn.ForeColor = System.Drawing.Color.White;
            this.buttonLogIn.Location = new System.Drawing.Point(813, 794);
            this.buttonLogIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(87, 51);
            this.buttonLogIn.TabIndex = 0;
            this.buttonLogIn.Text = "Login";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUser.Location = new System.Drawing.Point(22, 29);
            this.pictureBoxUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(312, 310);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 1;
            this.pictureBoxUser.TabStop = false;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogOut.BackColor = System.Drawing.Color.Red;
            this.buttonLogOut.ForeColor = System.Drawing.Color.White;
            this.buttonLogOut.Location = new System.Drawing.Point(909, 794);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(87, 51);
            this.buttonLogOut.TabIndex = 2;
            this.buttonLogOut.Text = "Logout";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(22, 360);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.ReadOnly = true;
            this.textBoxUserName.Size = new System.Drawing.Size(242, 26);
            this.textBoxUserName.TabIndex = 3;
            this.textBoxUserName.Text = "User name";
            // 
            // textBoxUserEmail
            // 
            this.textBoxUserEmail.Location = new System.Drawing.Point(22, 400);
            this.textBoxUserEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUserEmail.Name = "textBoxUserEmail";
            this.textBoxUserEmail.ReadOnly = true;
            this.textBoxUserEmail.Size = new System.Drawing.Size(242, 26);
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
            this.groupBoxUserInfo.Location = new System.Drawing.Point(18, 18);
            this.groupBoxUserInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxUserInfo.Name = "groupBoxUserInfo";
            this.groupBoxUserInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxUserInfo.Size = new System.Drawing.Size(358, 502);
            this.groupBoxUserInfo.TabIndex = 6;
            this.groupBoxUserInfo.TabStop = false;
            this.groupBoxUserInfo.Text = "User Info";
            // 
            // textBoxUserHometown
            // 
            this.textBoxUserHometown.Location = new System.Drawing.Point(23, 440);
            this.textBoxUserHometown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUserHometown.Name = "textBoxUserHometown";
            this.textBoxUserHometown.ReadOnly = true;
            this.textBoxUserHometown.Size = new System.Drawing.Size(242, 26);
            this.textBoxUserHometown.TabIndex = 6;
            this.textBoxUserHometown.Text = "Hometown";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.BackColor = System.Drawing.Color.IndianRed;
            this.richTextBox1.Location = new System.Drawing.Point(18, 780);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(356, 62);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "Note: This application have created settings file at \"C:\\FacebookApp\".";
            // 
            // buttonUserDoPost
            // 
            this.buttonUserDoPost.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonUserDoPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserDoPost.ForeColor = System.Drawing.Color.White;
            this.buttonUserDoPost.Location = new System.Drawing.Point(276, 158);
            this.buttonUserDoPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUserDoPost.Name = "buttonUserDoPost";
            this.buttonUserDoPost.Size = new System.Drawing.Size(74, 74);
            this.buttonUserDoPost.TabIndex = 8;
            this.buttonUserDoPost.Text = "Post it!";
            this.buttonUserDoPost.UseVisualStyleBackColor = false;
            this.buttonUserDoPost.Click += new System.EventHandler(this.buttonUserDoPost_Click);
            // 
            // textBoxUserPost
            // 
            this.textBoxUserPost.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxUserPost.Location = new System.Drawing.Point(9, 29);
            this.textBoxUserPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUserPost.Multiline = true;
            this.textBoxUserPost.Name = "textBoxUserPost";
            this.textBoxUserPost.Size = new System.Drawing.Size(256, 201);
            this.textBoxUserPost.TabIndex = 9;
            this.textBoxUserPost.Text = "Have some thoughts?";
            this.textBoxUserPost.Click += new System.EventHandler(this.textBoxUserPost_Click);
            // 
            // groupBoxPostArea
            // 
            this.groupBoxPostArea.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBoxPostArea.Controls.Add(this.buttonUserDoPost);
            this.groupBoxPostArea.Controls.Add(this.textBoxUserPost);
            this.groupBoxPostArea.Location = new System.Drawing.Point(18, 529);
            this.groupBoxPostArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPostArea.Name = "groupBoxPostArea";
            this.groupBoxPostArea.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPostArea.Size = new System.Drawing.Size(358, 242);
            this.groupBoxPostArea.TabIndex = 10;
            this.groupBoxPostArea.TabStop = false;
            this.groupBoxPostArea.Text = "Post Area";
            // 
            // groupBoxUserFriends
            // 
            this.groupBoxUserFriends.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBoxUserFriends.Controls.Add(this.textBoxFriendsEmail);
            this.groupBoxUserFriends.Controls.Add(this.imageNormalPictureBox);
            this.groupBoxUserFriends.Controls.Add(this.textBoxFriendsHometown);
            this.groupBoxUserFriends.Controls.Add(this.buttonUserFriendsFind);
            this.groupBoxUserFriends.Controls.Add(this.textBoxFriendsFullName);
            this.groupBoxUserFriends.Controls.Add(this.buttonUserFriendFindBy);
            this.groupBoxUserFriends.Controls.Add(this.listBoxUserFriends);
            this.groupBoxUserFriends.Location = new System.Drawing.Point(386, 18);
            this.groupBoxUserFriends.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxUserFriends.Name = "groupBoxUserFriends";
            this.groupBoxUserFriends.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxUserFriends.Size = new System.Drawing.Size(300, 662);
            this.groupBoxUserFriends.TabIndex = 11;
            this.groupBoxUserFriends.TabStop = false;
            this.groupBoxUserFriends.Text = "User Friends";
            // 
            // textBoxFriendsEmail
            // 
            this.textBoxFriendsEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.textBoxFriendsEmail.Location = new System.Drawing.Point(8, 570);
            this.textBoxFriendsEmail.Name = "textBoxFriendsEmail";
            this.textBoxFriendsEmail.ReadOnly = true;
            this.textBoxFriendsEmail.Size = new System.Drawing.Size(242, 26);
            this.textBoxFriendsEmail.TabIndex = 12;
            this.textBoxFriendsEmail.Text = "Friend\'s Email";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(8, 421);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(100, 100);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 14;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // textBoxFriendsHometown
            // 
            this.textBoxFriendsHometown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Location.Name", true));
            this.textBoxFriendsHometown.Location = new System.Drawing.Point(7, 610);
            this.textBoxFriendsHometown.Name = "textBoxFriendsHometown";
            this.textBoxFriendsHometown.ReadOnly = true;
            this.textBoxFriendsHometown.Size = new System.Drawing.Size(242, 26);
            this.textBoxFriendsHometown.TabIndex = 12;
            this.textBoxFriendsHometown.Text = "Friend\'s Hometown";
            // 
            // buttonUserFriendsFind
            // 
            this.buttonUserFriendsFind.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonUserFriendsFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserFriendsFind.ForeColor = System.Drawing.Color.White;
            this.buttonUserFriendsFind.Location = new System.Drawing.Point(8, 29);
            this.buttonUserFriendsFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUserFriendsFind.Name = "buttonUserFriendsFind";
            this.buttonUserFriendsFind.Size = new System.Drawing.Size(123, 74);
            this.buttonUserFriendsFind.TabIndex = 10;
            this.buttonUserFriendsFind.Text = "See my friends!";
            this.buttonUserFriendsFind.UseVisualStyleBackColor = false;
            this.buttonUserFriendsFind.Click += new System.EventHandler(this.buttonUserFriendsFind_Click);
            // 
            // textBoxFriendsFullName
            // 
            this.textBoxFriendsFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.textBoxFriendsFullName.Location = new System.Drawing.Point(8, 530);
            this.textBoxFriendsFullName.Name = "textBoxFriendsFullName";
            this.textBoxFriendsFullName.ReadOnly = true;
            this.textBoxFriendsFullName.Size = new System.Drawing.Size(242, 26);
            this.textBoxFriendsFullName.TabIndex = 16;
            this.textBoxFriendsFullName.Text = "Friend\'s Name";
            // 
            // buttonUserFriendFindBy
            // 
            this.buttonUserFriendFindBy.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonUserFriendFindBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserFriendFindBy.ForeColor = System.Drawing.Color.White;
            this.buttonUserFriendFindBy.Location = new System.Drawing.Point(169, 29);
            this.buttonUserFriendFindBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUserFriendFindBy.Name = "buttonUserFriendFindBy";
            this.buttonUserFriendFindBy.Size = new System.Drawing.Size(123, 74);
            this.buttonUserFriendFindBy.TabIndex = 11;
            this.buttonUserFriendFindBy.Text = "Find friend by...";
            this.buttonUserFriendFindBy.UseVisualStyleBackColor = false;
            this.buttonUserFriendFindBy.Click += new System.EventHandler(this.buttonUserFriendFindBy_Click);
            // 
            // listBoxUserFriends
            // 
            this.listBoxUserFriends.BackColor = System.Drawing.Color.Gainsboro;
            this.listBoxUserFriends.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxUserFriends.DataSource = this.userBindingSource;
            this.listBoxUserFriends.FormattingEnabled = true;
            this.listBoxUserFriends.ItemHeight = 20;
            this.listBoxUserFriends.Location = new System.Drawing.Point(10, 113);
            this.listBoxUserFriends.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxUserFriends.Name = "listBoxUserFriends";
            this.listBoxUserFriends.Size = new System.Drawing.Size(282, 300);
            this.listBoxUserFriends.Sorted = true;
            this.listBoxUserFriends.TabIndex = 0;
            // 
            // buttonGetFriendsLikedPages
            // 
            this.buttonGetFriendsLikedPages.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonGetFriendsLikedPages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetFriendsLikedPages.ForeColor = System.Drawing.Color.White;
            this.buttonGetFriendsLikedPages.Location = new System.Drawing.Point(9, 29);
            this.buttonGetFriendsLikedPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGetFriendsLikedPages.Name = "buttonGetFriendsLikedPages";
            this.buttonGetFriendsLikedPages.Size = new System.Drawing.Size(282, 48);
            this.buttonGetFriendsLikedPages.TabIndex = 10;
            this.buttonGetFriendsLikedPages.Text = "Get friend\'s random liked pages!";
            this.buttonGetFriendsLikedPages.UseVisualStyleBackColor = false;
            this.buttonGetFriendsLikedPages.Click += new System.EventHandler(this.buttonGetFriendsLikedPages_Click);
            // 
            // groupBoxFriendsLikedPages
            // 
            this.groupBoxFriendsLikedPages.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBoxFriendsLikedPages.Controls.Add(this.label1);
            this.groupBoxFriendsLikedPages.Controls.Add(this.comboBoxSortAlgorithms);
            this.groupBoxFriendsLikedPages.Controls.Add(this.groupBoxFriendsLikedPagesWithPictures);
            this.groupBoxFriendsLikedPages.Controls.Add(this.buttonGetFriendsLikedPages);
            this.groupBoxFriendsLikedPages.Location = new System.Drawing.Point(694, 18);
            this.groupBoxFriendsLikedPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFriendsLikedPages.Name = "groupBoxFriendsLikedPages";
            this.groupBoxFriendsLikedPages.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFriendsLikedPages.Size = new System.Drawing.Size(300, 502);
            this.groupBoxFriendsLikedPages.TabIndex = 12;
            this.groupBoxFriendsLikedPages.TabStop = false;
            this.groupBoxFriendsLikedPages.Text = "Friend\'s Liked Pages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sort:";
            // 
            // comboBoxSortAlgorithms
            // 
            this.comboBoxSortAlgorithms.FormattingEnabled = true;
            this.comboBoxSortAlgorithms.Items.AddRange(new object[] {
            "Ascending (likes amount)",
            "Descending (likes amount)"});
            this.comboBoxSortAlgorithms.Location = new System.Drawing.Point(59, 460);
            this.comboBoxSortAlgorithms.Name = "comboBoxSortAlgorithms";
            this.comboBoxSortAlgorithms.Size = new System.Drawing.Size(234, 28);
            this.comboBoxSortAlgorithms.TabIndex = 13;
            this.comboBoxSortAlgorithms.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortAlgorithms_SelectedIndexChanged);
            // 
            // groupBoxFriendsLikedPagesWithPictures
            // 
            this.groupBoxFriendsLikedPagesWithPictures.Location = new System.Drawing.Point(14, 86);
            this.groupBoxFriendsLikedPagesWithPictures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFriendsLikedPagesWithPictures.Name = "groupBoxFriendsLikedPagesWithPictures";
            this.groupBoxFriendsLikedPagesWithPictures.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFriendsLikedPagesWithPictures.Size = new System.Drawing.Size(278, 366);
            this.groupBoxFriendsLikedPagesWithPictures.TabIndex = 11;
            this.groupBoxFriendsLikedPagesWithPictures.TabStop = false;
            this.groupBoxFriendsLikedPagesWithPictures.Text = "Friend\'s Liked Pages with pictures";
            // 
            // comboBoxThemeColor
            // 
            this.comboBoxThemeColor.FormattingEnabled = true;
            this.comboBoxThemeColor.Items.AddRange(new object[] {
            "Light",
            "Dark",
            "Default"});
            this.comboBoxThemeColor.Location = new System.Drawing.Point(62, 25);
            this.comboBoxThemeColor.Name = "comboBoxThemeColor";
            this.comboBoxThemeColor.Size = new System.Drawing.Size(230, 28);
            this.comboBoxThemeColor.TabIndex = 13;
            this.comboBoxThemeColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxThemeColor_SelectedIndexChanged);
            // 
            // groupBoxThemeColor
            // 
            this.groupBoxThemeColor.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBoxThemeColor.Controls.Add(this.label2);
            this.groupBoxThemeColor.Controls.Add(this.comboBoxThemeColor);
            this.groupBoxThemeColor.Location = new System.Drawing.Point(386, 780);
            this.groupBoxThemeColor.Name = "groupBoxThemeColor";
            this.groupBoxThemeColor.Size = new System.Drawing.Size(300, 62);
            this.groupBoxThemeColor.TabIndex = 14;
            this.groupBoxThemeColor.TabStop = false;
            this.groupBoxThemeColor.Text = "Theme Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Color:";
            // 
            // AppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1014, 863);
            this.Controls.Add(this.groupBoxThemeColor);
            this.Controls.Add(this.groupBoxFriendsLikedPages);
            this.Controls.Add(this.groupBoxUserFriends);
            this.Controls.Add(this.groupBoxPostArea);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBoxUserInfo);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonLogIn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AppUI";
            this.Text = "DesignPatternsApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.groupBoxUserInfo.ResumeLayout(false);
            this.groupBoxUserInfo.PerformLayout();
            this.groupBoxPostArea.ResumeLayout(false);
            this.groupBoxPostArea.PerformLayout();
            this.groupBoxUserFriends.ResumeLayout(false);
            this.groupBoxUserFriends.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.groupBoxFriendsLikedPages.ResumeLayout(false);
            this.groupBoxFriendsLikedPages.PerformLayout();
            this.groupBoxThemeColor.ResumeLayout(false);
            this.groupBoxThemeColor.PerformLayout();
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
        private System.Windows.Forms.Button buttonGetFriendsLikedPages;
        private System.Windows.Forms.GroupBox groupBoxFriendsLikedPages;
        private System.Windows.Forms.Button buttonUserFriendFindBy;
        private System.Windows.Forms.GroupBox groupBoxFriendsLikedPagesWithPictures;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox textBoxFriendsHometown;
        private System.Windows.Forms.TextBox textBoxFriendsEmail;
        private System.Windows.Forms.TextBox textBoxFriendsFullName;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.ComboBox comboBoxSortAlgorithms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxThemeColor;
        private System.Windows.Forms.GroupBox groupBoxThemeColor;
        private System.Windows.Forms.Label label2;
    }
}

