using Algorithms.DesignPatterns.GangOfFour.Creational.FactoryMethod.Xml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Creational.FactoryMethod.Xml
{
    public class XmlDocumentFactory : IDocumentFactory
    {
        public Document CreateDocument()
        {
            return new XmlDocument();
        }
    }
}
