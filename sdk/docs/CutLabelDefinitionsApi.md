# Lusid.Sdk.Api.CutLabelDefinitionsApi

All URIs are relative to *http://local-unit-test-server.lusid.com:43652*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCutLabelDefinition**](CutLabelDefinitionsApi.md#createcutlabeldefinition) | **POST** /api/systemconfiguration/cutlabels | [EARLY ACCESS] Create a Cut Label
[**DeleteCutLabelDefinition**](CutLabelDefinitionsApi.md#deletecutlabeldefinition) | **DELETE** /api/systemconfiguration/cutlabels/{code} | [EARLY ACCESS] Delete a Cut Label
[**GetCutLabelDefinition**](CutLabelDefinitionsApi.md#getcutlabeldefinition) | **GET** /api/systemconfiguration/cutlabels/{code} | [EARLY ACCESS] Get a Cut Label
[**ListCutLabelDefinitions**](CutLabelDefinitionsApi.md#listcutlabeldefinitions) | **GET** /api/systemconfiguration/cutlabels | [EARLY ACCESS] List Existing Cut Labels
[**UpdateCutLabelDefinition**](CutLabelDefinitionsApi.md#updatecutlabeldefinition) | **PUT** /api/systemconfiguration/cutlabels/{code} | [EARLY ACCESS] Update a Cut Label


<a name="createcutlabeldefinition"></a>
# **CreateCutLabelDefinition**
> CutLabelDefinition CreateCutLabelDefinition (CreateCutLabelDefinitionRequest createCutLabelDefinitionRequest = null)

[EARLY ACCESS] Create a Cut Label

Create a Cut Label valid in all scopes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateCutLabelDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:43652";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CutLabelDefinitionsApi(config);
            var createCutLabelDefinitionRequest = new CreateCutLabelDefinitionRequest(); // CreateCutLabelDefinitionRequest | The cut label definition (optional) 

            try
            {
                // [EARLY ACCESS] Create a Cut Label
                CutLabelDefinition result = apiInstance.CreateCutLabelDefinition(createCutLabelDefinitionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CutLabelDefinitionsApi.CreateCutLabelDefinition: " + e.Message );
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
 **createCutLabelDefinitionRequest** | [**CreateCutLabelDefinitionRequest**](CreateCutLabelDefinitionRequest.md)| The cut label definition | [optional] 

### Return type

[**CutLabelDefinition**](CutLabelDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created cut label |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecutlabeldefinition"></a>
# **DeleteCutLabelDefinition**
> DateTimeOffset DeleteCutLabelDefinition (string code)

[EARLY ACCESS] Delete a Cut Label

Delete a specified cut label

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteCutLabelDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:43652";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CutLabelDefinitionsApi(config);
            var code = code_example;  // string | The Code of the Cut Label that is being Deleted

            try
            {
                // [EARLY ACCESS] Delete a Cut Label
                DateTimeOffset result = apiInstance.DeleteCutLabelDefinition(code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CutLabelDefinitionsApi.DeleteCutLabelDefinition: " + e.Message );
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
 **code** | **string**| The Code of the Cut Label that is being Deleted | 

### Return type

**DateTimeOffset**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The time of deletion |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcutlabeldefinition"></a>
# **GetCutLabelDefinition**
> CutLabelDefinition GetCutLabelDefinition (string code, DateTimeOffset? asAt = null)

[EARLY ACCESS] Get a Cut Label

Get a specified cut label at a given time

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetCutLabelDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:43652";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CutLabelDefinitionsApi(config);
            var code = code_example;  // string | The Code of the Cut Label that is being queried
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The time at which to get the Cut Label (optional) 

            try
            {
                // [EARLY ACCESS] Get a Cut Label
                CutLabelDefinition result = apiInstance.GetCutLabelDefinition(code, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CutLabelDefinitionsApi.GetCutLabelDefinition: " + e.Message );
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
 **code** | **string**| The Code of the Cut Label that is being queried | 
 **asAt** | **DateTimeOffset?**| The time at which to get the Cut Label | [optional] 

### Return type

[**CutLabelDefinition**](CutLabelDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested cut label |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcutlabeldefinitions"></a>
# **ListCutLabelDefinitions**
> PagedResourceListOfCutLabelDefinition ListCutLabelDefinitions (DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, string page = null)

[EARLY ACCESS] List Existing Cut Labels

List all the Cut Label Definitions that are valid at the given AsAt time

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListCutLabelDefinitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:43652";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CutLabelDefinitionsApi(config);
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The As At time at which listed Cut Labels are valid (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set.              For example, to filter on code, use \"code eq 'string'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing cut labels from a previous call This value is returned from the previous call.  If a pagination token is provided the sortBy, filter, and asAt fields  must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 

            try
            {
                // [EARLY ACCESS] List Existing Cut Labels
                PagedResourceListOfCutLabelDefinition result = apiInstance.ListCutLabelDefinitions(asAt, sortBy, start, limit, filter, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CutLabelDefinitionsApi.ListCutLabelDefinitions: " + e.Message );
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
 **asAt** | **DateTimeOffset?**| Optional. The As At time at which listed Cut Labels are valid | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set.              For example, to filter on code, use \&quot;code eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **page** | **string**| The pagination token to use to continue listing cut labels from a previous call This value is returned from the previous call.  If a pagination token is provided the sortBy, filter, and asAt fields  must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional] 

### Return type

[**PagedResourceListOfCutLabelDefinition**](PagedResourceListOfCutLabelDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of cut labels |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecutlabeldefinition"></a>
# **UpdateCutLabelDefinition**
> CutLabelDefinition UpdateCutLabelDefinition (string code, UpdateCutLabelDefinitionRequest updateCutLabelDefinitionRequest = null)

[EARLY ACCESS] Update a Cut Label

Update a specified cut label

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdateCutLabelDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:43652";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CutLabelDefinitionsApi(config);
            var code = code_example;  // string | The Code of the Cut Label that is being updated
            var updateCutLabelDefinitionRequest = new UpdateCutLabelDefinitionRequest(); // UpdateCutLabelDefinitionRequest | The cut label update definition (optional) 

            try
            {
                // [EARLY ACCESS] Update a Cut Label
                CutLabelDefinition result = apiInstance.UpdateCutLabelDefinition(code, updateCutLabelDefinitionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CutLabelDefinitionsApi.UpdateCutLabelDefinition: " + e.Message );
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
 **code** | **string**| The Code of the Cut Label that is being updated | 
 **updateCutLabelDefinitionRequest** | [**UpdateCutLabelDefinitionRequest**](UpdateCutLabelDefinitionRequest.md)| The cut label update definition | [optional] 

### Return type

[**CutLabelDefinition**](CutLabelDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated cut label |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

