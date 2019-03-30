using Algorithms.DesignPatterns.GangOfFour.Structural.Adapter;
using Algorithms.DesignPatterns.GangOfFour.Structural.Bridge;
using Algorithms.DesignPatterns.GangOfFour.Structural.Bridge.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour
{
    [TestClass, TestCategory("Algorithms.DesignPatterns.GangOfFour.Structural")]
    public class StructuralTests
    {
        [TestMethod]
        public void Adapter ()
        {
            // Arrange
            IOperativeSystem[] systems = { new WindowsOperativeSystem(), new MacOperativeSystem(), new LinuxOperativeSystemAdapter() };

            //Act
            foreach (IOperativeSystem system in systems)
            {
                system.TurnOn();
                system.ShutDown();
            }
        }

        [TestMethod]
        public void Bridge ()
        {
            var order = new AscOrder();
            var sort = new QuickSort(order);
            var array = new []{ 3, 5, 1, 2, 4 };

            var sortedArray = sort.Sort(array).ToArray ();

            for (var i = 1; i < 5; i ++)
            {
                Assert.AreEqual(i, sortedArray[i - 1]);
            }
        }
    }
}
