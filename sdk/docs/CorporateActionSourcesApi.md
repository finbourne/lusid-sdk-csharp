# Lusid.Sdk.Api.CorporateActionSourcesApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BatchUpsertCorporateActions**](CorporateActionSourcesApi.md#batchupsertcorporateactions) | **POST** /api/corporateactionsources/{scope}/{code}/corporateactions | [EARLY ACCESS] BatchUpsertCorporateActions: Batch upsert corporate actions (instrument transition events) to corporate action source. |
| [**CreateCorporateActionSource**](CorporateActionSourcesApi.md#createcorporateactionsource) | **POST** /api/corporateactionsources | [EARLY ACCESS] CreateCorporateActionSource: Create corporate action source |
| [**DeleteCorporateActionSource**](CorporateActionSourcesApi.md#deletecorporateactionsource) | **DELETE** /api/corporateactionsources/{scope}/{code} | [EARLY ACCESS] DeleteCorporateActionSource: Delete a corporate action source |
| [**DeleteCorporateActions**](CorporateActionSourcesApi.md#deletecorporateactions) | **DELETE** /api/corporateactionsources/{scope}/{code}/corporateactions | [EARLY ACCESS] DeleteCorporateActions: Delete corporate actions (instrument transition events) from a corporate action source |
| [**DeleteInstrumentEvents**](CorporateActionSourcesApi.md#deleteinstrumentevents) | **DELETE** /api/corporateactionsources/{scope}/{code}/instrumentevents | [EARLY ACCESS] DeleteInstrumentEvents: Delete instrument events from a corporate action source |
| [**GetCorporateActions**](CorporateActionSourcesApi.md#getcorporateactions) | **GET** /api/corporateactionsources/{scope}/{code}/corporateactions | [EARLY ACCESS] GetCorporateActions: List corporate actions (instrument transition events) from the corporate action source. |
| [**GetInstrumentEvents**](CorporateActionSourcesApi.md#getinstrumentevents) | **GET** /api/corporateactionsources/{scope}/{code}/instrumentevents | [EARLY ACCESS] GetInstrumentEvents: Get extrinsic instrument events out of a given corporate actions source. |
| [**ListCorporateActionSources**](CorporateActionSourcesApi.md#listcorporateactionsources) | **GET** /api/corporateactionsources | [EARLY ACCESS] ListCorporateActionSources: List corporate action sources |
| [**UpsertInstrumentEvents**](CorporateActionSourcesApi.md#upsertinstrumentevents) | **POST** /api/corporateactionsources/{scope}/{code}/instrumentevents | [EARLY ACCESS] UpsertInstrumentEvents: Upsert instrument events to the provided corporate actions source. |

<a id="batchupsertcorporateactions"></a>
# **BatchUpsertCorporateActions**
> UpsertCorporateActionsResponse BatchUpsertCorporateActions (string scope, string code, List<UpsertCorporateActionRequest>? upsertCorporateActionRequest = null)

[EARLY ACCESS] BatchUpsertCorporateActions: Batch upsert corporate actions (instrument transition events) to corporate action source.

Create or update one or more corporate actions in a particular corporate action source. Failures are identified in the body of the response.                If a corporate action is upserted at exactly the same effective datetime as a transaction for the same instrument, the corporate action takes precedence. Depending on the nature of the corporate action, this may mean it affects the transaction.                The maximum number of corporate actions that this method can upsert per request is 10,000.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CorporateActionSourcesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CorporateActionSourcesApi>();
            var scope = "scope_example";  // string | The scope of corporate action source
            var code = "code_example";  // string | The code of the corporate action source
            var upsertCorporateActionRequest = new List<UpsertCorporateActionRequest>?(); // List<UpsertCorporateActionRequest>? | The corporate action definitions (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertCorporateActionsResponse result = apiInstance.BatchUpsertCorporateActions(scope, code, upsertCorporateActionRequest, opts: opts);

                // [EARLY ACCESS] BatchUpsertCorporateActions: Batch upsert corporate actions (instrument transition events) to corporate action source.
                UpsertCorporateActionsResponse result = apiInstance.BatchUpsertCorporateActions(scope, code, upsertCorporateActionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CorporateActionSourcesApi.BatchUpsertCorporateActions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchUpsertCorporateActionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] BatchUpsertCorporateActions: Batch upsert corporate actions (instrument transition events) to corporate action source.
    ApiResponse<UpsertCorporateActionsResponse> response = apiInstance.BatchUpsertCorporateActionsWithHttpInfo(scope, code, upsertCorporateActionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CorporateActionSourcesApi.BatchUpsertCorporateActionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of corporate action source |  |
| **code** | **string** | The code of the corporate action source |  |
| **upsertCorporateActionRequest** | [**List&lt;UpsertCorporateActionRequest&gt;?**](UpsertCorporateActionRequest.md) | The corporate action definitions | [optional]  |

### Return type

[**UpsertCorporateActionsResponse**](UpsertCorporateActionsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created corporate actions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createcorporateactionsource"></a>
# **CreateCorporateActionSource**
> CorporateActionSource CreateCorporateActionSource (CreateCorporateActionSourceRequest createCorporateActionSourceRequest)

[EARLY ACCESS] CreateCorporateActionSource: Create corporate action source

Create a corporate action source.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CorporateActionSourcesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CorporateActionSourcesApi>();
            var createCorporateActionSourceRequest = new CreateCorporateActionSourceRequest(); // CreateCorporateActionSourceRequest | The corporate action source definition

            try
            {
                // uncomment the below to set overrides at the request level
                // CorporateActionSource result = apiInstance.CreateCorporateActionSource(createCorporateActionSourceRequest, opts: opts);

                // [EARLY ACCESS] CreateCorporateActionSource: Create corporate action source
                CorporateActionSource result = apiInstance.CreateCorporateActionSource(createCorporateActionSourceRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CorporateActionSourcesApi.CreateCorporateActionSource: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCorporateActionSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateCorporateActionSource: Create corporate action source
    ApiResponse<CorporateActionSource> response = apiInstance.CreateCorporateActionSourceWithHttpInfo(createCorporateActionSourceRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CorporateActionSourcesApi.CreateCorporateActionSourceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createCorporateActionSourceRequest** | [**CreateCorporateActionSourceRequest**](CreateCorporateActionSourceRequest.md) | The corporate action source definition |  |

### Return type

[**CorporateActionSource**](CorporateActionSource.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created corporate action source |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletecorporateactionsource"></a>
# **DeleteCorporateActionSource**
> DeletedEntityResponse DeleteCorporateActionSource (string scope, string code)

[EARLY ACCESS] DeleteCorporateActionSource: Delete a corporate action source

Deletes a single corporate action source

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CorporateActionSourcesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CorporateActionSourcesApi>();
            var scope = "scope_example";  // string | The scope of the corporate action source to be deleted
            var code = "code_example";  // string | The code of the corporate action source to be deleted

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteCorporateActionSource(scope, code, opts: opts);

                // [EARLY ACCESS] DeleteCorporateActionSource: Delete a corporate action source
                DeletedEntityResponse result = apiInstance.DeleteCorporateActionSource(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CorporateActionSourcesApi.DeleteCorporateActionSource: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCorporateActionSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteCorporateActionSource: Delete a corporate action source
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteCorporateActionSourceWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CorporateActionSourcesApi.DeleteCorporateActionSourceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the corporate action source to be deleted |  |
| **code** | **string** | The code of the corporate action source to be deleted |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Corporate Action Source Deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletecorporateactions"></a>
# **DeleteCorporateActions**
> DeletedEntityResponse DeleteCorporateActions (string scope, string code, List<string> corporateActionIds)

[EARLY ACCESS] DeleteCorporateActions: Delete corporate actions (instrument transition events) from a corporate action source

Delete one or more corporate actions from a particular corporate action source.                The maximum number of corporate actions that this method can delete per request is 1,000.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CorporateActionSourcesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CorporateActionSourcesApi>();
            var scope = "scope_example";  // string | The scope of the corporate action source
            var code = "code_example";  // string | The code of the corporate action source
            var corporateActionIds = new List<string>(); // List<string> | The IDs of the corporate actions to delete

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteCorporateActions(scope, code, corporateActionIds, opts: opts);

                // [EARLY ACCESS] DeleteCorporateActions: Delete corporate actions (instrument transition events) from a corporate action source
                DeletedEntityResponse result = apiInstance.DeleteCorporateActions(scope, code, corporateActionIds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CorporateActionSourcesApi.DeleteCorporateActions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCorporateActionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteCorporateActions: Delete corporate actions (instrument transition events) from a corporate action source
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteCorporateActionsWithHttpInfo(scope, code, corporateActionIds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CorporateActionSourcesApi.DeleteCorporateActionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the corporate action source |  |
| **code** | **string** | The code of the corporate action source |  |
| **corporateActionIds** | [**List&lt;string&gt;**](string.md) | The IDs of the corporate actions to delete |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Corporate Actions Deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteinstrumentevents"></a>
# **DeleteInstrumentEvents**
> DeletedEntityResponse DeleteInstrumentEvents (string scope, string code, List<string> instrumentEventIds)

[EARLY ACCESS] DeleteInstrumentEvents: Delete instrument events from a corporate action source

Delete one or more corporate actions from a particular corporate action source.                The maximum number of instrument events that this method can delete per request is 1,000.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CorporateActionSourcesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CorporateActionSourcesApi>();
            var scope = "scope_example";  // string | The scope of the corporate action source
            var code = "code_example";  // string | The code of the corporate action source
            var instrumentEventIds = new List<string>(); // List<string> | The IDs of the instrument events to delete

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteInstrumentEvents(scope, code, instrumentEventIds, opts: opts);

                // [EARLY ACCESS] DeleteInstrumentEvents: Delete instrument events from a corporate action source
                DeletedEntityResponse result = apiInstance.DeleteInstrumentEvents(scope, code, instrumentEventIds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CorporateActionSourcesApi.DeleteInstrumentEvents: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInstrumentEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteInstrumentEvents: Delete instrument events from a corporate action source
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteInstrumentEventsWithHttpInfo(scope, code, instrumentEventIds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CorporateActionSourcesApi.DeleteInstrumentEventsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the corporate action source |  |
| **code** | **string** | The code of the corporate action source |  |
| **instrumentEventIds** | [**List&lt;string&gt;**](string.md) | The IDs of the instrument events to delete |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Instrument Events Deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getcorporateactions"></a>
# **GetCorporateActions**
> ResourceListOfCorporateAction GetCorporateActions (string scope, string code, DateTimeOrCutLabel? fromEffectiveAt = null, DateTimeOrCutLabel? toEffectiveAt = null, DateTimeOffset? asAt = null, List<string>? sortBy = null, int? limit = null, string? filter = null)

[EARLY ACCESS] GetCorporateActions: List corporate actions (instrument transition events) from the corporate action source.

Get corporate actions from a particular corporate action source.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CorporateActionSourcesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CorporateActionSourcesApi>();
            var scope = "scope_example";  // string | The scope of the corporate action source.
            var code = "code_example";  // string | The code of the corporate action source.
            var fromEffectiveAt = "fromEffectiveAt_example";  // DateTimeOrCutLabel? | Optional. The start effective date of the data range. (optional) 
            var toEffectiveAt = "toEffectiveAt_example";  // DateTimeOrCutLabel? | Optional. The end effective date of the data range. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The AsAt date of the data. (optional) 
            var sortBy = new List<string>?(); // List<string>? | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the results to this number. (optional) 
            var filter = "filter_example";  // string? | Optional. Expression to filter the result set.              For example, to filter on the Announcement Date, use \"announcementDate eq '2020-03-06'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfCorporateAction result = apiInstance.GetCorporateActions(scope, code, fromEffectiveAt, toEffectiveAt, asAt, sortBy, limit, filter, opts: opts);

                // [EARLY ACCESS] GetCorporateActions: List corporate actions (instrument transition events) from the corporate action source.
                ResourceListOfCorporateAction result = apiInstance.GetCorporateActions(scope, code, fromEffectiveAt, toEffectiveAt, asAt, sortBy, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CorporateActionSourcesApi.GetCorporateActions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCorporateActionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetCorporateActions: List corporate actions (instrument transition events) from the corporate action source.
    ApiResponse<ResourceListOfCorporateAction> response = apiInstance.GetCorporateActionsWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, asAt, sortBy, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CorporateActionSourcesApi.GetCorporateActionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the corporate action source. |  |
| **code** | **string** | The code of the corporate action source. |  |
| **fromEffectiveAt** | **DateTimeOrCutLabel?** | Optional. The start effective date of the data range. | [optional]  |
| **toEffectiveAt** | **DateTimeOrCutLabel?** | Optional. The end effective date of the data range. | [optional]  |
| **asAt** | **DateTimeOffset?** | Optional. The AsAt date of the data. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional]  |
| **limit** | **int?** | Optional. When paginating, limit the results to this number. | [optional]  |
| **filter** | **string?** | Optional. Expression to filter the result set.              For example, to filter on the Announcement Date, use \&quot;announcementDate eq &#39;2020-03-06&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**ResourceListOfCorporateAction**](ResourceListOfCorporateAction.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Corporate Actions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getinstrumentevents"></a>
# **GetInstrumentEvents**
> PagedResourceListOfInstrumentEventHolder GetInstrumentEvents (string scope, string code, DateTimeOffset? asAt = null, int? limit = null, string? page = null, string? filter = null, string? timelineScope = null, string? timelineCode = null, string? closedPeriodId = null)

[EARLY ACCESS] GetInstrumentEvents: Get extrinsic instrument events out of a given corporate actions source.

Retrieves extrinsic corporate actions out of a corporate actions source

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CorporateActionSourcesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CorporateActionSourcesApi>();
            var scope = "scope_example";  // string | The scope of the corporate action source.
            var code = "code_example";  // string | The code of the corporate action source.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The AsAt date of the data. (optional) 
            var limit = 1000;  // int? | Optional. When paginating, limit the number of returned results to this many. If not specified, a default  of 1000 is used. (optional)  (default to 1000)
            var page = "page_example";  // string? | Optional. The pagination token to use to continue listing items from a previous call. Page values are  return from list calls, and must be supplied exactly as returned. Additionally, when specifying this  value, asAt, filter and limit must not  be modified. (optional) 
            var filter = "filter_example";  // string? | Optional. Expression to filter the result set. (optional) 
            var timelineScope = "timelineScope_example";  // string? | The scope of the Timeline, used to override the AsAt, and fetch post close activity data.              If this is provided, timelineCode and closedPeriodId must also be provided. (optional) 
            var timelineCode = "timelineCode_example";  // string? | The code of the Timeline, used to override the AsAt, and fetch post close activity data.              If this is provided, timelineScope and closedPeriodId must also be provided. (optional) 
            var closedPeriodId = "closedPeriodId_example";  // string? | The code of the ClosedPeriod attached to the timeline, used to override the AsAt, and fetch post close activity data.              If this is provided, timelineScope and timelineCode must also be provided. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfInstrumentEventHolder result = apiInstance.GetInstrumentEvents(scope, code, asAt, limit, page, filter, timelineScope, timelineCode, closedPeriodId, opts: opts);

                // [EARLY ACCESS] GetInstrumentEvents: Get extrinsic instrument events out of a given corporate actions source.
                PagedResourceListOfInstrumentEventHolder result = apiInstance.GetInstrumentEvents(scope, code, asAt, limit, page, filter, timelineScope, timelineCode, closedPeriodId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CorporateActionSourcesApi.GetInstrumentEvents: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInstrumentEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetInstrumentEvents: Get extrinsic instrument events out of a given corporate actions source.
    ApiResponse<PagedResourceListOfInstrumentEventHolder> response = apiInstance.GetInstrumentEventsWithHttpInfo(scope, code, asAt, limit, page, filter, timelineScope, timelineCode, closedPeriodId);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CorporateActionSourcesApi.GetInstrumentEventsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the corporate action source. |  |
| **code** | **string** | The code of the corporate action source. |  |
| **asAt** | **DateTimeOffset?** | Optional. The AsAt date of the data. | [optional]  |
| **limit** | **int?** | Optional. When paginating, limit the number of returned results to this many. If not specified, a default  of 1000 is used. | [optional] [default to 1000] |
| **page** | **string?** | Optional. The pagination token to use to continue listing items from a previous call. Page values are  return from list calls, and must be supplied exactly as returned. Additionally, when specifying this  value, asAt, filter and limit must not  be modified. | [optional]  |
| **filter** | **string?** | Optional. Expression to filter the result set. | [optional]  |
| **timelineScope** | **string?** | The scope of the Timeline, used to override the AsAt, and fetch post close activity data.              If this is provided, timelineCode and closedPeriodId must also be provided. | [optional]  |
| **timelineCode** | **string?** | The code of the Timeline, used to override the AsAt, and fetch post close activity data.              If this is provided, timelineScope and closedPeriodId must also be provided. | [optional]  |
| **closedPeriodId** | **string?** | The code of the ClosedPeriod attached to the timeline, used to override the AsAt, and fetch post close activity data.              If this is provided, timelineScope and timelineCode must also be provided. | [optional]  |

### Return type

[**PagedResourceListOfInstrumentEventHolder**](PagedResourceListOfInstrumentEventHolder.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Instrument Events |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listcorporateactionsources"></a>
# **ListCorporateActionSources**
> PagedResourceListOfCorporateActionSource ListCorporateActionSources (DateTimeOffset? asAt = null, List<string>? sortBy = null, int? limit = null, string? filter = null, string? page = null)

[EARLY ACCESS] ListCorporateActionSources: List corporate action sources

Gets a list of all corporate action sources

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CorporateActionSourcesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CorporateActionSourcesApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var sortBy = new List<string>?(); // List<string>? | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var limit = 100;  // int? | Optional. When paginating, limit the number of returned results to this many. If not specified, a default  of 100 is used. (optional)  (default to 100)
            var filter = "filter_example";  // string? | Optional. Expression to filter the result set. For example, to  filter on the Display Name, use \"displayName eq 'string'\"  Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var page = "page_example";  // string? | Optional. The pagination token to use to continue listing items from a previous call. Page values are  return from list calls, and must be supplied exactly as returned. Additionally, when specifying this  value, the filter, asAt, and limit must not  be modified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfCorporateActionSource result = apiInstance.ListCorporateActionSources(asAt, sortBy, limit, filter, page, opts: opts);

                // [EARLY ACCESS] ListCorporateActionSources: List corporate action sources
                PagedResourceListOfCorporateActionSource result = apiInstance.ListCorporateActionSources(asAt, sortBy, limit, filter, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CorporateActionSourcesApi.ListCorporateActionSources: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCorporateActionSourcesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListCorporateActionSources: List corporate action sources
    ApiResponse<PagedResourceListOfCorporateActionSource> response = apiInstance.ListCorporateActionSourcesWithHttpInfo(asAt, sortBy, limit, filter, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CorporateActionSourcesApi.ListCorporateActionSourcesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | Optional. The AsAt date of the data | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional]  |
| **limit** | **int?** | Optional. When paginating, limit the number of returned results to this many. If not specified, a default  of 100 is used. | [optional] [default to 100] |
| **filter** | **string?** | Optional. Expression to filter the result set. For example, to  filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;  Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **page** | **string?** | Optional. The pagination token to use to continue listing items from a previous call. Page values are  return from list calls, and must be supplied exactly as returned. Additionally, when specifying this  value, the filter, asAt, and limit must not  be modified. | [optional]  |

### Return type

[**PagedResourceListOfCorporateActionSource**](PagedResourceListOfCorporateActionSource.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All Existing Corporate Action Sources |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertinstrumentevents"></a>
# **UpsertInstrumentEvents**
> UpsertInstrumentEventsResponse UpsertInstrumentEvents (string scope, string code, List<UpsertInstrumentEventRequest>? upsertInstrumentEventRequest = null)

[EARLY ACCESS] UpsertInstrumentEvents: Upsert instrument events to the provided corporate actions source.

Batch upsert instrument events to corporate action sources.                The maximum number of instrument events that this method can upsert per request is 10,000.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CorporateActionSourcesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CorporateActionSourcesApi>();
            var scope = "scope_example";  // string | The scope of the corporate action source.
            var code = "code_example";  // string | The code of the corporate action source.
            var upsertInstrumentEventRequest = new List<UpsertInstrumentEventRequest>?(); // List<UpsertInstrumentEventRequest>? | The instrument event definitions. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertInstrumentEventsResponse result = apiInstance.UpsertInstrumentEvents(scope, code, upsertInstrumentEventRequest, opts: opts);

                // [EARLY ACCESS] UpsertInstrumentEvents: Upsert instrument events to the provided corporate actions source.
                UpsertInstrumentEventsResponse result = apiInstance.UpsertInstrumentEvents(scope, code, upsertInstrumentEventRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CorporateActionSourcesApi.UpsertInstrumentEvents: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertInstrumentEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpsertInstrumentEvents: Upsert instrument events to the provided corporate actions source.
    ApiResponse<UpsertInstrumentEventsResponse> response = apiInstance.UpsertInstrumentEventsWithHttpInfo(scope, code, upsertInstrumentEventRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CorporateActionSourcesApi.UpsertInstrumentEventsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the corporate action source. |  |
| **code** | **string** | The code of the corporate action source. |  |
| **upsertInstrumentEventRequest** | [**List&lt;UpsertInstrumentEventRequest&gt;?**](UpsertInstrumentEventRequest.md) | The instrument event definitions. | [optional]  |

### Return type

[**UpsertInstrumentEventsResponse**](UpsertInstrumentEventsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Instrument Events Upserted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

