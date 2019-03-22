using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Adapter
{
    public class WindowsOperativeSystem : IOperativeSystem
    {
        public void ShutDown()
        {
            Console.WriteLine("Windows ShutDown");
        }

        public void TurnOn()
        {
            Console.WriteLine("Windows TurnOn");
        }
    }
}
