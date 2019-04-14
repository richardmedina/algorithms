using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Decorator.Drawing
{
    public class Rectangle : IShape
    {
        public bool Draw()
        {
            Console.WriteLine("Drawing Rectangle");

            return true;
        }
    }
}
