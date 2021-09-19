# Lusid.Sdk.Api.ScopesApi

All URIs are relative to *http://local-unit-test-server.lusid.com:53466*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListScopes**](ScopesApi.md#listscopes) | **GET** /api/scopes | [EARLY ACCESS] List Scopes


<a name="listscopes"></a>
# **ListScopes**
> ResourceListOfScopeDefinition ListScopes (string filter = null)

[EARLY ACCESS] List Scopes

List all the scopes that contain data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListScopesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:53466";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScopesApi(config);
            var filter = filter_example;  // string | Expression to filter the result set.              For example, to filter on the Scope, use \"scope eq 'string'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] List Scopes
                ResourceListOfScopeDefinition result = apiInstance.ListScopes(filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScopesApi.ListScopes: " + e.Message );
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
 **filter** | **string**| Expression to filter the result set.              For example, to filter on the Scope, use \&quot;scope eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

### Return type

[**ResourceListOfScopeDefinition**](ResourceListOfScopeDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of scopes |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

