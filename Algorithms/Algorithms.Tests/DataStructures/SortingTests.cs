using Algorithms.DataStructures.Sorting;
using Algorithms.DataStructures.Sorting.Quick;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests.DataStructures
{
    [TestClass]
    public class SortingTests
    {

        [TestMethod]
        public void QuicksortTest()
        {
            var input = new int[] { 10, 1, 9, 2, 8, 3, 7, 4, 6, 5 };
            ISort sort = new Quicksort();

            var result = sort.Sort(input);

            Console.WriteLine(result);
        }
    }
}
