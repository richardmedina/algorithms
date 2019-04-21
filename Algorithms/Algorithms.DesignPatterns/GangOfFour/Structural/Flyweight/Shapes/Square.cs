using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Flyweight.Shapes
{
    public class Square : IShape
    {
        public string Color { get; set; }
        public void Draw()
        {
            Console.WriteLine($"Drawing Square with Color: {Color}");
        }
    }
}
