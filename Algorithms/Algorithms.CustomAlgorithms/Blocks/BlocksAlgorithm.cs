using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.CustomAlgorithms.Blocks
{
    public class BlocksAlgorithm : ICustomAlgorithm<int, string[]>
    {
        public int Run(string[] blocks)
        {
            var scores = new List<Score>();

            for (int i = 0; i < blocks.Length; i++)
            {
                var block = blocks[i];
                var prev = scores.Any() ? scores[scores.Count - 1] : null;
                Score score = null;

                if (block == "Z")
                {
                    if (scores.Any())
                    {
                        scores.RemoveAt(scores.Count - 1);
                    }
                    continue;
                }

                if (block == "X")
                {
                    if (prev != null)
                    {
                        score = new Score();
                        score.Current = 2 * prev.Current;
                        score.Total = prev.Total + score.Current;

                        scores.Add(score);
                    }

                    continue;
                }

                if (block == "+")
                {
                    var prevPrev = scores.Count > 2 ? scores[scores.Count - 2] : null;
                    if (prev != null && prevPrev != null)
                    {
                        score = new Score();
                        score.Current = prev.Current + prevPrev.Current;
                        score.Total = prev.Total + score.Current;
                        scores.Add(score);
                    }
                    continue;
                }

                var current = int.Parse(block);
                score = new Score();
                if (prev != null)
                {
                    score.Current = current;
                    score.Total = prev.Total + score.Current;
                }
                else
                {
                    score.Current = current;
                    score.Total = current;
                }
                scores.Add(score);
            }


            return scores.Any ()
                ? scores.Last ().Total
                : 0;
        }
    }

    class Score
    {
        public int Current { get; set; }
        public int Total { get; set; }
    }
}
