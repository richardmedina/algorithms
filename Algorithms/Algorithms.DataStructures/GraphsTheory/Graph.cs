using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DataStructures.GraphsTheory
{
    public class Graph
    {
        public int[,] Adjacency { get; set; }
        int[] InDegree { get; set; }
        public int NodeCount { get; set; }

        public Graph(int nodeCount)
        {
            NodeCount = nodeCount;
            Adjacency = new int[NodeCount, NodeCount];
            InDegree = new int[NodeCount];
        }

        public void AddArista (int startNode, int endNode)
        {
            Adjacency[startNode, endNode] = 1;
        }

        public void AddArista (int startNode, int endNode, int weight)
        {
            Adjacency[startNode, endNode] = weight;
        }

        public int GetAdjacency (int row, int col)
        {
            return Adjacency[row, col];
        }

        public void ShowAdjacency ()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < NodeCount; i ++)
            {
                Console.Write($"\t{i}");
            }

            Console.WriteLine();

            for (int i = 0; i < NodeCount; i ++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{i}\t");

                for (int j = 0; j < NodeCount; j ++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{Adjacency[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        
        /// <summary>
        /// Calculates Indegree for each node in the Adjacency Matrix
        /// InDegree is the number of Aristas that come to it
        /// </summary>
        public void CalculateIndegree ()
        {
            for (int i = 0; i < NodeCount; i ++)
            {
                for (int j = 0; j < NodeCount; j ++)
                {
                    if (Adjacency [j, i] > 0)
                    {
                        InDegree[i]++;
                    }
                }
            }
        }
        
        public void ShowInDegree ()
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < NodeCount; i ++)
            {
                Console.WriteLine($"Node {i} = {InDegree[i]}");
            }
        }

        public int FindInDegreeZero ()
        {
            for (int i = 0; i < NodeCount; i ++)
            {
                if (InDegree[i] == 0) return i;
            }

            return -1;
        }

        public void DecrementInDegree (int node)
        {
            InDegree[node] = -1;

            for (int i = 0; i < NodeCount; i ++)
            {
                if (Adjacency[node, i] == 1)
                {
                    InDegree[i]--;
                }
            }
        }

        public void TopologicSort ()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            var node = 0;
            do
            {
                node = FindInDegreeZero();

                if (node != -1)
                {
                    Console.Write($"{node}-> ");
                    DecrementInDegree(node);
                }

            } while (node != -1);
        }

        public void PrintSmallestRoute (int initial, int target)
        {
            
        }
    }
}
