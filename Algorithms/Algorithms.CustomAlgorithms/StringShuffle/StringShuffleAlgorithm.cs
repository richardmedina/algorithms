using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.CustomAlgorithms.StringShuffle
{
    public class StringShuffleAlgorithm : ICustomAlgorithm<string, string>
    {
        public string Run(string input)
        {
            var result = new StringBuilder(input);
            var random = new Random();
            var i = 0;
            while (input.Length > 0)
            {
                var idx = random.Next(input.Length - 1);
                result[i ++] = input[idx];
                input = input.Remove(idx, 1);
            }

            return result.ToString();
        }
    }
}
