# Lusid.Sdk.Api.SchemasApi

All URIs are relative to *http://localhost/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEntitySchema**](SchemasApi.md#getentityschema) | **GET** /api/schemas/entities/{entity} | [BETA] Get schema
[**GetPropertySchema**](SchemasApi.md#getpropertyschema) | **GET** /api/schemas/properties | [BETA] Get property schema
[**GetValueTypes**](SchemasApi.md#getvaluetypes) | **GET** /api/schemas/types | [BETA] Get value types
[**ListEntities**](SchemasApi.md#listentities) | **GET** /api/schemas/entities | [BETA] List entities



## GetEntitySchema

> Schema GetEntitySchema (string entity)

[BETA] Get schema

Gets the schema and meta-data for a given entity

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetEntitySchemaExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchemasApi(Configuration.Default);
            var entity = entity_example;  // string | The name of a valid entity

            try
            {
                // [BETA] Get schema
                Schema result = apiInstance.GetEntitySchema(entity);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SchemasApi.GetEntitySchema: " + e.Message );
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
 **entity** | **string**| The name of a valid entity | 

### Return type

[**Schema**](Schema.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPropertySchema

> PropertySchema GetPropertySchema (List<string> propertyKeys = null, DateTimeOffset? asAt = null)

[BETA] Get property schema

Get the schemas for the provided list of property keys.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPropertySchemaExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchemasApi(Configuration.Default);
            var propertyKeys = new List<string>(); // List<string> | One or more property keys for which the schema is requested (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 

            try
            {
                // [BETA] Get property schema
                PropertySchema result = apiInstance.GetPropertySchema(propertyKeys, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SchemasApi.GetPropertySchema: " + e.Message );
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
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| One or more property keys for which the schema is requested | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 

### Return type

[**PropertySchema**](PropertySchema.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetValueTypes

> ResourceListOfValueType GetValueTypes (List<string> sortBy = null, int? start = null, int? limit = null)

[BETA] Get value types

Gets the available value types for which a schema is available.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetValueTypesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchemasApi(Configuration.Default);
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 

            try
            {
                // [BETA] Get value types
                ResourceListOfValueType result = apiInstance.GetValueTypes(sortBy, start, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SchemasApi.GetValueTypes: " + e.Message );
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
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 

### Return type

[**ResourceListOfValueType**](ResourceListOfValueType.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListEntities

> ResourceListOfString ListEntities ()

[BETA] List entities

List all available entities for which schema information is available.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListEntitiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchemasApi(Configuration.Default);

            try
            {
                // [BETA] List entities
                ResourceListOfString result = apiInstance.ListEntities();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SchemasApi.ListEntities: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**ResourceListOfString**](ResourceListOfString.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

