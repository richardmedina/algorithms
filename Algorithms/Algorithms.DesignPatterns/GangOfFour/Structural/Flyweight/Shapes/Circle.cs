using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Flyweight.Shapes
{
    public class Circle : IShape
    {
        public string Color { get; set; }

        public void Draw()
        {
            Console.WriteLine($"Drawing Circle with Color: {Color}");
        }
    }
}
