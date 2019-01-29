using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace A19_Ex03_Vova_321924466_Anton_321829707.TemplateMethodPattern
{
    public class FriendsReligion : TemplateMethodSkeleton
    {
        private User m_LoggedInUser;
        private Dictionary<string, string> m_friendsReligion;

        public FriendsReligion(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_friendsReligion = new Dictionary<string, string>();
        }

        public override Dictionary<string, string> InformationGather()
        {
            foreach (User friend in m_LoggedInUser.Friends)
            {
                string noReligion = "No Religion to show";

                if (friend.Religion != null)
                {
                    m_friendsReligion.Add(string.Format("{0}", friend.FirstName), friend.Religion.ToString());
                }
                else if (friend.Religion == null)
                {
                    m_friendsReligion.Add(string.Format("{0}", friend.FirstName), noReligion);
                }
            }

            return m_friendsReligion;
        }
    }
}