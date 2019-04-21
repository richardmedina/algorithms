using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Proxy
{
    public class HttpProxyRequest
    {
        public string Resource { get; set; }
        public IDictionary<string, string> Headers { get; set; }
        public string Body { get; set; }
    }
}
