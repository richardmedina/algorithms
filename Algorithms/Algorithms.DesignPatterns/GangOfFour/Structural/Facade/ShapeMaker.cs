using Algorithms.DesignPatterns.GangOfFour.Structural.Facade.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Facade
{
    public class ShapeMaker : IShapeMaker
    {
        public IShape CreateCircle()
        {
            return new Circle();
        }

        public IShape CreateSquare()
        {
            return new Square();
        }

        public IShape CreateTriangle()
        {
            return new Triangle();
        }
    }
}
