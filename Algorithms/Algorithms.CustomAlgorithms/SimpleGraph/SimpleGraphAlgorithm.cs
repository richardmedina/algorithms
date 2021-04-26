using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CustomAlgorithms.SimpleGraph
{
    public class SimpleGraphAlgorithm : ICustomAlgorithm<int, int>
    {

        public int Run(int nodes)
        {
            nodes = 7;
            var source = 0;

            var dijkstra = new Dijkstra(nodes);

            dijkstra.Run(source);


            for(int i = 0; i < nodes; i++)
            {
                if(i != source)
                {
                    Console.WriteLine($"Source : {source} -> Dest: {i} = minCost: {dijkstra.Distance[i]}");
                }
            }

            return 0;
        }
    }
}
