using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C18_Ex03_Logic
{
    /// the strategy interface
    public interface ISearchBy
    {
        bool SearchSucceded(User i_CurrFriend, EditAbleFriend i_FriendToLookFor);
    }
}
