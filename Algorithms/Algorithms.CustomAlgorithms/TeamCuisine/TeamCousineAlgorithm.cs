using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CustomAlgorithms.TeamCuisine
{
    public class TeamCousineAlgorithm : ICustomAlgorithm<string[,], TeamCuisineParams>
    {
        public string[,] Run(TeamCuisineParams param)
        {
            var preferences = new string [0,0];

            for (int i = 0; i < param.TeamCuisinePreferences.GetLength(0); i++)
            {
                var first = param.TeamCuisinePreferences[i, 0];
                var second = param.TeamCuisinePreferences[i, 1];

                if (second == "*") {
                    for(int j = 0; j < param.LunchMenuPairs.GetLength (0); j ++)
                    {
                        preferences = AddItemToBiArray(preferences, 
                            first, 
                            param.LunchMenuPairs[j, 0]);
                    }
                    continue;
                }

                var match = FindInBiArrayAtIndex(second, 1, 0, param.LunchMenuPairs);

                if (match != null)
                {
                    preferences = AddItemToBiArray(preferences, first, match);
                }
            }



            return preferences;
        }

        private string [,] AddItemToBiArray (string [,] arrayFrom, string first, string second)
        {
            var newSize = arrayFrom.GetLength(0) + 1;
            var newArray = new string[newSize, 2];

            for (int i = 0; i < arrayFrom.GetLength(0); i ++)
            {
                newArray[i, 0] = arrayFrom[i, 0];
                newArray[i, 1] = arrayFrom[i, 1];
            }

            newArray[newSize - 1, 0] = first;
            newArray[newSize - 1, 1] = second;

            return newArray;
        }

        private string FindInBiArrayAtIndex(string value, int indexToMatch, int indexToReturn, string[,] array)
        {
            for (int i = 0; i < array.GetLength (0); i ++)
            {
                if (value == array [i, indexToMatch]) return array[i, indexToReturn];
            }

            return null;
        }
    }
}
