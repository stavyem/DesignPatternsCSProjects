using System;
using System.ComponentModel;
using System.Windows.Forms;
using BasicFacebookFeatures.Logic;
using BasicFacebookFeatures.FacebookUI;
using FacebookWrapper;

namespace BasicFacebookFeatures.UI
{
    public partial class FormLogin : Form
    {
        private const string k_LoginAsUserPlaceholder = "Continue as {0}";
        private const bool k_NewLoginToken = true;

        public bool RememberUserInPrevSession { get; set; }

        public FormMain FormMain { get; private set; }

        public LoginManager LoginManager { get; private set; }

        private bool ExitFormMainWithLogoutButton { get; set; }

        public FormLogin()
        {
            InitializeComponent();
            LoginManager = new LoginManager();
            RememberUserInPrevSession = false;
            ExitFormMainWithLogoutButton = true;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            checkBoxRememberMe.Checked = LoginManager.LoadAppSettingsIfExists();
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
                LoginManager.SaveAppSettings(checkBoxRememberMe.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            executeLoginAction();
        }

        private void buttonLoginAsDifferentUser_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            LoginManager.IsValidAccessToken = !k_NewLoginToken;
            executeLoginAction();
        }

        private void executeLoginAction()
        {
            bool isSuccessfulLogin = LoginManager.LoginToFacebook();

            if (isSuccessfulLogin)
            {
                initiateFacebookFormAfterLogin();
            }
            else
            {
                MessageBox.Show(LoginManager.LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void initiateFacebookFormAfterLogin()
        {
            FormMain = new FormMain(LoginManager.LoginResult.LoggedInUser);
            switchForms();
        }

        private void switchForms()
        {
            this.Visible = false;
            FormMain.ShowDialog();
            ExitFormMainWithLogoutButton = FormMain.LogoutButtonClicked;
            FormMain.Dispose();
            this.Visible = true;
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
            pictureBoxProfilePhoto.LoadAsync(LoginManager.LoginResult.LoggedInUser.PictureNormalURL);
            buttonLoginAsUser.Text = string.Format(k_LoginAsUserPlaceholder, LoginManager.LoginResult.LoggedInUser.Name);
            changingButtonVisibility(!k_NewLoginToken);
        }

        private void changingButtonVisibility(bool i_NewLoginToken)
        {
            LoginManager.IsValidAccessToken = !i_NewLoginToken;
            buttonLogin.Visible = i_NewLoginToken;
            buttonLoginAsUser.Visible = !i_NewLoginToken;
            buttonLoginAsDifferentUser.Visible = !i_NewLoginToken;
        }
    }
}

