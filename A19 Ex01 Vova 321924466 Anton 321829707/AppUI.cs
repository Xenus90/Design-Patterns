using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A19_Ex01_Vova_321924466_Anton_321829707
{
    public partial class AppUI : Form
    {
        private User m_LoggedInUser;
        private AppSettings m_AppSettings;
        private FriendsByRequest m_FriendsByRequest;
        private RandomFriendLikedPages m_RandomFriendLikedPages;

        public AppUI()
        {
            InitializeComponent();
            FacebookService.s_FbApiVersion = 3.2f;

            m_AppSettings = AppSettings.LoadFromFile();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = m_AppSettings.LastWindowLocation;
            this.Size = m_AppSettings.LastWindowSize;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            m_AppSettings.LastWindowLocation = this.Location;
            m_AppSettings.LastWindowSize = this.Size;
            m_AppSettings.SaveToFile();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            LoginResult result = FacebookService.Login("1848689845240560", 
                "public_profile", 
                "email", 
                "user_friends", 
                "user_hometown",                      
                "user_birthday",
                "user_events",
                "user_gender",
                "user_likes",   
                "user_location",
                "user_photos",
                "user_posts",
                "manage_pages",
                "publish_pages",
                "publish_to_groups");         

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                //fetchUserInfo();
                new Thread(fetchUserInfo).Start(); 
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser != null)
            {
                try
                {
                    FacebookService.Logout(resetUserInfoOnLogout);
                }
                catch (Exception LogOutException)
                {
                    MessageBox.Show("Logout error occured!" + System.Environment.NewLine + LogOutException.Message);
                } 
            }
            else
            {
                MessageBox.Show("You need to login first!");
            }
        }

        private void fetchUserInfo()
        {
            //try
            //{
            //    this.Text = string.Format("Welcome {0} {1}!", m_LoggedInUser.FirstName, m_LoggedInUser.LastName);
            //    pictureBoxUser.LoadAsync(m_LoggedInUser.PictureLargeURL);
            //    textBoxUserName.Text = string.Format("{0} {1}", m_LoggedInUser.LastName, m_LoggedInUser.FirstName);
            //    textBoxUserEmail.Text = m_LoggedInUser.Email;
            //    textBoxUserHometown.Text = m_LoggedInUser.Location.Name;
            //}
            //catch (Exception fetchUserInfoException)
            //{
            //    MessageBox.Show(@"We were unable to retrive one or more fields of your info ¯\_(ツ)_/¯" + System.Environment.NewLine + fetchUserInfoException.Message);
            //}

            groupBoxUserInfo.Invoke(new Action(
                () =>
                    {
                        try
                        {
                            this.Text = string.Format("Welcome {0} {1}!", m_LoggedInUser.FirstName, m_LoggedInUser.LastName);
                            pictureBoxUser.LoadAsync(m_LoggedInUser.PictureLargeURL);
                            textBoxUserName.Text = string.Format("{0} {1}", m_LoggedInUser.LastName, m_LoggedInUser.FirstName);
                            textBoxUserEmail.Text = m_LoggedInUser.Email;
                            textBoxUserHometown.Text = m_LoggedInUser.Location.Name;
                        }
                        catch (Exception fetchUserInfoException)
                        {
                            MessageBox.Show(@"We were unable to retrive one or more fields of your info ¯\_(ツ)_/¯" + System.Environment.NewLine + fetchUserInfoException.Message);
                        }
                    }));
        }

        private void resetUserInfoOnLogout()
        {
            this.Text = this.Name;
            this.pictureBoxUser.Image = null;
            this.textBoxUserName.Text = "User name";
            this.textBoxUserEmail.Text = "Email";
            this.textBoxUserHometown.Text = "Hometown";
            this.textBoxUserPost.Text = "Have some thoughts?";
            this.listBoxUserFriends.Items.Clear();
            this.pictureBoxUserFriend.Image = null;
            this.groupBoxFriendsLikedPagesWithPictures.Controls.Clear();
            this.textBoxLikedPageURL.Text = string.Empty;
            this.m_LoggedInUser = null;
        }

        private void textBoxUserPost_Click(object sender, EventArgs e)
        {
            textBoxUserPost.Text = string.Empty;
        }

        private void buttonUserDoPost_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser != null)
            {
                if (textBoxUserPost.Text != string.Empty)
                {
                    try
                    {
                        Status postedStatus = m_LoggedInUser.PostStatus(textBoxUserPost.Text);
                        MessageBox.Show("Status Posted! " + System.Environment.NewLine + "ID: " + postedStatus.Id);
                        textBoxUserPost.Text = "Have some thoughts?";
                    }
                    catch (Exception doPostException)
                    {
                        MessageBox.Show("Something went wrong durning post." + System.Environment.NewLine + doPostException.Message);                      
                    }
                }
                else
                {
                    MessageBox.Show("You can't post an empty thought!");
                }
            }
            else
            {
                MessageBox.Show("You need to login first!");
            }
        }      
     
        private void buttonUserFriendsFind_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser != null)
            {
                listBoxUserFriends.Items.Clear();
                listBoxUserFriends.DisplayMember = "Name";

                foreach (User friend in m_LoggedInUser.Friends)
                {
                    listBoxUserFriends.Items.Add(friend);
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }

                if (m_LoggedInUser.Friends.Count == 0)
                {
                    MessageBox.Show("You have no friends using that application.");
                } 
            }
            else
            {
                MessageBox.Show("You need to login first!");
            }
        }

        private void listBoxUserFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUserFriends.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxUserFriends.SelectedItem as User;

                if (selectedFriend.PictureNormalURL != null)
                {
                    pictureBoxUserFriend.LoadAsync(selectedFriend.PictureNormalURL);
                }
            }
        }

        private void buttonUserFriendFindBy_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser != null)
            {
                if (m_FriendsByRequest == null)
                {
                    m_FriendsByRequest = new FriendsByRequest(m_LoggedInUser);
                }

                m_FriendsByRequest.Location = Cursor.Position;
                m_FriendsByRequest.ShowDialog();
            }
            else
            {
                MessageBox.Show("You need to login first!");
            }
        }

        private void buttonGetFriendsLikedPages_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser != null)
            {
                if (m_RandomFriendLikedPages == null)
                {
                    m_RandomFriendLikedPages = new RandomFriendLikedPages(m_LoggedInUser, groupBoxFriendsLikedPagesWithPictures);
                }

                groupBoxFriendsLikedPagesWithPictures = m_RandomFriendLikedPages.GetPages(); 
            }
            else
            {
                MessageBox.Show("You need to login first!");
            }
        }       
    }
}