# Lusid.Sdk.Api.PropertyDefinitionsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePropertyDefinition**](PropertyDefinitionsApi.md#createpropertydefinition) | **POST** /api/propertydefinitions | Define a new property
[**DeletePropertyDefinition**](PropertyDefinitionsApi.md#deletepropertydefinition) | **DELETE** /api/propertydefinitions/{domain}/{scope}/{code} | Delete property definition
[**GetMultiplePropertyDefinitions**](PropertyDefinitionsApi.md#getmultiplepropertydefinitions) | **GET** /api/propertydefinitions | Get multiple property definitions
[**GetPropertyDefinition**](PropertyDefinitionsApi.md#getpropertydefinition) | **GET** /api/propertydefinitions/{domain}/{scope}/{code} | Get property definition
[**UpdatePropertyDefinition**](PropertyDefinitionsApi.md#updatepropertydefinition) | **PUT** /api/propertydefinitions/{domain}/{scope}/{code} | Update the definition of the specified existing property



## CreatePropertyDefinition

> PropertyDefinition CreatePropertyDefinition (CreatePropertyDefinitionRequest definition = null)

Define a new property

Create a new property definition

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
            var definition = new CreatePropertyDefinitionRequest(); // CreatePropertyDefinitionRequest | The definition of the new property (optional) 

            try
            {
                // Define a new property
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
 **definition** | [**CreatePropertyDefinitionRequest**](CreatePropertyDefinitionRequest.md)| The definition of the new property | [optional] 

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

Delete the definition of the specified property

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
            var domain = domain_example;  // string | The Property Domain of the property to be deleted
            var scope = scope_example;  // string | The scope of the property to be deleted
            var code = code_example;  // string | The code of the property to be deleted

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
 **domain** | **string**| The Property Domain of the property to be deleted | 
 **scope** | **string**| The scope of the property to be deleted | 
 **code** | **string**| The code of the property to be deleted | 

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

> ResourceListOfPropertyDefinition GetMultiplePropertyDefinitions (List<string> propertyKeys = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)

Get multiple property definitions

Get one or more property definitions

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
            var propertyKeys = new List<string>(); // List<string> | One or more keys for properties for which the schema should be returned (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 

            try
            {
                // Get multiple property definitions
                ResourceListOfPropertyDefinition result = apiInstance.GetMultiplePropertyDefinitions(propertyKeys, asAt, sortBy, start, limit, filter);
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
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| One or more keys for properties for which the schema should be returned | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 

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

Retrieve the definition for the identified property

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
            var domain = domain_example;  // string | The Property Domain of the requested property
            var scope = scope_example;  // string | The scope of the requested property
            var code = code_example;  // string | The code of the requested property
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 

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
 **domain** | **string**| The Property Domain of the requested property | 
 **scope** | **string**| The scope of the requested property | 
 **code** | **string**| The code of the requested property | 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 

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

Update the definition of the specified existing property

Not all elements within a property definition are modifiable due to the potential implications for data  already stored against these properties

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
            var domain = domain_example;  // string | The Property Domain of the property being updated
            var scope = scope_example;  // string | The scope of the property to be updated
            var code = code_example;  // string | The code of the property to be updated
            var definition = new UpdatePropertyDefinitionRequest(); // UpdatePropertyDefinitionRequest | The updated definition of the property (optional) 

            try
            {
                // Update the definition of the specified existing property
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
 **domain** | **string**| The Property Domain of the property being updated | 
 **scope** | **string**| The scope of the property to be updated | 
 **code** | **string**| The code of the property to be updated | 
 **definition** | [**UpdatePropertyDefinitionRequest**](UpdatePropertyDefinitionRequest.md)| The updated definition of the property | [optional] 

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

