using System;
using System.Collections.Generic;
using System.IO;

namespace Lusid.Sdk.Client;

/// <summary>
/// Data formats
/// </summary>
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
public enum DataFormat
{
    Json, 
    Xml, 
    Binary, 
    None
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// A container for data used to make API requests
/// </summary>
public class Request
{
    /// <summary>
    /// Request form parameters
    /// </summary>
    public Dictionary<string, string> FormParameters { get; set; } = new();
    
    /// <summary>
    /// Request query string parameters
    /// </summary>
    public Multimap<string, string> QueryParameters { get; set; } = new();
    
    /// <summary>
    /// Parameters to be bound to segments of the request URL.
    /// Used in <see cref="Resource"/>
    /// </summary>
    public Dictionary<string, string> PathParameters { get; set; } = new();
    
    /// <summary>
    /// Files to be uploaded with the request
    /// </summary>
    public Multimap<string, Stream> FileParameters { get; set; } = new(); 

    /// <summary>
    /// Request headers
    /// </summary>
    public Multimap<string, string> Headers { get; set; } = new();

    /// <summary>
    /// Determines what HTTP method to use for this request. See <see cref="HttpMethod"/> for valid values.
    /// Default is <see cref="HttpMethod.Get"/>
    /// </summary>
    public HttpMethod Method { get; set; } = HttpMethod.Get;

    /// <summary>
    /// Client side timeout for the request
    /// </summary>
    public TimeSpan? Timeout { get; set; }
    
    /// <summary>
    /// The resource URL to make the request against.
    /// Tokens should be substituted with <see cref="PathParameters"/>> parameters matched by name.
    /// Does not include a leading slash, or the schema or domain.
    /// Should be combined with a base URL to assemble final URL:
    /// {BaseUrl}/{Resource} (BaseUrl is scheme + domain, e.g. https://example.lusid.com)
    /// </summary>
    /// <example>
    /// request.Resource = "Foo/{FooId}";
    /// request.PathParameters.Add("FooId", "123");
    /// </example>
    public string Resource { get; set; } = "";
    
    /// <summary>
    /// Serializer to use when writing request bodies.
    /// </summary>
    public DataFormat RequestFormat { get; set; }
    
    /// <summary>
    /// The number of attempts that were made to send this request
    /// </summary>
    /// <remarks>
    /// This number is incremented each time the RestClient sends the request.
    /// </remarks>
    public int Attempts { get; private set; }
    
    internal void IncreaseNumberOfAttempts() => Attempts++;
    
    /// <summary>
    /// The body of the request
    /// </summary>
    public object? Body { get; set; }
}
