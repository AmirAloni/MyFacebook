using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C18_Ex03_Logic
{
    public interface ILoginLogoutObserver
    {
        void UserLoggedIn();
        void UserLoggedout();
    }
}
