# Lusid.Sdk.Api.CustomDataModelsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BatchAmend**](CustomDataModelsApi.md#batchamend) | **POST** /api/datamodel/$batchamend | [INTERNAL] BatchAmend: Batch amend Custom Data Models |
| [**CreateCustomDataModel**](CustomDataModelsApi.md#createcustomdatamodel) | **POST** /api/datamodel/{entityType} | [EXPERIMENTAL] CreateCustomDataModel: Create a Custom Data Model |
| [**DeleteCustomDataModel**](CustomDataModelsApi.md#deletecustomdatamodel) | **DELETE** /api/datamodel/{entityType}/{scope}/{code} | [EXPERIMENTAL] DeleteCustomDataModel: Delete a Custom Data Model |
| [**GetCustomDataModel**](CustomDataModelsApi.md#getcustomdatamodel) | **GET** /api/datamodel/{entityType}/{scope}/{code} | [EXPERIMENTAL] GetCustomDataModel: Get a Custom Data Model |
| [**ListDataModelHierarchies**](CustomDataModelsApi.md#listdatamodelhierarchies) | **GET** /api/datamodel/hierarchies | [EXPERIMENTAL] ListDataModelHierarchies: List Custom Data Model hierarchies. |
| [**ListSupportedEntityTypes**](CustomDataModelsApi.md#listsupportedentitytypes) | **GET** /api/datamodel/entitytype | [EXPERIMENTAL] ListSupportedEntityTypes: List the currently supported entity types for use in Custom Data Models. |
| [**UpdateCustomDataModel**](CustomDataModelsApi.md#updatecustomdatamodel) | **PUT** /api/datamodel/{entityType}/{scope}/{code} | [EXPERIMENTAL] UpdateCustomDataModel: Update a Custom Data Model |

<a id="batchamend"></a>
# **BatchAmend**
> BatchAmendCustomDataModelMembershipResponse BatchAmend (string successMode, Dictionary<string, MembershipAmendmentRequest> requestBody)

[INTERNAL] BatchAmend: Batch amend Custom Data Models

Add/Remove entities to/from a Custom Data Model in a single operation.                Each amendment request must be keyed by a unique correlation ID.  This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each amendment in the response.                Note: If using partial failure modes, then it is important to check the response body for failures as any  failures will still return a 200 status code.

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

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CustomDataModelsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CustomDataModelsApi>();
            var successMode = "\"Partial\"";  // string | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial. (default to "Partial")
            var requestBody = new Dictionary<string, MembershipAmendmentRequest>(); // Dictionary<string, MembershipAmendmentRequest> | The payload describing the amendments to make for the given Custom Data Model.

            try
            {
                // uncomment the below to set overrides at the request level
                // BatchAmendCustomDataModelMembershipResponse result = apiInstance.BatchAmend(successMode, requestBody, opts: opts);

                // [INTERNAL] BatchAmend: Batch amend Custom Data Models
                BatchAmendCustomDataModelMembershipResponse result = apiInstance.BatchAmend(successMode, requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CustomDataModelsApi.BatchAmend: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchAmendWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [INTERNAL] BatchAmend: Batch amend Custom Data Models
    ApiResponse<BatchAmendCustomDataModelMembershipResponse> response = apiInstance.BatchAmendWithHttpInfo(successMode, requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CustomDataModelsApi.BatchAmendWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **successMode** | **string** | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial. | [default to &quot;Partial&quot;] |
| **requestBody** | [**Dictionary&lt;string, MembershipAmendmentRequest&gt;**](MembershipAmendmentRequest.md) | The payload describing the amendments to make for the given Custom Data Model. |  |

### Return type

[**BatchAmendCustomDataModelMembershipResponse**](BatchAmendCustomDataModelMembershipResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The batch amendment operation was successful |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createcustomdatamodel"></a>
# **CreateCustomDataModel**
> CustomDataModel CreateCustomDataModel (string entityType, CreateCustomDataModelRequest? createCustomDataModelRequest = null)

[EXPERIMENTAL] CreateCustomDataModel: Create a Custom Data Model

Creates a Custom Data Model.

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

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CustomDataModelsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CustomDataModelsApi>();
            var entityType = "entityType_example";  // string | The entity type of the Data Model.
            var createCustomDataModelRequest = new CreateCustomDataModelRequest?(); // CreateCustomDataModelRequest? | The request containing the details of the Data Model. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // CustomDataModel result = apiInstance.CreateCustomDataModel(entityType, createCustomDataModelRequest, opts: opts);

                // [EXPERIMENTAL] CreateCustomDataModel: Create a Custom Data Model
                CustomDataModel result = apiInstance.CreateCustomDataModel(entityType, createCustomDataModelRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CustomDataModelsApi.CreateCustomDataModel: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCustomDataModelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateCustomDataModel: Create a Custom Data Model
    ApiResponse<CustomDataModel> response = apiInstance.CreateCustomDataModelWithHttpInfo(entityType, createCustomDataModelRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CustomDataModelsApi.CreateCustomDataModelWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityType** | **string** | The entity type of the Data Model. |  |
| **createCustomDataModelRequest** | [**CreateCustomDataModelRequest?**](CreateCustomDataModelRequest?.md) | The request containing the details of the Data Model. | [optional]  |

### Return type

[**CustomDataModel**](CustomDataModel.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created Data Model |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletecustomdatamodel"></a>
# **DeleteCustomDataModel**
> DeletedEntityResponse DeleteCustomDataModel (string entityType, string scope, string code)

[EXPERIMENTAL] DeleteCustomDataModel: Delete a Custom Data Model

Delete a Custom Data Model. The data model will remain viewable at previous as at times, but will no longer  be part of any hierarchies.

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

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CustomDataModelsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CustomDataModelsApi>();
            var entityType = "entityType_example";  // string | The entity type of the Data Model.
            var scope = "scope_example";  // string | The scope of the specified Data Model.
            var code = "code_example";  // string | The code of the specified Data Model.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteCustomDataModel(entityType, scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteCustomDataModel: Delete a Custom Data Model
                DeletedEntityResponse result = apiInstance.DeleteCustomDataModel(entityType, scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CustomDataModelsApi.DeleteCustomDataModel: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCustomDataModelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteCustomDataModel: Delete a Custom Data Model
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteCustomDataModelWithHttpInfo(entityType, scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CustomDataModelsApi.DeleteCustomDataModelWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityType** | **string** | The entity type of the Data Model. |  |
| **scope** | **string** | The scope of the specified Data Model. |  |
| **code** | **string** | The code of the specified Data Model. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The deleted entity metadata |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getcustomdatamodel"></a>
# **GetCustomDataModel**
> CustomDataModel GetCustomDataModel (string entityType, string scope, string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetCustomDataModel: Get a Custom Data Model

Retrieves a Custom Data Model at a given as at time.

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

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CustomDataModelsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CustomDataModelsApi>();
            var entityType = "entityType_example";  // string | The entity type of the Data Model.
            var scope = "scope_example";  // string | The scope of the specified Data Model.
            var code = "code_example";  // string | The code of the specified Data Model.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Data Model. Defaults to return              the latest version of the Data Model if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // CustomDataModel result = apiInstance.GetCustomDataModel(entityType, scope, code, asAt, opts: opts);

                // [EXPERIMENTAL] GetCustomDataModel: Get a Custom Data Model
                CustomDataModel result = apiInstance.GetCustomDataModel(entityType, scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CustomDataModelsApi.GetCustomDataModel: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomDataModelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetCustomDataModel: Get a Custom Data Model
    ApiResponse<CustomDataModel> response = apiInstance.GetCustomDataModelWithHttpInfo(entityType, scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CustomDataModelsApi.GetCustomDataModelWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityType** | **string** | The entity type of the Data Model. |  |
| **scope** | **string** | The scope of the specified Data Model. |  |
| **code** | **string** | The code of the specified Data Model. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Data Model. Defaults to return              the latest version of the Data Model if not specified. | [optional]  |

### Return type

[**CustomDataModel**](CustomDataModel.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Data Model |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listdatamodelhierarchies"></a>
# **ListDataModelHierarchies**
> ResourceListOfDataModelSummary ListDataModelHierarchies (DateTimeOffset? asAt = null, string? filter = null)

[EXPERIMENTAL] ListDataModelHierarchies: List Custom Data Model hierarchies.

Lists the data model summaries within their hierarchical structure.

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

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CustomDataModelsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CustomDataModelsApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Data Model. Defaults to return              the latest version of the Data Model if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. Only EntityType is supported (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfDataModelSummary result = apiInstance.ListDataModelHierarchies(asAt, filter, opts: opts);

                // [EXPERIMENTAL] ListDataModelHierarchies: List Custom Data Model hierarchies.
                ResourceListOfDataModelSummary result = apiInstance.ListDataModelHierarchies(asAt, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CustomDataModelsApi.ListDataModelHierarchies: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDataModelHierarchiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListDataModelHierarchies: List Custom Data Model hierarchies.
    ApiResponse<ResourceListOfDataModelSummary> response = apiInstance.ListDataModelHierarchiesWithHttpInfo(asAt, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CustomDataModelsApi.ListDataModelHierarchiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Data Model. Defaults to return              the latest version of the Data Model if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. Only EntityType is supported | [optional]  |

### Return type

[**ResourceListOfDataModelSummary**](ResourceListOfDataModelSummary.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All data model hierarchies. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listsupportedentitytypes"></a>
# **ListSupportedEntityTypes**
> ResourceListOfString ListSupportedEntityTypes ()

[EXPERIMENTAL] ListSupportedEntityTypes: List the currently supported entity types for use in Custom Data Models.

Lists the currently supported entity types available to bind with Custom Data Models.

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

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CustomDataModelsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CustomDataModelsApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfString result = apiInstance.ListSupportedEntityTypes(opts: opts);

                // [EXPERIMENTAL] ListSupportedEntityTypes: List the currently supported entity types for use in Custom Data Models.
                ResourceListOfString result = apiInstance.ListSupportedEntityTypes();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CustomDataModelsApi.ListSupportedEntityTypes: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSupportedEntityTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListSupportedEntityTypes: List the currently supported entity types for use in Custom Data Models.
    ApiResponse<ResourceListOfString> response = apiInstance.ListSupportedEntityTypesWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CustomDataModelsApi.ListSupportedEntityTypesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ResourceListOfString**](ResourceListOfString.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All supported entity types. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatecustomdatamodel"></a>
# **UpdateCustomDataModel**
> CustomDataModel UpdateCustomDataModel (string entityType, string scope, string code, UpdateCustomDataModelRequest? updateCustomDataModelRequest = null)

[EXPERIMENTAL] UpdateCustomDataModel: Update a Custom Data Model

Updates a Custom Data Model.

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

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CustomDataModelsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CustomDataModelsApi>();
            var entityType = "entityType_example";  // string | The entity type of the Data Model.
            var scope = "scope_example";  // string | The scope of the specified Data Model.
            var code = "code_example";  // string | The code of the specified Data Model.
            var updateCustomDataModelRequest = new UpdateCustomDataModelRequest?(); // UpdateCustomDataModelRequest? | The request containing the details of the Data Model. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // CustomDataModel result = apiInstance.UpdateCustomDataModel(entityType, scope, code, updateCustomDataModelRequest, opts: opts);

                // [EXPERIMENTAL] UpdateCustomDataModel: Update a Custom Data Model
                CustomDataModel result = apiInstance.UpdateCustomDataModel(entityType, scope, code, updateCustomDataModelRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CustomDataModelsApi.UpdateCustomDataModel: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCustomDataModelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateCustomDataModel: Update a Custom Data Model
    ApiResponse<CustomDataModel> response = apiInstance.UpdateCustomDataModelWithHttpInfo(entityType, scope, code, updateCustomDataModelRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CustomDataModelsApi.UpdateCustomDataModelWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityType** | **string** | The entity type of the Data Model. |  |
| **scope** | **string** | The scope of the specified Data Model. |  |
| **code** | **string** | The code of the specified Data Model. |  |
| **updateCustomDataModelRequest** | [**UpdateCustomDataModelRequest?**](UpdateCustomDataModelRequest?.md) | The request containing the details of the Data Model. | [optional]  |

### Return type

[**CustomDataModel**](CustomDataModel.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated Data Model |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

