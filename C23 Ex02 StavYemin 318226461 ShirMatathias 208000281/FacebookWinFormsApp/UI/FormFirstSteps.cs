using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using BasicFacebookFeatures.Logic;
using CefSharp.DevTools.CSS;

namespace BasicFacebookFeatures.UI
{
    internal partial class FormFirstSteps : Form
    {
        private FacebookUserData m_UserData;

        internal FormFirstSteps(FacebookUserData i_UserData)
        {
            InitializeComponent();
            m_UserData = i_UserData;
        }

        protected override void OnShown(EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            new Thread(populateAllExistingInfoToUI).Start();Cursor.Current = Cursors.Default;
        }

        private void loadPhotoInfoToPanel(Photo i_Photo, DateTimePicker i_DateTimePicker, PictureBox i_PictureBox)
        {
            if (i_Photo != null)
            {
                i_DateTimePicker.Invoke(new Action(() => i_DateTimePicker.Visible = true));
                i_DateTimePicker.Invoke(new Action(() => i_DateTimePicker.Value = (DateTime)i_Photo.CreatedTime)) ;
                i_PictureBox.Invoke(new Action(() => i_PictureBox.LoadAsync(i_Photo.PictureNormalURL)));
            }
        }

        private void setAllPhotosFromAlbums()
        {
            new Thread(() => loadPhotoInfoToPanel(m_UserData.FirstWallPhoto, dateTimePickerFirstWallPhoto, pictureBoxFirstWallPhoto)).Start() ;
            new Thread(() => loadPhotoInfoToPanel(m_UserData.FirstProfilePhoto, dateTimePickerFirstProfilePhoto, pictureBoxFirstProfilePhoto)).Start();
            new Thread(() => loadPhotoInfoToPanel(m_UserData.FirstCoverPhoto, dateTimePickerFirstCoverPhoto, pictureBoxFirstCoverPhoto)).Start();
            new Thread(() => loadPhotoInfoToPanel(m_UserData.FirstCoverPhotoOfTheFirstAlbum, dateTimePickerFirstPhotoInFirstAlbum, pictureBoxFirstPhotoInFirstAlbum)).Start();
        }

        private void setCheckIn()
        {
            Post firstCheckIn = m_UserData.FirstCheckIn;

            if (firstCheckIn.Place != null)
            {
                dateTimePickerFirstCheckIn.Invoke(new Action(() => dateTimePickerFirstCheckIn.Visible = true));
                dateTimePickerFirstCheckIn.Invoke(new Action(() => dateTimePickerFirstCheckIn.Value = (DateTime)firstCheckIn.CreatedTime));
                pictureBoxFirstCheckIn.Invoke(new Action(() => pictureBoxFirstCheckIn.LoadAsync(firstCheckIn.Place.PictureURL)));
                textBoxFirstCheckIn.Invoke(new Action(() => textBoxFirstCheckIn.Text = firstCheckIn.Place.Location.ToString()));
            }
        }

        private void setStatus()
        {
            Post firstPostStatus = m_UserData.FirstPostStatus;

            if (firstPostStatus != null)
            {
                dateTimePickerFirstPost.Invoke(new Action(() => dateTimePickerFirstPost.Visible = true));
                dateTimePickerFirstPost.Invoke(new Action(() => dateTimePickerFirstPost.Value = (DateTime)firstPostStatus.CreatedTime));
                textBoxFirstPost.Invoke(new Action(() => textBoxFirstPost.Text = firstPostStatus.Message));
            }
        }

        private void populateAllExistingInfoToUI()
        {
            new Thread(setAllPhotosFromAlbums).Start();
            new Thread(setStatus).Start();
            new Thread(setCheckIn).Start();
        }
    }
}
