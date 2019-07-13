using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CustomAlgorithms.TwoNumbers
{
    /// <summary>
    /// Finds into an array the first two numbers that add to a target number
    /// Example: 
    /// array = [ 2, 7, 11, 15 ]
    /// target: 9
    /// result: [0, 1] = matching number indexes
    /// </summary>
    public class TwoNumbersAlgorithm : ICustomAlgorithm<int[], TwoNumbersAlgorithmParams>
    {
        public int[] Run(TwoNumbersAlgorithmParams args)
        {
            var complements = new Dictionary<int, int>();
            var nums = args.Array;
            var target = args.Target;

            for (int i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (complements.ContainsKey(num))
                {
                    return new int[] { complements[num], i };
                }
                complements.Add(target - num, i);
            }
            throw new ArgumentException ("Target was not found into provided array");
        }
    }
}
