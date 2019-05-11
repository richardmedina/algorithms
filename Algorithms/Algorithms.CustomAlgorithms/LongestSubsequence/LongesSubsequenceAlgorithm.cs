using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CustomAlgorithms.LongestSubsequence
{
    /// <summary>
    /// Returns the longest subsequence on two given strings
    /// examples:
    /// String1 = "ABAZDC", String2 = "BACBAD" => "ABAD"
    /// String1 = "AGGTAB", String2 = "GXTXAYB" => "GTAB"
    /// String1 = "aaaa", String2 = "aa" => "aa"
    /// </summary>
    public class LongesSubsequenceAlgorithm : ICustomAlgorithm<string, LongestSubsequenceParams>
    {
        public string Run(LongestSubsequenceParams param)
        {
            var s1 = param.String1;
            var s2 = param.String2;
            var cs1 = s1.ToCharArray();
            var cs2 = s2.ToCharArray();

            var subs = new List<string>();

            for (int i = 0; i < cs1.Length; i++)
            {
                var sub = string.Empty;
                int lastIndex = 0;

                for (int j = i; j < cs1.Length; j++)
                {
                    var currentChar = cs1[j];

                    if (lastIndex >= cs1.Length || lastIndex >= cs2.Length) break;

                    var index = IndexOf(cs2, currentChar, lastIndex);

                    if (index > -1)
                    {
                        sub += currentChar;
                        lastIndex = index + 1;
                    }
                }

                subs.Add(sub);
            }

            var longest = string.Empty;

            foreach (var value in subs)
                if (longest.Length < value.Length)
                    longest = value;
            return longest;
        }

        private int IndexOf (char[] source, char c, int initialPosition = 0)
        {
            for (int i = initialPosition; i < source.Length; i++)
            {
                if (source[i] == c) return i;
            }

            return -1;
        }
    }
}
