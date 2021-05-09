using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.CustomAlgorithms.BinarySum
{
    /// <summary>
    /// This algorithm will summ two binary numbers as string and
    /// it returns the result in a new string
    /// </summary>
    public class BinarySumAlgorithm : ICustomAlgorithm<string, BinarySumParams>
    {
        public string Run(BinarySumParams param)
        {
            return sum(param.BinaryNumber1, param.BinaryNumber2);
        }

        public string sum(string b1, string b2)
        {
            var result = "";

            var max = Math.Max(b1.Length, b2.Length);

            var carry = 0;
            for(int  i = 0; i < max; i++)
            {
                var digit1 = b1.Length - i > 0 ? b1[b1.Length - 1 - i] : '0';
                var digit2 = b2.Length - i > 0 ? b2[b2.Length - 1 - i] : '0';

                var val1 = digit1 == '1' ? 1 : 0;
                var val2 = digit2 == '1' ? 1 : 0;

                var sum = val1 + val2 + carry;
                carry = 0;

                if(sum > 1)
                {
                    sum -= 2 * (sum / 2);
                    carry = 1;
                }

                result = $"{sum}{result}";
            }

            if (carry > 0) result = $"{carry}{result}";

            return result;
        }
    }
}
