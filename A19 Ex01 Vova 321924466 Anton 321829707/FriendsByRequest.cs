using System;
using System.Windows.Forms;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace A19_Ex01_Vova_321924466_Anton_321829707
{
    public partial class FriendsByRequest : Form
    {
        private User m_LoggedInUser;
        private Dictionary<string, string> m_FriendsInInputedCity;
        private Dictionary<string, string> m_FriendsRelationShipStatus;

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

        private void findFriendsButton_Click(object sender, EventArgs e)
        {
            ListBoxOfFriends.Items.Clear();
            Dictionary<string, string> friendsWithInputedCity = launchFriendInACityFinder();
            fillTextBoxWithFriendsByEnteredLocation(friendsWithInputedCity, CityTextBox.Text);
        }     

        private void friendsCityLocation()
        {
            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (friend.Location != null)
                {
                    m_FriendsInInputedCity.Add(string.Format("{0} {1}", friend.FirstName, friend.LastName), friend.Location.Name);
                }
                else if (friend.Location == null)
                {
                    m_FriendsInInputedCity.Add(string.Format("{0} {1}", friend.FirstName, friend.LastName), string.Empty);
                }

            }
        }

        private void fillTextBoxWithFriendsByEnteredLocation(Dictionary<string, string> i_friendsWithInputedCity, string i_desiredLocation)
        {
            Dictionary<string, string> matchedCityByDesiredInput = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> friend in m_FriendsInInputedCity)
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

        private void findFriendsFromMyBirthCountry_Click(object sender, EventArgs e)
        {
            ListBoxOfFriends.Items.Clear();
            Dictionary<string, string> friendsStatus = infoGather();
            fillTextBoxWithSingleFriends(friendsStatus);
        }

        private void launchRelationshipStatus()
        {
            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (friend.RelationshipStatus == User.eRelationshipStatus.Single)
                {
                    m_FriendsRelationShipStatus.Add(string.Format("{0} {1}", friend.FirstName, friend.LastName), friend.RelationshipStatus.ToString());
                }
            }
        }

        private void fillTextBoxWithSingleFriends(Dictionary<string, string> i_friendsStatus)
        {
            foreach (KeyValuePair<string, string> friendAndRltStatus in i_friendsStatus)
            {
                ListBoxOfFriends.Items.Add(friendAndRltStatus.Key + ", " + friendAndRltStatus.Value);
            }
        }

        private Dictionary<string, string> launchFriendInACityFinder()
        {
            if (m_FriendsInInputedCity == null)
            {
                m_FriendsInInputedCity = new Dictionary<string, string>();
                friendsCityLocation();
                return m_FriendsInInputedCity;
            }
            else
            {
                return m_FriendsInInputedCity;
            }
        }

        private Dictionary<string, string> infoGather()
        {
            if (m_FriendsRelationShipStatus == null)
            {
                m_FriendsRelationShipStatus = new Dictionary<string, string>();
                launchRelationshipStatus();
                return m_FriendsRelationShipStatus;
            }

            else
            {
                return m_FriendsRelationShipStatus;
            }
        }
    }
}