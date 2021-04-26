using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.CustomAlgorithms.DirectoryCreator
{
    /// <summary>
    /// Creates directory list with unique names.
    /// If input array contains duplicated values, 
    /// algorithm should rename them to the form filename(n)
    /// where n will define the uniquiness
    /// </summary>
    public class DirectoryCreatorCustomAlgorithm : ICustomAlgorithm<string[], string[]>
    {
        public string[] Run(string[] input)
        {
            var result = new string[input.Length];

            var dict = new Dictionary<string, int>();

            int resultIdx = 0;
            foreach (var dir in input)
            {
                if (!dict.ContainsKey(dir))
                {
                    dict.Add(dir, 0);
                    result[resultIdx ++] = dir;
                }
                else
                {
                    var count = dict[dir] + 1;
                    result[resultIdx++] = $"{dir}({count})";

                    dict[dir] = count;
                }
            }

            return result;
        }
    }
}
