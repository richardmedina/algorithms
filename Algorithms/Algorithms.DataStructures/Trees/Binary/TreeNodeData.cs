using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DataStructures.Trees.Binary
{
    public class TreeNodeData : IComparable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CompareTo(object obj)
        {
            var data = (TreeNodeData) obj;

            if (Id == data.Id) return 0;
            if (Id > data.Id) return 1;

            return -1;
        }

        public override string ToString()
        {
            return $"Node Id :{Id}, FirstName: {FirstName}, LastName: {LastName}";
        }
    }
}
