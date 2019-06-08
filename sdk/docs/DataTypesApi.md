# Lusid.Sdk.Api.DataTypesApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDataType**](DataTypesApi.md#createdatatype) | **POST** /api/datatypes | Create data type definition
[**GetDataType**](DataTypesApi.md#getdatatype) | **GET** /api/datatypes/{scope}/{code} | Get data type definition
[**GetUnitsFromDataType**](DataTypesApi.md#getunitsfromdatatype) | **GET** /api/datatypes/{scope}/{code}/units | Get units from data type
[**ListDataTypes**](DataTypesApi.md#listdatatypes) | **GET** /api/datatypes/{scope} | List data types
[**UpdateDataType**](DataTypesApi.md#updatedatatype) | **PUT** /api/datatypes/{scope}/{code} | Update data type definition



## CreateDataType

> DataType CreateDataType (CreateDataTypeRequest request = null)

Create data type definition

Create a new data type definition    Data types cannot be created in either the \"default\" or \"system\" scopes.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateDataTypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataTypesApi();
            var request = new CreateDataTypeRequest(); // CreateDataTypeRequest | The definition of the new data type (optional) 

            try
            {
                // Create data type definition
                DataType result = apiInstance.CreateDataType(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataTypesApi.CreateDataType: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateDataTypeRequest**](CreateDataTypeRequest.md)| The definition of the new data type | [optional] 

### Return type

[**DataType**](DataType.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDataType

> DataType GetDataType (string scope, string code)

Get data type definition

Get the definition of a specified data type

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetDataTypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataTypesApi();
            var scope = scope_example;  // string | The scope of the data type
            var code = code_example;  // string | The code of the data type

            try
            {
                // Get data type definition
                DataType result = apiInstance.GetDataType(scope, code);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataTypesApi.GetDataType: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the data type | 
 **code** | **string**| The code of the data type | 

### Return type

[**DataType**](DataType.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetUnitsFromDataType

> ResourceListOfIUnitDefinitionDto GetUnitsFromDataType (string scope, string code, List<string> units = null, string filter = null)

Get units from data type

Get the definitions of the specified units associated bound to a specific data type

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetUnitsFromDataTypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataTypesApi();
            var scope = scope_example;  // string | The scope of the data type
            var code = code_example;  // string | The code of the data type
            var units = new List<string>(); // List<string> | One or more unit identifiers for which the definition is being requested (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 

            try
            {
                // Get units from data type
                ResourceListOfIUnitDefinitionDto result = apiInstance.GetUnitsFromDataType(scope, code, units, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataTypesApi.GetUnitsFromDataType: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the data type | 
 **code** | **string**| The code of the data type | 
 **units** | [**List&lt;string&gt;**](string.md)| One or more unit identifiers for which the definition is being requested | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 

### Return type

[**ResourceListOfIUnitDefinitionDto**](ResourceListOfIUnitDefinitionDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListDataTypes

> ResourceListOfDataType ListDataTypes (string scope, bool? includeSystem = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)

List data types

List all data types in a specified scope

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListDataTypesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataTypesApi();
            var scope = scope_example;  // string | The requested scope of the data types
            var includeSystem = true;  // bool? | Whether to additionally include those data types in the \"system\" scope (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 

            try
            {
                // List data types
                ResourceListOfDataType result = apiInstance.ListDataTypes(scope, includeSystem, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataTypesApi.ListDataTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The requested scope of the data types | 
 **includeSystem** | **bool?**| Whether to additionally include those data types in the \&quot;system\&quot; scope | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 

### Return type

[**ResourceListOfDataType**](ResourceListOfDataType.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateDataType

> DataType UpdateDataType (string scope, string code, UpdateDataTypeRequest request = null)

Update data type definition

Update the definition of the specified existing data type    Not all elements within a data type definition are modifiable due to the potential implications for data  already stored against the types

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdateDataTypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataTypesApi();
            var scope = scope_example;  // string | The scope of the data type
            var code = code_example;  // string | The code of the data type
            var request = new UpdateDataTypeRequest(); // UpdateDataTypeRequest | The updated definition of the data type (optional) 

            try
            {
                // Update data type definition
                DataType result = apiInstance.UpdateDataType(scope, code, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataTypesApi.UpdateDataType: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the data type | 
 **code** | **string**| The code of the data type | 
 **request** | [**UpdateDataTypeRequest**](UpdateDataTypeRequest.md)| The updated definition of the data type | [optional] 

### Return type

[**DataType**](DataType.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

