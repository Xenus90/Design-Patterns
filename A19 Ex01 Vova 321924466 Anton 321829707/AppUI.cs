using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A19_Ex01_Vova_321924466_Anton_321829707
{
    public partial class AppUI : Form
    {
        User m_LoggedInUser;
        AppSettings m_AppSettings;

        public AppUI()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 200;
            FacebookService.s_FbApiVersion = 3.2f;

            m_AppSettings = AppSettings.LoadFromFile();
            StartPosition = FormStartPosition.Manual;
            this.Location = m_AppSettings.LastWindowLocation;
            this.Size = m_AppSettings.LastWindowSize;
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
                "user_friends",
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
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                FacebookService.Logout(resetUserInfoOnLogout);
            }
            catch (Exception LogOutException)
            {
                MessageBox.Show("You need first to login." + System.Environment.NewLine + LogOutException.Message);               
            }
        }

        private void fetchUserInfo()
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
                MessageBox.Show("We were unable to retrive one or more fields of your info :-(" + System.Environment.NewLine + fetchUserInfoException.Message);
            }
        }

        private void resetUserInfoOnLogout()
        {
            this.Text = this.Name;
            pictureBoxUser.Image = null;
            textBoxUserName.Text = "User name";
            textBoxUserEmail.Text = "Email";
            textBoxUserHometown.Text = "Hometown";
            textBoxUserPost.Text = "Have some thoughts?";
        }

        private void textBoxUserPost_Click(object sender, EventArgs e)
        {
            textBoxUserPost.Text = "";
        }

        private void buttonUserDoPost_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser != null)
            {
                if (textBoxUserPost.Text != "")
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            m_AppSettings.LastWindowLocation = this.Location;
            m_AppSettings.LastWindowSize = this.Size;
            m_AppSettings.SaveToFile();
        }
    }
}