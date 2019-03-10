using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Creational.FactoryMethod
{
    public abstract class Document
    {
        public virtual void Open()
        {
            Console.WriteLine("Opening Document");
        }
        public virtual void Close()
        {
            Console.WriteLine("Closing Document");
        }

        public abstract string GetDocumentType();
    }
}
