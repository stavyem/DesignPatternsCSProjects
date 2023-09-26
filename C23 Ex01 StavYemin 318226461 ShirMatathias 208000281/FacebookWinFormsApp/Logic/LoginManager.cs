using System;
using FacebookWrapper;

namespace BasicFacebookFeatures.Logic
{
    public sealed class LoginManager
    {
        public LoginResult LoginResult { get; private set; }

        public bool IsValidAccessToken { get; set; }

        public AppSettings AppSettings { get; set; }

        public LoginManager()
        {
            LoginResult = null;
            AppSettings = null;
            IsValidAccessToken = false;
        }

        public void SaveAppSettings(bool i_IsRememberMeChecked)
        {
            AppSettings.RememberUser = i_IsRememberMeChecked;
            AppSettings.LastAccessToken = i_IsRememberMeChecked ? LoginResult.AccessToken : null;

            try
            {
                AppSettings.SaveToFile();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool LoadAppSettingsIfExists()
        {
            AppSettings = AppSettings.LoadFromFile();
            if (AppSettings.RememberUser && !string.IsNullOrEmpty(AppSettings.LastAccessToken))
            {
                LoginResult = FacebookService.Connect(AppSettings.LastAccessToken);
                IsValidAccessToken = !string.IsNullOrEmpty(LoginResult.AccessToken);
            }

            return IsValidAccessToken;
        }

        public bool LoginToFacebook()
        {
            return IsValidAccessToken ? loginWithExistToken() : loginWithNewToken();
        }

        private bool loginWithExistToken()
        {
            LoginResult = FacebookService.Connect(LoginResult.AccessToken);

            return !string.IsNullOrEmpty(LoginResult.AccessToken);
        }

        private bool loginWithNewToken()
        {
            LoginResult = FacebookService.Login(
                    "1956996001345439",
                    "email",
                    "public_profile",
                    "user_events",
                    "user_friends",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos",
                    "user_birthday",
                    "user_gender",
                    "user_hometown");

            return !string.IsNullOrEmpty(LoginResult.AccessToken);
        }
    }
}
