using Algorithms.DesignPatterns.GangOfFour.Creational.AbstractFactory;
using Algorithms.DesignPatterns.GangOfFour.Creational.AbstractFactory.MazeObjects;
using Algorithms.DesignPatterns.GangOfFour.Creational.AbstractFactory.MazeObjects.Enchanted;
using Algorithms.DesignPatterns.GangOfFour.Creational.Builder;
using Algorithms.DesignPatterns.GangOfFour.Creational.Builder.ConcreteBuilders;
using Algorithms.DesignPatterns.GangOfFour.Creational.FactoryMethod;
using Algorithms.DesignPatterns.GangOfFour.Creational.FactoryMethod.Pdf;
using Algorithms.DesignPatterns.GangOfFour.Creational.FactoryMethod.Xml;
using Algorithms.DesignPatterns.GangOfFour.Creational.Prototype;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour
{
    [TestClass, TestCategory("Algorithms.DesignPatterns.GangOfFour.Creational")]
    public class CreationalTests
    {
        [TestMethod]
        public void FactoryMethod ()
        {
            // Arrange
            var factory = new DocumentFactory();

            // Act
            var pdfDocument = factory.CreateDocument("Pdf");
            var xmlDocument = factory.CreateDocument("Xml");

            // Assert
            Assert.IsInstanceOfType(pdfDocument, typeof(PdfDocument));
            Assert.AreEqual("Pdf", pdfDocument.GetDocumentType());

            Assert.IsInstanceOfType(xmlDocument, typeof(XmlDocument));
            Assert.AreEqual("Xml", xmlDocument.GetDocumentType());
        }

        [TestMethod]
        public void AbstractFactory ()
        {
            // Arrange
            IMazeFactory factory = new MazeFactory();
            IMazeFactory enchantedFactory = new EnchantedMazeFactory();

            // Act
            var game = new MazeGame();
            Maze maze = game.CreateMaze(factory);
            Maze mazeWithEnchantedRooms = game.CreateMaze(enchantedFactory);

            // Assert
            foreach (Room room in maze.Rooms)
            {
                Assert.IsInstanceOfType(room, typeof(Room));
                Assert.IsNotInstanceOfType(room, typeof(EnchantedRoom));
            }

            foreach (Room room in mazeWithEnchantedRooms.Rooms)
                Assert.IsInstanceOfType(room, typeof(EnchantedRoom));
        }

        [TestMethod]
        public void Builder ()
        {
            // Arrange
            var simpleMemeBuilder = new SimpleMemeBuilder();
            var sepiaMemeBuilder = new SepiaMemeBuilder();
            var memeBuilderDirector = new MemeBuilderDirector();

            // Act
            memeBuilderDirector.SetMemeBuilder(simpleMemeBuilder);
            memeBuilderDirector.BuildMeme();
            var simpleMeme = memeBuilderDirector.GetMeme();

            memeBuilderDirector.SetMemeBuilder(sepiaMemeBuilder);
            memeBuilderDirector.BuildMeme();
            var sepiaMeme = memeBuilderDirector.GetMeme();

            // Assert
            Assert.AreEqual("NoFilter", simpleMeme.Filter);
            Assert.AreEqual("SimpleFrame", simpleMeme.Frame);
            Assert.AreEqual("No more, no less", simpleMeme.Text);

            Assert.AreEqual("Sepia", sepiaMeme.Filter);
            Assert.AreEqual("Metallic", sepiaMeme.Frame);
            Assert.AreEqual("I came searching for copper but found gold", sepiaMeme.Text);

        }

        [TestMethod]
        public void Prototype ()
        {
            // Arrange
            var info1 = new PersonalInformation
            {
                FirstName = "Richard",
                LastName = "Medina",
                DateOfBirth = new DateTime (1982, 05, 18)
            };

            // Act
            PersonalInformation info2 = (PersonalInformation) info1.Clone();

            //Assert
            Assert.AreNotEqual(info1, info2);
            Assert.AreEqual(info1.FirstName, info2.FirstName);
            Assert.AreEqual(info1.LastName, info2.LastName);
            Assert.AreEqual(info1.DateOfBirth, info2.DateOfBirth);

        }
    }
}
