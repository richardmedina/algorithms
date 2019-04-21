using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Flyweight
{
    public interface IShape
    {
        string Color { get; set; }
        void Draw();
    }
}
