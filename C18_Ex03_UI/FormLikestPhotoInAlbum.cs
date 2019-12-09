using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using C18_Ex03_Logic;
using static C18_Ex03_Logic.LogicManager;

namespace C18_Ex03_UI
{
    public partial class FormLikestPhotoInAlbum : Form
    {
        private List<ProxyAlbum> m_ProxAlbums = null;

        public FormLikestPhotoInAlbum()
        {
            InitializeComponent();
            buttonExit.Enabled = true;
            m_ProxAlbums = LogicServices.buildProxAlbumList(LogicServices.GetAlbums());
            fillListBoxWithProxyAlbums();
        }

        private void fillListBoxWithProxyAlbums()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";

            foreach (ProxyAlbum ProxAlbum in m_ProxAlbums)
            {
                listBoxAlbums.Items.Add(ProxAlbum);
            }

        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxAlbums.Items.Count == 1)
            {
                ProxyAlbum selectedAlbum = listBoxAlbums.SelectedItem as ProxyAlbum;
                pictureBoxTopLikePhoto.LoadAsync(selectedAlbum.CoverPhoto().PictureNormalURL);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}