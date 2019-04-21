using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Proxy
{
    public interface IHttpProxy
    {
        HttpProxyResponse Get(string resource);
        HttpProxyResponse Post(string resource, object body);

        HttpProxyResponse Put(string resource, object body);
        HttpProxyResponse Delete(string resource);
    }
}
