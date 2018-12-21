using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace A19_Ex02_Vova_321924466_Anton_321829707.FacadePattern
{
    public class FriendInACityFinder : IInformationGather
    {
        private User m_LoggedInUser;
        private Dictionary<string, string> m_FriendsInAInputtedCity;

        public FriendInACityFinder(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public Dictionary<string, string> InformationGather()
        {
            if (m_FriendsInAInputtedCity == null)
            {
                m_FriendsInAInputtedCity = new Dictionary<string, string>();
                friendsCityLocation();
                return m_FriendsInAInputtedCity;
            }
            else
            {
                return m_FriendsInAInputtedCity;
            }
        }

        private void friendsCityLocation()
        {
            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (friend.Location != null)
                {
                    m_FriendsInAInputtedCity.Add(string.Format("{0} {1}", friend.FirstName, friend.LastName), friend.Location.Name);
                }
                else if (friend.Location == null)
                {
                    m_FriendsInAInputtedCity.Add(string.Format("{0} {1}", friend.FirstName, friend.LastName), string.Empty);
                }

            }
        }
    }
}