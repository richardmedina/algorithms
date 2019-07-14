using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DataStructures.Trees.Binary
{
    public interface ITreeNode<T> where T : class, IComparable
    {
        T Data { get; set; }
        ITreeNode<T> Left { get; set; }
        ITreeNode<T> Right { get; set; }

        bool Exists(T data);
        void Insert(ITreeNode<T> node);
    }
}
