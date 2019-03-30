using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Bridge.Impl
{
    public class AscOrder : IOrder
    {
        public int Compare(int x, int y)
        {
            if (x == y) return 0;
            return x < y ? -1 : 1;
        }
    }
}
