using BasicFacebookFeatures.Logic;
using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI
{
    public interface ICommand
    {
        void Execute();
    }

    public class LoginCommand : ICommand
    {
        private readonly FacebookUserData m_UserData;
        private readonly Action m_OnSuccessfulLogin;

        internal LoginCommand(FacebookUserData userData, Action onSuccessfulLogin)
        {
            m_UserData = userData;
            m_OnSuccessfulLogin = onSuccessfulLogin;
        }

        public void Execute()
        { 
            bool isSuccessfulLogin = m_UserData.LoginToFacebook();

            if (isSuccessfulLogin)
            {
                m_OnSuccessfulLogin?.Invoke();
            }
            else
            {
                MessageBox.Show(FacebookUserData.LoginResult.ErrorMessage, "Login Failed");
            }
        }
    }

    public class LoginAsDifferentUserCommand : ICommand
    {
        private readonly FacebookUserData m_UserData;
        private readonly Action m_OnSuccessfulLogin;

        internal LoginAsDifferentUserCommand(FacebookUserData userData, Action onSuccessfulLogin)
        {
            m_UserData = userData;
            m_OnSuccessfulLogin = onSuccessfulLogin;
        }

        public void Execute()
        {
            FacebookService.LogoutWithUI();
            m_UserData.IsValidAccessToken = false;
            bool isSuccessfulLogin = m_UserData.LoginToFacebook();

            if (isSuccessfulLogin)
            {
                m_OnSuccessfulLogin?.Invoke();
            }
            else
            {
                MessageBox.Show(FacebookUserData.LoginResult.ErrorMessage, "Login Failed");
            }

        }
    }

}
