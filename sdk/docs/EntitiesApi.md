# Lusid.Sdk.Api.EntitiesApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCustomEntityByEntityUniqueId**](EntitiesApi.md#getcustomentitybyentityuniqueid) | **GET** /api/entities/customentities/{entityUniqueId} | [EXPERIMENTAL] GetCustomEntityByEntityUniqueId: Get a Custom Entity instance by its EntityUniqueId |
| [**GetDataTypeByEntityUniqueId**](EntitiesApi.md#getdatatypebyentityuniqueid) | **GET** /api/entities/datatypes/{entityUniqueId} | [EXPERIMENTAL] GetDataTypeByEntityUniqueId: Get DataType by EntityUniqueId |
| [**GetInstrumentByEntityUniqueId**](EntitiesApi.md#getinstrumentbyentityuniqueid) | **GET** /api/entities/instruments/{entityUniqueId} | [EXPERIMENTAL] GetInstrumentByEntityUniqueId: Get instrument by EntityUniqueId |
| [**GetPortfolioByEntityUniqueId**](EntitiesApi.md#getportfoliobyentityuniqueid) | **GET** /api/entities/portfolios/{entityUniqueId} | [EXPERIMENTAL] GetPortfolioByEntityUniqueId: Get portfolio by EntityUniqueId |
| [**GetPortfolioChanges**](EntitiesApi.md#getportfoliochanges) | **GET** /api/entities/changes/portfolios | GetPortfolioChanges: Get the next change to each portfolio in a scope. |
| [**GetPropertyDefinitionByEntityUniqueId**](EntitiesApi.md#getpropertydefinitionbyentityuniqueid) | **GET** /api/entities/propertydefinitions/{entityUniqueId} | [EXPERIMENTAL] GetPropertyDefinitionByEntityUniqueId: Get property definition by EntityUniqueId |

<a id="getcustomentitybyentityuniqueid"></a>
# **GetCustomEntityByEntityUniqueId**
> CustomEntityEntity GetCustomEntityByEntityUniqueId (string entityUniqueId, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? previews = null)

[EXPERIMENTAL] GetCustomEntityByEntityUniqueId: Get a Custom Entity instance by its EntityUniqueId

Retrieve a particular Custom Entity instance.  If the Custom Entity is deleted, this will return the state of the Custom Entity immediately prior to deletion.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EntitiesApi>();
            var entityUniqueId = "entityUniqueId_example";  // string | The universally unique identifier of the Custom Entity.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the Custom Entity. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Custom Entity. Defaults to returning the latest version of the Custom Entity if not specified. (optional) 
            var previews = new List<string>?(); // List<string>? | The ids of the staged modifications to be previewed in the response. (optional) 

            try
            {
                // [EXPERIMENTAL] GetCustomEntityByEntityUniqueId: Get a Custom Entity instance by its EntityUniqueId
                CustomEntityEntity result = apiInstance.GetCustomEntityByEntityUniqueId(entityUniqueId, effectiveAt, asAt, previews);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EntitiesApi.GetCustomEntityByEntityUniqueId: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomEntityByEntityUniqueIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetCustomEntityByEntityUniqueId: Get a Custom Entity instance by its EntityUniqueId
    ApiResponse<CustomEntityEntity> response = apiInstance.GetCustomEntityByEntityUniqueIdWithHttpInfo(entityUniqueId, effectiveAt, asAt, previews);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EntitiesApi.GetCustomEntityByEntityUniqueIdWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityUniqueId** | **string** | The universally unique identifier of the Custom Entity. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the Custom Entity. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Custom Entity. Defaults to returning the latest version of the Custom Entity if not specified. | [optional]  |
| **previews** | [**List&lt;string&gt;?**](string.md) | The ids of the staged modifications to be previewed in the response. | [optional]  |

### Return type

[**CustomEntityEntity**](CustomEntityEntity.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested CustomEntity |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getdatatypebyentityuniqueid"></a>
# **GetDataTypeByEntityUniqueId**
> DataTypeEntity GetDataTypeByEntityUniqueId (string entityUniqueId, DateTimeOffset? asAt = null, List<string>? previews = null)

[EXPERIMENTAL] GetDataTypeByEntityUniqueId: Get DataType by EntityUniqueId

Retrieve the definition of a particular DataType.  If the DataType is deleted, this will return the state of the DataType immediately prior to deletion.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EntitiesApi>();
            var entityUniqueId = "entityUniqueId_example";  // string | The universally unique identifier of the DataType definition.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the DataType definition. Defaults to returning the latest version of the DataType definition if not specified. (optional) 
            var previews = new List<string>?(); // List<string>? | The ids of the staged modifications to be previewed in the response. (optional) 

            try
            {
                // [EXPERIMENTAL] GetDataTypeByEntityUniqueId: Get DataType by EntityUniqueId
                DataTypeEntity result = apiInstance.GetDataTypeByEntityUniqueId(entityUniqueId, asAt, previews);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EntitiesApi.GetDataTypeByEntityUniqueId: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataTypeByEntityUniqueIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetDataTypeByEntityUniqueId: Get DataType by EntityUniqueId
    ApiResponse<DataTypeEntity> response = apiInstance.GetDataTypeByEntityUniqueIdWithHttpInfo(entityUniqueId, asAt, previews);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EntitiesApi.GetDataTypeByEntityUniqueIdWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityUniqueId** | **string** | The universally unique identifier of the DataType definition. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the DataType definition. Defaults to returning the latest version of the DataType definition if not specified. | [optional]  |
| **previews** | [**List&lt;string&gt;?**](string.md) | The ids of the staged modifications to be previewed in the response. | [optional]  |

### Return type

[**DataTypeEntity**](DataTypeEntity.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested DataType entity |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getinstrumentbyentityuniqueid"></a>
# **GetInstrumentByEntityUniqueId**
> InstrumentEntity GetInstrumentByEntityUniqueId (string entityUniqueId, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? previews = null)

[EXPERIMENTAL] GetInstrumentByEntityUniqueId: Get instrument by EntityUniqueId

Retrieve the definition of a particular instrument.  If the instrument is deleted, this will return the state of the instrument immediately prior to deletion.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EntitiesApi>();
            var entityUniqueId = "entityUniqueId_example";  // string | The universally unique identifier of the instrument definition.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the Instrument definition. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the instrument definition. Defaults to returning the latest version of the instrument definition if not specified. (optional) 
            var previews = new List<string>?(); // List<string>? | The ids of the staged modifications to be previewed in the response. (optional) 

            try
            {
                // [EXPERIMENTAL] GetInstrumentByEntityUniqueId: Get instrument by EntityUniqueId
                InstrumentEntity result = apiInstance.GetInstrumentByEntityUniqueId(entityUniqueId, effectiveAt, asAt, previews);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EntitiesApi.GetInstrumentByEntityUniqueId: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInstrumentByEntityUniqueIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetInstrumentByEntityUniqueId: Get instrument by EntityUniqueId
    ApiResponse<InstrumentEntity> response = apiInstance.GetInstrumentByEntityUniqueIdWithHttpInfo(entityUniqueId, effectiveAt, asAt, previews);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EntitiesApi.GetInstrumentByEntityUniqueIdWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityUniqueId** | **string** | The universally unique identifier of the instrument definition. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the Instrument definition. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the instrument definition. Defaults to returning the latest version of the instrument definition if not specified. | [optional]  |
| **previews** | [**List&lt;string&gt;?**](string.md) | The ids of the staged modifications to be previewed in the response. | [optional]  |

### Return type

[**InstrumentEntity**](InstrumentEntity.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested instrument entity |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getportfoliobyentityuniqueid"></a>
# **GetPortfolioByEntityUniqueId**
> PortfolioEntity GetPortfolioByEntityUniqueId (string entityUniqueId, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? previews = null)

[EXPERIMENTAL] GetPortfolioByEntityUniqueId: Get portfolio by EntityUniqueId

Retrieve the definition of a particular portfolio.  If the portfolio is deleted, this will return the state of the portfolio immediately prior to deletion.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EntitiesApi>();
            var entityUniqueId = "entityUniqueId_example";  // string | The universally unique identifier of the portfolio definition.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio definition. Defaults to returning the latest version of the portfolio definition if not specified. (optional) 
            var previews = new List<string>?(); // List<string>? | The ids of the staged modifications to be previewed in the response. (optional) 

            try
            {
                // [EXPERIMENTAL] GetPortfolioByEntityUniqueId: Get portfolio by EntityUniqueId
                PortfolioEntity result = apiInstance.GetPortfolioByEntityUniqueId(entityUniqueId, effectiveAt, asAt, previews);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EntitiesApi.GetPortfolioByEntityUniqueId: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPortfolioByEntityUniqueIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetPortfolioByEntityUniqueId: Get portfolio by EntityUniqueId
    ApiResponse<PortfolioEntity> response = apiInstance.GetPortfolioByEntityUniqueIdWithHttpInfo(entityUniqueId, effectiveAt, asAt, previews);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EntitiesApi.GetPortfolioByEntityUniqueIdWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityUniqueId** | **string** | The universally unique identifier of the portfolio definition. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the portfolio definition. Defaults to returning the latest version of the portfolio definition if not specified. | [optional]  |
| **previews** | [**List&lt;string&gt;?**](string.md) | The ids of the staged modifications to be previewed in the response. | [optional]  |

### Return type

[**PortfolioEntity**](PortfolioEntity.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolio entity |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getportfoliochanges"></a>
# **GetPortfolioChanges**
> ResourceListOfChange GetPortfolioChanges (string scope, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = null)

GetPortfolioChanges: Get the next change to each portfolio in a scope.

Gets the time of the next (earliest effective at) modification (correction and/or amendment) to each portfolio in a scope relative to a point in bitemporal time.  Includes changes from parent portfolios in different scopes.  Excludes changes from subscriptions (e.g corporate actions).

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EntitiesApi>();
            var scope = "scope_example";  // string | The scope
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel | The effective date of the origin.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The as-at date of the origin. (optional) 

            try
            {
                // GetPortfolioChanges: Get the next change to each portfolio in a scope.
                ResourceListOfChange result = apiInstance.GetPortfolioChanges(scope, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EntitiesApi.GetPortfolioChanges: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPortfolioChangesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetPortfolioChanges: Get the next change to each portfolio in a scope.
    ApiResponse<ResourceListOfChange> response = apiInstance.GetPortfolioChangesWithHttpInfo(scope, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EntitiesApi.GetPortfolioChangesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope |  |
| **effectiveAt** | **DateTimeOrCutLabel** | The effective date of the origin. |  |
| **asAt** | **DateTimeOffset?** | The as-at date of the origin. | [optional]  |

### Return type

[**ResourceListOfChange**](ResourceListOfChange.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | The details of the input related failure |  -  |
| **200** | A list of portfolio changes in the requested scope relative to the specified time. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getpropertydefinitionbyentityuniqueid"></a>
# **GetPropertyDefinitionByEntityUniqueId**
> PropertyDefinitionEntity GetPropertyDefinitionByEntityUniqueId (string entityUniqueId, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? previews = null)

[EXPERIMENTAL] GetPropertyDefinitionByEntityUniqueId: Get property definition by EntityUniqueId

Retrieve a particular property definition.  If the property definition is deleted, this will return the state of the property definition immediately prior to deletion.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EntitiesApi>();
            var entityUniqueId = "entityUniqueId_example";  // string | The universally unique identifier of the property definition.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime at which to retrieve the property definition. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the property definition. Defaults to returning the latest version of the property definition if not specified. (optional) 
            var previews = new List<string>?(); // List<string>? | The ids of the staged modifications to be previewed in the response. (optional) 

            try
            {
                // [EXPERIMENTAL] GetPropertyDefinitionByEntityUniqueId: Get property definition by EntityUniqueId
                PropertyDefinitionEntity result = apiInstance.GetPropertyDefinitionByEntityUniqueId(entityUniqueId, effectiveAt, asAt, previews);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EntitiesApi.GetPropertyDefinitionByEntityUniqueId: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPropertyDefinitionByEntityUniqueIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetPropertyDefinitionByEntityUniqueId: Get property definition by EntityUniqueId
    ApiResponse<PropertyDefinitionEntity> response = apiInstance.GetPropertyDefinitionByEntityUniqueIdWithHttpInfo(entityUniqueId, effectiveAt, asAt, previews);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EntitiesApi.GetPropertyDefinitionByEntityUniqueIdWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityUniqueId** | **string** | The universally unique identifier of the property definition. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime at which to retrieve the property definition. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the property definition. Defaults to returning the latest version of the property definition if not specified. | [optional]  |
| **previews** | [**List&lt;string&gt;?**](string.md) | The ids of the staged modifications to be previewed in the response. | [optional]  |

### Return type

[**PropertyDefinitionEntity**](PropertyDefinitionEntity.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested property definition entity |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

