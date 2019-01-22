using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using A19_Ex03_Vova_321924466_Anton_321829707.FactoryMethodPattern;
using A19_Ex03_Vova_321924466_Anton_321829707.ObserverPattern;

namespace A19_Ex03_Vova_321924466_Anton_321829707
{
    public partial class AppUI : Form, IThemeObserver
    {
        private User m_LoggedInUser;
        private AppSettings m_AppSettings;
        private Creator m_FeaturesCreator;
        private FriendsByRequestWrapper m_FriendsByRequestWrapper;
        private RandomFriendLikedPages m_RandomFriendLikedPages;
        private ThemeDelegateWrapper m_ThemeDelegate;

        public AppUI()
        {
            InitializeComponent();
            FacebookService.s_FbApiVersion = 3.2f;
            FacebookService.s_CollectionLimit = 100;

            this.StartPosition = FormStartPosition.Manual;
            m_AppSettings = AppSettings.GetInstance;
            m_AppSettings.LoadFromFile();      
            this.Location = m_AppSettings.LastWindowLocation;
            this.Size = m_AppSettings.LastWindowSize;

            m_ThemeDelegate = new ThemeDelegateWrapper();
            m_ThemeDelegate.AddObserver(this.UpdateTheme);
        }

        public void UpdateTheme(string i_ThemeName)
        {
            if (i_ThemeName == "Light")
            {
                this.BackColor = Color.Lavender;
            }
            else if (i_ThemeName == "Dark")
            {
                this.BackColor = Color.LightSlateGray;
            }
            else if (i_ThemeName == "Default")
            {
                this.BackColor = Color.LightSteelBlue;
            }

            foreach(Control singleControl in this.Controls)
            {
                if (singleControl.GetType() == typeof(GroupBox))
                {
                    updateThemeInEveryGroupBox(i_ThemeName, (GroupBox)singleControl);
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            m_AppSettings.SaveToFile(this);
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
            try
            {               
                this.Text = this.Name;
                this.pictureBoxUser.Image = null;
                this.textBoxUserName.Text = "User name";
                this.textBoxUserEmail.Text = "Email";
                this.textBoxUserHometown.Text = "Hometown";
                this.textBoxUserPost.Text = "Have some thoughts?";
                userBindingSource.Clear();
                this.groupBoxFriendsLikedPagesWithPictures.Controls.Clear();
                this.m_LoggedInUser = null;               
            }
            catch (Exception clearOnLogoutExpection)
            {
                MessageBox.Show("An error occured during logout." + System.Environment.NewLine + clearOnLogoutExpection.Message);
            }
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
                listBoxUserFriends.DisplayMember = "FirstName";
                userBindingSource.DataSource = m_LoggedInUser.Friends;

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

        private void buttonUserFriendFindBy_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser != null)
            {
                if (m_FriendsByRequestWrapper == null)
                {
                    m_FeaturesCreator = new CreatorFriendsByRequestWrapper();
                    m_FriendsByRequestWrapper = m_FeaturesCreator.FactoryMethod(m_LoggedInUser, null) as FriendsByRequestWrapper;
                    m_ThemeDelegate.AddObserver(m_FriendsByRequestWrapper.m_FriendsByRequest.UpdateTheme);
                }

                m_FriendsByRequestWrapper.m_FriendsByRequest.Location = Cursor.Position;
                m_FriendsByRequestWrapper.m_FriendsByRequest.ShowDialog();
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
                    m_FeaturesCreator = new CreatorRandomFriendLikedPages();
                    m_RandomFriendLikedPages = m_FeaturesCreator.FactoryMethod(m_LoggedInUser, this.groupBoxFriendsLikedPagesWithPictures) as RandomFriendLikedPages;
                }

                groupBoxFriendsLikedPagesWithPictures = m_RandomFriendLikedPages.GetPages(); 
            }
            else
            {
                MessageBox.Show("You need to login first!");
            }
        }

        private void comboBoxSortAlgorithms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_LoggedInUser != null)
            {               
               if (m_RandomFriendLikedPages != null)
               {
                    try
                    {
                        m_RandomFriendLikedPages.sortPicsBoxArrAlgorithm(comboBoxSortAlgorithms.SelectedItem.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Please, select one of provided sorts.");
                    }
               }
               else
               {
                    MessageBox.Show("You first need to fetch the pages!");
               }
            }
            else
            {                
                MessageBox.Show("You need to login first!");
            }
        }

        private void comboBoxThemeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_LoggedInUser != null)
            {
                if (m_FriendsByRequestWrapper != null)
                {
                    switch (comboBoxThemeColor.SelectedItem.ToString())
                    {
                        case "Light":
                            m_ThemeDelegate.NotifyAllObservers("Light");
                            break;
                        case "Dark":
                            m_ThemeDelegate.NotifyAllObservers("Dark");
                            break;
                        case "Default":
                            m_ThemeDelegate.NotifyAllObservers("Default");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Please, open 'Friends By Request' first!" + System.Environment.NewLine + "We need to create an instance in order to change both windows.");
                }
            }
            else
            {
                MessageBox.Show("You need to login first!");
            }
        }

        private void updateThemeInEveryGroupBox(string i_ThemeName, GroupBox i_GroupBox)
        {
            if (i_ThemeName == "Light")
            {
                i_GroupBox.BackColor = Color.SteelBlue;

                foreach (Control singleControl in i_GroupBox.Controls)
                {
                    if (singleControl.GetType() == typeof(Button))
                    {
                        singleControl.BackColor = Color.LightSkyBlue;
                    }
                    else if (singleControl.GetType() == typeof(ListBox))
                    {
                        singleControl.BackColor = Color.WhiteSmoke;
                    }
                    else if (singleControl.GetType() == typeof(TextBox))
                    {
                        singleControl.BackColor = Color.FromName("ControlLightLight");
                    }
                    else if (singleControl.GetType() == typeof(ComboBox))
                    {
                        singleControl.BackColor = Color.FromName("HighlightText");
                    }
                }
            }
            else if (i_ThemeName == "Dark")
            {
                i_GroupBox.BackColor = Color.DarkBlue;

                foreach (Control singleControl in i_GroupBox.Controls)
                {
                    if (singleControl.GetType() == typeof(Button))
                    {
                        singleControl.BackColor = Color.MidnightBlue;
                    }
                    else if (singleControl.GetType() == typeof(ListBox))
                    {
                        singleControl.BackColor = Color.DimGray;
                    }
                    else if (singleControl.GetType() == typeof(TextBox))
                    {
                        singleControl.BackColor = Color.FromName("WindowFrame");
                    }
                    else if (singleControl.GetType() == typeof(ComboBox))
                    {
                        singleControl.BackColor = Color.FromName("ScrollBar");
                    }
                }
            }
            else if (i_ThemeName == "Default")
            {               
                i_GroupBox.BackColor = Color.CornflowerBlue;

                foreach (Control singleControl in i_GroupBox.Controls)
                {
                    if (singleControl.GetType() == typeof(Button))
                    {
                        singleControl.BackColor = Color.RoyalBlue;
                    }
                    else if (singleControl.GetType() == typeof(ListBox))
                    {
                        singleControl.BackColor = Color.Gainsboro;
                    }
                    else if (singleControl.GetType() == typeof(TextBox))
                    {
                        singleControl.BackColor = Color.FromName("Control");
                    }
                    else if (singleControl.GetType() == typeof(ComboBox))
                    {
                        singleControl.BackColor = Color.FromName("Window");
                    }
                }
            }
        }
    }
}