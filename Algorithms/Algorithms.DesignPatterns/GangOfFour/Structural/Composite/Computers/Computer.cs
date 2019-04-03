using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Composite.Computers
{
    public class Computer : List<IComponent>, IComponentContainer<IComponent>
    {
        private string name;
        public Computer(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        public decimal GetPrice()
        {
            var price = 0M;
            foreach(var component in this)
            {
                price += component.GetPrice();
            }

            return price;
        }
    }
}
