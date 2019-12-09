using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Threading;
using System.Drawing;
using static C18_Ex03_Logic.LogicManager;

namespace C18_Ex03_Logic
{
    public class ProxyAlbum
    {
        private Album m_OrgAlbum = null;
        private int m_IndexOfTheLikestPhoto = -1;

        public ProxyAlbum(Album i_Album)
        {
            m_OrgAlbum = i_Album;
        }

        public Album OrgAlbum
        {
            get
            {
                return m_OrgAlbum;
            }
        }

        public int Index
        {
            get
            {
                if (m_IndexOfTheLikestPhoto == -1)
                {
                    m_IndexOfTheLikestPhoto = LogicServices.FindLikestPhotoIndex(m_OrgAlbum);
                }
                return m_IndexOfTheLikestPhoto;
            }
        }

        public Photo CoverPhoto()
        {
            if (m_IndexOfTheLikestPhoto == -1)
            {
                m_IndexOfTheLikestPhoto = LogicServices.FindLikestPhotoIndex(m_OrgAlbum);
            }

            return m_OrgAlbum.Photos[m_IndexOfTheLikestPhoto];
        }
    }
}
