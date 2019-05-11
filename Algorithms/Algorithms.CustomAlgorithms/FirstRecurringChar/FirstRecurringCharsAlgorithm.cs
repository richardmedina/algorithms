using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CustomAlgorithms.FirstRecurringChar
{
    /// <summary>
    /// Gets first recurring char from a given char array
    /// example: 
    /// ['D','B','C','A','B','A'] => 'B'
    /// </summary>
    public class FirstRecurringCharAlgorithm : ICustomAlgorithm<char, char[]>
    {
        public char Run(char[] array)
        {
            Hashtable hash = new Hashtable();

            for (int i = 0; i < array.Length; i++)
            {
                var value = array[i];
                if (hash.ContainsKey(value))
                    return value;

                hash.Add(value, value);
            }

            return '\0';
        }
    }
}
