using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.Sorting
{
    public abstract class SortBase : ISort
    {
        public abstract int[] Sort(int[] input);
        public int[] CopyArray(int[] arr)
        {
            var newArr = new int[arr.Length];
            Array.Copy(arr, newArr, arr.Length);

            return arr;
        }
    }
}
