using Algorithms.DesignPatterns.GangOfFour.Creational.AbstractFactory;
using Algorithms.DesignPatterns.GangOfFour.Creational.AbstractFactory.MazeObjects;
using Algorithms.DesignPatterns.GangOfFour.Creational.AbstractFactory.MazeObjects.Enchanted;
using Algorithms.DesignPatterns.GangOfFour.Creational.FactoryMethod;
using Algorithms.DesignPatterns.GangOfFour.Creational.FactoryMethod.Pdf;
using Algorithms.DesignPatterns.GangOfFour.Creational.FactoryMethod.Xml;
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
            var factory = new DocumentFactory();
            var pdfDocument = factory.CreateDocument("Pdf");
            var xmlDocument = factory.CreateDocument("Xml");

            Assert.IsInstanceOfType(pdfDocument, typeof(PdfDocument));
            Assert.AreEqual("Pdf", pdfDocument.GetDocumentType());

            Assert.IsInstanceOfType(xmlDocument, typeof(XmlDocument));
            Assert.AreEqual("Xml", xmlDocument.GetDocumentType());
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
