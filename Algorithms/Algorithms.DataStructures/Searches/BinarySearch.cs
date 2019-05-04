using Algorithms.DataStructures.Searches.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DataStructures.Searches
{
    public class BinarySearch : ISearch
    {
        public int DoSearch (int number, int [] array)
        {
            for (int min = 0, max = array.Length -1; min <= max; )
            {
                var mid = (min + max) / 2;

                if (number == array[mid])
                    return mid;
                
                if (number < array[mid])
                    max = mid - 1;

                else
                    min = mid + 1;
            }

            return -1;
        }
    }
}
