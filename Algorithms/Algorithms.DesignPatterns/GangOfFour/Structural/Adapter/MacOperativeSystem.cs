using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Adapter
{
    public class MacOperativeSystem : IOperativeSystem
    {
        public void ShutDown()
        {
            Console.WriteLine("Mac is shutting down ...Done");
        }

        public void TurnOn()
        {
            Console.WriteLine("Mac is turning o ...Done");
        }
    }
}
