using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Logic
{
    internal class FacebookUserData
    {
        private LoginManager m_LoginManager = new LoginManager();

        internal FacebookObjectCollection<Post> Posts
        {
            get
            {
                return LoginManager.LoginResult?.LoggedInUser.Posts;
            }
        }

        internal FacebookObjectCollection<Album> Albums
        {
            get
            {
                return LoginManager.LoginResult?.LoggedInUser.Albums;
            }
        }

        internal FacebookObjectCollection<Event> Events
        {
            get
            {
                return LoginManager.LoginResult?.LoggedInUser.Events;
            }
        }

        internal FacebookObjectCollection<Group> Groups
        {
            get
            {
                return LoginManager.LoginResult?.LoggedInUser.Groups;
            }
        }

        internal FacebookObjectCollection<Page> LikedPages
        {
            get
            {
                return LoginManager.LoginResult?.LoggedInUser.LikedPages;
            }
        }

        internal Post FirstCheckIn
        {
            get
            {
                return FacebookFirstSteps.Instance.FirstCheckIn;
            }
        }

        internal Post FirstPostStatus
        {
            get
            {
                return FacebookFirstSteps.Instance.FirstPostStatus;
            }

        }

        internal Photo FirstCoverPhoto 
        {
            get
            {
                return FacebookFirstSteps.Instance.FirstCoverPhoto;
            }
        }

        internal Photo FirstProfilePhoto
        {
            get
            {
                return FacebookFirstSteps.Instance.FirstProfilePhoto;
            }
        }

        internal Photo FirstCoverPhotoOfTheFirstAlbum
        {
            get
            {
                return FacebookFirstSteps.Instance.FirstCoverPhotoOfTheFirstAlbum;
            }
        }

        internal Photo FirstWallPhoto
        {
            get
            {
                return FacebookFirstSteps.Instance.FirstWallPhoto;
            }
        }

        internal static Album CoverPhotosAlbum
        {
            get
            {
                return FacebookFirstSteps.FetchCoverPhotosAlbum(LoginManager.LoginResult?.LoggedInUser);
            }
            
        }

        internal string ProfilePicture
        {
            get
            {
                return LoginManager.LoginResult?.LoggedInUser.PictureNormalURL;
            }
        }

        internal static Dictionary<string, int> FavouritePlaces
        {
            get
            {
                return Logic.FavouritePlaces.GetFavouritePlaces(LoginManager.LoginResult?.LoggedInUser);
            }
        }

        internal static LoginResult LoginResult
        {
            get
            {
                return LoginManager.LoginResult;
            }
        }

        internal bool IsValidAccessToken
        {
            get
            {
                return m_LoginManager.IsValidAccessToken;
            }
            set
            {
                value = m_LoginManager.IsValidAccessToken;
            }
        }

        internal bool LoadAppSettingsIfExists()
        {
            return m_LoginManager.LoadAppSettingsIfExists();
        }

        internal bool LoginToFacebook()
        {
            return m_LoginManager.LoginToFacebook();
        }

        internal void SaveAppSettings(bool i_IsRememberMeChecked)
        {
            m_LoginManager.SaveAppSettings(i_IsRememberMeChecked);
        }
    }
}
