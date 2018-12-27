using FacebookWrapper.ObjectModel;

namespace A19_Ex03_Vova_321924466_Anton_321829707.CacheProxyPattern
{
    public class GetLikedPagesFromFacebook : IGetLikedPages
    {
        public string[] GetRandomFriendLikedPages(User io_RandomFriend)
        {
            string[] pageImageLocation = new string[10];

            for (int i = 0; i < pageImageLocation.Length && i < io_RandomFriend.LikedPages.Count; i++)
            {
                pageImageLocation[i] = io_RandomFriend.LikedPages[i].URL;
            }

            return pageImageLocation;
        }
    }
}