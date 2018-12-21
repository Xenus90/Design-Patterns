using System;
using System.Windows.Forms;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using A19_Ex02_Vova_321924466_Anton_321829707.FacadePattern;

namespace A19_Ex02_Vova_321924466_Anton_321829707
{
    public partial class FriendsByRequest : Form
    {
        private User m_LoggedInUser;
        private IInformationGather m_FriendsInACity;
        private IInformationGather m_SingleFriends;

        public FriendsByRequest(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Text = "Friends Location";
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
                ListBoxOfFriends.Items.Add(friendAndRltStatus.Key + ", " + friendAndRltStatus.Value);
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
                ListBoxOfFriends.Items.Add(friendAndLocation.Key + ", " + friendAndLocation.Value);
            }
        }
    }
}