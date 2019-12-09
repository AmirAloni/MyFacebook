using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace C18_Ex03_Logic
{
    public class MyUser 
    {
        public User User { get; set; }
        private List<ILoginLogoutObserver> m_LoginLogoutObservers = new List<ILoginLogoutObserver>();

        public void AttachLoginLogoutObserver(ILoginLogoutObserver i_LoginLogoutObserver)
        {
                m_LoginLogoutObservers.Add(i_LoginLogoutObserver);
        }

        public void DetachLoginLogoutObserver(ILoginLogoutObserver i_LoginLogoutObserver)
        {
            m_LoginLogoutObservers.Remove(i_LoginLogoutObserver);
        }

        public void notifyLoginObservers()
        {
            foreach (ILoginLogoutObserver observer in m_LoginLogoutObservers)
            {
                observer.UserLoggedIn();

            }
        }

        public void notifyLogoutObservers()
        {
            foreach (ILoginLogoutObserver observer in m_LoginLogoutObservers)
            {
                observer.UserLoggedout();
            }
        }
    }
}
