using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Creational.FactoryMethod
{
    /// <summary>
    /// The Factory. Represents the superclass for Factory Method implementation
    /// </summary>
    public interface IDocumentFactory
    {
        /// <summary>
        /// Factory Method
        /// </summary>
        /// <returns></returns>
        Document CreateDocument();
    }
}
