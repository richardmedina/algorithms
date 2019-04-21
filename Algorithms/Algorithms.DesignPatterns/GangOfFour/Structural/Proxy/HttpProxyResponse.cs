using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Proxy
{
    public class HttpProxyResponse
    {
        public Dictionary<string, string> Headers;
        public object Body { get; set; }
        public int HttpStatusCode { get; set; }
    }
}
