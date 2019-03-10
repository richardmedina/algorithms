using Algorithms.DesignPatterns.GangOfFour.Creational.FactoryMethod.Pdf;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Creational.FactoryMethod.Pdf
{
    public class PdfDocumentFactory : IDocumentFactory
    {
        public Document CreateDocument()
        {
            return new PdfDocument();
        }
    }
}
