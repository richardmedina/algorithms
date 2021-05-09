using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.CustomAlgorithms.BinarySum
{
    /// <summary>
    /// This algorithm will summ two binary numbers as string and
    /// it returns the result in a new string.
    /// 
    /// UPDATE: Covered case when numerical case is other than binary,
    /// We just need to modify the NUM_SYS and add the corresponding case to GetDigitAsNumber method
    /// </summary>
    public class BinarySumAlgorithm : ICustomAlgorithm<string, BinarySumParams>
    {
        const int NUM_SYS = 10;

        public string Run(BinarySumParams param)
        {
            return sum(param.BinaryNumber1, param.BinaryNumber2, NUM_SYS);
        }

        public string sum(string b1, string b2, int NumSys)
        {
            var result = "";

            var max = Math.Max(b1.Length, b2.Length);

            var carry = 0;
            for(int  i = 0; i < max; i++)
            {
                var digit1 = b1.Length - i > 0 ? b1[b1.Length - 1 - i] : '0';
                var digit2 = b2.Length - i > 0 ? b2[b2.Length - 1 - i] : '0';

                var val1 = GetDigitAsNumber(digit1, NumSys);
                var val2 = GetDigitAsNumber(digit2, NumSys);

                var sum = val1 + val2 + carry;
                carry = 0;

                if(sum > NumSys - 1)
                {
                    sum -= NumSys * (sum / NumSys);
                    carry = 1;
                }

                result = $"{sum}{result}";
            }

            if (carry > 0) result = $"{carry}{result}";

            return result;
        }

        

        private int GetDigitAsNumber(char digit, int NumSys)
        {
            if(NumSys == 2)
            {
                return digit == '1' ? 1 : 0;
            }
            if (NumSys == 10)
            {
                var values = Enumerable.Range(0, NumSys)
                    .Select(n => new { Value = n, Digit = $"{n}" });

                return values
                    .SingleOrDefault(v => v.Digit == $"{digit}")?.Value ?? throw new ArgumentException($"Digit {digit} not valid");
            }

            return 0;
        }
    }
}
