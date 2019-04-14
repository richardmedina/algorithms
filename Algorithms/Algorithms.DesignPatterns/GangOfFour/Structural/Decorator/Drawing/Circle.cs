using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Decorator.Drawing
{
    public class Circle : IShape
    {
        public bool Draw()
        {
            Console.WriteLine("Drawing Circle");
            return true;
        }
    }
}
