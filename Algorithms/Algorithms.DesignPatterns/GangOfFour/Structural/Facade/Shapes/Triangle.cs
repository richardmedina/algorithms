﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Facade.Shapes
{
    public class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Triangle");
        }
    }
}
