using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using A19_Ex03_Vova_321924466_Anton_321829707.FacadePattern;
using A19_Ex03_Vova_321924466_Anton_321829707.ObserverPattern;
using A19_Ex03_Vova_321924466_Anton_321829707.TemplateMethodPattern;

namespace A19_Ex03_Vova_321924466_Anton_321829707
{
    public partial class FriendsByRequest : Form, IThemeObserver
    {
        private User m_LoggedInUser;
        private IInformationGather m_FriendsInACity;
        private IInformationGather m_SingleFriends;
        private TemplateMethodSkeleton m_TemplateSkeleton;

        public FriendsByRequest(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Text = "Friends Location";
        }

        public void UpdateTheme(string i_ThemeName)
        {
            if (i_ThemeName == "Light")
            {
                this.BackColor = Color.Lavender;

                foreach (Control singleControl in this.Controls)
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
                }
            }
            else if (i_ThemeName == "Dark")
            {
                this.BackColor = Color.LightSlateGray;

                foreach (Control singleControl in this.Controls)
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
                }
            }
            else if (i_ThemeName == "Default")
            {
                this.BackColor = Color.LightSteelBlue;

                foreach (Control singleControl in this.Controls)
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
                        singleControl.BackColor = Color.FromName("Window");
                    }
                }
            }
        }

        private void CityTextBox_Click(object sender, EventArgs e)
        {
            CityTextBox.Text = string.Empty;
        }

        private void findFriendsFromMyBirthCountry_Click(object sender, EventArgs e)
        {
            ListBoxOfFriends.Items.Clear();
            m_SingleFriends = new SingeFriendsFinder(m_LoggedInUser);
            Dictionary<string, string> friendsRelationShipStatus = m_SingleFriends.InformationGather();
            fillTextBoxWithSingleFriends(friendsRelationShipStatus);
        }

        private void fillTextBoxWithSingleFriends(Dictionary<string, string> i_friendsStatus)
        {
            foreach (KeyValuePair<string, string> friendAndRltStatus in i_friendsStatus)
            {
                ListBoxOfFriends.Items.Add(friendAndRltStatus.Key + friendAndRltStatus.Value);
            }
        }

        private void findFriendsButton_Click(object sender, EventArgs e)
        {
                ListBoxOfFriends.Items.Clear();
                m_FriendsInACity = new FriendInACityFinder(m_LoggedInUser);
                Dictionary<string, string> friendsWithInputedCity = m_FriendsInACity.InformationGather();
                fillTextBoxWithFriendsByEnteredLocation(friendsWithInputedCity, CityTextBox.Text);
        }

        private void fillTextBoxWithFriendsByEnteredLocation(Dictionary<string, string> i_friendsWithInputedCity, string i_desiredLocation)
        {
            Dictionary<string, string> matchedCityByDesiredInput = new Dictionary<string, string>();

            foreach (KeyValuePair<string, string> friend in i_friendsWithInputedCity)
            {
                if (friend.Value.ToLower().Contains(i_desiredLocation.ToLower()))
                {
                    matchedCityByDesiredInput.Add(friend.Key, friend.Value);
                }
            }

            foreach (KeyValuePair<string, string> friendAndLocation in matchedCityByDesiredInput)
            {
                ListBoxOfFriends.Items.Add(friendAndLocation.Key + friendAndLocation.Value);
            }
        }

        private void friendsReligion_Click(object sender, EventArgs e)
        {
            ListBoxOfFriends.Items.Clear();
            m_TemplateSkeleton = new FriendsReligion(m_LoggedInUser);
            Dictionary<string, string> tempDictionary = new Dictionary<string, string>();
            Dictionary<string, string> friendsReligion = new Dictionary<string, string>();
            friendsReligion = m_TemplateSkeleton.TemplateMethod(tempDictionary);
            fillTextBoxWithFriendsReligion(friendsReligion);
        }

        private void fillTextBoxWithFriendsReligion(Dictionary<string, string> i_friendsReligion)
        {
            foreach (KeyValuePair<string, string> friendsReligion in i_friendsReligion)
            {
                ListBoxOfFriends.Items.Add(friendsReligion.Key + friendsReligion.Value);
            }
        }
    }
}