﻿using System.Net;
using System.Text;

namespace Bixby_web_server.Helpers;

public class HttpContext
{
    public HttpContext(HttpListenerRequest request, HttpListenerResponse response)
    {
        Request = request;
        Response = response;
        Url = $"{request.Url.Scheme}://{request.Url.Authority}";
    }

    public HttpListenerRequest Request { get; }
    public HttpListenerResponse Response { get; }
    public string Url { get; } // Variable to store the URL
    public string[] DynamicPath { get; private set; } = { }; // Variable to store the dynamic path
    public string? ResponseContent { get; set; } // Property to store the response content

    public void ExtractDynamicPath(string pattern)
    {
        var path = Request.Url.LocalPath;
        var pathSegments = path.Split('/');
        var patternSegments = pattern.Split('/');
        var dynamicSegments = new List<string>();

        if (pathSegments.Length == patternSegments.Length)
            for (var i = 0; i < pathSegments.Length; i++)
                if (patternSegments[i].StartsWith("{") && patternSegments[i].EndsWith("}"))
                    dynamicSegments.Add(pathSegments[i]);
        DynamicPath = dynamicSegments.ToArray();
    }

    public async Task WriteResponseAsync(string? content, string contentType,
        HttpStatusCode statusCode = HttpStatusCode.OK, Dictionary<string, string>? headers = null)
    {
        ResponseContent = content;
        var buffer = Encoding.UTF8.GetBytes(content);
        Response.StatusCode = (int)statusCode;
        Response.ContentType = contentType;
        Response.ContentLength64 = buffer.Length;

        if (headers != null)
            foreach (var header in headers)
                Response.Headers.Add(header.Key, header.Value);
        await Response.OutputStream.WriteAsync(buffer, 0, buffer.Length).ConfigureAwait(false);
        Response.Close();
    }

    public async Task WriteResponse(string? content, string contentType, HttpStatusCode statusCode = HttpStatusCode.OK,
        Dictionary<string, string>? headers = null)
    {
        ResponseContent = content;
        var buffer = Encoding.UTF8.GetBytes(content);
        Response.StatusCode = (int)statusCode;
        Response.ContentType = contentType;
        Response.ContentLength64 = buffer.Length;
        if (headers != null)
            foreach (var header in headers)
                Response.Headers.Add(header.Key, header.Value);
        await Response.OutputStream.WriteAsync(buffer, 0, buffer.Length).ConfigureAwait(false);
    }
}