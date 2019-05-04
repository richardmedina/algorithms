using Algorithms.DataStructures.Searches.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DataStructures.Searches
{
    public class SequentialSearch : ISearch
    {
        public int DoSearch(int number, int[] array)
        {
            for (int i = 0; i < array.Length; i ++)
            {
                if (array[i] == number)
                    return i;
            }

            return -1;
        }
    }
}
