using Algorithms.CustomAlgorithms.AddTwoListNodes;
using Algorithms.CustomAlgorithms.Blocks;
using Algorithms.CustomAlgorithms.DirectoryCreator;
using Algorithms.CustomAlgorithms.FirstRecurringChar;
using Algorithms.CustomAlgorithms.FizzBuzz;
using Algorithms.CustomAlgorithms.IncrementArray;
using Algorithms.CustomAlgorithms.IsPalindrome;
using Algorithms.CustomAlgorithms.LongestSubsequence;
using Algorithms.CustomAlgorithms.SimpleGraph;
using Algorithms.CustomAlgorithms.StringShuffle;
using Algorithms.CustomAlgorithms.TeamCuisine;
using Algorithms.CustomAlgorithms.ThirdSmallest;
using Algorithms.CustomAlgorithms.TwoNumbers;
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
        public void IncrementArrayTest()
        {
            // Arrange
            var customAlgorithm = new IncrementArrayAlgorithm();
            int[] expectedResult1 = { 1, 2, 3, 5 };
            int[] expectedResult2 = { 1, 0, 0, 0, 0 };

            // Act
            var result1 = customAlgorithm.Run(new[] { 1, 2, 3, 4 });
            var result2 = customAlgorithm.Run(new[] { 9, 9, 9, 9 });

            // Assert
            Assert.IsTrue(result1.SequenceEqual(expectedResult1));
            Assert.IsTrue(result2.SequenceEqual(expectedResult2));
        }

        [TestMethod]
        public void LongestSubsequenceTest()
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
        public void FirstRecurringCharTest()
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
        public void ThirdSmallestTest()
        {
            // Arrange
            var customAlgorithm = new ThirdSmallestAlgorithm();
            var expectedResult1 = 50;
            var expectedResult2 = 3;

            // Act
            var result1 = customAlgorithm.Run(new[] { 50, 10, 20, 100, 200 });
            var result2 = customAlgorithm.Run(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });

            // Assert
            Assert.AreEqual(expectedResult1, result1);
            Assert.AreEqual(expectedResult2, result2);
        }

        [TestMethod]
        public void TeamCousineTest()
        {
            var customAlgorithm = new TeamCuisineAlgorithm();
            var param = new TeamCuisineParams
            {
                LunchMenuPairs = new[,] {
                    { "Pizza", "Italian"},
                    { "Curry", "Indian" },
                    { "Masala", "Indian" }
                },
                TeamCuisinePreferences = new[,]{
                    { "Jose", "Italian" },
                    { "John", "Indian" },
                    { "Sarah", "Thai" },
                    { "Mary", "*" }
                }
            };

            var result = customAlgorithm.Run(param);
        }

        [TestMethod]
        public void FizzBuzzTest()
        {
            var customAlgorithm = new FizzBuzzAlgorithm();
            customAlgorithm.Run(100);
        }

        [TestMethod]
        public void IsPalindromeTest()
        {
            var customAlgorithm = new IsPalindromeAlgorithm();
            var isPalindrome = "sugus";
            var isPalindrome2 = "hooh";
            var isNotPalindrome = "Hello";

            Assert.AreEqual(true, customAlgorithm.Run(isPalindrome));
            Assert.AreEqual(true, customAlgorithm.Run(isPalindrome2));
            Assert.AreEqual(false, customAlgorithm.Run(isNotPalindrome));
        }

        [DataTestMethod()]
        [DataRow("abcde")]
        [DataRow("abcde")]
        [DataRow("abcde")]
        [DataRow("abcde")]
        [DataRow("abcde")]
        [DataRow("abcde")]
        [DataRow("abcde")]
        public void StringShuffleTest(string input)
        {
            var customAlgorithm = new StringShuffleAlgorithm();

            var result = customAlgorithm.Run(input);
            Console.WriteLine(result);
        }

        [TestMethod]
        public void BlocksAlgorithmTest()
        {
            // Arrange
            var customAlgorithm = new BlocksAlgorithm();
            var blocks = new[] { "5", "-2", "4", "Z", "X", "9", "+", "+" };

            // Act
            var result = customAlgorithm.Run(blocks);

            // Assert
            Assert.AreEqual(27, result);
        }


        [TestMethod]
        public void TwoNumsTest()
        {
            // Arrange
            var customAlgorithm = new TwoNumbersAlgorithm();
            var input = new[] { 2, 7, 11, 15 };
            var target = 9;

            //Act
            var result = customAlgorithm.Run(new TwoNumbersAlgorithmParams
            {
                Array = input,
                Target = target
            });

            // Assert
            Assert.AreEqual(result[0], 0);
            Assert.AreEqual(result[1], 1);
        }

        [TestMethod]
        public void AddTwoListNodesTest ()
        {
            // Arrange
            var customAlgorithm = new AddTwoListNodesAlgorithm();
            var list1 = new ListNode(2);
            list1.next = new ListNode(4);
            list1.next.next = new ListNode(3);

            var list2 = new ListNode(5);
            list2.next = new ListNode(6);
            list2.next.next = new ListNode(4);


            // Act
            var result = customAlgorithm.Run(new AddTwoListNodesArguments
            {
                ListNode1 = list1,
                ListNode2 = list2
            });

            // Assert
            Assert.AreEqual(7, result.val);
            Assert.AreEqual(0, result.next.val);
            Assert.AreEqual(8, result.next.next.val);
        }

        [TestMethod]
        public void SimpleGraph()
        {
            var customAlgorithm = new SimpleGraphAlgorithm();
            customAlgorithm.Run(7);

            Console.WriteLine("Hello Dijkstra!");
        }

        [TestMethod]
        public void DirectoryCreator()
        {
            var input = new string []{ "dir1", "dir1", "dir2", "dir3", "dir1", "dir2"};
            var expected = new string[] { "dir1", "dir1(1)", "dir2", "dir3", "dir1(2)", "dir2(1)" };

            var algo = new DirectoryCreatorCustomAlgorithm();

            var result = algo.Run(input);

            for (int i = 0; i < input.Length; i++)
                Assert.AreEqual(expected[i], result[i]);
            


            Console.WriteLine("Result: " + string.Join(", ", result));
        }

    }
}
