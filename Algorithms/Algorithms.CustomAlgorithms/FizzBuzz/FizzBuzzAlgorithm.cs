using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CustomAlgorithms.FizzBuzz
{
    public class FizzBuzzAlgorithm : ICustomAlgorithm<int, int>
    {
        /// <summary>
        /// Prints the numbers from 1 to N,
        /// but for multiples of 3 print Fizz instead of numbers,
        /// for multiples of 5 print Buzz
        /// for multiples of 3 and 5 print FizzBuzz
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public int Run(int n)
        {
            for (int i = 1; i <= n; i ++)
            {
                string value = string.Empty;
                if (i % 3 == 0) { value += "Fizz"; }
                if (i % 5 == 0) { value += "Buzz"; }

                value = value != string.Empty ? value : i.ToString();
                Console.Write ($"{value} ");
            }

            return 0;
        }
    }
}
