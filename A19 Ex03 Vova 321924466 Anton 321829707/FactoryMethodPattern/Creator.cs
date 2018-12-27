using FacebookWrapper.ObjectModel;

namespace A19_Ex03_Vova_321924466_Anton_321829707.FactoryMethodPattern
{
    public abstract class Creator
    {
        public abstract IFacebookFeature FactoryMethod(User io_LoggedInUser, object i_Object);
    }
}