using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic
{
    class FavouritePlaces
    {
        public static Dictionary<string, int> GetFavouritePlaces(User r_LoggedInUser)
        {
            try
            {
                Dictionary<string, int> placesFrequencies = getPlacesFrequencies(r_LoggedInUser);
                return sortFavouritePlaces(placesFrequencies);
            }
            catch
            {
                throw new Exception("Couldn't fetch favourite places");
            }
        }

        private static Dictionary<string, int> getPlacesFrequencies(User i_User)
        {
            Dictionary<string, int> placesFrequencies = new Dictionary<string, int>();

            foreach (Checkin checkin in i_User.Checkins)
            {
                if (checkin.Place != null)
                {
                    if (placesFrequencies.ContainsKey(checkin.Place.Name))
                    {
                        placesFrequencies[checkin.Place.Name]++;
                    }
                    else
                    {
                        placesFrequencies[checkin.Place.Name] = 1;
                    }
                }
            }

            return placesFrequencies;
        }

        private static Dictionary<string, int> sortFavouritePlaces(Dictionary<string, int> i_PlacesFrequencies)
        {
            return i_PlacesFrequencies.OrderByDescending(place => place.Value).ToDictionary(place => place.Key, place => place.Value);
        }
    }
}
