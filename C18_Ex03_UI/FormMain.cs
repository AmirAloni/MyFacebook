using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Threading;
using static C18_Ex03_Logic.LogicManager;
using C18_Ex03_Logic;

namespace C18_Ex03_UI
{
    public partial class FormMain : Form
    {
        private int TaggedPhotosIndex = 0;
        private List<Photo> TaggedPhotos = null;
        Thread m_SlideThread = null;

        private enum eFormMain
        {
            NumberOfTaggedPictures = 4
        }

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Height = 675;
            this.Width = 940;

            panelBinding.Hide();
            myButtonEndSlideShow.Hide();
        }



        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (LogicServices.loginAndInit())
            {
                buttonLogIn.Enabled = false;
                fetchUserInfo();
                addLoginLogoutObservers();
                LogicServices.LoggedInUser.notifyLoginObservers();
            }
            else
            {
                MessageBox.Show("Error while trying to login");//Error while trying to login
            }

        }


        //Fetch All user info required
        private void fetchUserInfo()
        {
            fetchPersonalInformation();
            fetchFriendsList();
            fetchEventsList();
            fetchTaggedPosts();
            fetchLikedPages();
            fetchStatuses();
            FetchTaggedPhotos();
        }

        private void addLoginLogoutObservers()
        {
            buttonLogOut.AddMe(LogicServices.LoggedInUser);
            buttonLikestPhotoInAlbum.AddMe(LogicServices.LoggedInUser);
            buttonPostStatus.AddMe(LogicServices.LoggedInUser);
            buttonMostPopularPagesF.AddMe(LogicServices.LoggedInUser);
            buttonNext.AddMe(LogicServices.LoggedInUser);
            buttonPrev.AddMe(LogicServices.LoggedInUser);

            listBoxEvents.AddMe(LogicServices.LoggedInUser);
            listBoxTaggedPosts.AddMe(LogicServices.LoggedInUser);
            listBoxLikedPages.AddMe(LogicServices.LoggedInUser);
            listBoxStatuses.AddMe(LogicServices.LoggedInUser);
            listBoxFriendsList.AddMe(LogicServices.LoggedInUser);
            listBoxBinding.AddMe(LogicServices.LoggedInUser);

            textBoxPostStatus.AddMe(LogicServices.LoggedInUser);
            firstNameTextBox.AddMe(LogicServices.LoggedInUser);
            lastNameTextBox.AddMe(LogicServices.LoggedInUser);
        }

        //fetch Personal Information
        private void fetchPersonalInformation()
        {
            new Thread(fillPersonalInformation).Start();
        }
        private void fillPersonalInformation()
        {
            labelPrivateName.Invoke(new Action(() => labelPrivateName.Text = LogicServices.GetFirstName()));
            labelFamilyName.Invoke(new Action(() => labelFamilyName.Text = LogicServices.GetLastName()));
            pictureBoxProfilePicture.Invoke(new Action(() => pictureBoxProfilePicture.LoadAsync(LogicServices.GetProfilePic())));
            labelBirthday.Invoke(new Action(() => labelBirthday.Text = LogicServices.GetBirthday()));
            labelEmail.Invoke(new Action(() => labelEmail.Text = LogicServices.GetEmail()));
        }

        //Fetch Friends
        private void fetchFriendsList()
        {
            listBoxFriendsList.Items.Clear();

            if (LogicServices.GetFriendsCount() > 0)
            {
                enabelFriendsCommands();
                new Thread(fillListBoxFriends).Start();
            }
            else
            {
                MessageBox.Show("No Friends");
            }
        }
        private void fillListBoxFriends()
        {
            listBoxFriendsList.DisplayMember = "Name";

            foreach (User friend in LogicServices.GetFriends())
            {
                listBoxFriendsList.Invoke(new Action(() => listBoxFriendsList.Items.Add(friend)));
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }
        }

        private void enabelFriendsCommands()
        {
            buttonSearchFriends.Enabled = true;
            buttonEditFriendsNames.Enabled = true;
        }
   

        //Fetch Events
        private void fetchEventsList()
        {
            listBoxEvents.Items.Clear();

            if (LogicServices.GetEventsCount() > 0)
            {
                new Thread(fillListBoxEvents).Start();
            }
            
        }
        private void fillListBoxEvents()
        {
            listBoxEvents.DisplayMember = "Name";

            foreach (Event userEvent in LogicServices.GetEvents())
            {
                listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Add(userEvent)));
                userEvent.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }
        }

        //Fetch Tagged Posts
        private void fetchTaggedPosts()
        {
            listBoxTaggedPosts.Items.Clear();
            if (LogicServices.GetPostsTaggedInCount() > 0)
            {
                new Thread(fillListBoxTaggedPost).Start();
            }
            else
            {
                MessageBox.Show("No Posts Tagged In");
            }
        }
        private void fillListBoxTaggedPost()
        {
            listBoxTaggedPosts.DisplayMember = "Name";
            foreach (Post post in LogicServices.GetPostsTaggedIn())
            {
                if (post.Place != null)
                {
                    listBoxTaggedPosts.Invoke(new Action(() => listBoxTaggedPosts.Items.Add(post)));
                }
            }
        }

        //Fetch Liked Pages
        private void fetchLikedPages()
        {
            listBoxLikedPages.Items.Clear();

            if (LogicServices.GetLikedPagesCount() > 0)
            {
                new Thread(fillListBoxLikedPages).Start();
            }
            else
            {

            }
        }
        private void fillListBoxLikedPages()
        {
            listBoxLikedPages.DisplayMember = "Name";

            foreach (Page page in LogicServices.GetLikedPages())
            {
                listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.Items.Add(page)));
            }
        }

        //Post Status
        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            new Thread(PostStatus).Start();
        }
        private void PostStatus()
        {
            if (textBoxPostStatus.Text != string.Empty)
            {
                if (LogicServices.PostStatus(textBoxPostStatus.Text))
                {
                    MessageBox.Show("Status Posted!");
                    textBoxPostStatus.Invoke(new Action(() => textBoxPostStatus.Text = string.Empty));
                }
                else
                {
                    MessageBox.Show("Error while posting status");
                }
            }
            else
            {
                MessageBox.Show("Status is empty, write something");
            }
        }

        //Browse through photos of the user
        private void FetchTaggedPhotos()
        {
            myButtonEndSlideShow.Invoke(new Action(() => myButtonEndSlideShow.Hide()));

            if (LogicServices.GetPhotosTaggedInCount() > 0)
            {
                myButtonSlideShow.Enabled = true;
                new Thread(fillPictureBoxTaggedPhotos).Start();
            }
        }

        private void fillPictureBoxTaggedPhotos()
        {
            TaggedPhotos = LogicServices.GetPhotosTaggedIn().ToList();
            pictureBoxMyPicture.Invoke(new Action(() => pictureBoxMyPicture.LoadAsync(TaggedPhotos[TaggedPhotosIndex].PictureNormalURL)));
        }

        //Fetch Statuses
        private void fetchStatuses()
        {
            if (LogicServices.GetStatusesCount() > 0)
            {
                new Thread(fillListBoxStatuses).Start();
            }
        }
        private void fillListBoxStatuses()
        {
            foreach (Status status in LogicServices.GetStatuses())
            {
                if (status.Message != null)
                {
                    listBoxStatuses.Invoke(new Action(() => listBoxStatuses.Items.Add(status.Message)));
                }
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void logout()
        {
            if (LogicServices.Logout())
            {
                clearFormCommands();
                MessageBox.Show("You are Logged out");
            }
            else
            {
                MessageBox.Show("Error logging out");
            }


        }

        private void clearFormCommands()
        {
            buttonLogIn.Enabled = true;

            myButtonSlideShow.Enabled = false;
            buttonSearchFriends.Enabled = false;
            buttonEditFriendsNames.Enabled = false;
            panelBinding.Enabled = false;

            pictureBoxProfilePicture.Image = null;
            pictureBoxFriendPicture.Image = null;
            pictureBoxEventPicture.Image = null;
            pictureBoxMyPicture.Image = null;

            labelPrivateName.Text = "-";
            labelFamilyName.Text = "-";
            labelBirthday.Text = "-";
            labelGender.Text = "-";
            labelEmail.Text = "-";

            panelBinding.Hide();
            panelBinding.Enabled = false;
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxEvents.SelectedItem as Event;
                pictureBoxEventPicture.LoadAsync(selectedEvent.PictureNormalURL);
            }
        }

        private void listBoxFriendsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriendsList.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxFriendsList.SelectedItem as User;
                pictureBoxFriendPicture.LoadAsync(selectedFriend.PictureNormalURL);
            }
        }

        private void buttonSearchFriends_Click(object sender, EventArgs e)
        {
            FormSearchFriends formSearchFriends = new FormSearchFriends();
            formSearchFriends.StartPosition = FormStartPosition.CenterParent;
            formSearchFriends.ShowDialog();
        }

        private void buttonMostPopularPagesF_Click(object sender, EventArgs e)
        {
            if (LogicServices.GetFriendsCount() < 3)
            {
                MessageBox.Show("You have less then three friends, sorry");
            }
            else
            {
                FormTopCategories formCategory = new FormTopCategories();
                formCategory.StartPosition = FormStartPosition.CenterParent;
                formCategory.ShowDialog();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (TaggedPhotos != null)
            {
                if (TaggedPhotosIndex + 1 < TaggedPhotos.Count)
                {
                    TaggedPhotosIndex++;
                    pictureBoxMyPicture.LoadAsync(TaggedPhotos[TaggedPhotosIndex].PictureNormalURL);
                }
            }
        }


        private void buttonLikestPhotoInAlbum_Click(object sender, EventArgs e)
        {
            if ((LogicServices.GetAlbums()).Count == 0)
            {
                MessageBox.Show("You don't have any albums, sorry");
            }
            else
            {
                FormLikestPhotoInAlbum formAlbumsListBox = new FormLikestPhotoInAlbum();
                formAlbumsListBox.StartPosition = FormStartPosition.CenterParent;
                formAlbumsListBox.ShowDialog();
            }
        }

        private void buttonEditFriendsNames_Click(object sender, EventArgs e)
        {
            panelBinding.Show();
            panelBinding.Enabled = true;
            LogicServices.buildEditAbleFriends();
            editAbleFriendBindingSource.DataSource = LogicServices.EditableFriends;
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (TaggedPhotos != null)
            {
                if (TaggedPhotosIndex - 1 >= 0)
                {
                    TaggedPhotosIndex--;
                    pictureBoxMyPicture.LoadAsync(TaggedPhotos[TaggedPhotosIndex].PictureNormalURL);
                }
            }
        }

        private void myButtonDone_Click(object sender, EventArgs e)
        {
            panelBinding.Enabled = false;
            panelBinding.Hide();
        }

        private void myButtonSlideShow_Click(object sender, EventArgs e)
        {
            myButtonEndSlideShow.Show();
            m_SlideThread = new Thread(startSlideShow);
            m_SlideThread.Start();
        }

        private void startSlideShow()
        {
            MyPhotoList photoSlideShow = new MyPhotoList();
            photoSlideShow.TaggedPhotos = LogicServices.GetPhotosTaggedIn().ToList();

            foreach (Photo photo in photoSlideShow)
            {
                pictureBoxMyPicture.LoadAsync(photo.PictureNormalURL);
                Thread.Sleep(2500);
            }
            FetchTaggedPhotos();
        }

        private void myButtonEndSlideShow_Click(object sender, EventArgs e)
        {
            if(m_SlideThread.IsAlive)
            {
                m_SlideThread.Abort();
            }
            FetchTaggedPhotos();
        }
    }
    }



