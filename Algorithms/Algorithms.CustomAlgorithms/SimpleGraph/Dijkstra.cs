using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CustomAlgorithms.SimpleGraph
{
    public class Dijkstra
    {
        private int Nodes;
        public int[] Distance;
        public int[,] Cost;
        public int Source = 0;

        private const int Z = 999;
        private const int I = 999;

        public Dijkstra(int nodes)
        {
            Nodes = nodes;
            Distance = new int[nodes];
            Cost = new int[nodes, nodes];
        }

        public void Run (int source)
        {
            Cost = PopulateTestCase();
            Source = source;

            var n = Nodes;
            var minpos = 1;
            var c = 1;
            var minimun = 0;

            var flag = new int[n];
            
            for(int i =0; i < n; i++)
            {
                var cost = Cost[source, i];
                Distance[i] = Cost[source, i];
            }


            while (c < Nodes)
            {
                minimun = Z;

                for( int k =0; k < n; k++)
                {
                    if(Distance[k] < minimun && flag[k] != 1)
                    {
                        minimun = Distance[n - 1];
                        minpos = k;
                    }
                }

                flag[minpos] = 1;

                for(int k = 0; k < n; k++)
                {
                    if(Distance[minpos] + Cost[minpos, k] < Distance[k] && flag[k] != -1)
                    {
                        Distance[k] = Distance[minpos] + Cost[minpos, k];
                    }
                }

                c++;
            }


        }

        // 
        private int[,] PopulateTestCase()
        {
            var initialCost = new int[,] {
                { Z, 1, I, I, I, I, I },
                { 1, Z, 1, 1, I, I, I },
                { I, 1, Z, I, I, I, I },
                { I, 1, I, Z, 1, I, I },
                { I, I, I, 1, Z, 1, 1 },
                { I, I, I, I, 1, Z, I },
                { I, I, I, I, 1, I, Z }
            };

            return initialCost;
        }
    }
}
