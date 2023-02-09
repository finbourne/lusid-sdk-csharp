# Lusid.Sdk.Api.ParticipationsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteParticipation**](ParticipationsApi.md#deleteparticipation) | **DELETE** /api/participations/{scope}/{code} | [EARLY ACCESS] DeleteParticipation: Delete participation
[**GetParticipation**](ParticipationsApi.md#getparticipation) | **GET** /api/participations/{scope}/{code} | [EARLY ACCESS] GetParticipation: Get Participation
[**ListParticipations**](ParticipationsApi.md#listparticipations) | **GET** /api/participations | [EARLY ACCESS] ListParticipations: List Participations
[**UpsertParticipations**](ParticipationsApi.md#upsertparticipations) | **POST** /api/participations | [EARLY ACCESS] UpsertParticipations: Upsert Participation


<a name="deleteparticipation"></a>
# **DeleteParticipation**
> DeletedEntityResponse DeleteParticipation (string scope, string code)

[EARLY ACCESS] DeleteParticipation: Delete participation

Delete an participation. Deletion will be valid from the participation's creation datetime.  This means that the participation will no longer exist at any effective datetime from the asAt datetime of deletion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteParticipationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ParticipationsApi(config);
            var scope = scope_example;  // string | The participation scope.
            var code = code_example;  // string | The participation's code. This, together with the scope uniquely identifies the participation to delete.

            try
            {
                // [EARLY ACCESS] DeleteParticipation: Delete participation
                DeletedEntityResponse result = apiInstance.DeleteParticipation(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ParticipationsApi.DeleteParticipation: " + e.Message );
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
 **scope** | **string**| The participation scope. | 
 **code** | **string**| The participation&#39;s code. This, together with the scope uniquely identifies the participation to delete. | 

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
| **200** | The response from deleting an participation. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparticipation"></a>
# **GetParticipation**
> Participation GetParticipation (string scope, string code, DateTimeOffset? asAt = null, List<string> propertyKeys = null)

[EARLY ACCESS] GetParticipation: Get Participation

Fetch a Participation that matches the specified identifier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetParticipationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ParticipationsApi(config);
            var scope = scope_example;  // string | The scope to which the participation belongs.
            var code = code_example;  // string | The participation's unique identifier.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the participation. Defaults to return the latest version of the participation if not specified. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Participation\" domain to decorate onto the participation.              These take the format {domain}/{scope}/{code} e.g. \"Participation/system/Name\". (optional) 

            try
            {
                // [EARLY ACCESS] GetParticipation: Get Participation
                Participation result = apiInstance.GetParticipation(scope, code, asAt, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ParticipationsApi.GetParticipation: " + e.Message );
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
 **scope** | **string**| The scope to which the participation belongs. | 
 **code** | **string**| The participation&#39;s unique identifier. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the participation. Defaults to return the latest version of the participation if not specified. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Participation\&quot; domain to decorate onto the participation.              These take the format {domain}/{scope}/{code} e.g. \&quot;Participation/system/Name\&quot;. | [optional] 

### Return type

[**Participation**](Participation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The participation matching the given identifier. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listparticipations"></a>
# **ListParticipations**
> PagedResourceListOfParticipation ListParticipations (DateTimeOffset? asAt = null, string page = null, List<string> sortBy = null, int? limit = null, string filter = null, List<string> propertyKeys = null)

[EARLY ACCESS] ListParticipations: List Participations

Fetch the last pre-AsAt date version of each Participation in scope (does not fetch the entire history).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListParticipationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ParticipationsApi(config);
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the participation. Defaults to return the latest version of the participation if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing participations from a previous call to list participations.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional) 
            var sortBy = new List<string>(); // List<string> | Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Participation\" domain to decorate onto each participation.                  These take the format {domain}/{scope}/{code} e.g. \"Participation/system/Name\". (optional) 

            try
            {
                // [EARLY ACCESS] ListParticipations: List Participations
                PagedResourceListOfParticipation result = apiInstance.ListParticipations(asAt, page, sortBy, limit, filter, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ParticipationsApi.ListParticipations: " + e.Message );
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
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the participation. Defaults to return the latest version of the participation if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing participations from a previous call to list participations.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Participation\&quot; domain to decorate onto each participation.                  These take the format {domain}/{scope}/{code} e.g. \&quot;Participation/system/Name\&quot;. | [optional] 

### Return type

[**PagedResourceListOfParticipation**](PagedResourceListOfParticipation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Participations in scope. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertparticipations"></a>
# **UpsertParticipations**
> ResourceListOfParticipation UpsertParticipations (ParticipationSetRequest participationSetRequest = null)

[EARLY ACCESS] UpsertParticipations: Upsert Participation

Upsert; update existing participations with given ids, or create new participations otherwise.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertParticipationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ParticipationsApi(config);
            var participationSetRequest = new ParticipationSetRequest(); // ParticipationSetRequest | The collection of participation requests. (optional) 

            try
            {
                // [EARLY ACCESS] UpsertParticipations: Upsert Participation
                ResourceListOfParticipation result = apiInstance.UpsertParticipations(participationSetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ParticipationsApi.UpsertParticipations: " + e.Message );
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
 **participationSetRequest** | [**ParticipationSetRequest**](ParticipationSetRequest.md)| The collection of participation requests. | [optional] 

### Return type

[**ResourceListOfParticipation**](ResourceListOfParticipation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A collection of participations. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

