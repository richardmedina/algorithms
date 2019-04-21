using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Structural.Proxy
{
    public class HttpProxy : IHttpProxy
    {
        public HttpProxy()
        {
        }
        public HttpProxyResponse Delete(string resource)
        {
            var request = CreateRequest(resource, null, null);
            
            return new HttpProxyResponse
            {
                HttpStatusCode = 200
            };
        }

        public HttpProxyResponse Get(string resource)
        {
            var request = CreateRequest(resource, null, null);

            return new HttpProxyResponse
            {
                HttpStatusCode = 200
            };
        }

        public HttpProxyResponse Post(string resource, object body)
        {
            var request = CreateRequest(resource, body, null);
            return new HttpProxyResponse
            {
                HttpStatusCode = 201
            };
        }

        public HttpProxyResponse Put(string resource, object body)
        {
            var request = CreateRequest(resource, body, null);
            return new HttpProxyResponse
            {
                HttpStatusCode = 200
            };
        }

        private HttpProxyRequest CreateRequest (string resource, object body, IDictionary<string, string>  headers)
        {
            return new HttpProxyRequest
            {
                Resource = resource,
                Body = (body ?? string.Empty).ToString (),
                Headers = headers
            };
        }
    }
}
