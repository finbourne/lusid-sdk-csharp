# Lusid.Sdk.Api.PropertyDefinitionsApi

All URIs are relative to *http://localhost/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePropertyDefinition**](PropertyDefinitionsApi.md#createpropertydefinition) | **POST** /api/propertydefinitions | [EARLY ACCESS] Create property definition
[**DeletePropertyDefinition**](PropertyDefinitionsApi.md#deletepropertydefinition) | **DELETE** /api/propertydefinitions/{domain}/{scope}/{code} | [EARLY ACCESS] Delete property definition
[**GetMultiplePropertyDefinitions**](PropertyDefinitionsApi.md#getmultiplepropertydefinitions) | **GET** /api/propertydefinitions | [EARLY ACCESS] Get multiple property definitions
[**GetPropertyDefinition**](PropertyDefinitionsApi.md#getpropertydefinition) | **GET** /api/propertydefinitions/{domain}/{scope}/{code} | [EARLY ACCESS] Get property definition
[**UpdatePropertyDefinition**](PropertyDefinitionsApi.md#updatepropertydefinition) | **PUT** /api/propertydefinitions/{domain}/{scope}/{code} | [EARLY ACCESS] Update property definition



## CreatePropertyDefinition

> PropertyDefinition CreatePropertyDefinition (CreatePropertyDefinitionRequest definition)

[EARLY ACCESS] Create property definition

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
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi(Configuration.Default);
            var definition = new CreatePropertyDefinitionRequest(); // CreatePropertyDefinitionRequest | The definition of the new property.

            try
            {
                // [EARLY ACCESS] Create property definition
                PropertyDefinition result = apiInstance.CreatePropertyDefinition(definition);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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
 **definition** | [**CreatePropertyDefinitionRequest**](CreatePropertyDefinitionRequest.md)| The definition of the new property. | 

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
| **201** | The newly created property definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeletePropertyDefinition

> DeletedEntityResponse DeletePropertyDefinition (string domain, string scope, string code)

[EARLY ACCESS] Delete property definition

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
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi(Configuration.Default);
            var domain = domain_example;  // string | The domain of the property to be deleted.
            var scope = scope_example;  // string | The scope of the property to be deleted.
            var code = code_example;  // string | The code of the property to be deleted. Together with the domain and scope this uniquely              identifies the property.

            try
            {
                // [EARLY ACCESS] Delete property definition
                DeletedEntityResponse result = apiInstance.DeletePropertyDefinition(domain, scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetMultiplePropertyDefinitions

> ResourceListOfPropertyDefinition GetMultiplePropertyDefinitions (List<string> propertyKeys, DateTimeOffset? asAt = null, string filter = null)

[EARLY ACCESS] Get multiple property definitions

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
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi(Configuration.Default);
            var propertyKeys = new List<string>(); // List<string> | One or more property keys which identify each property that a definition should              be retrieved for. The format for each property key is {domain}/{scope}/{code}, e.g. 'Portfolio/Manager/Id'.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the property definitions. Defaults to return              the latest version of each definition if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] Get multiple property definitions
                ResourceListOfPropertyDefinition result = apiInstance.GetMultiplePropertyDefinitions(propertyKeys, asAt, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPropertyDefinition

> PropertyDefinition GetPropertyDefinition (string domain, string scope, string code, DateTimeOffset? asAt = null)

[EARLY ACCESS] Get property definition

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
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi(Configuration.Default);
            var domain = domain_example;  // string | The domain of the specified property.
            var scope = scope_example;  // string | The scope of the specified property.
            var code = code_example;  // string | The code of the specified property. Together with the domain and scope this uniquely              identifies the property.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the property definition. Defaults to return              the latest version of the definition if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] Get property definition
                PropertyDefinition result = apiInstance.GetPropertyDefinition(domain, scope, code, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePropertyDefinition

> PropertyDefinition UpdatePropertyDefinition (string domain, string scope, string code, UpdatePropertyDefinitionRequest definition = null)

[EARLY ACCESS] Update property definition

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
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi(Configuration.Default);
            var domain = domain_example;  // string | The domain of the property being updated.
            var scope = scope_example;  // string | The scope of the property being updated.
            var code = code_example;  // string | The code of the property being updated. Together with the domain and scope this uniquely              identifies the property.
            var definition = new UpdatePropertyDefinitionRequest(); // UpdatePropertyDefinitionRequest | The updated definition of the property. (optional) 

            try
            {
                // [EARLY ACCESS] Update property definition
                PropertyDefinition result = apiInstance.UpdatePropertyDefinition(domain, scope, code, definition);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
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
 **definition** | [**UpdatePropertyDefinitionRequest**](UpdatePropertyDefinitionRequest.md)| The updated definition of the property. | [optional] 

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
| **200** | The updated property definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

