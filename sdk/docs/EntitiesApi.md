# Lusid.Sdk.Api.EntitiesApi

All URIs are relative to *http://local-unit-test-server.lusid.com:59337*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPortfolioChanges**](EntitiesApi.md#getportfoliochanges) | **GET** /api/entities/changes/portfolios | [EARLY ACCESS] GetPortfolioChanges: Get the next change to each portfolio in a scope.


<a name="getportfoliochanges"></a>
# **GetPortfolioChanges**
> ResourceListOfChange GetPortfolioChanges (string scope, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetPortfolioChanges: Get the next change to each portfolio in a scope.

Gets the time of the next (earliest effective at) modification (correction and/or amendment) to each portfolio in a scope relative to a point in bitemporal time.  Includes changes from parent portfolios in different scopes.  Excludes changes from subcriptions (e.g corporate actions).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioChangesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:59337";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EntitiesApi(config);
            var scope = scope_example;  // string | The scope
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective date of the origin.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The as-at date of the origin. (optional) 

            try
            {
                // [EARLY ACCESS] GetPortfolioChanges: Get the next change to each portfolio in a scope.
                ResourceListOfChange result = apiInstance.GetPortfolioChanges(scope, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EntitiesApi.GetPortfolioChanges: " + e.Message );
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
 **scope** | **string**| The scope | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective date of the origin. | 
 **asAt** | **DateTimeOffset?**| The as-at date of the origin. | [optional] 

### Return type

[**ResourceListOfChange**](ResourceListOfChange.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | The details of the input related failure |  -  |
| **200** | A list of portfolio changes in the requested scope relative to the specified time. |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

