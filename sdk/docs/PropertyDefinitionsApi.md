# Lusid.Sdk.Api.PropertyDefinitionsApi

All URIs are relative to *http://http:/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePropertyDefinition**](PropertyDefinitionsApi.md#createpropertydefinition) | **POST** /api/propertydefinitions | Create property definition
[**DeletePropertyDefinition**](PropertyDefinitionsApi.md#deletepropertydefinition) | **DELETE** /api/propertydefinitions/{domain}/{scope}/{code} | Delete property definition
[**GetMultiplePropertyDefinitions**](PropertyDefinitionsApi.md#getmultiplepropertydefinitions) | **GET** /api/propertydefinitions | Get multiple property definitions
[**GetPropertyDefinition**](PropertyDefinitionsApi.md#getpropertydefinition) | **GET** /api/propertydefinitions/{domain}/{scope}/{code} | Get property definition
[**UpdatePropertyDefinition**](PropertyDefinitionsApi.md#updatepropertydefinition) | **PUT** /api/propertydefinitions/{domain}/{scope}/{code} | Update property definition



## CreatePropertyDefinition

> PropertyDefinition CreatePropertyDefinition (CreatePropertyDefinitionRequest definition)

Create property definition

Define a new property.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreatePropertyDefinitionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi();
            var definition = new CreatePropertyDefinitionRequest(); // CreatePropertyDefinitionRequest | The definition of the new property.

            try
            {
                // Create property definition
                PropertyDefinition result = apiInstance.CreatePropertyDefinition(definition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.CreatePropertyDefinition: " + e.Message );
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeletePropertyDefinition

> DeletedEntityResponse DeletePropertyDefinition (string domain, string scope, string code)

Delete property definition

Delete the definition of the specified property.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePropertyDefinitionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi();
            var domain = domain_example;  // string | The domain of the property to be deleted.
            var scope = scope_example;  // string | The scope of the property to be deleted.
            var code = code_example;  // string | The code of the property to be deleted. Together with the domain and scope this uniquely              identifies the property.

            try
            {
                // Delete property definition
                DeletedEntityResponse result = apiInstance.DeletePropertyDefinition(domain, scope, code);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.DeletePropertyDefinition: " + e.Message );
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetMultiplePropertyDefinitions

> ResourceListOfPropertyDefinition GetMultiplePropertyDefinitions (List<string> propertyKeys, DateTimeOffset? asAt = null, string filter = null)

Get multiple property definitions

Retrieve the definition of one or more specified properties.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetMultiplePropertyDefinitionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi();
            var propertyKeys = new List<string>(); // List<string> | One or more property keys which identify each property that a definition should              be retrieved for. The format for each property key is {domain}/{scope}/{code}, e.g. \"Instrument/system/Name\".
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the property definition/s. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. (optional) 

            try
            {
                // Get multiple property definitions
                ResourceListOfPropertyDefinition result = apiInstance.GetMultiplePropertyDefinitions(propertyKeys, asAt, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.GetMultiplePropertyDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| One or more property keys which identify each property that a definition should              be retrieved for. The format for each property key is {domain}/{scope}/{code}, e.g. \&quot;Instrument/system/Name\&quot;. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the property definition/s. | [optional] 
 **filter** | **string**| Expression to filter the result set. | [optional] 

### Return type

[**ResourceListOfPropertyDefinition**](ResourceListOfPropertyDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPropertyDefinition

> PropertyDefinition GetPropertyDefinition (string domain, string scope, string code, DateTimeOffset? asAt = null)

Get property definition

Retrieve the definition of the specified property.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPropertyDefinitionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi();
            var domain = domain_example;  // string | The domain of the specified property.
            var scope = scope_example;  // string | The scope of the specified property.
            var code = code_example;  // string | The code of the specified property. Together with the domain and scope this uniquely              identifies the property.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the property definition. (optional) 

            try
            {
                // Get property definition
                PropertyDefinition result = apiInstance.GetPropertyDefinition(domain, scope, code, asAt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.GetPropertyDefinition: " + e.Message );
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
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the property definition. | [optional] 

### Return type

[**PropertyDefinition**](PropertyDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePropertyDefinition

> PropertyDefinition UpdatePropertyDefinition (string domain, string scope, string code, UpdatePropertyDefinitionRequest definition = null)

Update property definition

Update the definition of the specified existing property. Not all elements within a property definition  are modifiable due to the potential implications for data already stored against the property.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdatePropertyDefinitionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PropertyDefinitionsApi();
            var domain = domain_example;  // string | The domain of the property being updated.
            var scope = scope_example;  // string | The scope of the property being updated.
            var code = code_example;  // string | The code of the property being updated. Together with the domain and scope this uniquely              identifies the property.
            var definition = new UpdatePropertyDefinitionRequest(); // UpdatePropertyDefinitionRequest | The updated definition of the property. (optional) 

            try
            {
                // Update property definition
                PropertyDefinition result = apiInstance.UpdatePropertyDefinition(domain, scope, code, definition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PropertyDefinitionsApi.UpdatePropertyDefinition: " + e.Message );
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

