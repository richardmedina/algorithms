using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Creational.Builder.ConcreteBuilders
{
    public class SimpleMemeBuilder : MemeBuilder
    {
        public override void BuildFilter()
        {
            Meme.Filter = "NoFilter";
        }

        public override void BuildFrame()
        {
            Meme.Frame = "SimpleFrame";
        }

        public override void BuildText()
        {
            Meme.Text = "No more, no less";
        }
    }
}
