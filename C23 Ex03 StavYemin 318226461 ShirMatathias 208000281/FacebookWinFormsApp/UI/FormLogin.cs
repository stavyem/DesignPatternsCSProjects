using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures.Logic;
using BasicFacebookFeatures.FacebookUI;
using FacebookWrapper;

namespace BasicFacebookFeatures.UI
{
    internal partial class FormLogin : Form
    {
        private const string k_LoginAsUserPlaceholder = "Continue as {0}";
        private const bool k_NewLoginToken = true;
        private FacebookUserData m_UserData;
        private ICommand m_LoginCommand;
        private ICommand m_LoginAsDifferentUser;

        internal static bool RememberUserInPrevSession { get; set; }
        internal Form FormMain { get; private set; }
        private bool ExitFormMainWithLogoutButton { get; set; }

        internal FormLogin(FacebookUserData i_UserData)
        {
            InitializeComponent();
            m_UserData = i_UserData;
            RememberUserInPrevSession = false;
            ExitFormMainWithLogoutButton = true;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            checkBoxRememberMe.Checked = m_UserData.LoadAppSettingsIfExists();
            RememberUserInPrevSession = checkBoxRememberMe.Checked;

            if (RememberUserInPrevSession)
            {
                populateUIToLogginWithExistToken();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            try
            {
                m_UserData.SaveAppSettings(checkBoxRememberMe.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Execute the login command
            m_LoginCommand = new LoginCommand(m_UserData, initiateFacebookFormAfterLogin);
            m_LoginCommand.Execute();
        }

        private void buttonLoginAsDifferentUser_Click(object sender, EventArgs e)
        {
            // Execute the login command
            m_LoginAsDifferentUser = new LoginAsDifferentUserCommand(m_UserData, initiateFacebookFormAfterLogin);
            m_LoginAsDifferentUser.Execute();
        }

        private void initiateFacebookFormAfterLogin()
        {
            FormMain = FormFactory.CreateForm("Main");
            switchForms();
        }

        private void switchForms()
        {
            Visible = false;
            FormMain.ShowDialog();
            ExitFormMainWithLogoutButton = (FormMain as FormMain).LogoutButtonClicked;
            FormMain.Dispose();
            Visible = true;
        }

        private void FormLogin_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                 RememberUserInPrevSession = checkBoxRememberMe.Checked;
            }
            else
            {
                doWhenFormIsVisible();
            }
        }

        private void doWhenFormIsVisible()
        {
            if (RememberUserInPrevSession || !ExitFormMainWithLogoutButton)
            {
                populateUIToLogginWithExistToken();
            }
            else
            {
                initializeUIToInitialState();
            }
        }

        private void initializeUIToInitialState()
        {
            checkBoxRememberMe.Checked = false;
            changingButtonVisibility(k_NewLoginToken);
        }

        private void populateUIToLogginWithExistToken()
        {
            pictureBoxProfilePhoto.LoadAsync(FacebookUserData.LoginResult.LoggedInUser.PictureNormalURL);
            buttonLoginAsUser.Text = string.Format(k_LoginAsUserPlaceholder, FacebookUserData.LoginResult.LoggedInUser.Name);
            changingButtonVisibility(!k_NewLoginToken);
        }

        private void changingButtonVisibility(bool i_NewLoginToken)
        {
            m_UserData.IsValidAccessToken = !i_NewLoginToken;
            buttonLogin.Visible = i_NewLoginToken;
            buttonLoginAsUser.Visible = !i_NewLoginToken;
            buttonLoginAsDifferentUser.Visible = !i_NewLoginToken;
        }

    }
}

