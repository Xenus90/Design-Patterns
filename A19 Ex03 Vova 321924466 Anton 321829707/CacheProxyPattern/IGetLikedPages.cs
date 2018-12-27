using FacebookWrapper.ObjectModel;

namespace A19_Ex03_Vova_321924466_Anton_321829707.CacheProxyPattern
{
    public interface IGetLikedPages
    {
        string[] GetRandomFriendLikedPages(User io_RandomFriend);  
    }
}