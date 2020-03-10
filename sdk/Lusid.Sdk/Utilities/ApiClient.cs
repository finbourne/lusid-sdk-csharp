using System.Collections.Generic;
using RestSharp;

namespace Lusid.Sdk.Client
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ApiClient
    {
        partial void InterceptRequest(IRestRequest request)
        {
            var version = typeof(ApiClient).Assembly.GetName().Version;
            
            request.AddHeaders(new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("X-LUSID-SDK-Language", "C#"),
                new KeyValuePair<string, string>("X-LUSID-SDK-Version", $"{version.Major}.{version.Minor}.{version.Build}")
            });
        }
        
    }
}