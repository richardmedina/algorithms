using Algorithms.DesignPatterns.GangOfFour.Creational.AbstractFactory;
using Algorithms.DesignPatterns.GangOfFour.Creational.AbstractFactory.MazeObjects;
using Algorithms.DesignPatterns.GangOfFour.Creational.AbstractFactory.MazeObjects.Enchanted;
using Algorithms.DesignPatterns.GangOfFour.Creational.FactoryMethod;
using Algorithms.DesignPatterns.GangOfFour.Creational.FactoryMethod.Pdf;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour
{
    [TestClass]
    public class CreationalTests
    {
        [TestMethod]
        public void FactoryMethod ()
        {
            IDocumentFactory factory = new PdfDocumentFactory();
            var document = factory.CreateDocument();

            Assert.IsInstanceOfType(document, typeof(PdfDocument));
            Assert.AreEqual("Pdf", document.GetDocumentType());
        }

        [TestMethod]
        public void AbstractFactory ()
        {
            IMazeFactory factory = new MazeFactory();
            IMazeFactory enchantedFactory = new EnchantedMazeFactory();

            var game = new MazeGame();

            Maze maze = game.CreateMaze(factory);
            Maze mazeWithEnchantedRooms = game.CreateMaze(enchantedFactory);

            foreach (Room room in maze.Rooms)
            {
                Assert.IsInstanceOfType(room, typeof(Room));
                Assert.IsNotInstanceOfType(room, typeof(EnchantedRoom));
            }

            foreach (Room room in mazeWithEnchantedRooms.Rooms)
                Assert.IsInstanceOfType(room, typeof(EnchantedRoom));
        }
    }
}
