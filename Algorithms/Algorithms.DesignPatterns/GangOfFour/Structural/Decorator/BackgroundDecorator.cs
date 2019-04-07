using Algorithms.DesignPatterns.GangOfFour.Structural.Decorator.Drawing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Decorator
{
    public class BackgroundDecorator : IShape
    {
        private readonly IShape shape;
        public BackgroundDecorator(IShape shape)
        {
            this.shape = shape;
        }
        public bool Draw()
        {
            shape.Draw();
            Console.WriteLine("Setting background");

            return true;
        }
    }
}
