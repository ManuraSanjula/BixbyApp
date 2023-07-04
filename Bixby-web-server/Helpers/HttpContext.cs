using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Bixby_web_server.Helpers
{
    public class HttpContext
    {
        public HttpListenerRequest Request { get; }
        public HttpListenerResponse Response { get; }
        public string?[]? DynamicPath { get; private set; } = { }; // Variable to store the dynamic path
        public string ResponseContent { get; set; } // Property to store the response content

        public HttpContext(HttpListenerRequest request, HttpListenerResponse response)
        {
            Request = request;
            Response = response;
        }

        public void ExtractDynamicPath(string pattern)
        {
            string? path = Request.RawUrl;
            string[]? pathSegments = path?.Split('/');
            string[] patternSegments = pattern.Split('/');
            List<string> dynamicSegments = new List<string>();

            if (pathSegments != null && pathSegments.Length == patternSegments.Length)
            {
                for (int i = 0; i < pathSegments.Length; i++)
                {
                    if (patternSegments[i].StartsWith("{") && patternSegments[i].EndsWith("}"))
                    {
                        dynamicSegments.Add(pathSegments[i]);
                    }
                }
            }
            DynamicPath = dynamicSegments.ToArray();
        }

        public async Task WriteResponseAsync(string content, string contentType, HttpStatusCode statusCode = HttpStatusCode.OK, Dictionary<string, string>? headers = null)
        {
            ResponseContent = content;
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(content);
            Response.StatusCode = (int)statusCode;
            Response.ContentType = contentType;
            Response.ContentLength64 = buffer.Length;

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    Response.Headers.Add(header.Key, header.Value);
                }
            }
            await Response.OutputStream.WriteAsync(buffer, 0, buffer.Length).ConfigureAwait(false);
            Response.Close();
        }

        public async Task WriteResponse(string content, string contentType, HttpStatusCode statusCode = HttpStatusCode.OK, Dictionary<string, string>? headers = null)
        {
            ResponseContent = content;
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(content);
            Response.StatusCode = (int)statusCode;
            Response.ContentType = contentType;
            Response.ContentLength64 = buffer.Length;
            if (headers != null)
            {
                foreach (var header in headers)
                {
                    Response.Headers.Add(header.Key, header.Value);
                }
            }
            await Response.OutputStream.WriteAsync(buffer, 0, buffer.Length).ConfigureAwait(false);
        }
    }
}
