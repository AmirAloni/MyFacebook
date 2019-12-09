using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C18_Ex03_Logic;

namespace C18_Ex03_UI
{
    public class MyButton: Button, ILoginLogoutObserver
    {
        public void AddMe(MyUser i_User)
        {
            i_User.AttachLoginLogoutObserver(this as ILoginLogoutObserver);
        }

        public void UserLoggedIn()
        {
            this.Enabled = true;
        }

        public void UserLoggedout()
        {
            this.Enabled = false;
        }
    }
}
