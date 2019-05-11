using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CustomAlgorithms
{
    public interface ICustomAlgorithm<TResult, TParam>
    {
        TResult Run(TParam param);
    }
}
