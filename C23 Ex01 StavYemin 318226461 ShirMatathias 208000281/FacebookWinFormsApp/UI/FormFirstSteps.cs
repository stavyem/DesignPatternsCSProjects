using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using BasicFacebookFeatures.Logic;

namespace BasicFacebookFeatures.UI
{
    public partial class FormFirstSteps : Form
    {
        private readonly User r_LoggedInUser;
        private FacebookFirstSteps m_FacebookFirstPhases;

        public FormFirstSteps(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
        }

        protected override void OnShown(EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            m_FacebookFirstPhases = new FacebookFirstSteps(r_LoggedInUser);
            populateAllExistingInfoToUI();Cursor.Current = Cursors.Default;
        }

        private void loadPhotoInfoToPanel(Photo i_Photo, DateTimePicker i_DateTimePicker, PictureBox i_PictureBox)
        {
            if (i_Photo != null)
            {
                i_DateTimePicker.Visible = true;
                i_DateTimePicker.Value = (DateTime)i_Photo.CreatedTime;
                i_PictureBox.LoadAsync(i_Photo.PictureNormalURL);
            }
        }

        private void setAllPhotosFromAlbums()
        {
            loadPhotoInfoToPanel(m_FacebookFirstPhases.FirstWallPhoto, dateTimePickerFirstWallPhoto, pictureBoxFirstWallPhoto);
            loadPhotoInfoToPanel(m_FacebookFirstPhases.FirstProfilePhoto, dateTimePickerFirstProfilePhoto, pictureBoxFirstProfilePhoto);
            loadPhotoInfoToPanel(m_FacebookFirstPhases.FirstCoverPhoto, dateTimePickerFirstCoverPhoto, pictureBoxFirstCoverPhoto);
            loadPhotoInfoToPanel(m_FacebookFirstPhases.FirstCoverPhotoOfTheFirstAlbum, dateTimePickerFirstPhotoInFirstAlbum, pictureBoxFirstPhotoInFirstAlbum);
        }

        private void setCheckIn()
        {
            Post firstCheckIn = m_FacebookFirstPhases.FirstCheckIn;

            if (firstCheckIn.Place != null)
            {
                this.dateTimePickerFirstCheckIn.Visible = true;
                this.dateTimePickerFirstCheckIn.Value = (DateTime)firstCheckIn.CreatedTime;
                this.pictureBoxFirstCheckIn.LoadAsync(firstCheckIn.Place.PictureURL);
                this.textBoxFirstCheckIn.Text = firstCheckIn.Place.Location.ToString();
            }
        }

        private void setStatus()
        {
            Post firstPostStatus = m_FacebookFirstPhases.FirstPostStatus;

            if (firstPostStatus != null)
            {
                this.dateTimePickerFirstPost.Visible = true;
                this.dateTimePickerFirstPost.Value = (DateTime)firstPostStatus.CreatedTime;
                this.textBoxFirstPost.Text = firstPostStatus.Message;
            }
        }

        private void populateAllExistingInfoToUI()
        {
            setAllPhotosFromAlbums();
            setStatus();
            setCheckIn();
        }
    }
}
