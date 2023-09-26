using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using BasicFacebookFeatures.Logic;
using BasicFacebookFeatures.UI;

namespace BasicFacebookFeatures.FacebookUI
{
    internal partial class FormMain : Form
    {
        private Form m_FormFacebookButton = null;
        private FacebookUserData m_UserData;
        internal bool LogoutButtonClicked { get; private set; }

        internal FormMain(FacebookUserData i_UserData)
        {
            InitializeComponent();
            LogoutButtonClicked = false;
            FacebookService.s_CollectionLimit = 100;
            m_UserData = i_UserData;
            loadUserPhotos();
        }

        private void loadUserPhotos()
        {
            pictureBoxProfile.LoadAsync(m_UserData.ProfilePicture);
            loadCoverPhoto();
        }

        private void loadCoverPhoto()
        {
            Album coverAlbum = FacebookUserData.CoverPhotosAlbum;

            if (coverAlbum != null)
            {
                pictureBoxCoverPhoto.LoadAsync(coverAlbum.Photos[0].PictureNormalURL);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LogoutButtonClicked = true;
            FacebookService.LogoutWithUI();
            FormLogin.RememberUserInPrevSession = false;
            this.Close();
        }

        private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(loadPosts).Start();
        }

        private void loadPosts()
        {
            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));

            foreach (Post post in m_UserData.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Caption)));
                }
                else
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(string.Format("[{0}]", post.Type))));
                }
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void linkAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadAlbums();
        }

        private void loadAlbums()
        {
            albumBindingSource.DataSource = m_UserData.Albums;
        }

        private void labelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(loadEvents).Start();
        }

        private void loadEvents()
        {
            listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Clear()));
            listBoxEvents.Invoke(new Action(() => listBoxEvents.DisplayMember = "Name"));
            foreach (Event fbEvent in m_UserData.Events)
            {
                listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Add(fbEvent)));
            }

            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private void linkLabelFetchGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(loadGroups).Start();
        }

        private void loadGroups()
        {
            listBoxGroups.Invoke(new Action(() => listBoxGroups.Items.Clear()));
            listBoxGroups.Invoke(new Action(() => listBoxGroups.DisplayMember = "Name"));
            try
            {
                foreach (Group group in m_UserData.Groups)
                {
                    listBoxGroups.Invoke(new Action(() => listBoxGroups.Items.Add(group)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }

        private void linkLabelLikedPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(loadLikedPages).Start();
        }

        private void loadLikedPages()
        {
            listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.Items.Clear()));
            listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.DisplayMember = "Name"));

            try
            {
                foreach (Page page in m_UserData.LikedPages)
                {
                    listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.Items.Add(page)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxLikedPages.Items.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(");
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected = m_UserData.Posts[listBoxPosts.SelectedIndex];

            listBoxPostComments.DisplayMember = "Message";
            listBoxPostComments.DataSource = selected.Comments;
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxEvents.SelectedItem as Event;

                pictureBoxEvent.LoadAsync(selectedEvent.Cover.SourceURL);
            }
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItems.Count == 1)
            {
                Group selectedGroup = listBoxGroups.SelectedItem as Group;

                pictureBoxGroup.LoadAsync(selectedGroup.PictureNormalURL);
            }
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLikedPages.SelectedItems.Count == 1)
            {
                Page selectedPage = listBoxLikedPages.SelectedItem as Page;

                if (selectedPage.PictureURL != null)
                {
                    pictureBoxLikedPages.LoadAsync(selectedPage.PictureURL);
                }
            }
        }

        private void buttonFacebook_Click(object sender, EventArgs e)
        {
            m_FormFacebookButton = FormFactory.CreateForm((sender as Button)?.Tag as string);
            m_FormFacebookButton.ShowDialog();
        }
    }
}
