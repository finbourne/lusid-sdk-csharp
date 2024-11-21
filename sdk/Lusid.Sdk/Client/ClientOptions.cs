using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using Lusid.Sdk.Client.Auth;

namespace Lusid.Sdk.Client;

/// <summary>
/// Configuration options provided to the client implementing <see cref="IClient"/>
/// </summary>
public class ClientOptions {
    
    /// <summary>
    /// The base url should include the scheme + domain, and not end in a forward slash
    /// eg. https://example.lusid.com
    /// </summary>
    public ClientOptions(string baseUrl)
    {
        BaseUrl = baseUrl;
    }

    /// <summary>
    /// Base URL for all requests made with this client instance.
    /// It should include the scheme + domain, and not end in a forward slash
    /// eg. https://example.lusid.com
    /// </summary>
    public string BaseUrl { get; }

    /// <summary>
    /// The authenticator that will be used to populate the request with the necessary authentication data
    /// </summary>
    public OAuthAuthenticator? Authenticator { get; set; }

    /// <summary>
    /// X509CertificateCollection to be sent with the request
    /// </summary>
    public X509CertificateCollection? ClientCertificates { get; set; }

    /// <summary>
    /// The proxy to use when making requests. Default is null, which will use the default system proxy if one is set.
    /// </summary>
    public IWebProxy? Proxy { get; set; }

    /// <summary>
    /// The value of the User-Agent header to be sent with requests
    /// </summary>
    public string? UserAgent { get; set; }

    /// <summary>
    /// The client side timeout for the request
    /// </summary>
    public TimeSpan? Timeout { get; set; }
}
