# Lusid.Sdk.Api.LoginApi

All URIs are relative to *http://local-unit-test-server.lusid.com:55426*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSamlIdentityProviderId**](LoginApi.md#getsamlidentityproviderid) | **GET** /api/login/saml/{domain} | GetSamlIdentityProviderId: Get SAML Identity Provider


<a name="getsamlidentityproviderid"></a>
# **GetSamlIdentityProviderId**
> string GetSamlIdentityProviderId (string domain)

GetSamlIdentityProviderId: Get SAML Identity Provider

Get the unique identifier for the SAML 2.0 Identity Provider to be used for domain.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetSamlIdentityProviderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:55426";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoginApi(config);
            var domain = domain_example;  // string | The domain that the user will be logging in to

            try
            {
                // GetSamlIdentityProviderId: Get SAML Identity Provider
                string result = apiInstance.GetSamlIdentityProviderId(domain);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginApi.GetSamlIdentityProviderId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| The domain that the user will be logging in to | 

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The ID of the SAML Identity Provider to be used (may be null) |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

