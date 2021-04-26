using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.CustomAlgorithms.AddToSortedArray
{
    /// <summary>
    /// Add value to internal sorted array and returns a new array
    /// </summary>
    public class AddToSortedArrayAlgorithm : ICustomAlgorithm<int[], int>
    {
        private int[] array;

        public int[] Run(int value)
        {
            array = AddToSorted(value, array);

            return array;
        }

        private int[] AddToSorted(int value, int[] array)
        {
            if ((array?.Length ?? 0) == 0) return new[] { value };

            var arr = new int[array.Length + 1];
            var idx = 0;
            var added = false;

            foreach (var item in array)
            {
                if (!added && value < item)
                {
                    arr[idx++] = value;
                    added = true;
                }

                arr[idx++] = item;
            }

            if (!added)
            {
                arr[idx++] = value;
            }

            return arr;
        }

    }
}
