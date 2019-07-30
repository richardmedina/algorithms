using Algorithms.DataStructures.GraphsTheory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests.DataStructures
{
    [TestClass]
    public class GraphTests
    {

        [TestMethod]
        public void GraphsTopologicTest ()
        {
            var graph = new Graph(7);

            graph.AddArista(0, 1, 1);
            graph.AddArista(0, 2, 1);
            graph.AddArista(0, 3, 1);

            graph.AddArista(1, 3, 1);
            graph.AddArista(1, 4, 1);
            graph.AddArista(2, 5, 1);

            graph.AddArista(3, 2, 1);
            graph.AddArista(3, 5, 1);
            graph.AddArista(3, 6, 1);

            graph.AddArista(4, 3, 1);
            graph.AddArista(4, 6, 1);
            graph.AddArista(6, 5, 1);

            graph.ShowAdjacency();
            graph.CalculateIndegree();
            graph.ShowInDegree();

            graph.TopologicSort();
        }
    }
}
