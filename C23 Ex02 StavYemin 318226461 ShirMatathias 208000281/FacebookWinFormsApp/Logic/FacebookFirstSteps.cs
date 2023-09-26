using FacebookWrapper.ObjectModel;
using System.Linq;

namespace BasicFacebookFeatures.Logic
{
    internal sealed class FacebookFirstSteps
    {
        private readonly User r_LoggedInUser;
        private static bool s_IsFirstTry = true;
        private static Album s_CoverAlbum;

        internal Post FirstCheckIn { get; private set; }
        internal Post FirstPostStatus { get; private set; }
        internal Photo FirstCoverPhoto { get; private set; }
        internal Photo FirstProfilePhoto { get; private set; }
        internal Photo FirstCoverPhotoOfTheFirstAlbum { get; private set; }
        internal Photo FirstWallPhoto { get; private set; }
        private static FacebookFirstSteps s_Instance;
        private static readonly object sr_LockObject = new object();

        private FacebookFirstSteps()
        {
            r_LoggedInUser = LoginManager.LoginResult?.LoggedInUser;
            getFirstInfoItems(r_LoggedInUser);
        }

        internal static FacebookFirstSteps Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_LockObject)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new FacebookFirstSteps();
                        }
                    }
                }

                return s_Instance;
            }
        }

        private void getFirstInfoItems(User i_User)
        {
            getFirstStatusAndCheckIn();
            getAllFirstPhotosFromAlbums();
        }

        private void getFirstStatusAndCheckIn()
        {
            if (r_LoggedInUser.Posts != null)
            {
                foreach (Post post in r_LoggedInUser.Posts)
                {
                    Post.eType? postType = post.Type;

                    if (post.Place != null)
                    {
                        FirstCheckIn = post;
                    }
                    else if (postType == Post.eType.status)
                    {
                        FirstPostStatus = post;
                    }
                }
            }
        }

        private void getAllFirstPhotosFromAlbums()
        {
            if (r_LoggedInUser.Albums != null)
            {
                Album coverPhotoAlbum = FetchCoverPhotosAlbum(r_LoggedInUser);
                Album profilePhotoAlbum = null;
                Album theFirstAlbum = null;
                Album firstWallPhotoAlbum = null;

                foreach (Album album in r_LoggedInUser.Albums)
                {
                    if (album.Photos.Count == 0)
                    {
                        continue;
                    }

                    switch (album.Type)
                    {
                        case Album.eType.Profile:
                            profilePhotoAlbum = album;
                            break;
                        case Album.eType.Wall:
                            firstWallPhotoAlbum = album;
                            break;
                        case Album.eType.Normal:
                            theFirstAlbum = album;
                            break;
                    }
                }

                FirstCoverPhoto = extractTheFirstPhotoFromAlbumIfExist(coverPhotoAlbum);
                FirstProfilePhoto = extractTheFirstPhotoFromAlbumIfExist(profilePhotoAlbum);
                FirstCoverPhotoOfTheFirstAlbum = extractTheFirstPhotoFromAlbumIfExist(theFirstAlbum);
                FirstWallPhoto = extractTheFirstPhotoFromAlbumIfExist(firstWallPhotoAlbum);
            }
        }

        private Photo extractTheFirstPhotoFromAlbumIfExist(Album i_TheAlbum)
        {
            return i_TheAlbum?.Photos.Last();
        }

        internal static Album FetchCoverPhotosAlbum(User i_LoggedInUser)
        {

            if (s_IsFirstTry)
            {
                foreach (Album album in i_LoggedInUser.Albums)
                {
                    if (album.Count > 0 && album.Name == "Cover photos" || album.Name == "תמונות נושא")
                    {
                        s_CoverAlbum = album;
                        break;
                    }
                }

                s_IsFirstTry = false;
            }

            return s_CoverAlbum;
        }
    }
}
