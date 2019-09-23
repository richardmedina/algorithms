using Algorithms.DataStructures.GraphsTheory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.DataStructures
{
    [TestClass]
    public class GraphTests
    {

        [TestMethod]
        public void GraphsTopologicTest ()
        {
            var graph = new Graph(7);

            graph.AddArista(0, 1, 1);
            graph.AddArista(0, 2, 1);
            graph.AddArista(0, 3, 1);

            graph.AddArista(1, 3, 1);
            graph.AddArista(1, 4, 1);
            graph.AddArista(2, 5, 1);

            graph.AddArista(3, 2, 1);
            graph.AddArista(3, 5, 1);
            graph.AddArista(3, 6, 1);

            graph.AddArista(4, 3, 1);
            graph.AddArista(4, 6, 1);
            graph.AddArista(6, 5, 1);

            graph.ShowAdjacency();

            graph.CalculateIndegree();
            graph.ShowInDegree();

            graph.TopologicSort();
        }

        [TestMethod]
        public void SmallRouteGraph()
        {
            var start = 0;
            var end = 5;
            //var distance = 0;
            //var dato = "";

            var graph = new Graph(7);

            graph.AddArista(0, 1, 2);
            graph.AddArista(0, 3, 1);
            graph.AddArista(1, 3, 3);

            graph.AddArista(1, 4, 10);
            graph.AddArista(2, 0, 4);
            graph.AddArista(2, 5, 5);

            graph.AddArista(3, 2, 2);
            graph.AddArista(3, 4, 2);
            graph.AddArista(3, 5, 8);

            graph.AddArista(3, 6, 4);
            graph.AddArista(4, 6, 6);
            graph.AddArista(6, 5, 1);

            graph.ShowAdjacency();

            // Table
            // 0: Visited
            // 1: Distance
            // 2: Previous
            int[,] table = new int[graph.NodeCount, 3];

            // Initializing table

            for (int i = 0; i < graph.NodeCount; i++)
            {
                table[i, 0] = 0;
                table[i, 1] = int.MaxValue;
                table[i, 2] = 0;
            }

            table[start, 1] = 0;

            ShowTable(table);

            int actual = start;
            int distance = 0;
            do
            {
                // Mark node as visited
                table[actual, 0] = 1;

                for (int column = 0; column < graph.NodeCount; column++)
                {
                    // Looking for who this node is directed to
                    if (graph.GetAdjacency(actual, column) != 0)
                    {
                        // Calculating distance
                        distance = graph.GetAdjacency(actual, column) + table[actual, 1];

                        if (distance < table[column, 1])
                        {
                            table[column, 1] = distance;
                            table[column, 2] = actual;
                        }
                    }
                }

                // Looking for the new actual not that has not been visited

                int minorIndex = -1;
                int minorDistance = int.MaxValue;

                for(int x = 0; x < graph.NodeCount; x ++)
                {
                    if (table [x, 1] < minorDistance && table [x, 0] == 0)
                    {
                        minorIndex = x;
                        minorDistance = table[x, 1];
                    }
                }

                actual = minorIndex;
            } while (actual != -1);

            ShowTable(table);

            var route = new List<int>();
            int node = end;

            while(node != start)
            {
                route.Add(node);
                node = table[node, 2];
            }

            route.Add(start);
            route.Reverse();
            Console.WriteLine("-- Route --");
            foreach (int pos in route)
            {
                Console.Write($"{pos}->");
            }

            Console.WriteLine();
        }

        private static void ShowTable (int[,] table)
        {
            for(int i = 0; i < table.GetLength (0); i ++)
            {
                Console.WriteLine($"{i}-> {table[i, 0]}\t{table[i,1]}\t{table[i, 2]}");
            }

            Console.WriteLine("----------");
        }
    }
}
