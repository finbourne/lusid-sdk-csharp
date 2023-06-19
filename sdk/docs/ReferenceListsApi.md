# Lusid.Sdk.Api.ReferenceListsApi

All URIs are relative to *https://www.lusid.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteReferenceList**](ReferenceListsApi.md#deletereferencelist) | **DELETE** /api/referencelists/{scope}/{code} | [EARLY ACCESS] DeleteReferenceList: Delete Reference List
[**GetReferenceList**](ReferenceListsApi.md#getreferencelist) | **GET** /api/referencelists/{scope}/{code} | [EARLY ACCESS] GetReferenceList: Get Reference List
[**ListReferenceLists**](ReferenceListsApi.md#listreferencelists) | **GET** /api/referencelists | [EARLY ACCESS] ListReferenceLists: List Reference Lists
[**UpsertReferenceList**](ReferenceListsApi.md#upsertreferencelist) | **POST** /api/referencelists | [EARLY ACCESS] UpsertReferenceList: Upsert Reference List


<a name="deletereferencelist"></a>
# **DeleteReferenceList**
> DeletedEntityResponse DeleteReferenceList (string scope, string code)

[EARLY ACCESS] DeleteReferenceList: Delete Reference List

Delete a Reference List instance.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteReferenceListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReferenceListsApi(config);
            var scope = scope_example;  // string | The scope to which the Reference List belongs.
            var code = code_example;  // string | The Reference List's unique identifier.

            try
            {
                // [EARLY ACCESS] DeleteReferenceList: Delete Reference List
                DeletedEntityResponse result = apiInstance.DeleteReferenceList(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceListsApi.DeleteReferenceList: " + e.Message );
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
 **scope** | **string**| The scope to which the Reference List belongs. | 
 **code** | **string**| The Reference List&#39;s unique identifier. | 

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
| **200** | The deleted reference list response. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreferencelist"></a>
# **GetReferenceList**
> ReferenceListResponse GetReferenceList (string scope, string code, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetReferenceList: Get Reference List

Retrieve a Reference List instance at a point in AsAt time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetReferenceListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReferenceListsApi(config);
            var scope = scope_example;  // string | The scope to which the Reference List belongs.
            var code = code_example;  // string | The Reference List's unique identifier.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the Reference List. Defaults to return the latest version of the Reference List if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] GetReferenceList: Get Reference List
                ReferenceListResponse result = apiInstance.GetReferenceList(scope, code, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceListsApi.GetReferenceList: " + e.Message );
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
 **scope** | **string**| The scope to which the Reference List belongs. | 
 **code** | **string**| The Reference List&#39;s unique identifier. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the Reference List. Defaults to return the latest version of the Reference List if not specified. | [optional] 

### Return type

[**ReferenceListResponse**](ReferenceListResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Reference List matching the requested identifier. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listreferencelists"></a>
# **ListReferenceLists**
> PagedResourceListOfReferenceListResponse ListReferenceLists (DateTimeOffset? asAt = null, string page = null, int? limit = null, string filter = null)

[EARLY ACCESS] ListReferenceLists: List Reference Lists

List all the Reference Lists matching particular criteria.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListReferenceListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReferenceListsApi(config);
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list Reference Lists. Defaults to return the latest version of Reference Lists if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing Reference Lists from a previous call to list Reference Lists.              This value is returned from the previous call. If a pagination token is provided, the filter, limit and asAt fields              must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this number. Defaults to 100 if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] ListReferenceLists: List Reference Lists
                PagedResourceListOfReferenceListResponse result = apiInstance.ListReferenceLists(asAt, page, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceListsApi.ListReferenceLists: " + e.Message );
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
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list Reference Lists. Defaults to return the latest version of Reference Lists if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing Reference Lists from a previous call to list Reference Lists.              This value is returned from the previous call. If a pagination token is provided, the filter, limit and asAt fields              must not have changed since the original request. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this number. Defaults to 100 if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional] 

### Return type

[**PagedResourceListOfReferenceListResponse**](PagedResourceListOfReferenceListResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A collection of Reference Lists. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertreferencelist"></a>
# **UpsertReferenceList**
> ReferenceListResponse UpsertReferenceList (ReferenceListRequest referenceListRequest = null)

[EARLY ACCESS] UpsertReferenceList: Upsert Reference List

Insert the Reference List if it does not exist or update the Reference List with the supplied state if it does exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertReferenceListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReferenceListsApi(config);
            var referenceListRequest = new ReferenceListRequest(); // ReferenceListRequest | The payload describing the Reference List instance. (optional) 

            try
            {
                // [EARLY ACCESS] UpsertReferenceList: Upsert Reference List
                ReferenceListResponse result = apiInstance.UpsertReferenceList(referenceListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceListsApi.UpsertReferenceList: " + e.Message );
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
 **referenceListRequest** | [**ReferenceListRequest**](ReferenceListRequest.md)| The payload describing the Reference List instance. | [optional] 

### Return type

[**ReferenceListResponse**](ReferenceListResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The upserted Reference List instance. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

