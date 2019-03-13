using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Creational.Builder
{
    public abstract class MemeBuilder
    {
        protected Meme Meme;

        public Meme GetMeme ()
        {
            return Meme;
        }

        public void CreateMeme ()
        {
            Meme = new Meme();
        }

        public abstract void BuildFilter();
        public abstract void BuildFrame();
        public abstract void BuildText();
    }
}
