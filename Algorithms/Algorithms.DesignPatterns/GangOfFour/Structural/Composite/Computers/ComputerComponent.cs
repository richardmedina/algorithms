using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Composite.Computers
{
    public class ComputerComponent : IComponent
    {
        private string name { get; set; }
        private decimal price { get; set; }
        public ComputerComponent(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public string GetName()
        {
            return name;
        }

        public decimal GetPrice()
        {
            return price;
        }
    }
}
