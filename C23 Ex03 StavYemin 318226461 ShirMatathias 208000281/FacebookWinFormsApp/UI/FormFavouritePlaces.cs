using BasicFacebookFeatures.Logic;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI
{
    internal partial class FormFavouritePlaces : Form
    {
        private FacebookUserData m_UserData;

        internal FormFavouritePlaces(FacebookUserData i_UserData)
        {
            InitializeComponent();
            m_UserData = i_UserData;
        }

        protected override void OnShown(EventArgs e)
        {
            listBox1.Items.Clear();
            new Thread(fillFavouritePlaces).Start();
        }

        private void fillFavouritePlaces()
        {
            try
            {
                Dictionary<string, int> favouritePlaces = FacebookUserData.FavouritePlaces;

                foreach (KeyValuePair<string, int> place in favouritePlaces)
                {
                    listBox1.Invoke(new Action(() => listBox1.Items.Add($"{place.Key} - visited {place.Value} times")));
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
                foreach (Post post in m_UserData.Posts)
                {
                    if(post.Place != null)
                    {
                        string pattern = @"^(.*?)(?= -[^-]*$)";
                        Match match = Regex.Match(listBox1.SelectedItem.ToString(), pattern);
                        string strMatch = match.ToString();
                        if (strMatch.Equals(post.Place.Name))
                        {
                            pictureBoxFavPlaces.LoadAsync(post?.Place.PictureNormalURL);
                        }
                    }
                }
            }
        }
    }
}
