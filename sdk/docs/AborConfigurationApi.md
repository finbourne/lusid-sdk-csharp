# Lusid.Sdk.Api.AborConfigurationApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAborConfiguration**](AborConfigurationApi.md#createaborconfiguration) | **POST** /api/aborconfiguration/{scope} | [EXPERIMENTAL] CreateAborConfiguration: Create an AborConfiguration. |
| [**DeleteAborConfiguration**](AborConfigurationApi.md#deleteaborconfiguration) | **DELETE** /api/aborconfiguration/{scope}/{code} | [EXPERIMENTAL] DeleteAborConfiguration: Delete an AborConfiguration. |
| [**GetAborConfiguration**](AborConfigurationApi.md#getaborconfiguration) | **GET** /api/aborconfiguration/{scope}/{code} | [EXPERIMENTAL] GetAborConfiguration: Get AborConfiguration. |
| [**ListAborConfigurations**](AborConfigurationApi.md#listaborconfigurations) | **GET** /api/aborconfiguration | [EXPERIMENTAL] ListAborConfigurations: List AborConfiguration. |
| [**UpsertAborConfigurationProperties**](AborConfigurationApi.md#upsertaborconfigurationproperties) | **POST** /api/aborconfiguration/{scope}/{code}/properties/$upsert | [EXPERIMENTAL] UpsertAborConfigurationProperties: Upsert AborConfiguration properties |

<a id="createaborconfiguration"></a>
# **CreateAborConfiguration**
> AborConfiguration CreateAborConfiguration (string scope, AborConfigurationRequest aborConfigurationRequest)

[EXPERIMENTAL] CreateAborConfiguration: Create an AborConfiguration.

Create the given AborConfiguration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateAborConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AborConfigurationApi(config);
            var scope = "scope_example";  // string | The scope of the AborConfiguration.
            var aborConfigurationRequest = new AborConfigurationRequest(); // AborConfigurationRequest | The definition of the AborConfiguration.

            try
            {
                // [EXPERIMENTAL] CreateAborConfiguration: Create an AborConfiguration.
                AborConfiguration result = apiInstance.CreateAborConfiguration(scope, aborConfigurationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AborConfigurationApi.CreateAborConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAborConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateAborConfiguration: Create an AborConfiguration.
    ApiResponse<AborConfiguration> response = apiInstance.CreateAborConfigurationWithHttpInfo(scope, aborConfigurationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AborConfigurationApi.CreateAborConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the AborConfiguration. |  |
| **aborConfigurationRequest** | [**AborConfigurationRequest**](AborConfigurationRequest.md) | The definition of the AborConfiguration. |  |

### Return type

[**AborConfiguration**](AborConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created abor configuration. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteaborconfiguration"></a>
# **DeleteAborConfiguration**
> DeletedEntityResponse DeleteAborConfiguration (string scope, string code)

[EXPERIMENTAL] DeleteAborConfiguration: Delete an AborConfiguration.

Delete the given AborConfiguration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteAborConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AborConfigurationApi(config);
            var scope = "scope_example";  // string | The scope of the AborConfiguration to be deleted.
            var code = "code_example";  // string | The code of the AborConfiguration to be deleted. Together with the scope this uniquely identifies the AborConfiguration.

            try
            {
                // [EXPERIMENTAL] DeleteAborConfiguration: Delete an AborConfiguration.
                DeletedEntityResponse result = apiInstance.DeleteAborConfiguration(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AborConfigurationApi.DeleteAborConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAborConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteAborConfiguration: Delete an AborConfiguration.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteAborConfigurationWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AborConfigurationApi.DeleteAborConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the AborConfiguration to be deleted. |  |
| **code** | **string** | The code of the AborConfiguration to be deleted. Together with the scope this uniquely identifies the AborConfiguration. |  |

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
| **200** | The datetime that the Abor was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaborconfiguration"></a>
# **GetAborConfiguration**
> AborConfiguration GetAborConfiguration (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetAborConfiguration: Get AborConfiguration.

Retrieve the definition of a particular AborConfiguration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetAborConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AborConfigurationApi(config);
            var scope = "scope_example";  // string | The scope of the AborConfiguration.
            var code = "code_example";  // string | The code of the AborConfiguration. Together with the scope this uniquely identifies the AborConfiguration.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the AborConfiguration properties. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the AborConfiguration definition. Defaults to returning the latest version of the AborConfiguration definition if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'AborConfiguration' domain to decorate onto the AborConfiguration.              These must take the format {domain}/{scope}/{code}, for example 'AborConfiguration/Manager/Id'. If no properties are specified, then no properties will be returned. (optional) 

            try
            {
                // [EXPERIMENTAL] GetAborConfiguration: Get AborConfiguration.
                AborConfiguration result = apiInstance.GetAborConfiguration(scope, code, effectiveAt, asAt, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AborConfigurationApi.GetAborConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAborConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetAborConfiguration: Get AborConfiguration.
    ApiResponse<AborConfiguration> response = apiInstance.GetAborConfigurationWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AborConfigurationApi.GetAborConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the AborConfiguration. |  |
| **code** | **string** | The code of the AborConfiguration. Together with the scope this uniquely identifies the AborConfiguration. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the AborConfiguration properties. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the AborConfiguration definition. Defaults to returning the latest version of the AborConfiguration definition if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;AborConfiguration&#39; domain to decorate onto the AborConfiguration.              These must take the format {domain}/{scope}/{code}, for example &#39;AborConfiguration/Manager/Id&#39;. If no properties are specified, then no properties will be returned. | [optional]  |

### Return type

[**AborConfiguration**](AborConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested AborConfiguration definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listaborconfigurations"></a>
# **ListAborConfigurations**
> PagedResourceListOfAborConfiguration ListAborConfigurations (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListAborConfigurations: List AborConfiguration.

List all the AborConfiguration matching particular criteria.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListAborConfigurationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AborConfigurationApi(config);
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the TimeVariant properties for the AborConfiguration. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the AborConfiguration. Defaults to returning the latest version of each AAborConfigurationbor if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing AborConfiguration; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the AborConfiguration type, specify \"id.Code eq 'AborConfiguration1'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'AborConfiguration' domain to decorate onto each AborConfiguration.              These must take the format {domain}/{scope}/{code}, for example 'AborConfiguration/Manager/Id'. (optional) 

            try
            {
                // [EXPERIMENTAL] ListAborConfigurations: List AborConfiguration.
                PagedResourceListOfAborConfiguration result = apiInstance.ListAborConfigurations(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AborConfigurationApi.ListAborConfigurations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAborConfigurationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListAborConfigurations: List AborConfiguration.
    ApiResponse<PagedResourceListOfAborConfiguration> response = apiInstance.ListAborConfigurationsWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AborConfigurationApi.ListAborConfigurationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the TimeVariant properties for the AborConfiguration. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the AborConfiguration. Defaults to returning the latest version of each AAborConfigurationbor if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing AborConfiguration; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the AborConfiguration type, specify \&quot;id.Code eq &#39;AborConfiguration1&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;AborConfiguration&#39; domain to decorate onto each AborConfiguration.              These must take the format {domain}/{scope}/{code}, for example &#39;AborConfiguration/Manager/Id&#39;. | [optional]  |

### Return type

[**PagedResourceListOfAborConfiguration**](PagedResourceListOfAborConfiguration.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested abor configurations. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertaborconfigurationproperties"></a>
# **UpsertAborConfigurationProperties**
> AborConfigurationProperties UpsertAborConfigurationProperties (string scope, string code, Dictionary<string, Property>? requestBody = null)

[EXPERIMENTAL] UpsertAborConfigurationProperties: Upsert AborConfiguration properties

Update or insert one or more properties onto a single AborConfiguration. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain 'AborConfiguration'.                Upserting a property that exists for an AborConfiguration, with a null value, will delete the instance of the property for that group.                Properties have an <i>effectiveFrom</i> datetime for which the property is valid, and an <i>effectiveUntil</i>  datetime until which the property is valid. Not supplying an <i>effectiveUntil</i> datetime results in the property being  valid indefinitely, or until the next <i>effectiveFrom</i> datetime of the property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertAborConfigurationPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AborConfigurationApi(config);
            var scope = "scope_example";  // string | The scope of the AborConfiguration to update or insert the properties onto.
            var code = "code_example";  // string | The code of the AborConfiguration to update or insert the properties onto. Together with the scope this uniquely identifies the AborConfiguration.
            var requestBody = new Dictionary<string, Property>?(); // Dictionary<string, Property>? | The properties to be updated or inserted onto the chart of account. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \"AborConfiguration/Manager/Id\". (optional) 

            try
            {
                // [EXPERIMENTAL] UpsertAborConfigurationProperties: Upsert AborConfiguration properties
                AborConfigurationProperties result = apiInstance.UpsertAborConfigurationProperties(scope, code, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AborConfigurationApi.UpsertAborConfigurationProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertAborConfigurationPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertAborConfigurationProperties: Upsert AborConfiguration properties
    ApiResponse<AborConfigurationProperties> response = apiInstance.UpsertAborConfigurationPropertiesWithHttpInfo(scope, code, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AborConfigurationApi.UpsertAborConfigurationPropertiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the AborConfiguration to update or insert the properties onto. |  |
| **code** | **string** | The code of the AborConfiguration to update or insert the properties onto. Together with the scope this uniquely identifies the AborConfiguration. |  |
| **requestBody** | [**Dictionary&lt;string, Property&gt;?**](Property.md) | The properties to be updated or inserted onto the chart of account. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;AborConfiguration/Manager/Id\&quot;. | [optional]  |

### Return type

[**AborConfigurationProperties**](AborConfigurationProperties.md)

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

