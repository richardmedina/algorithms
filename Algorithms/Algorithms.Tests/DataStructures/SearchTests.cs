using Algorithms.DataStructures.Searches;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Algorithms.Tests
{
    [TestClass]
    public class SearchTests
    {
        private static int number = 10;
        private static int [] array = { 1, 2, 3, 10, 20, 40, 100, 200, 300 };
        private const int EXPECTED_INDEX = 3;

        [TestMethod]
        public void SequentialSerchTest()
        {
            // Arrange
            var sequentialSearch = new SequentialSearch();

            // Act
            var index = sequentialSearch.DoSearch(number, array);

            // Assert
            Assert.AreEqual(EXPECTED_INDEX, index);
        }


        [TestMethod]
        public void BinarySearchTest()
        {
            // Arrange
            var binarySearch = new BinarySearch ();

            // Act
            var index = binarySearch.DoSearch(number, array);

            // Assert
            Assert.AreEqual(EXPECTED_INDEX, index);
        }

    }
}
