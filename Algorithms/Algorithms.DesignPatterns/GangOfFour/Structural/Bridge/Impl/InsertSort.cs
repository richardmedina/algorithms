using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Bridge.Impl
{
    public class InsertSort : ISort
    {
        private readonly IOrder _order;
        public InsertSort(IOrder order)
        {
            _order = order;
        }
        public IEnumerable<int> Sort(IEnumerable<int> enumerable)
        {
            return enumerable.OrderBy(i => i, _order);
        }
    }
}
