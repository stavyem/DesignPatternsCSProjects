using BasicFacebookFeatures.FacebookUI;
using BasicFacebookFeatures.Logic;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.UI
{
    internal static class FormFactory
    {
        private static FacebookUserData s_FacebookUserData = new FacebookUserData();

        internal static Form CreateForm(string i_FormName)
        {
            Form FormFactory;

            switch (i_FormName)
            {
                case "Main":
                    FormFactory = new FormMain(s_FacebookUserData);
                    break;
                case "Login":
                    FormFactory = new FormLogin(s_FacebookUserData);
                    break;
                case "FirstSteps":
                    FormFactory = new FormFirstSteps(s_FacebookUserData);
                    break;
                case "FavouritePlaces":
                    FormFactory = new FormFavouritePlaces(s_FacebookUserData);
                    break;
                default:
                    FormFactory = null;
                    break;
            }

            return FormFactory;
        }
    }
}
