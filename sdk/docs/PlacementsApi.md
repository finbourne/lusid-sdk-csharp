# Lusid.Sdk.Api.PlacementsApi

All URIs are relative to *https://www.lusid.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePlacement**](PlacementsApi.md#deleteplacement) | **DELETE** /api/placements/{scope}/{code} | [EARLY ACCESS] DeletePlacement: Delete placement
[**GetPlacement**](PlacementsApi.md#getplacement) | **GET** /api/placements/{scope}/{code} | [EARLY ACCESS] GetPlacement: Get Placement
[**ListPlacements**](PlacementsApi.md#listplacements) | **GET** /api/placements | [EARLY ACCESS] ListPlacements: List Placements
[**UpsertPlacements**](PlacementsApi.md#upsertplacements) | **POST** /api/placements | [EARLY ACCESS] UpsertPlacements: Upsert Placement


<a name="deleteplacement"></a>
# **DeletePlacement**
> DeletedEntityResponse DeletePlacement (string scope, string code)

[EARLY ACCESS] DeletePlacement: Delete placement

Delete an placement. Deletion will be valid from the placement's creation datetime.  This means that the placement will no longer exist at any effective datetime from the asAt datetime of deletion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePlacementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlacementsApi(config);
            var scope = scope_example;  // string | The placement scope.
            var code = code_example;  // string | The placement's code. This, together with the scope uniquely identifies the placement to delete.

            try
            {
                // [EARLY ACCESS] DeletePlacement: Delete placement
                DeletedEntityResponse result = apiInstance.DeletePlacement(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacementsApi.DeletePlacement: " + e.Message );
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
 **scope** | **string**| The placement scope. | 
 **code** | **string**| The placement&#39;s code. This, together with the scope uniquely identifies the placement to delete. | 

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The response from deleting an placement. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplacement"></a>
# **GetPlacement**
> Placement GetPlacement (string scope, string code, DateTimeOffset? asAt = null, List<string> propertyKeys = null)

[EARLY ACCESS] GetPlacement: Get Placement

Fetch a Placement that matches the specified identifier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPlacementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlacementsApi(config);
            var scope = scope_example;  // string | The scope to which the placement belongs.
            var code = code_example;  // string | The placement's unique identifier.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the placement. Defaults to return the latest version of the placement if not specified. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Placement\" domain to decorate onto the placement.              These take the format {domain}/{scope}/{code} e.g. \"Placement/system/Name\". (optional) 

            try
            {
                // [EARLY ACCESS] GetPlacement: Get Placement
                Placement result = apiInstance.GetPlacement(scope, code, asAt, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacementsApi.GetPlacement: " + e.Message );
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
 **scope** | **string**| The scope to which the placement belongs. | 
 **code** | **string**| The placement&#39;s unique identifier. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the placement. Defaults to return the latest version of the placement if not specified. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Placement\&quot; domain to decorate onto the placement.              These take the format {domain}/{scope}/{code} e.g. \&quot;Placement/system/Name\&quot;. | [optional] 

### Return type

[**Placement**](Placement.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The placement matching the given identifier. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listplacements"></a>
# **ListPlacements**
> PagedResourceListOfPlacement ListPlacements (DateTimeOffset? asAt = null, string page = null, List<string> sortBy = null, int? limit = null, string filter = null, List<string> propertyKeys = null)

[EARLY ACCESS] ListPlacements: List Placements

Fetch the last pre-AsAt date version of each placement in scope (does not fetch the entire history).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListPlacementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlacementsApi(config);
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the placement. Defaults to return the latest version of the placement if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing placements from a previous call to list placements.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional) 
            var sortBy = new List<string>(); // List<string> | Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Placement\" domain to decorate onto each placement.                  These take the format {domain}/{scope}/{code} e.g. \"Placement/system/Name\". (optional) 

            try
            {
                // [EARLY ACCESS] ListPlacements: List Placements
                PagedResourceListOfPlacement result = apiInstance.ListPlacements(asAt, page, sortBy, limit, filter, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacementsApi.ListPlacements: " + e.Message );
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
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the placement. Defaults to return the latest version of the placement if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing placements from a previous call to list placements.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Placement\&quot; domain to decorate onto each placement.                  These take the format {domain}/{scope}/{code} e.g. \&quot;Placement/system/Name\&quot;. | [optional] 

### Return type

[**PagedResourceListOfPlacement**](PagedResourceListOfPlacement.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Placements in scope. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertplacements"></a>
# **UpsertPlacements**
> ResourceListOfPlacement UpsertPlacements (PlacementSetRequest placementSetRequest = null)

[EARLY ACCESS] UpsertPlacements: Upsert Placement

Upsert; update existing placements with given ids, or create new placements otherwise.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertPlacementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlacementsApi(config);
            var placementSetRequest = new PlacementSetRequest(); // PlacementSetRequest | The collection of placement requests. (optional) 

            try
            {
                // [EARLY ACCESS] UpsertPlacements: Upsert Placement
                ResourceListOfPlacement result = apiInstance.UpsertPlacements(placementSetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacementsApi.UpsertPlacements: " + e.Message );
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
 **placementSetRequest** | [**PlacementSetRequest**](PlacementSetRequest.md)| The collection of placement requests. | [optional] 

### Return type

[**ResourceListOfPlacement**](ResourceListOfPlacement.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A collection of placements. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

