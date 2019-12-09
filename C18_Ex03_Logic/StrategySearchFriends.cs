using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static C18_Ex03_Logic.LogicManager;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C18_Ex03_Logic
{
        public class StrategySearchFriends
        {
          private FacebookObjectCollection<User> m_FilteredFriends = new FacebookObjectCollection<User>();
          private EditAbleFriend m_FriendToLookFor = new EditAbleFriend();
          private List<ISearchBy> m_SearchByList { get; set; }
           

            public StrategySearchFriends(EditAbleFriend i_FriendToLookFor, List<ISearchBy> i_SearchBy)
            {
                m_FriendToLookFor = i_FriendToLookFor;
                m_SearchByList = i_SearchBy;
            }

        public FacebookObjectCollection<User> GetFilteredFriends()
        {
           return m_FilteredFriends;
        }

            public void Search()
            {
              foreach (User friend in LogicServices.GetFriends())
              {
                bool searchOK = true;

                foreach (ISearchBy searcher in m_SearchByList)
                {
                    if(!searcher.SearchSucceded(friend, m_FriendToLookFor))
                    {
                        searchOK = false;
                    }
                }

                if(searchOK)
                {
                    m_FilteredFriends.Add(friend);
                }
              }
                
            }
            
        }

        /// a strategy implementation
        public class Gender : ISearchBy
        {
            public bool SearchSucceded(User i_CurrFriend, EditAbleFriend i_FriendToLookFor)
        {
                return i_CurrFriend.Gender == i_FriendToLookFor.Gender;
            }
        }

        public class FirstName : ISearchBy
        {
            public bool SearchSucceded(User i_CurrFriend, EditAbleFriend i_FriendToLookFor)
        {
                return i_CurrFriend.FirstName.Contains(i_FriendToLookFor.FirstName);
            }
        }

    public class LastName : ISearchBy
    {
        public bool SearchSucceded(User i_CurrFriend, EditAbleFriend i_FriendToLookFor)
        {
            return i_CurrFriend.LastName.Contains(i_FriendToLookFor.LastName);
        }
    }
}

