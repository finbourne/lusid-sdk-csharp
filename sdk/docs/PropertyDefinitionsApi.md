# Lusid.Sdk.Api.PropertyDefinitionsApi

All URIs are relative to *https://www.lusid.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDerivedPropertyDefinition**](PropertyDefinitionsApi.md#createderivedpropertydefinition) | **POST** /api/propertydefinitions/derived | [EARLY ACCESS] CreateDerivedPropertyDefinition: Create derived property definition
[**CreatePropertyDefinition**](PropertyDefinitionsApi.md#createpropertydefinition) | **POST** /api/propertydefinitions | CreatePropertyDefinition: Create property definition
[**DeletePropertyDefinition**](PropertyDefinitionsApi.md#deletepropertydefinition) | **DELETE** /api/propertydefinitions/{domain}/{scope}/{code} | DeletePropertyDefinition: Delete property definition
[**DeletePropertyDefinitionProperties**](PropertyDefinitionsApi.md#deletepropertydefinitionproperties) | **POST** /api/propertydefinitions/{domain}/{scope}/{code}/properties/$delete | [EARLY ACCESS] DeletePropertyDefinitionProperties: Delete property definition properties
[**GetMultiplePropertyDefinitions**](PropertyDefinitionsApi.md#getmultiplepropertydefinitions) | **GET** /api/propertydefinitions | GetMultiplePropertyDefinitions: Get multiple property definitions
[**GetPropertyDefinition**](PropertyDefinitionsApi.md#getpropertydefinition) | **GET** /api/propertydefinitions/{domain}/{scope}/{code} | GetPropertyDefinition: Get property definition
[**GetPropertyDefinitionPropertyTimeSeries**](PropertyDefinitionsApi.md#getpropertydefinitionpropertytimeseries) | **GET** /api/propertydefinitions/{domain}/{scope}/{code}/properties/time-series | [EARLY ACCESS] GetPropertyDefinitionPropertyTimeSeries: Get Property Definition Property Time Series
[**UpdateDerivedPropertyDefinition**](PropertyDefinitionsApi.md#updatederivedpropertydefinition) | **PUT** /api/propertydefinitions/derived/{domain}/{scope}/{code} | [EARLY ACCESS] UpdateDerivedPropertyDefinition: Update a pre-existing derived property definition
[**UpdatePropertyDefinition**](PropertyDefinitionsApi.md#updatepropertydefinition) | **PUT** /api/propertydefinitions/{domain}/{scope}/{code} | UpdatePropertyDefinition: Update property definition
[**UpsertPropertyDefinitionProperties**](PropertyDefinitionsApi.md#upsertpropertydefinitionproperties) | **POST** /api/propertydefinitions/{domain}/{scope}/{code}/properties | [EARLY ACCESS] UpsertPropertyDefinitionProperties: Upsert properties to a property definition


<a name="createderivedpropertydefinition"></a>
# **CreateDerivedPropertyDefinition**
> PropertyDefinition CreateDerivedPropertyDefinition (CreateDerivedPropertyDefinitionRequest createDerivedPropertyDefinitionRequest)

[EARLY ACCESS] CreateDerivedPropertyDefinition: Create derived property definition

Define a new derived property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateDerivedPropertyDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi(config);
            var createDerivedPropertyDefinitionRequest = new CreateDerivedPropertyDefinitionRequest(); // CreateDerivedPropertyDefinitionRequest | The definition of the new derived property.

            try
            {
                // [EARLY ACCESS] CreateDerivedPropertyDefinition: Create derived property definition
                PropertyDefinition result = apiInstance.CreateDerivedPropertyDefinition(createDerivedPropertyDefinitionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.CreateDerivedPropertyDefinition: " + e.Message );
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
 **createDerivedPropertyDefinitionRequest** | [**CreateDerivedPropertyDefinitionRequest**](CreateDerivedPropertyDefinitionRequest.md)| The definition of the new derived property. | 

### Return type

[**PropertyDefinition**](PropertyDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created derived property definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpropertydefinition"></a>
# **CreatePropertyDefinition**
> PropertyDefinition CreatePropertyDefinition (CreatePropertyDefinitionRequest createPropertyDefinitionRequest)

CreatePropertyDefinition: Create property definition

Define a new property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreatePropertyDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi(config);
            var createPropertyDefinitionRequest = new CreatePropertyDefinitionRequest(); // CreatePropertyDefinitionRequest | The definition of the new property.

            try
            {
                // CreatePropertyDefinition: Create property definition
                PropertyDefinition result = apiInstance.CreatePropertyDefinition(createPropertyDefinitionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.CreatePropertyDefinition: " + e.Message );
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
 **createPropertyDefinitionRequest** | [**CreatePropertyDefinitionRequest**](CreatePropertyDefinitionRequest.md)| The definition of the new property. | 

### Return type

[**PropertyDefinition**](PropertyDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created property definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepropertydefinition"></a>
# **DeletePropertyDefinition**
> DeletedEntityResponse DeletePropertyDefinition (string domain, string scope, string code)

DeletePropertyDefinition: Delete property definition

Delete the definition of the specified property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePropertyDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi(config);
            var domain = domain_example;  // string | The domain of the property to be deleted.
            var scope = scope_example;  // string | The scope of the property to be deleted.
            var code = code_example;  // string | The code of the property to be deleted. Together with the domain and scope this uniquely              identifies the property.

            try
            {
                // DeletePropertyDefinition: Delete property definition
                DeletedEntityResponse result = apiInstance.DeletePropertyDefinition(domain, scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.DeletePropertyDefinition: " + e.Message );
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
 **domain** | **string**| The domain of the property to be deleted. | 
 **scope** | **string**| The scope of the property to be deleted. | 
 **code** | **string**| The code of the property to be deleted. Together with the domain and scope this uniquely              identifies the property. | 

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
| **200** | The time that the property definition was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepropertydefinitionproperties"></a>
# **DeletePropertyDefinitionProperties**
> DeletedEntityResponse DeletePropertyDefinitionProperties (string domain, string scope, string code, List<string> requestBody, DateTimeOrCutLabel effectiveAt = null)

[EARLY ACCESS] DeletePropertyDefinitionProperties: Delete property definition properties

Delete one or more properties from a single property definition. If the properties are time-variant then an effective date time from which the  properties will be deleted must be specified. If the properties are perpetual then it is invalid to specify an effective date time for deletion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePropertyDefinitionPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi(config);
            var domain = domain_example;  // string | The domain of the property definition to delete properties from.
            var scope = scope_example;  // string | The scope of the property definition to delete properties from.
            var code = code_example;  // string | The code of the property definition to delete properties from.
            var requestBody = new List<string>(); // List<string> | The property keys of the properties to delete. These must take the format              {domain}/{scope}/{code} e.g \"PropertyDefinition/myScope/someAttributeKey\". Each property must be from the \"PropertyDefinition\" domain.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified 'effectiveAt' datetime. If the 'effectiveAt' is not provided or is before              the time-variant property exists then a failure is returned. Do not specify this parameter if an of the properties to delete are perpetual. (optional) 

            try
            {
                // [EARLY ACCESS] DeletePropertyDefinitionProperties: Delete property definition properties
                DeletedEntityResponse result = apiInstance.DeletePropertyDefinitionProperties(domain, scope, code, requestBody, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.DeletePropertyDefinitionProperties: " + e.Message );
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
 **domain** | **string**| The domain of the property definition to delete properties from. | 
 **scope** | **string**| The scope of the property definition to delete properties from. | 
 **code** | **string**| The code of the property definition to delete properties from. | 
 **requestBody** | [**List&lt;string&gt;**](string.md)| The property keys of the properties to delete. These must take the format              {domain}/{scope}/{code} e.g \&quot;PropertyDefinition/myScope/someAttributeKey\&quot;. Each property must be from the \&quot;PropertyDefinition\&quot; domain. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is before              the time-variant property exists then a failure is returned. Do not specify this parameter if an of the properties to delete are perpetual. | [optional] 

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the properties were deleted from the specified definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmultiplepropertydefinitions"></a>
# **GetMultiplePropertyDefinitions**
> ResourceListOfPropertyDefinition GetMultiplePropertyDefinitions (List<string> propertyKeys, DateTimeOffset? asAt = null, string filter = null, DateTimeOrCutLabel effectiveAt = null)

GetMultiplePropertyDefinitions: Get multiple property definitions

Retrieve the definition of one or more specified properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetMultiplePropertyDefinitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi(config);
            var propertyKeys = new List<string>(); // List<string> | One or more property keys which identify each property that a definition should              be retrieved for. The format for each property key is {domain}/{scope}/{code}, e.g. 'Portfolio/Manager/Id'.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the property definitions. Defaults to return              the latest version of each definition if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.               For example, to filter on the Lifetime, use \"lifeTime eq 'Perpetual'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to list properties attached to the Property Definition.              Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // GetMultiplePropertyDefinitions: Get multiple property definitions
                ResourceListOfPropertyDefinition result = apiInstance.GetMultiplePropertyDefinitions(propertyKeys, asAt, filter, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.GetMultiplePropertyDefinitions: " + e.Message );
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
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| One or more property keys which identify each property that a definition should              be retrieved for. The format for each property key is {domain}/{scope}/{code}, e.g. &#39;Portfolio/Manager/Id&#39;. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the property definitions. Defaults to return              the latest version of each definition if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.               For example, to filter on the Lifetime, use \&quot;lifeTime eq &#39;Perpetual&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to list properties attached to the Property Definition.              Defaults to the current LUSID system datetime if not specified. | [optional] 

### Return type

[**ResourceListOfPropertyDefinition**](ResourceListOfPropertyDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested property definitions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpropertydefinition"></a>
# **GetPropertyDefinition**
> PropertyDefinition GetPropertyDefinition (string domain, string scope, string code, DateTimeOffset? asAt = null, DateTimeOrCutLabel effectiveAt = null)

GetPropertyDefinition: Get property definition

Retrieve the definition of a specified property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPropertyDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi(config);
            var domain = domain_example;  // string | The domain of the specified property.
            var scope = scope_example;  // string | The scope of the specified property.
            var code = code_example;  // string | The code of the specified property. Together with the domain and scope this uniquely              identifies the property.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the property definition. Defaults to return              the latest version of the definition if not specified. (optional) 
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to list properties attached to the Property Definition.              Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // GetPropertyDefinition: Get property definition
                PropertyDefinition result = apiInstance.GetPropertyDefinition(domain, scope, code, asAt, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.GetPropertyDefinition: " + e.Message );
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
 **domain** | **string**| The domain of the specified property. | 
 **scope** | **string**| The scope of the specified property. | 
 **code** | **string**| The code of the specified property. Together with the domain and scope this uniquely              identifies the property. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the property definition. Defaults to return              the latest version of the definition if not specified. | [optional] 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to list properties attached to the Property Definition.              Defaults to the current LUSID system datetime if not specified. | [optional] 

### Return type

[**PropertyDefinition**](PropertyDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested property definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpropertydefinitionpropertytimeseries"></a>
# **GetPropertyDefinitionPropertyTimeSeries**
> ResourceListOfPropertyInterval GetPropertyDefinitionPropertyTimeSeries (string domain, string scope, string code, string propertyKey, DateTimeOffset? asAt = null, string filter = null, string page = null, int? limit = null)

[EARLY ACCESS] GetPropertyDefinitionPropertyTimeSeries: Get Property Definition Property Time Series

List the complete time series of a property definition property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPropertyDefinitionPropertyTimeSeriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi(config);
            var domain = domain_example;  // string | The domain of the property definition to which the property is attached
            var scope = scope_example;  // string | The scope of the property definition to which the property is attached
            var code = code_example;  // string | The code of the property definition to which the property is attached
            var propertyKey = propertyKey_example;  // string | The property key of the property whose history to show. This must be from the \"Property Definition\" domain and in the format              {domain}/{scope}/{code}, for example \"PropertyDefinition/myScope/someAttributeKey\".
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to show the history. Defaults to the current datetime if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the results. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter and asAt fields              must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 

            try
            {
                // [EARLY ACCESS] GetPropertyDefinitionPropertyTimeSeries: Get Property Definition Property Time Series
                ResourceListOfPropertyInterval result = apiInstance.GetPropertyDefinitionPropertyTimeSeries(domain, scope, code, propertyKey, asAt, filter, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.GetPropertyDefinitionPropertyTimeSeries: " + e.Message );
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
 **domain** | **string**| The domain of the property definition to which the property is attached | 
 **scope** | **string**| The scope of the property definition to which the property is attached | 
 **code** | **string**| The code of the property definition to which the property is attached | 
 **propertyKey** | **string**| The property key of the property whose history to show. This must be from the \&quot;Property Definition\&quot; domain and in the format              {domain}/{scope}/{code}, for example \&quot;PropertyDefinition/myScope/someAttributeKey\&quot;. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to show the history. Defaults to the current datetime if not specified. | [optional] 
 **filter** | **string**| Expression to filter the results. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **page** | **string**| The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter and asAt fields              must not have changed since the original request. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. | [optional] 

### Return type

[**ResourceListOfPropertyInterval**](ResourceListOfPropertyInterval.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The time series of the property |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatederivedpropertydefinition"></a>
# **UpdateDerivedPropertyDefinition**
> PropertyDefinition UpdateDerivedPropertyDefinition (string domain, string scope, string code, UpdateDerivedPropertyDefinitionRequest updateDerivedPropertyDefinitionRequest)

[EARLY ACCESS] UpdateDerivedPropertyDefinition: Update a pre-existing derived property definition

This will fail if the property definition does not exist

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdateDerivedPropertyDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi(config);
            var domain = domain_example;  // string | Domain of the property definition
            var scope = scope_example;  // string | Scope of the property definition
            var code = code_example;  // string | Code of the property definition
            var updateDerivedPropertyDefinitionRequest = new UpdateDerivedPropertyDefinitionRequest(); // UpdateDerivedPropertyDefinitionRequest | Information about the derived property definition being updated

            try
            {
                // [EARLY ACCESS] UpdateDerivedPropertyDefinition: Update a pre-existing derived property definition
                PropertyDefinition result = apiInstance.UpdateDerivedPropertyDefinition(domain, scope, code, updateDerivedPropertyDefinitionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.UpdateDerivedPropertyDefinition: " + e.Message );
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
 **domain** | **string**| Domain of the property definition | 
 **scope** | **string**| Scope of the property definition | 
 **code** | **string**| Code of the property definition | 
 **updateDerivedPropertyDefinitionRequest** | [**UpdateDerivedPropertyDefinitionRequest**](UpdateDerivedPropertyDefinitionRequest.md)| Information about the derived property definition being updated | 

### Return type

[**PropertyDefinition**](PropertyDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated derived property definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepropertydefinition"></a>
# **UpdatePropertyDefinition**
> PropertyDefinition UpdatePropertyDefinition (string domain, string scope, string code, UpdatePropertyDefinitionRequest updatePropertyDefinitionRequest)

UpdatePropertyDefinition: Update property definition

Update the definition of a specified existing property. Not all elements within a property definition  are modifiable due to the potential implications for values already stored against the property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdatePropertyDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi(config);
            var domain = domain_example;  // string | The domain of the property being updated.
            var scope = scope_example;  // string | The scope of the property being updated.
            var code = code_example;  // string | The code of the property being updated. Together with the domain and scope this uniquely              identifies the property.
            var updatePropertyDefinitionRequest = new UpdatePropertyDefinitionRequest(); // UpdatePropertyDefinitionRequest | The updated definition of the property.

            try
            {
                // UpdatePropertyDefinition: Update property definition
                PropertyDefinition result = apiInstance.UpdatePropertyDefinition(domain, scope, code, updatePropertyDefinitionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.UpdatePropertyDefinition: " + e.Message );
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
 **domain** | **string**| The domain of the property being updated. | 
 **scope** | **string**| The scope of the property being updated. | 
 **code** | **string**| The code of the property being updated. Together with the domain and scope this uniquely              identifies the property. | 
 **updatePropertyDefinitionRequest** | [**UpdatePropertyDefinitionRequest**](UpdatePropertyDefinitionRequest.md)| The updated definition of the property. | 

### Return type

[**PropertyDefinition**](PropertyDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated property definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertpropertydefinitionproperties"></a>
# **UpsertPropertyDefinitionProperties**
> BatchUpsertPropertyDefinitionPropertiesResponse UpsertPropertyDefinitionProperties (string domain, string scope, string code, Dictionary<string, Property> requestBody, string successMode = null)

[EARLY ACCESS] UpsertPropertyDefinitionProperties: Upsert properties to a property definition

Create or update properties for a particular property definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertPropertyDefinitionPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi(config);
            var domain = domain_example;  // string | The domain of the specified property.
            var scope = scope_example;  // string | The scope of the specified property.
            var code = code_example;  // string | The code of the specified property. Together with the domain and scope this uniquely
            var requestBody = new Dictionary<string, Property>(); // Dictionary<string, Property> | The properties to be created or updated. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code}, for example              'PropertyDefinition/Manager/Id'.
            var successMode = successMode_example;  // string | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial. (optional)  (default to "Partial")

            try
            {
                // [EARLY ACCESS] UpsertPropertyDefinitionProperties: Upsert properties to a property definition
                BatchUpsertPropertyDefinitionPropertiesResponse result = apiInstance.UpsertPropertyDefinitionProperties(domain, scope, code, requestBody, successMode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.UpsertPropertyDefinitionProperties: " + e.Message );
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
 **domain** | **string**| The domain of the specified property. | 
 **scope** | **string**| The scope of the specified property. | 
 **code** | **string**| The code of the specified property. Together with the domain and scope this uniquely | 
 **requestBody** | [**Dictionary&lt;string, Property&gt;**](Property.md)| The properties to be created or updated. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code}, for example              &#39;PropertyDefinition/Manager/Id&#39;. | 
 **successMode** | **string**| Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial. | [optional] [default to &quot;Partial&quot;]

### Return type

[**BatchUpsertPropertyDefinitionPropertiesResponse**](BatchUpsertPropertyDefinitionPropertiesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The asAt datetime at which the properties were updated or created. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

