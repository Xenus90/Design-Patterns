using FacebookWrapper.ObjectModel;

namespace A19_Ex02_Vova_321924466_Anton_321829707.FactoryMethodPattern
{
    public class FriendsByRequestWrapper : IFacebookFeature
    {
        public FriendsByRequestWrapper(User io_LoggedInUser)
        {
            m_FriendsByRequest = new FriendsByRequest(io_LoggedInUser);
        }

        public User LoggedInUser { get; set; }

        public FriendsByRequest m_FriendsByRequest { get; private set; }            
    }
}