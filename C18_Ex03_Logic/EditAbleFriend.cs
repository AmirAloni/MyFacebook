using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C18_Ex03_Logic
{
    public class EditAbleFriend
    {
        private string m_FirstName = null;
        private string m_FamilyName = null;
        public string FullName { get; set; }
        public User.eGender Gender { get; set; }

        public EditAbleFriend()
        {

        }
            public EditAbleFriend(string i_FirstName, string i_LastName)
        {
            m_FirstName = i_FirstName;
            m_FamilyName = i_LastName;
            FullName = m_FirstName + " " + m_FamilyName;
        }
        public string FirstName
        {
            get
            {
                return m_FirstName;
            }
            set
            {
                m_FirstName = value;
                FullName = FullName = m_FirstName + " " + m_FamilyName;
            }
        }

        public string LastName
        {
            get
            {
                return m_FamilyName;
            }
            set
            {
                m_FamilyName = value;
                FullName = m_FirstName + " " + m_FamilyName;

            }
        }

    }
}
