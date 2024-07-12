# Lusid.Sdk.Api.FundConfigurationsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateFundConfiguration**](FundConfigurationsApi.md#createfundconfiguration) | **POST** /api/fundconfigurations/{scope} | [EXPERIMENTAL] CreateFundConfiguration: Create a FundConfiguration. |
| [**DeleteFundConfiguration**](FundConfigurationsApi.md#deletefundconfiguration) | **DELETE** /api/fundconfigurations/{scope}/{code} | [EXPERIMENTAL] DeleteFundConfiguration: Delete a FundConfiguration. |
| [**GetFundConfiguration**](FundConfigurationsApi.md#getfundconfiguration) | **GET** /api/fundconfigurations/{scope}/{code} | [EXPERIMENTAL] GetFundConfiguration: Get FundConfiguration. |
| [**ListFundConfigurations**](FundConfigurationsApi.md#listfundconfigurations) | **GET** /api/fundconfigurations | [EXPERIMENTAL] ListFundConfigurations: List FundConfiguration. |
| [**UpsertFundConfigurationProperties**](FundConfigurationsApi.md#upsertfundconfigurationproperties) | **POST** /api/fundconfigurations/{scope}/{code}/properties/$upsert | [EXPERIMENTAL] UpsertFundConfigurationProperties: Upsert FundConfiguration properties |

<a id="createfundconfiguration"></a>
# **CreateFundConfiguration**
> FundConfiguration CreateFundConfiguration (string scope, FundConfigurationRequest fundConfigurationRequest)

[EXPERIMENTAL] CreateFundConfiguration: Create a FundConfiguration.

Create the given FundConfiguration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateFundConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundConfigurationsApi(config);
            var scope = "scope_example";  // string | The scope of the FundConfiguration.
            var fundConfigurationRequest = new FundConfigurationRequest(); // FundConfigurationRequest | The definition of the FundConfiguration.

            try
            {
                // [EXPERIMENTAL] CreateFundConfiguration: Create a FundConfiguration.
                FundConfiguration result = apiInstance.CreateFundConfiguration(scope, fundConfigurationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundConfigurationsApi.CreateFundConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFundConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateFundConfiguration: Create a FundConfiguration.
    ApiResponse<FundConfiguration> response = apiInstance.CreateFundConfigurationWithHttpInfo(scope, fundConfigurationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundConfigurationsApi.CreateFundConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the FundConfiguration. |  |
| **fundConfigurationRequest** | [**FundConfigurationRequest**](FundConfigurationRequest.md) | The definition of the FundConfiguration. |  |

### Return type

[**FundConfiguration**](FundConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created Fund configuration. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletefundconfiguration"></a>
# **DeleteFundConfiguration**
> DeletedEntityResponse DeleteFundConfiguration (string scope, string code)

[EXPERIMENTAL] DeleteFundConfiguration: Delete a FundConfiguration.

Delete the given FundConfiguration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteFundConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundConfigurationsApi(config);
            var scope = "scope_example";  // string | The scope of the FundConfiguration to be deleted.
            var code = "code_example";  // string | The code of the FundConfiguration to be deleted.               Together with the scope this uniquely identifies the FundConfiguration.

            try
            {
                // [EXPERIMENTAL] DeleteFundConfiguration: Delete a FundConfiguration.
                DeletedEntityResponse result = apiInstance.DeleteFundConfiguration(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundConfigurationsApi.DeleteFundConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFundConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteFundConfiguration: Delete a FundConfiguration.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteFundConfigurationWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundConfigurationsApi.DeleteFundConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the FundConfiguration to be deleted. |  |
| **code** | **string** | The code of the FundConfiguration to be deleted.               Together with the scope this uniquely identifies the FundConfiguration. |  |

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
| **200** | The datetime that the FundConfiguration was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfundconfiguration"></a>
# **GetFundConfiguration**
> FundConfiguration GetFundConfiguration (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetFundConfiguration: Get FundConfiguration.

Retrieve the definition of a particular FundConfiguration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetFundConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundConfigurationsApi(config);
            var scope = "scope_example";  // string | The scope of the FundConfiguration.
            var code = "code_example";  // string | The code of the FundConfiguration. Together with the scope this uniquely identifies the FundConfiguration.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the FundConfiguration properties. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the FundConfiguration definition. Defaults to returning the latest version of the FundConfiguration definition if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'FundConfiguration' domain to decorate onto the FundConfiguration.              These must take the format {domain}/{scope}/{code}, for example 'FundConfiguration/Manager/Id'. If no properties are specified, then no properties will be returned. (optional) 

            try
            {
                // [EXPERIMENTAL] GetFundConfiguration: Get FundConfiguration.
                FundConfiguration result = apiInstance.GetFundConfiguration(scope, code, effectiveAt, asAt, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundConfigurationsApi.GetFundConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFundConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetFundConfiguration: Get FundConfiguration.
    ApiResponse<FundConfiguration> response = apiInstance.GetFundConfigurationWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundConfigurationsApi.GetFundConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the FundConfiguration. |  |
| **code** | **string** | The code of the FundConfiguration. Together with the scope this uniquely identifies the FundConfiguration. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the FundConfiguration properties. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the FundConfiguration definition. Defaults to returning the latest version of the FundConfiguration definition if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;FundConfiguration&#39; domain to decorate onto the FundConfiguration.              These must take the format {domain}/{scope}/{code}, for example &#39;FundConfiguration/Manager/Id&#39;. If no properties are specified, then no properties will be returned. | [optional]  |

### Return type

[**FundConfiguration**](FundConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested FundConfiguration definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listfundconfigurations"></a>
# **ListFundConfigurations**
> PagedResourceListOfFundConfiguration ListFundConfigurations (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListFundConfigurations: List FundConfiguration.

List all the FundConfiguration matching particular criteria.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListFundConfigurationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundConfigurationsApi(config);
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the TimeVariant properties for the FundConfiguration.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the FundConfiguration. Defaults to returning the latest version of each FundConfiguration if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing FundConfiguration; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the FundConfiguration type, specify \"id.Code eq 'FundConfiguration1'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'FundConfiguration' domain to decorate onto each FundConfiguration.              These must take the format {domain}/{scope}/{code}, for example 'FundConfiguration/Manager/Id'. (optional) 

            try
            {
                // [EXPERIMENTAL] ListFundConfigurations: List FundConfiguration.
                PagedResourceListOfFundConfiguration result = apiInstance.ListFundConfigurations(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundConfigurationsApi.ListFundConfigurations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListFundConfigurationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListFundConfigurations: List FundConfiguration.
    ApiResponse<PagedResourceListOfFundConfiguration> response = apiInstance.ListFundConfigurationsWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundConfigurationsApi.ListFundConfigurationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the TimeVariant properties for the FundConfiguration.              Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the FundConfiguration. Defaults to returning the latest version of each FundConfiguration if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing FundConfiguration; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the FundConfiguration type, specify \&quot;id.Code eq &#39;FundConfiguration1&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;FundConfiguration&#39; domain to decorate onto each FundConfiguration.              These must take the format {domain}/{scope}/{code}, for example &#39;FundConfiguration/Manager/Id&#39;. | [optional]  |

### Return type

[**PagedResourceListOfFundConfiguration**](PagedResourceListOfFundConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Fund configurations. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertfundconfigurationproperties"></a>
# **UpsertFundConfigurationProperties**
> FundConfigurationProperties UpsertFundConfigurationProperties (string scope, string code, Dictionary<string, Property>? requestBody = null)

[EXPERIMENTAL] UpsertFundConfigurationProperties: Upsert FundConfiguration properties

Update or insert one or more properties onto a single FundConfiguration. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain 'FundConfiguration'.                Upserting a property that exists for an FundConfiguration, with a null value, will delete the instance of the property for that group.                Properties have an <i>effectiveFrom</i> datetime for which the property is valid, and an <i>effectiveUntil</i>  datetime until which the property is valid. Not supplying an <i>effectiveUntil</i> datetime results in the property being  valid indefinitely, or until the next <i>effectiveFrom</i> datetime of the property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertFundConfigurationPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundConfigurationsApi(config);
            var scope = "scope_example";  // string | The scope of the FundConfiguration to update or insert the properties onto.
            var code = "code_example";  // string | The code of the FundConfiguration to update or insert the properties onto. Together with the scope this uniquely identifies the FundConfiguration.
            var requestBody = new Dictionary<string, Property>?(); // Dictionary<string, Property>? | The properties to be updated or inserted onto the Fund Configuration. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \"FundConfiguration/Manager/Id\". (optional) 

            try
            {
                // [EXPERIMENTAL] UpsertFundConfigurationProperties: Upsert FundConfiguration properties
                FundConfigurationProperties result = apiInstance.UpsertFundConfigurationProperties(scope, code, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundConfigurationsApi.UpsertFundConfigurationProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertFundConfigurationPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertFundConfigurationProperties: Upsert FundConfiguration properties
    ApiResponse<FundConfigurationProperties> response = apiInstance.UpsertFundConfigurationPropertiesWithHttpInfo(scope, code, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundConfigurationsApi.UpsertFundConfigurationPropertiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the FundConfiguration to update or insert the properties onto. |  |
| **code** | **string** | The code of the FundConfiguration to update or insert the properties onto. Together with the scope this uniquely identifies the FundConfiguration. |  |
| **requestBody** | [**Dictionary&lt;string, Property&gt;?**](Property.md) | The properties to be updated or inserted onto the Fund Configuration. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;FundConfiguration/Manager/Id\&quot;. | [optional]  |

### Return type

[**FundConfigurationProperties**](FundConfigurationProperties.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated or inserted properties |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

