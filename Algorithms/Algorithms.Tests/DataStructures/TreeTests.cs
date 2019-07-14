using Algorithms.DataStructures.Trees.Binary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tests.DataStructures
{
    [TestClass]
    public class TreeTests
    {

        [TestMethod]
        public void BinaryTreeTest ()
        {
            var tree = new BinarySearchTree();

            var datas = Enumerable.Range(1, 100)
                .Select(n => new TreeNode<TreeNodeData>
                {
                    Data = new TreeNodeData
                    {
                        Id = n,
                        FirstName = $"FiratName {n}",
                        LastName = $"LastName {n}"
                    }
                });

            foreach (var data in datas)
            {
                tree.Insert(data);
            }

            PrintIfExists(tree, 1);
            PrintIfExists(tree, 25);
            PrintIfExists(tree, 100);
            PrintIfExists(tree, 150);
        }

        private void PrintIfExists (ITreeNode<TreeNodeData> node, int id)
        {
            var data = new TreeNodeData
            {
                Id = id
            };

            if (node.Exists(data))
            {
                Console.WriteLine($"FOUND: TreeNodeDate id {id}");
            }
            else {
                Console.WriteLine($"NOTFOUND: TreeNodeDate id {id}");
            }
            
        }
    }
}
