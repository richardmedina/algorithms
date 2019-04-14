using Algorithms.DesignPatterns.GangOfFour.Structural.Adapter;
using Algorithms.DesignPatterns.GangOfFour.Structural.Bridge;
using Algorithms.DesignPatterns.GangOfFour.Structural.Bridge.Impl;
using Algorithms.DesignPatterns.GangOfFour.Structural.Composite.Computers;
using Algorithms.DesignPatterns.GangOfFour.Structural.Facade;
using Algorithms.DesignPatterns.GangOfFour.Structural.Facade.Shapes;
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
        public void Adapter()
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
        public void Bridge()
        {
            var order = new AscOrder();
            var sort = new QuickSort(order);
            var array = new[] { 3, 5, 1, 2, 4 };

            var sortedArray = sort.Sort(array).ToArray();

            for (var i = 1; i < 5; i++)
            {
                Assert.AreEqual(i, sortedArray[i - 1]);
            }
        }

        [TestMethod]
        public void Composite()
        {
            // Arrange
            var computer = new Computer("Cheap Computer");
            var motherboard = new ComputerComponent("Motherboard", 100);
            var cpu = new ComputerComponent("CPU", 150);
            var monitor = new ComputerComponent("Monitor", 50);
            computer.AddRange(new[] { motherboard, cpu, monitor });

            // Act
            var price = computer.GetPrice();

            // Assert
            Assert.AreEqual(300, price);
            Assert.AreEqual("Cheap Computer", computer.GetName());
            Assert.AreEqual("Motherboard", motherboard.GetName());
            Assert.AreEqual(100, motherboard.GetPrice());
            Assert.AreEqual("CPU", cpu.GetName());
            Assert.AreEqual(150, cpu.GetPrice());
            Assert.AreEqual("Monitor", monitor.GetName());
            Assert.AreEqual(50, monitor.GetPrice());
        }

        [TestMethod]
        public void Facade ()
        {
            // Arrange
            IShapeMaker shapeMaker = new ShapeMaker();

            // Act
            IShape circle = shapeMaker.CreateCircle();
            IShape square = shapeMaker.CreateSquare();
            IShape triangle = shapeMaker.CreateTriangle();

            // Assert
            Assert.IsInstanceOfType(circle, typeof(Circle));
            Assert.IsInstanceOfType(square, typeof(Square));
            Assert.IsInstanceOfType(triangle, typeof(Triangle));
        }
    }
}
