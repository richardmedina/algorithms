using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Creational.Builder.ConcreteBuilders
{
    public class SepiaMemeBuilder : MemeBuilder
    {
        public override void BuildFilter()
        {
            Meme.Filter = "Sepia";
        }

        public override void BuildFrame()
        {
            Meme.Frame = "Metallic";
        }

        public override void BuildText()
        {
            Meme.Text = "I came searching for copper but found gold";
        }
    }
}
