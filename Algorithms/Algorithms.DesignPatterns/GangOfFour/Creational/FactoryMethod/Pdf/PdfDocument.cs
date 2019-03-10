using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Creational.FactoryMethod.Pdf
{
    public class PdfDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening Pdf MyDocument");
        }

        public override void Close()
        {
            Console.WriteLine("Closing Pdf MyDocument");
        }

        public override string GetDocumentType()
        {
            return "Pdf";
        }
    }
}
