using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.CustomAlgorithms.TeamCuisine
{
    public class TeamCuisine2Algorithm : ICustomAlgorithm<string[,], TeamCuisineParams>
    {
        public string[,] Run(TeamCuisineParams param)
        {
            return GetCuisinePreference(param.LunchMenuPairs, param.TeamCuisinePreferences);
        }

        private string[,] GetCuisinePreference(string[,] lunchMenuPairs, string[,] teamCuisinePreference)
        {
            var dict = new Dictionary<string, string[]>();
            for(int i = 0; i < lunchMenuPairs.GetLength(0); i ++)
            {
                var lunch = lunchMenuPairs[i, 0];
                var cuisine = lunchMenuPairs[i, 1];

                if (dict.ContainsKey(cuisine))
                {
                    var current = dict[cuisine];
                    var @new = new string[current.Length + 1];

                    for (int x = 0; x < current.Length; x++)
                    {
                        @new[x] = current[x];
                    }

                    @new[current.Length] = lunch;

                    dict[cuisine] = @new;
                    continue;
                }

                dict.Add(cuisine, new string[] { lunch });
            }

            var result = new string[0, 2];

            for (int i=0; i < teamCuisinePreference.GetLength(0); i++)
            {
                var member = teamCuisinePreference[i, 0];
                var cuisine = teamCuisinePreference[i, 1];

                var lunch = new string[0];

                if (dict.ContainsKey(cuisine))
                {
                    var lunches = dict[cuisine];
                    result = AddToLunchPreferences(result, member, lunches);
                }

                if(cuisine == "*")
                {
                    foreach(var key in dict.Keys)
                    {
                        var lunches = dict[key];
                        result = AddToLunchPreferences(result, member, lunches);
                    }
                }
            }

            return result;
        }

        private string[,] AddToLunchPreferences(string[,] currentLunchPreferences, string member, string[] lunches)
        {
            var result = new string[currentLunchPreferences.GetLength(0) + lunches.Length, 2];
            Array.Copy(currentLunchPreferences, result, currentLunchPreferences.Length);

            for (int x = 0; x < lunches.Length; x++)
            {
                result[result.GetLength(0) - lunches.Length + x, 0] = member;
                result[result.GetLength(0) - lunches.Length + x, 1] = lunches[x];
            }

            return result;
        }
    }
}
