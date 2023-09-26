using BasicFacebookFeatures.Logic;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI
{
    public partial class FormFavouritePlaces : Form
    {
        private readonly User r_LoggedInUser;
        private static Dictionary<string, int> m_FavouritePlaces;

        public FormFavouritePlaces(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
        }

        protected override void OnShown(EventArgs e)
        {
            m_FavouritePlaces = FavouritePlaces.GetFavouritePlaces(r_LoggedInUser);
            listBox1.Items.Clear();
            fillFavouritePlaces();
        }

        private void fillFavouritePlaces()
        {
            try
            {
                Dictionary<string, int> favouritePlaces = FavouritePlaces.GetFavouritePlaces(r_LoggedInUser);

                foreach (KeyValuePair<string, int> place in favouritePlaces)
                {
                    listBox1.Items.Add($"{place.Key} - visited {place.Value} times");
                }
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                foreach (Post post in r_LoggedInUser.Posts)
                {
                    if(post.Place != null)
                    {
                        string pattern = @"^(.*?)(?= -[^-]*$)";
                        Match match = Regex.Match(listBox1.SelectedItem.ToString(), pattern);
                        string matchi_match = match.ToString();
                        if (matchi_match.Equals(post.Place.Name))
                        {
                            pictureBoxFavPlaces.LoadAsync(post?.Place.PictureNormalURL);
                        }
                    }
                }
            }
        }
    }
}
