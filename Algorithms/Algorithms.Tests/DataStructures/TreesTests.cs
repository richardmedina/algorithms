using Algorithms.DataStructures.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests.DataStructures
{

    class LevelData {
        public int Total;
        public int Count;
        public float Average => Total / Count;
    }

    [TestClass]
    public class TreesTests
    {
        
        [TestMethod]
        public void GetAverageByLevel()
        {
            BinaryTreeNode root = new BinaryTreeNode(4);
            
            root.Left = new BinaryTreeNode(7);
            root.Left.Left = new BinaryTreeNode(10);
            root.Left.Right = new BinaryTreeNode(2);
            root.Left.Right.Right = new BinaryTreeNode(6);
            root.Left.Right.Left = new BinaryTreeNode(2);

            root.Right = new BinaryTreeNode(9);
            root.Right.Right = new BinaryTreeNode(6);

            var data = new Dictionary<int, LevelData>();

            Collect(root, data, 0);

            Console.WriteLine("Dictionary: ", data);
        }

        static void Collect (BinaryTreeNode node, Dictionary<int, LevelData> data, int level)
        {
            if (node == null) return;

            if (!data.ContainsKey(level))
            {
                var levelData = new LevelData
                {
                    Total = node.Value,
                    Count = 1
                };

                data.Add(level, levelData);
            }
            else
            {
                data[level].Total += node.Value;
                data[level].Count++;
            }


            Collect(node.Left, data, level + 1);
            Collect(node.Right, data, level + 1);
        }
    }
}
