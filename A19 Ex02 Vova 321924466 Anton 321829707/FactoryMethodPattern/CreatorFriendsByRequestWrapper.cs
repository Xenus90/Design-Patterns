using FacebookWrapper.ObjectModel;

namespace A19_Ex02_Vova_321924466_Anton_321829707.FactoryMethodPattern
{
    public class CreatorFriendsByRequestWrapper : Creator
    {
        private static readonly object sr_FriendsByRequestWrapperInstanceLock = new object();
        private static FriendsByRequestWrapper s_FriendsByRequestWrapperInstance;

        public override IFacebookFeature FactoryMethod(User io_LoggedInUser, object i_Object)
        {
            if (s_FriendsByRequestWrapperInstance == null)
            {
                lock (sr_FriendsByRequestWrapperInstanceLock)
                {
                    if (s_FriendsByRequestWrapperInstance == null)
                    {
                        s_FriendsByRequestWrapperInstance = new FriendsByRequestWrapper(io_LoggedInUser);
                    }
                }
            }
            return s_FriendsByRequestWrapperInstance;
        }
    }
}