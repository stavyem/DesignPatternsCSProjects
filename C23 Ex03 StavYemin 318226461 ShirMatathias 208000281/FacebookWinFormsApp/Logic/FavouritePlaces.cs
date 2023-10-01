using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic
{
    class FavouritePlaces
    {
        internal static Dictionary<string, int> GetFavouritePlaces(User r_LoggedInUser)
        {
            try
            {
                Dictionary<string, int> placesFrequencies = getPlacesFrequencies(r_LoggedInUser);

                ISortStrategy<string, int> sortByValueStrategy = new SortByValueStrategy<string, int>();

                return sortFavouritePlaces(placesFrequencies, sortByValueStrategy);
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

        public interface ISortStrategy<TKey, TValue>
        {
            IEnumerable<KeyValuePair<TKey, TValue>> Sort(Dictionary<TKey, TValue> data);
        }

        public class SortByValueStrategy<TKey, TValue> : ISortStrategy<TKey, TValue>
        {
            public IEnumerable<KeyValuePair<TKey, TValue>> Sort(Dictionary<TKey, TValue> data)
            {
                return data.OrderByDescending(place => place.Value);
            }
        }

        private static Dictionary<string, int> sortFavouritePlaces(Dictionary<string, int> i_PlacesFrequencies, ISortStrategy<string, int> sortStrategy)
        {
            return sortStrategy.Sort(i_PlacesFrequencies).ToDictionary(item => item.Key, item => item.Value);
        }
    }
}
