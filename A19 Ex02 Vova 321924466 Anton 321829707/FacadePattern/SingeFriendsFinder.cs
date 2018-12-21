using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace A19_Ex02_Vova_321924466_Anton_321829707.FacadePattern
{
    public class SingeFriendsFinder : IInformationGather
    {
        private User m_LoggedInUser;
        private Dictionary<string, string> m_FriendsRelationShipStatus;

        public SingeFriendsFinder(User i_loggedInUser)
        {
            m_LoggedInUser = i_loggedInUser;
        }

        public Dictionary<string, string> InformationGather()
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

        public void launchRelationshipStatus()
        {
            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (friend.RelationshipStatus == null)//!!!!!!!!!!!!!== User.eRelationshipStatus.Single
                {
                    m_FriendsRelationShipStatus.Add(string.Format("{0} {1}", friend.FirstName, friend.LastName), friend.RelationshipStatus.ToString());
                }
            }
        }
    }
}