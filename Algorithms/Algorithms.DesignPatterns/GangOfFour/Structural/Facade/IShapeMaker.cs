using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Facade
{
    public interface IShapeMaker
    {
        IShape CreateCircle();
        IShape CreateSquare();
        IShape CreateTriangle();
    }
}
