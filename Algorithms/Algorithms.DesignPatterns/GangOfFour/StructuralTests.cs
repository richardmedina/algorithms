using Algorithms.DesignPatterns.GangOfFour.Structural.Adapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour
{
    [TestClass, TestCategory("Algorithms.DesignPatterns.GangOfFour.Structural")]
    public class StructuralTests
    {
        [TestMethod]
        public void Adapter ()
        {
            // Arrange
            IOperativeSystem[] systems = { new WindowsOperativeSystem(), new MacOperativeSystem(), new LinuxOperativeSystemAdapter() };

            //Act
            foreach (IOperativeSystem system in systems)
            {
                system.TurnOn();
                system.ShutDown();
            }
        }
    }
}
