using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Lusid.Sdk.Extensions;

namespace Lusid.Sdk.Client;

/// <summary>
/// Statuses for a response
/// </summary>
public enum ResponseStatus { 
    /// <summary>
    /// Not Applicable, for when the Request has not yet been made
    /// </summary>
    None,

    /// <summary>
    /// <see cref="ResponseStatus"/> for when the request passes as a result of <see cref="HttpResponseMessage.IsSuccessStatusCode"/> being true, or when the response is <see cref="HttpStatusCode.NotFound"/>
    /// </summary>
    Completed,

    /// <summary>
    /// <see cref="ResponseStatus"/> for when the request fails as a result of <see cref="HttpResponseMessage.IsSuccessStatusCode"/> being false, except for the case when the response is <see cref="HttpStatusCode.NotFound"/>
    /// </summary>
    Error, 

    /// <summary>
    /// <see cref="ResponseStatus"/> for when the operation is cancelled due to the request taking longer than the length of time prescribed by <see cref="Request.Timeout"/> or due to the client implementing <see cref="IClient"/> timing out.
    /// </summary>
    TimedOut,

    /// <summary>
    /// <see cref="ResponseStatus"/> for when the operation is cancelled, due to reasons other than <see cref="TimedOut"/>
    /// </summary>
    Aborted
}

/// <summary>
/// A container for data sent back from the API including deserialized data
/// </summary>
/// <typeparam name="T">The type of data to deserialize to</typeparam>
public class Response<T> : ResponseBase {
    
    /// <summary/>
    public Response() {}
    
    /// <summary/>
    public Response(Request request) : base(request) {}
    
    /// <summary>
    /// The deserialized data
    /// </summary>
    public T? Data { get; set; }
}

/// <summary>
/// To be extended by <see cref="Response{T}"/>
/// This class exists to provide a type agnostic response to be used in <see cref="PollyApiRetryHandler"/>>
/// </summary>
public abstract class ResponseBase {
    
    /// <summary/>
    protected ResponseBase() {}
    
    /// <summary/>
    protected ResponseBase(Request request)
    {
        Request = request;
        Request.IncreaseNumberOfAttempts();
    }
    
    /// <summary>
    /// The request that was made to get this response
    /// </summary>
    /// <remarks>
    /// Mainly for debugging if ResponseStatus is not OK
    /// </remarks>
    public Request? Request { get; set; }

    /// <summary>
    /// String representation of response content
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// HTTP response status code
    /// </summary>
    public HttpStatusCode StatusCode { get; set; }

    /// <summary>
    /// Whether the HTTP response status code indicates success
    /// </summary>
    public bool IsSuccessStatusCode { get; set; }

    /// <summary>
    /// Whether the HTTP response status code indicates success and no other error occurred
    /// (deserialization, timeout, ...)
    /// </summary>
    public bool IsSuccessful => IsSuccessStatusCode && ResponseStatus == ResponseStatus.Completed;

    /// <summary>
    /// Description of HTTP status returned
    /// </summary>
    public string? StatusDescription { get; set; }

    /// <summary>
    /// Response content
    /// </summary>
    public byte[]? RawBytes { get; set; }

    /// <summary>
    /// Response headers returned by server with the response
    /// </summary>
    public IReadOnlyCollection<Header> Headers { get; set; } = new List<Header>();

    /// <summary>
    /// Status of the request. Will return Error for transport errors.
    /// HTTP errors will still return ResponseStatus.Completed, check StatusCode instead
    /// </summary>
    public ResponseStatus ResponseStatus { get; set; } = ResponseStatus.None;

    /// <summary>
    /// Transport or another non-HTTP error generated while attempting request
    /// </summary>
    public string? ErrorMessage { get; set; }

    /// <summary>
    /// The exception thrown during the request, if any
    /// </summary>
    public Exception? ErrorException { get; set; }
}