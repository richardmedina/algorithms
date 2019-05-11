using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CustomAlgorithms.IncrementArray
{
    /// <summary>
    /// From a given array, it returns a new one incremented as if it were a single number,
    /// examples: 
    /// [1,2,3,4] => [1,2,3,5]
    /// [9,9,9,9] => [1,0,0,0,0]
    /// </summary>
    public class IncrementArrayAlgorithm : ICustomAlgorithm<int[], int[]>
    {
        public int[] Run(int[] array)
        {
            var carry = 0;
            var newArray = new int[array.Length];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                var value = array[i];
                var nextVal = value + carry + (i == array.Length - 1 ? 1 : 0);

                if (nextVal > 9)
                {
                    carry = 1;
                    nextVal -= 10;
                }
                else
                {
                    carry = 0;
                }

                newArray[i] = nextVal;
            }
            if (carry > 0)
            {
                var resizedArray = new int[newArray.Length + 1];

                Array.Copy(newArray, 0, resizedArray, 1, newArray.Length);
                resizedArray[0] = carry;
                newArray = resizedArray;
            }

            return newArray;
        }
    }
}
