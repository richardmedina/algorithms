using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Creational.Builder
{
    /// <summary>
    /// This class represents the Director for creating Memes using Builder Design Pattern
    /// </summary>
    public class MemeBuilderDirector
    {
        public MemeBuilder MemeBuilder;

        public void SetMemeBuilder (MemeBuilder memeBuilder)
        {
            MemeBuilder = memeBuilder;
        }

        public Meme GetMeme ()
        {
            return MemeBuilder.GetMeme();
        }

        public void BuildMeme ()
        {
            MemeBuilder.CreateMeme();
            MemeBuilder.BuildFilter();
            MemeBuilder.BuildFrame();
            MemeBuilder.BuildText();
        }
    }
}
