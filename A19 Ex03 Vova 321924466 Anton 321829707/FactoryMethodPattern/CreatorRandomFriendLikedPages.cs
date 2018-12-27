using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A19_Ex03_Vova_321924466_Anton_321829707.FactoryMethodPattern
{
    public class CreatorRandomFriendLikedPages : Creator
    {
        private static readonly object sr_RandomFriendLikedPagesInstanceLock = new object();
        private static RandomFriendLikedPages s_RandomFriendLikedPagesInstance;

        public override IFacebookFeature FactoryMethod(User io_LoggedInUser, object io_GroupBoxFriendsLikedPagesWithPictures)
        {
            if (s_RandomFriendLikedPagesInstance == null)
            {
                lock (sr_RandomFriendLikedPagesInstanceLock)
                {
                    if (s_RandomFriendLikedPagesInstance == null)
                    {
                        s_RandomFriendLikedPagesInstance = new RandomFriendLikedPages(io_LoggedInUser, (GroupBox)io_GroupBoxFriendsLikedPagesWithPictures);
                    }                    
                }
            }
            return s_RandomFriendLikedPagesInstance;
        }
    }
}