using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C18_Ex03_Logic
{
    public sealed class LogicManager
    {
        private CategoriesCounter m_CategoryCounter = null;
        public FacadeTopCategories Facade { get; set; }
        public MyUser LoggedInUser { get; set; }
        public List<EditAbleFriend> EditableFriends { get; set; }

        User m_User;
        // singleton -----
        private LogicManager() { }

        public static LogicManager LogicServices
        {
            get { return NestedHolder.instance; }
        }

        private class NestedHolder
        {
            internal static volatile LogicManager instance = new LogicManager();
        }
        // singleton end-----


        public bool loginAndInit()
        {
            LoggedInUser = new MyUser();

            LoginResult result = FacebookService.Login(
            "280166285895285",
            "public_profile",
            "user_friends",
            "user_gender",
            "user_birthday",
            "user_posts",
            "user_events",
            "user_hometown",
            "user_likes",
            "user_location",
            "user_photos",
            "user_posts",
            "user_tagged_places",
            "user_videos",
            "manage_pages",
            "publish_pages"
            );

            if (!string.IsNullOrEmpty(result.AccessToken))// If there is access token
            {
                LoggedInUser.User =  result.LoggedInUser;//Fill 'User' with data from 'Login Result'
                m_User = LoggedInUser.User;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetFirstName()
        {
            return m_User.FirstName;
        }
        public string GetLastName()
        {
            return m_User.LastName;
        }
        public string GetProfilePic()
        {
            return m_User.PictureNormalURL;
        }
        public string GetBirthday()
        {
            return m_User.Birthday;
        }
        public string GetHomeTown()
        {
            return m_User.Hometown.Name; ;
        }
        public string GetEmail()
        {
            return m_User.Email;
        }

        public int GetFriendsCount()
        {
            return m_User.Friends.Count;
        }
        public FacebookObjectCollection<User> GetFriends()
        {
            return m_User.Friends;
        }

        public int GetEventsCount()
        {
            return m_User.Events.Count;
        }
        public FacebookObjectCollection<Event> GetEvents()
        {
            return m_User.Events;
        }

        public int GetPostsTaggedInCount()
        {
            return m_User.PostsTaggedIn.Count;
        }
        public FacebookObjectCollection<Post> GetPostsTaggedIn()
        {
            return m_User.PostsTaggedIn;
        }

        public int GetLikedPagesCount()
        {
            return m_User.LikedPages.Count;
        }
        public FacebookObjectCollection<Page> GetLikedPages()
        {
            return m_User.LikedPages;
        }

        public int GetStatusesCount()
        {
            return m_User.Statuses.Count;
        }
        public FacebookObjectCollection<Status> GetStatuses()
        {
            return m_User.Statuses;
        }

        public int GetPhotosTaggedInCount()
        {
            return m_User.PhotosTaggedIn.Count;
        }
        public FacebookObjectCollection<Photo> GetPhotosTaggedIn()
        {
            return m_User.PhotosTaggedIn;
        }

        public bool PostStatus(String i_Status)
        {
            try
            {
                m_User.PostStatus(i_Status);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public FacebookObjectCollection<Album> GetAlbums()
        {
            return m_User.Albums;
        }

        public void buildEditAbleFriends()
        {
            EditableFriends = new List<EditAbleFriend>();

            foreach (User friend in m_User.Friends.ToList())
            {
                EditableFriends.Add(new EditAbleFriend(friend.FirstName, friend.LastName));
            }
        }

        public bool Logout()
        {
            if (LoggedInUser != null)
            {
                try
                {
                    LoggedInUser.notifyLogoutObservers();
                    FacebookService.Logout(null);
                    LoggedInUser = null;
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }



        public const int THREE = 3;
        public const int SIX = 6;

        public void createFacadeTopCategories(FacebookObjectCollection<User> i_Friends)
        {
            m_CategoryCounter = new CategoriesCounter();
            Facade = new FacadeTopCategories();

            CategoriesCounter.CategoryItem tempCategory;

            foreach (User friend in i_Friends)
            {
                foreach (Page likedPage in friend.LikedPages)
                {
                    for (int i = 0; i < SIX; i++)
                    {
                        if (likedPage.Category == m_CategoryCounter.CategoryList[i].Category)
                        {
                            m_CategoryCounter.CategoryList[i].incCounter();
                        }
                    }
                }
            }

            for (int i = 0; i < THREE; i++)
            {
                tempCategory = findMaxCategory();
                upadteFacade(tempCategory, i);
                m_CategoryCounter.CategoryList.Remove(tempCategory);
            }

        }

        private void upadteFacade(CategoriesCounter.CategoryItem tempCategory, int i)
        {
            switch (i)
            {
                case 0:
                    Facade.First = tempCategory.Category;
                    break;
                case 1:
                    Facade.Second = tempCategory.Category;
                    break;
                case 2:
                    Facade.Third = tempCategory.Category;
                    break;
            }
        }

        private CategoriesCounter.CategoryItem findMaxCategory()
        {
            CategoriesCounter.CategoryItem maxCategory = m_CategoryCounter.CategoryList[0];

            foreach (CategoriesCounter.CategoryItem category in m_CategoryCounter.CategoryList)
            {
                if (category.Counter > maxCategory.Counter)
                {
                    maxCategory = category;
                }
            }

            return maxCategory;
        }

        public int FindLikestPhotoIndex(Album i_OrgAlbum)
        {
            int sizeOfAlbum = i_OrgAlbum.Photos.Count;
            int maxLikes = -1;
            int retIndex = 0;

            for (int i = 0; i < sizeOfAlbum; i++)
            {
                if (i_OrgAlbum.Photos[i].LikedBy.Count > maxLikes)
                {
                    maxLikes = i_OrgAlbum.Photos[i].LikedBy.Count;
                    retIndex = i;
                }
            }

            return retIndex;
        }

        public List<ProxyAlbum> buildProxAlbumList(FacebookObjectCollection<Album> i_OrgAlbums)
        {
            List<ProxyAlbum> retProxyAlbumsList = new List<ProxyAlbum>();

            foreach (Album Orgalbum in i_OrgAlbums)
            {
                retProxyAlbumsList.Add(new ProxyAlbum(Orgalbum));
            }

            return retProxyAlbumsList;
        }

    }

}
