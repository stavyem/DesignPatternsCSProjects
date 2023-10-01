using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures.Logic
{
    internal struct FirstPhoto
    {
        public Photo Photo { get; set; }
        public eAlbumType AlbumType { get; set; }

        public enum eAlbumType
        {
            Profile,
            Cover,
            Wall,
            First
        }
    }

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
            foreach (Post post in getFirstStatusAndCheckIn()) 
            { 
                if (post.Place != null)
                {
                    FirstCheckIn = post;
                }
                if (post.Type == Post.eType.status && post.Message != null)
                {
                    FirstPostStatus = post;
                }
            }


            foreach (FirstPhoto firstPhoto in getAllFirstPhotosFromAlbums())
            {
                if (firstPhoto.Photo.PictureNormalURL != null)
                {
                    if (firstPhoto.AlbumType == FirstPhoto.eAlbumType.Profile)
                    {
                        FirstProfilePhoto = firstPhoto.Photo;
                    }
                    else if (firstPhoto.AlbumType == FirstPhoto.eAlbumType.First)
                    {
                        FirstCoverPhotoOfTheFirstAlbum = firstPhoto.Photo;
                    }
                    else if (firstPhoto.AlbumType == FirstPhoto.eAlbumType.Wall)
                    {
                        FirstWallPhoto = firstPhoto.Photo;
                    }
                    else
                    {
                        FirstCoverPhoto = firstPhoto.Photo;
                    }
                }
            }
        }

        private IEnumerable<Post> getFirstStatusAndCheckIn()
        {
            if (r_LoggedInUser.Posts != null)
            {
                foreach (Post post in r_LoggedInUser.Posts)
                {
                    Post.eType? postType = post.Type;

                    if (post.Place != null || postType == Post.eType.status)
                    {
                        yield return post;
                    }
                }
            }
        }

        private IEnumerable<FirstPhoto> getAllFirstPhotosFromAlbums()
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
                if (profilePhotoAlbum != null)
                {
                    FirstPhoto firstProfilePhoto = extractTheFirstPhotoFromAlbumIfExist(profilePhotoAlbum, FirstPhoto.eAlbumType.Profile);
                    yield return firstProfilePhoto;
                }
                if (theFirstAlbum != null)
                {
                    FirstPhoto firstCoverPhotoOfTheFirstAlbum = extractTheFirstPhotoFromAlbumIfExist(theFirstAlbum, FirstPhoto.eAlbumType.First);
                    yield return firstCoverPhotoOfTheFirstAlbum;
                }
                if (firstWallPhotoAlbum != null)
                {
                    FirstPhoto firstWallPhoto = extractTheFirstPhotoFromAlbumIfExist(firstWallPhotoAlbum, FirstPhoto.eAlbumType.Wall);
                    yield return firstWallPhoto;
                }
                if (coverPhotoAlbum != null)
                {
                    FirstPhoto firstCoverPhoto = extractTheFirstPhotoFromAlbumIfExist(coverPhotoAlbum, FirstPhoto.eAlbumType.Cover);
                    yield return firstCoverPhoto;
                }
            }
        }

        private FirstPhoto extractTheFirstPhotoFromAlbumIfExist(Album i_TheAlbum, 
                                                                FirstPhoto.eAlbumType i_AlbumType)
        {
            return new FirstPhoto { Photo = i_TheAlbum?.Photos.Last(), AlbumType = i_AlbumType };
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