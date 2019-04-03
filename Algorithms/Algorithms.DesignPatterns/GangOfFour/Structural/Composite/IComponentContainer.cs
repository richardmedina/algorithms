using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Composite
{
    public interface IComponentContainer<T> : IList<T>, IComponent 
        where T: IComponent
    {
        
    }
}
