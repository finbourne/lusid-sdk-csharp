# Lusid.Sdk.Api.CutLabelDefinitionsApi

All URIs are relative to *http://http:/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCutLabelDefinition**](CutLabelDefinitionsApi.md#createcutlabeldefinition) | **POST** /api/systemconfiguration/cutlabels | Create a Cut Label
[**DeleteCutLabelDefinition**](CutLabelDefinitionsApi.md#deletecutlabeldefinition) | **DELETE** /api/systemconfiguration/cutlabels/{code} | Delete a Cut Label
[**GetCutLabelDefinition**](CutLabelDefinitionsApi.md#getcutlabeldefinition) | **GET** /api/systemconfiguration/cutlabels/{code} | Get a Cut Label
[**ListCutLabelDefinitions**](CutLabelDefinitionsApi.md#listcutlabeldefinitions) | **GET** /api/systemconfiguration/cutlabels | List Existing Cut Labels
[**UpdateCutLabelDefinition**](CutLabelDefinitionsApi.md#updatecutlabeldefinition) | **PUT** /api/systemconfiguration/cutlabels/{code} | Update a Cut Label



## CreateCutLabelDefinition

> CutLabelDefinition CreateCutLabelDefinition (CreateCutLabelDefinitionRequest createRequest = null)

Create a Cut Label

Create a Cut Label valid in all scopes

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateCutLabelDefinitionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CutLabelDefinitionsApi();
            var createRequest = new CreateCutLabelDefinitionRequest(); // CreateCutLabelDefinitionRequest | The cut label definition (optional) 

            try
            {
                // Create a Cut Label
                CutLabelDefinition result = apiInstance.CreateCutLabelDefinition(createRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CutLabelDefinitionsApi.CreateCutLabelDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createRequest** | [**CreateCutLabelDefinitionRequest**](CreateCutLabelDefinitionRequest.md)| The cut label definition | [optional] 

### Return type

[**CutLabelDefinition**](CutLabelDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteCutLabelDefinition

> DateTimeOffset? DeleteCutLabelDefinition (string code)

Delete a Cut Label

Delete a specified cut label

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteCutLabelDefinitionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CutLabelDefinitionsApi();
            var code = code_example;  // string | The Code of the Cut Label that is being Deleted

            try
            {
                // Delete a Cut Label
                DateTimeOffset? result = apiInstance.DeleteCutLabelDefinition(code);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CutLabelDefinitionsApi.DeleteCutLabelDefinition: " + e.Message );
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

**DateTimeOffset?**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetCutLabelDefinition

> CutLabelDefinition GetCutLabelDefinition (string code, DateTimeOffset? asAt = null)

Get a Cut Label

Get a specified cut label at a given time

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetCutLabelDefinitionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CutLabelDefinitionsApi();
            var code = code_example;  // string | The Code of the Cut Label that is being queried
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The time at which to get the Cut Label (optional) 

            try
            {
                // Get a Cut Label
                CutLabelDefinition result = apiInstance.GetCutLabelDefinition(code, asAt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CutLabelDefinitionsApi.GetCutLabelDefinition: " + e.Message );
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListCutLabelDefinitions

> ResourceListOfCutLabelDefinition ListCutLabelDefinitions (DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, string query = null)

List Existing Cut Labels

List all the Cut Label Definitions that are valid at the given AsAt time

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListCutLabelDefinitionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CutLabelDefinitionsApi();
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The As At time at which listed Cut Labels are valid (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 
            var query = query_example;  // string | Optional. Expression specifying the criteria that the returned cut labels must meet (optional) 

            try
            {
                // List Existing Cut Labels
                ResourceListOfCutLabelDefinition result = apiInstance.ListCutLabelDefinitions(asAt, sortBy, start, limit, filter, query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CutLabelDefinitionsApi.ListCutLabelDefinitions: " + e.Message );
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
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 
 **query** | **string**| Optional. Expression specifying the criteria that the returned cut labels must meet | [optional] 

### Return type

[**ResourceListOfCutLabelDefinition**](ResourceListOfCutLabelDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateCutLabelDefinition

> CutLabelDefinition UpdateCutLabelDefinition (string code, UpdateCutLabelDefinitionRequest updateRequest = null)

Update a Cut Label

Update a specified cut label

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdateCutLabelDefinitionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CutLabelDefinitionsApi();
            var code = code_example;  // string | The Code of the Cut Label that is being updated
            var updateRequest = new UpdateCutLabelDefinitionRequest(); // UpdateCutLabelDefinitionRequest | The cut label update definition (optional) 

            try
            {
                // Update a Cut Label
                CutLabelDefinition result = apiInstance.UpdateCutLabelDefinition(code, updateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CutLabelDefinitionsApi.UpdateCutLabelDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The Code of the Cut Label that is being updated | 
 **updateRequest** | [**UpdateCutLabelDefinitionRequest**](UpdateCutLabelDefinitionRequest.md)| The cut label update definition | [optional] 

### Return type

[**CutLabelDefinition**](CutLabelDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

