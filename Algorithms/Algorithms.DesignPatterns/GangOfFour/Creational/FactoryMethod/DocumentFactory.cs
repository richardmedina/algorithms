using Algorithms.DesignPatterns.GangOfFour.Creational.FactoryMethod.Pdf;
using Algorithms.DesignPatterns.GangOfFour.Creational.FactoryMethod.Xml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Creational.FactoryMethod
{
    public class DocumentFactory
    {
        public Document CreateDocument(string type)
        {
            switch (type)
            {
                case "Pdf":
                    return new PdfDocument();
                case "Xml":
                    return new XmlDocument();

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
