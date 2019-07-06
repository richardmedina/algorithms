using Algorithms.CustomAlgorithms.FirstRecurringChar;
using Algorithms.CustomAlgorithms.FizzBuzz;
using Algorithms.CustomAlgorithms.IncrementArray;
using Algorithms.CustomAlgorithms.LongestSubsequence;
using Algorithms.CustomAlgorithms.TeamCuisine;
using Algorithms.CustomAlgorithms.ThirdSmallest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tests.CustomAlgorithms
{
    [TestClass]
    public class CustomAlgorithmsTests
    {
        [TestMethod]
        public void IncrementArrayTest ()
        {
            // Arrange
            var customAlgorithm = new IncrementArrayAlgorithm();
            int[] expectedResult1 = { 1, 2, 3, 5};
            int[] expectedResult2 = { 1, 0, 0, 0, 0 };

            // Act
            var result1 = customAlgorithm.Run(new[] { 1, 2, 3, 4 });
            var result2 = customAlgorithm.Run(new[] { 9, 9, 9, 9 });

            // Assert
            Assert.IsTrue(result1.SequenceEqual(expectedResult1));
            Assert.IsTrue(result2.SequenceEqual(expectedResult2));
        }

        [TestMethod]
        public void LongestSubsequenceTest ()
        {
            // Arrange
            var customAlgorithm = new LongesSubsequenceAlgorithm();
            var expectedResult1 = "ABAD";
            var expectedResult2 = "GTAB";
            var expectedResult3 = "aa";

            // Act
            var result1 = customAlgorithm.Run(new LongestSubsequenceParams { String1 = "ABAZDC", String2 = "BACBAD" });
            var result2 = customAlgorithm.Run(new LongestSubsequenceParams { String1 = "AGGTAB", String2 = "GXTXAYB" });
            var result3 = customAlgorithm.Run(new LongestSubsequenceParams { String1 = "aaaa", String2 = "aa" });

            // Assert
            Assert.AreEqual(expectedResult1, result1);
            Assert.AreEqual(expectedResult2, result2);
            Assert.AreEqual(expectedResult3, result3);
        }

        [TestMethod]
        public void FirstRecurringCharTest ()
        {
            // Arrange
            var customAlgorithm = new FirstRecurringCharAlgorithm();
            var expectedResult = 'B';
            // Act
            var result = customAlgorithm.Run("DBCABA".ToCharArray());

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ThirdSmallestTest ()
        {
            // Arrange
            var customAlgorithm = new ThirdSmallestAlgorithm();
            var expectedResult1 = 50;
            var expectedResult2 = 3;

            // Act
            var result1 = customAlgorithm.Run (new []{ 50, 10, 20, 100, 200 });
            var result2 = customAlgorithm.Run(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });

            // Assert
            Assert.AreEqual(expectedResult1, result1);
            Assert.AreEqual(expectedResult2, result2);
        }

        [TestMethod]
        public void TeamCousineTest ()
        {
            var customAlgorithm = new TeamCuisineAlgorithm();
            var param = new TeamCuisineParams
            {
                LunchMenuPairs = new [,] {
                    { "Pizza", "Italian"},
                    { "Curry", "Indian" },
                    { "Masala", "Indian" }
                },
                TeamCuisinePreferences = new [,]{
                    { "Jose", "Italian" },
                    { "John", "Indian" },
                    { "Sarah", "Thai" },
                    { "Mary", "*" }
                }
            };

            var result = customAlgorithm.Run(param);
        }

        [TestMethod]
        public void FizzBuzzTest ()
        {
            var customAlgorithm = new FizzBuzzAlgorithm();
            customAlgorithm.Run(100);
        }
    }
}
