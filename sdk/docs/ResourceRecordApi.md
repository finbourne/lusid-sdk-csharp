# Lusid.Sdk.Api.ResourceRecordApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteResourceRecord**](ResourceRecordApi.md#deleteresourcerecord) | **DELETE** /api/resourcerecords/{scope}/{code}/{resourceId} | [EARLY ACCESS] DeleteResourceRecord: Delete a Resource Record |
| [**GetResourceRecord**](ResourceRecordApi.md#getresourcerecord) | **GET** /api/resourcerecords/{scope}/{code}/{resourceId} | [EARLY ACCESS] GetResourceRecord: Get a Resource Record |
| [**ListResourceRecordCodes**](ResourceRecordApi.md#listresourcerecordcodes) | **GET** /api/resourcerecords/{scope} | [EARLY ACCESS] ListResourceRecordCodes: List Resource Records Codes for Scope |
| [**ListResourceRecordScopes**](ResourceRecordApi.md#listresourcerecordscopes) | **GET** /api/resourcerecords | [EARLY ACCESS] ListResourceRecordScopes: List Resource Record Scopes |
| [**ListResourceRecords**](ResourceRecordApi.md#listresourcerecords) | **GET** /api/resourcerecords/{scope}/{code} | [EARLY ACCESS] ListResourceRecords: List Resource Records |
| [**UpsertResourceRecord**](ResourceRecordApi.md#upsertresourcerecord) | **POST** /api/resourcerecords | [EARLY ACCESS] UpsertResourceRecord: Upsert a Resource Record |

<a id="deleteresourcerecord"></a>
# **DeleteResourceRecord**
> DeletedEntityResponse DeleteResourceRecord (string scope, string code, string resourceId)

[EARLY ACCESS] DeleteResourceRecord: Delete a Resource Record

Delete a resource record.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ResourceRecordApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ResourceRecordApi>();
            var scope = "scope_example";  // string | The scope of the resource record.
            var code = "code_example";  // string | The code of the resource record.
            var resourceId = "resourceId_example";  // string | The resource identifier of the resource record.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteResourceRecord(scope, code, resourceId, opts: opts);

                // [EARLY ACCESS] DeleteResourceRecord: Delete a Resource Record
                DeletedEntityResponse result = apiInstance.DeleteResourceRecord(scope, code, resourceId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ResourceRecordApi.DeleteResourceRecord: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteResourceRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteResourceRecord: Delete a Resource Record
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteResourceRecordWithHttpInfo(scope, code, resourceId);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ResourceRecordApi.DeleteResourceRecordWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the resource record. |  |
| **code** | **string** | The code of the resource record. |  |
| **resourceId** | **string** | The resource identifier of the resource record. |  |

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

<a id="getresourcerecord"></a>
# **GetResourceRecord**
> ResourceRecord GetResourceRecord (string scope, string code, string resourceId, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetResourceRecord: Get a Resource Record

Retrieve a resource record by its identifier.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ResourceRecordApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ResourceRecordApi>();
            var scope = "scope_example";  // string | The scope of the resource record.
            var code = "code_example";  // string | The code of the resource record.
            var resourceId = "resourceId_example";  // string | The resource identifier of the resource record.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the resource record. Defaults to return the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceRecord result = apiInstance.GetResourceRecord(scope, code, resourceId, asAt, opts: opts);

                // [EARLY ACCESS] GetResourceRecord: Get a Resource Record
                ResourceRecord result = apiInstance.GetResourceRecord(scope, code, resourceId, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ResourceRecordApi.GetResourceRecord: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResourceRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetResourceRecord: Get a Resource Record
    ApiResponse<ResourceRecord> response = apiInstance.GetResourceRecordWithHttpInfo(scope, code, resourceId, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ResourceRecordApi.GetResourceRecordWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the resource record. |  |
| **code** | **string** | The code of the resource record. |  |
| **resourceId** | **string** | The resource identifier of the resource record. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the resource record. Defaults to return the latest version if not specified. | [optional]  |

### Return type

[**ResourceRecord**](ResourceRecord.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested resource record. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listresourcerecordcodes"></a>
# **ListResourceRecordCodes**
> ResourceListOfString ListResourceRecordCodes (string scope, DateTimeOffset? asAt = null, string? sortOrder = null)

[EARLY ACCESS] ListResourceRecordCodes: List Resource Records Codes for Scope

List all resource records matching particular criteria.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ResourceRecordApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ResourceRecordApi>();
            var scope = "scope_example";  // string | The scope of the resource record.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the resource record. Defaults to return the latest version if not specified. (optional) 
            var sortOrder = "sortOrder_example";  // string? | Order of the sort - either \"ASC\" or \"DESC\" (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfString result = apiInstance.ListResourceRecordCodes(scope, asAt, sortOrder, opts: opts);

                // [EARLY ACCESS] ListResourceRecordCodes: List Resource Records Codes for Scope
                ResourceListOfString result = apiInstance.ListResourceRecordCodes(scope, asAt, sortOrder);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ResourceRecordApi.ListResourceRecordCodes: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListResourceRecordCodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListResourceRecordCodes: List Resource Records Codes for Scope
    ApiResponse<ResourceListOfString> response = apiInstance.ListResourceRecordCodesWithHttpInfo(scope, asAt, sortOrder);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ResourceRecordApi.ListResourceRecordCodesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the resource record. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the resource record. Defaults to return the latest version if not specified. | [optional]  |
| **sortOrder** | **string?** | Order of the sort - either \&quot;ASC\&quot; or \&quot;DESC\&quot; | [optional]  |

### Return type

[**ResourceListOfString**](ResourceListOfString.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of resource record codes. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listresourcerecordscopes"></a>
# **ListResourceRecordScopes**
> ResourceListOfScopeDefinition ListResourceRecordScopes (DateTimeOffset? asAt = null, string? page = null, int? limit = null)

[EARLY ACCESS] ListResourceRecordScopes: List Resource Record Scopes

List all resource records matching particular criteria.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ResourceRecordApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ResourceRecordApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the resource record. Defaults to return the latest version if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing resource records from a previous call. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfScopeDefinition result = apiInstance.ListResourceRecordScopes(asAt, page, limit, opts: opts);

                // [EARLY ACCESS] ListResourceRecordScopes: List Resource Record Scopes
                ResourceListOfScopeDefinition result = apiInstance.ListResourceRecordScopes(asAt, page, limit);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ResourceRecordApi.ListResourceRecordScopes: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListResourceRecordScopesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListResourceRecordScopes: List Resource Record Scopes
    ApiResponse<ResourceListOfScopeDefinition> response = apiInstance.ListResourceRecordScopesWithHttpInfo(asAt, page, limit);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ResourceRecordApi.ListResourceRecordScopesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the resource record. Defaults to return the latest version if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing resource records from a previous call. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |

### Return type

[**ResourceListOfScopeDefinition**](ResourceListOfScopeDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of resource records. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listresourcerecords"></a>
# **ListResourceRecords**
> PagedResourceListOfResourceRecord ListResourceRecords (string scope, string code, DateTimeOffset? asAt = null, string? page = null, List<string>? sortBy = null, int? limit = null, string? filter = null)

[EARLY ACCESS] ListResourceRecords: List Resource Records

List all resource records matching particular criteria.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ResourceRecordApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ResourceRecordApi>();
            var scope = "scope_example";  // string | The scope of the resource record.
            var code = "code_example";  // string | The code of the resource record.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the resource record. Defaults to return the latest version if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing resource records from a previous call. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfResourceRecord result = apiInstance.ListResourceRecords(scope, code, asAt, page, sortBy, limit, filter, opts: opts);

                // [EARLY ACCESS] ListResourceRecords: List Resource Records
                PagedResourceListOfResourceRecord result = apiInstance.ListResourceRecords(scope, code, asAt, page, sortBy, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ResourceRecordApi.ListResourceRecords: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListResourceRecordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListResourceRecords: List Resource Records
    ApiResponse<PagedResourceListOfResourceRecord> response = apiInstance.ListResourceRecordsWithHttpInfo(scope, code, asAt, page, sortBy, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ResourceRecordApi.ListResourceRecordsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the resource record. |  |
| **code** | **string** | The code of the resource record. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the resource record. Defaults to return the latest version if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing resource records from a previous call. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. | [optional]  |

### Return type

[**PagedResourceListOfResourceRecord**](PagedResourceListOfResourceRecord.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of resource records. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertresourcerecord"></a>
# **UpsertResourceRecord**
> ResourceRecord UpsertResourceRecord (UpsertResourceRecordRequest upsertResourceRecordRequest)

[EARLY ACCESS] UpsertResourceRecord: Upsert a Resource Record

Create or update a resource record.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ResourceRecordApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ResourceRecordApi>();
            var upsertResourceRecordRequest = new UpsertResourceRecordRequest(); // UpsertResourceRecordRequest | The resource record to upsert.

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceRecord result = apiInstance.UpsertResourceRecord(upsertResourceRecordRequest, opts: opts);

                // [EARLY ACCESS] UpsertResourceRecord: Upsert a Resource Record
                ResourceRecord result = apiInstance.UpsertResourceRecord(upsertResourceRecordRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ResourceRecordApi.UpsertResourceRecord: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertResourceRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpsertResourceRecord: Upsert a Resource Record
    ApiResponse<ResourceRecord> response = apiInstance.UpsertResourceRecordWithHttpInfo(upsertResourceRecordRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ResourceRecordApi.UpsertResourceRecordWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **upsertResourceRecordRequest** | [**UpsertResourceRecordRequest**](UpsertResourceRecordRequest.md) | The resource record to upsert. |  |

### Return type

[**ResourceRecord**](ResourceRecord.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The upserted resource record. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

