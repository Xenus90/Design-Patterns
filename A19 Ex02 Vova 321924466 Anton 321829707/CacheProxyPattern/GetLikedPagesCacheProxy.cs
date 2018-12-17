using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace A19_Ex02_Vova_321924466_Anton_321829707.CacheProxyPattern
{
    public class GetLikedPagesCacheProxy : IGetLikedPages
    {
        private IGetLikedPages m_GetLikedPagesFromFacebook;
        private Dictionary<string, Dictionary<int, string>> m_PreviousRandomFriends;
        
        public GetLikedPagesCacheProxy()
        {
            m_GetLikedPagesFromFacebook = new GetLikedPagesFromFacebook();
            m_PreviousRandomFriends = new Dictionary<string, Dictionary<int, string>>();
        }

        public string[] GetRandomFriendLikedPages(User io_RandomFriend)
        {
            string[] pageImageLocation = new string[10];
            
            if (m_PreviousRandomFriends.ContainsKey(io_RandomFriend.Name))
            {
                for (int i = 0; i < pageImageLocation.Length; i++)
                {
                    //pageImageLocation[i] = m_PreviousRandomFriends[io_RandomFriend.Name][i]; // This line can't be executed: we can't get any user liked pages because of Facebook permissions.
                    pageImageLocation[i] = io_RandomFriend.PictureNormalURL;
                }
            }
            else
            {
                m_PreviousRandomFriends.Add(io_RandomFriend.Name, null);

                for (int i = 0; i < pageImageLocation.Length && i < io_RandomFriend.LikedPages.Count; i++)
                {
                    pageImageLocation[i] = io_RandomFriend.LikedPages[i].URL;
                    m_PreviousRandomFriends[io_RandomFriend.Name].Add(i, io_RandomFriend.LikedPages[i].URL);
                }
            }

            return pageImageLocation;
        }
    }
}