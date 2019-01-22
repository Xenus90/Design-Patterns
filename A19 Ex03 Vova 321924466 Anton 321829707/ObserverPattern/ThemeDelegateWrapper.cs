namespace A19_Ex03_Vova_321924466_Anton_321829707.ObserverPattern
{
    public delegate void ChangeThemeDelegate(string i_ThemeName);

    public class ThemeDelegateWrapper
    {
        private ChangeThemeDelegate m_ChangeThemeDelegate;

        public void AddObserver(ChangeThemeDelegate i_ChangeThemeDelegate)
        {
            m_ChangeThemeDelegate += i_ChangeThemeDelegate;
        }

        public void RemoveObserver(ChangeThemeDelegate i_ChangeThemeDelegate)
        {
            m_ChangeThemeDelegate -= i_ChangeThemeDelegate;
        }

        public void NotifyAllObservers(string i_ThemeName)
        {
            if (m_ChangeThemeDelegate != null)
            {
                m_ChangeThemeDelegate.Invoke(i_ThemeName);
            }
        }
    }
}