# Lusid.Sdk.Api.CorporateActionSourcesApi

All URIs are relative to *http://localhost/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BatchUpsertCorporateActions**](CorporateActionSourcesApi.md#batchupsertcorporateactions) | **POST** /api/corporateactionsources/{scope}/{code}/corporateactions | [BETA] Upsert corporate actions
[**CreateCorporateActionSource**](CorporateActionSourcesApi.md#createcorporateactionsource) | **POST** /api/corporateactionsources | [BETA] Create Corporate Action Source
[**DeleteCorporateActionSource**](CorporateActionSourcesApi.md#deletecorporateactionsource) | **DELETE** /api/corporateactionsources/{scope}/{code} | [BETA] Delete a corporate action source
[**GetCorporateActions**](CorporateActionSourcesApi.md#getcorporateactions) | **GET** /api/corporateactionsources/{scope}/{code}/corporateactions | [BETA] Get corporate actions
[**ListCorporateActionSources**](CorporateActionSourcesApi.md#listcorporateactionsources) | **GET** /api/corporateactionsources | [BETA] Get corporate action sources


<a name="batchupsertcorporateactions"></a>
# **BatchUpsertCorporateActions**
> UpsertCorporateActionsResponse BatchUpsertCorporateActions (string scope, string code, List<UpsertCorporateActionRequest> actions = null)

[BETA] Upsert corporate actions

Attempt to create/update one or more corporate action in a specified corporate action source. Failed actions will be identified in the body of the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class BatchUpsertCorporateActionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporateActionSourcesApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of corporate action source
            var code = code_example;  // string | The code of the corporate action source
            var actions = new List<UpsertCorporateActionRequest>(); // List<UpsertCorporateActionRequest> | The corporate action definitions (optional) 

            try
            {
                // [BETA] Upsert corporate actions
                UpsertCorporateActionsResponse result = apiInstance.BatchUpsertCorporateActions(scope, code, actions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CorporateActionSourcesApi.BatchUpsertCorporateActions: " + e.Message );
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
 **scope** | **string**| The scope of corporate action source | 
 **code** | **string**| The code of the corporate action source | 
 **actions** | [**List&lt;UpsertCorporateActionRequest&gt;**](UpsertCorporateActionRequest.md)| The corporate action definitions | [optional] 

### Return type

[**UpsertCorporateActionsResponse**](UpsertCorporateActionsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created corporate actions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcorporateactionsource"></a>
# **CreateCorporateActionSource**
> CorporateActionSource CreateCorporateActionSource (CreateCorporateActionSourceRequest request)

[BETA] Create Corporate Action Source

Attempt to create a corporate action source.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateCorporateActionSourceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporateActionSourcesApi(Configuration.Default);
            var request = new CreateCorporateActionSourceRequest(); // CreateCorporateActionSourceRequest | The corporate action source definition

            try
            {
                // [BETA] Create Corporate Action Source
                CorporateActionSource result = apiInstance.CreateCorporateActionSource(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CorporateActionSourcesApi.CreateCorporateActionSource: " + e.Message );
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
 **request** | [**CreateCorporateActionSourceRequest**](CreateCorporateActionSourceRequest.md)| The corporate action source definition | 

### Return type

[**CorporateActionSource**](CorporateActionSource.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created corporate action source |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecorporateactionsource"></a>
# **DeleteCorporateActionSource**
> DeletedEntityResponse DeleteCorporateActionSource (string scope, string code)

[BETA] Delete a corporate action source

Deletes a single corporate action source

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteCorporateActionSourceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporateActionSourcesApi(Configuration.Default);
            var scope = scope_example;  // string | The Scope of the Corporate Action Source to be deleted
            var code = code_example;  // string | The Code of the Corporate Action Source to be deleted

            try
            {
                // [BETA] Delete a corporate action source
                DeletedEntityResponse result = apiInstance.DeleteCorporateActionSource(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CorporateActionSourcesApi.DeleteCorporateActionSource: " + e.Message );
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
 **scope** | **string**| The Scope of the Corporate Action Source to be deleted | 
 **code** | **string**| The Code of the Corporate Action Source to be deleted | 

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
| **200** | Corporate Action Source Deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporateactions"></a>
# **GetCorporateActions**
> ResourceListOfCorporateAction GetCorporateActions (string scope, string code, DateTimeOrCutLabel fromEffectiveAt = null, DateTimeOrCutLabel toEffectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)

[BETA] Get corporate actions

Gets corporate actions from a specific corporate action source

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetCorporateActionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporateActionSourcesApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the corporate action source
            var code = code_example;  // string | The code of the corporate action source
            var fromEffectiveAt = fromEffectiveAt_example;  // DateTimeOrCutLabel | Optional. The start effective date of the data range (optional) 
            var toEffectiveAt = toEffectiveAt_example;  // DateTimeOrCutLabel | Optional. The end effective date of the data range (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 

            try
            {
                // [BETA] Get corporate actions
                ResourceListOfCorporateAction result = apiInstance.GetCorporateActions(scope, code, fromEffectiveAt, toEffectiveAt, asAt, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CorporateActionSourcesApi.GetCorporateActions: " + e.Message );
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
 **scope** | **string**| The scope of the corporate action source | 
 **code** | **string**| The code of the corporate action source | 
 **fromEffectiveAt** | **DateTimeOrCutLabel**| Optional. The start effective date of the data range | [optional] 
 **toEffectiveAt** | **DateTimeOrCutLabel**| Optional. The end effective date of the data range | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 

### Return type

[**ResourceListOfCorporateAction**](ResourceListOfCorporateAction.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Corporate Actions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcorporateactionsources"></a>
# **ListCorporateActionSources**
> ResourceListOfCorporateActionSource ListCorporateActionSources (DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)

[BETA] Get corporate action sources

Gets a list of all corporate action sources

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListCorporateActionSourcesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporateActionSourcesApi(Configuration.Default);
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 

            try
            {
                // [BETA] Get corporate action sources
                ResourceListOfCorporateActionSource result = apiInstance.ListCorporateActionSources(asAt, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CorporateActionSourcesApi.ListCorporateActionSources: " + e.Message );
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
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 

### Return type

[**ResourceListOfCorporateActionSource**](ResourceListOfCorporateActionSource.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All Existing Corporate Action Sources |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

