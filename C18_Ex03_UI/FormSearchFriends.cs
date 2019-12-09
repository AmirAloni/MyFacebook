using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using C18_Ex03_Logic;
using static C18_Ex03_Logic.LogicManager;

namespace C18_Ex03_UI
{
    public partial class FormSearchFriends : Form
    {

        EditAbleFriend m_friendToLookFor = new EditAbleFriend();
        private List<ISearchBy> m_SearchByList = new List<ISearchBy>();
      

        public FormSearchFriends()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            listBoxFriendsListConditon.Items.Clear();
            listBoxFriendsListConditon.DisplayMember = "Name";
          
            initializeSearchParams();

            if (LogicServices.GetFriendsCount() == 0)
            {
                MessageBox.Show("Have no friends in list");
            }
            else
            {
                StrategySearchFriends searchStrategy = new StrategySearchFriends(m_friendToLookFor, m_SearchByList);
                searchStrategy.Search();

                foreach(User friend in searchStrategy.GetFilteredFriends())
                {
                    listBoxFriendsListConditon.Items.Add(friend);
                }
            }
        }

        private void initializeSearchParams()
        {
            // initialize relevant search object params 
            m_friendToLookFor.FirstName = textBoxFirstName.Text;
            m_friendToLookFor.LastName = textBoxLastName.Text;
            if (radioButtonMale.Checked)
            {
                m_friendToLookFor.Gender = User.eGender.male;
            }
            else
            {
                m_friendToLookFor.Gender = User.eGender.female;
            }

            //add relevant searches to list
            m_SearchByList.Add(new FirstName());
            m_SearchByList.Add(new LastName());
            m_SearchByList.Add(new Gender());
        }
  

        private void listBoxFriendsListConditon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriendsListConditon.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxFriendsListConditon.SelectedItem as User;
                pictureBoxFriendPicture.LoadAsync(selectedFriend.PictureNormalURL);
            }
        }
    }
}