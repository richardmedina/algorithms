using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CustomAlgorithms.IsPalindrome
{
    public class IsPalindromeAlgorithm : ICustomAlgorithm<bool, string>
    {
        public bool Run(string input)
        {
            for(int i = 0; i < input.Length / 2; i ++)
            {
                if (input [i] != input [input.Length - (i + 1)])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
