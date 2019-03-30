using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Bridge
{
    public interface ISort
    {
        IEnumerable<int> Sort(IEnumerable<int> enumerable);
    }
}
