using FacebookWrapper.ObjectModel;
using System.Linq;

namespace BasicFacebookFeatures.Logic
{
    public class FacebookFirstSteps
    {
        private readonly User r_LoggedInUser;
        private static bool s_IsFirstTry = true;
        private static Album s_CoverAlbum;

        public Post FirstCheckIn { get; private set; }

        public Post FirstPostStatus { get; private set; }

        public Photo FirstCoverPhoto { get; private set; }

        public Photo FirstProfilePhoto { get; private set; }

        public Photo FirstCoverPhotoOfTheFirstAlbum { get; private set; }

        public Photo FirstWallPhoto { get; private set; }

        public FacebookFirstSteps(User i_User)
        {
            r_LoggedInUser = i_User;
            GetFirstInfoItems(r_LoggedInUser);
        }

        public void GetFirstInfoItems(User i_User)
        {
            FirstCheckIn = i_User.Checkins?.Last();
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

        public static Album FetchCoverPhotosAlbum(User i_LoggedInUser)
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
