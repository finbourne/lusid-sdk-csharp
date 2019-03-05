# Lusid.Sdk.Api.LoginApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSamlIdentityProviderId**](LoginApi.md#getsamlidentityproviderid) | **GET** /api/login/saml/{domain} | Get SAML Identity Provider


<a name="getsamlidentityproviderid"></a>
# **GetSamlIdentityProviderId**
> string GetSamlIdentityProviderId (string domain)

Get SAML Identity Provider

Get the unique identifier for the SAML 2.0 Identity Provider to be used for domain.

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetSamlIdentityProviderIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoginApi();
            var domain = domain_example;  // string | The domain that the user will be logging in to

            try
            {
                // Get SAML Identity Provider
                string result = apiInstance.GetSamlIdentityProviderId(domain);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoginApi.GetSamlIdentityProviderId: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

