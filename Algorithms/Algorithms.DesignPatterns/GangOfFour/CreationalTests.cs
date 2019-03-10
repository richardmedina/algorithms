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
    }
}
