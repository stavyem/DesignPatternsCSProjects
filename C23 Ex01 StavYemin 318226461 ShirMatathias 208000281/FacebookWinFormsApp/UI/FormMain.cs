using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using BasicFacebookFeatures.Logic;
using BasicFacebookFeatures.UI;

namespace BasicFacebookFeatures.FacebookUI
{
    public partial class FormMain : Form
    {
        private readonly User r_LoggedInUser = null;
        private FormFirstSteps m_FormFacebookFirstPhases = null;
        private FormFavouritePlaces m_FormFavouritePlaces = null;

        public bool LogoutButtonClicked { get; private set; }

        public FormMain(User i_LoggedInUser)
        {
            InitializeComponent();
            LogoutButtonClicked = false;
            FacebookService.s_CollectionLimit = 100;
            r_LoggedInUser = i_LoggedInUser;
            loadUserPhotos();
        }

        private void loadUserPhotos()
        {
            pictureBoxProfile.LoadAsync(r_LoggedInUser.PictureNormalURL);
            loadCoverPhoto();
        }

        private void loadCoverPhoto()
        {
            Album coverAlbum = FacebookFirstSteps.FetchCoverPhotosAlbum(r_LoggedInUser);

            if (coverAlbum != null)
            {
                pictureBoxCoverPhoto.LoadAsync(coverAlbum.Photos[0].PictureNormalURL);
            }
            else
            {
                pictureBoxCoverPhoto.Image = Properties.Resources.noDataFound;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LogoutButtonClicked = true;
            FacebookService.LogoutWithUI();
            this.Close();
        }

        private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadPosts();
        }

        private void loadPosts()
        {
            listBoxPosts.Items.Clear();

            foreach (Post post in r_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
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
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";
            foreach (Album album in r_LoggedInUser.Albums)
            {
                listBoxAlbums.Items.Add(album);
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
        }

        private void labelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadEvents();
        }

        private void loadEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in r_LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(fbEvent);
            }

            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private void linkLabelFetchGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadGroups();
        }

        private void loadGroups()
        {
            listBoxGroups.Items.Clear();
            listBoxGroups.DisplayMember = "Name";
            try
            {
                foreach (Group group in r_LoggedInUser.Groups)
                {
                    listBoxGroups.Items.Add(group);
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadLikedPages();
        }

        private void loadLikedPages()
        {
            listBoxLikedPages.Items.Clear();
            listBoxLikedPages.DisplayMember = "Name";

            try
            {
                foreach (Page page in r_LoggedInUser.LikedPages)
                {
                    listBoxLikedPages.Items.Add(page);
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
            Post selected = r_LoggedInUser.Posts[listBoxPosts.SelectedIndex];

            listBoxPostComments.DisplayMember = "Message";
            listBoxPostComments.DataSource = selected.Comments;
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;

                if (selectedAlbum.PictureAlbumURL != null)
                {
                    pictureBoxAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    pictureBoxProfile.Image = pictureBoxProfile.ErrorImage;
                }
            }
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
                else
                {
                    pictureBoxLikedPages.Image = Properties.Resources.noDataFound;
                }
            }
        }

        private void buttonFirstStepsOnFacebook_Click(object sender, EventArgs e)
        {
            if (m_FormFacebookFirstPhases == null)
            {
                m_FormFacebookFirstPhases = new FormFirstSteps(r_LoggedInUser);
            }

            m_FormFacebookFirstPhases.ShowDialog();
        }

        private void buttonFavouritePlaces_Click(object sender, EventArgs e)
        {
            if (m_FormFavouritePlaces == null)
            {
                m_FormFavouritePlaces = new FormFavouritePlaces(r_LoggedInUser);
            }

            m_FormFavouritePlaces.ShowDialog();
        }
    }
}
