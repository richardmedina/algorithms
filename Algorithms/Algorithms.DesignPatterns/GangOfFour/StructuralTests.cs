using Algorithms.DesignPatterns.GangOfFour.Structural.Adapter;
using Algorithms.DesignPatterns.GangOfFour.Structural.Bridge.Impl;
using Algorithms.DesignPatterns.GangOfFour.Structural.Composite.Computers;
using Algorithms.DesignPatterns.GangOfFour.Structural.Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Decorator = Algorithms.DesignPatterns.GangOfFour.Structural.Decorator;
using Facade = Algorithms.DesignPatterns.GangOfFour.Structural.Facade;
using Flyweight = Algorithms.DesignPatterns.GangOfFour.Structural.Flyweight;

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
        public void Decorator ()
        {
            // Arrange
            Decorator.Drawing.IShape circle = new Decorator.Drawing.Circle();
            Decorator.Drawing.IShape rectangle = new Decorator.Drawing.Rectangle();
            Decorator.Drawing.IShape circleWithBackground = new Decorator.BackgroundDecorator(circle);
            Decorator.Drawing.IShape rectangleWithBackground = new Decorator.BackgroundDecorator(rectangle);

            // Act
            var circleResult = circle.Draw();
            var rectangleResult = rectangle.Draw();
            var circleWithBackgroundResult = circleWithBackground.Draw();
            var rectangleWithBackgroundResult = rectangleWithBackground.Draw();

            // Assert

            Assert.AreEqual(true, circleResult);
            Assert.AreEqual(true, rectangleResult);
            Assert.AreEqual(true, circleWithBackgroundResult);
            Assert.AreEqual(true, rectangleWithBackgroundResult);

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
            Assert.IsInstanceOfType(circle, typeof(Facade.Shapes.Circle));
            Assert.IsInstanceOfType(square, typeof(Facade.Shapes.Square));
            Assert.IsInstanceOfType(triangle, typeof(Facade.Shapes.Triangle));
        }

        [TestMethod]
        public void Flyweights ()
        {
            // Arrange
            Flyweight.FlyweightFactory factory = new Flyweight.FlyweightFactory();
            
            // Act
            for (int i = 0; i < 10; i ++)
            {
                var shape = factory.GetShape(i % 2 == 0 
                    ? Flyweight.ShapeType.Circle 
                    : Flyweight.ShapeType.Square);
                shape.Color = i % 3 == 0
                    ? "red"
                    : "blue";
                shape.Draw();
            }

            // Assert
            Assert.AreEqual(2, factory.GetShapesCount());
        }
    }
}
