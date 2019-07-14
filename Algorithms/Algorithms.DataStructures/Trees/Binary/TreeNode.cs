using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DataStructures.Trees.Binary
{
    public class TreeNode<T> : ITreeNode<T> where T : class, IComparable
    {
        public T Data { get; set; }
        public ITreeNode<T> Left { get; set; }
        public ITreeNode<T> Right { get; set; }


        public TreeNode()
        {
            Data = null;
            Left = null;
            Right = null;
        }

        public TreeNode(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }

        public bool Exists(T data)
        {
            var iter = this as ITreeNode<T>;

            do
            {
                var result = iter.Data.CompareTo(data);
                if (result == 0) return true;

                if (result == -1)
                {
                    iter = iter.Left;
                }
                else
                {
                    iter = iter.Right;
                }
                
            } while (iter != null);

            return false;
        }

        public void Insert(ITreeNode<T> node)
        {
            var iter = this as ITreeNode<T>;

            if (this.Data == null)
            {
                this.Data = node.Data;
                return;
            }

            do
            {
                var result = iter.Data.CompareTo(node.Data);
                if (result == 0) throw new ArgumentException("It is not possible to add duplicated values to the Tree");

                if (result == -1)
                {
                    if (iter.Left == null)
                    {
                        iter.Left = node;
                        break;
                    }
                    else
                    {
                        iter = iter.Left;
                    }
                }
                else
                {
                    if (iter.Right == null)
                    {
                        iter.Right = node;
                        break;
                    }
                    else
                    {
                        iter = iter.Right;
                    }
                }
                
            } while (iter != null);
        }
    }
}
