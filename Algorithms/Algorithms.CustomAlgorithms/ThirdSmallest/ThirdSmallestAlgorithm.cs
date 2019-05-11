using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CustomAlgorithms.ThirdSmallest
{
    public class ThirdSmallestAlgorithm : ICustomAlgorithm<int, int[]>
    {
        public int Run(int[] array)
        {
            var first = int.MaxValue;
            var second = int.MaxValue;
            var third = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                var value = array[i];

                if (value < first)
                {
                    third = second;
                    second = first;
                    first = value;
                }

                else if (value < second)
                {
                    third = second;
                    second = value;
                }

                else if (value < third)
                {
                    third = value;
                }
            }

            return third;
        }
    }
}
