using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Creational.FactoryMethod.Xml
{
    public class XmlDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening Xml Document");
        }
        public override void Close()
        {
            Console.WriteLine("Closing Xml Document");
        }

        public override string GetDocumentType()
        {
            return "Xml";
        }
    }
}
