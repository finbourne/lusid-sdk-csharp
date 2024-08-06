# Lusid.Sdk.Api.AborApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddDiaryEntry**](AborApi.md#adddiaryentry) | **POST** /api/abor/{scope}/{code}/accountingdiary/{diaryEntryCode} | [EXPERIMENTAL] AddDiaryEntry: Add a diary entry to the specified Abor. |
| [**ClosePeriod**](AborApi.md#closeperiod) | **POST** /api/abor/{scope}/{code}/accountingdiary/$closeperiod | [EXPERIMENTAL] ClosePeriod: Closes or locks the current period for the given Abor. |
| [**CreateAbor**](AborApi.md#createabor) | **POST** /api/abor/{scope} | [EXPERIMENTAL] CreateAbor: Create an Abor. |
| [**DeleteAbor**](AborApi.md#deleteabor) | **DELETE** /api/abor/{scope}/{code} | [EXPERIMENTAL] DeleteAbor: Delete an Abor. |
| [**GetAbor**](AborApi.md#getabor) | **GET** /api/abor/{scope}/{code} | [EXPERIMENTAL] GetAbor: Get Abor. |
| [**GetJournalEntryLines**](AborApi.md#getjournalentrylines) | **POST** /api/abor/{scope}/{code}/journalentrylines/$query | [EXPERIMENTAL] GetJournalEntryLines: Get the Journal Entry lines for the given Abor. |
| [**GetTrialBalance**](AborApi.md#gettrialbalance) | **POST** /api/abor/{scope}/{code}/trialbalance/$query | [EXPERIMENTAL] GetTrialBalance: Get the Trial balance for the given Abor. |
| [**ListAbors**](AborApi.md#listabors) | **GET** /api/abor | [EXPERIMENTAL] ListAbors: List Abors. |
| [**ListDiaryEntries**](AborApi.md#listdiaryentries) | **GET** /api/abor/{scope}/{code}/accountingdiary | [EXPERIMENTAL] ListDiaryEntries: List diary entries. |
| [**LockPeriod**](AborApi.md#lockperiod) | **POST** /api/abor/{scope}/{code}/accountingdiary/$lockperiod | [EXPERIMENTAL] LockPeriod: Locks the last Closed or given Closed Period. |
| [**PatchAbor**](AborApi.md#patchabor) | **PATCH** /api/abor/{scope}/{code} | [EXPERIMENTAL] PatchAbor: Patch Abor. |
| [**ReOpenPeriods**](AborApi.md#reopenperiods) | **POST** /api/abor/{scope}/{code}/accountingdiary/$reopenperiods | [EXPERIMENTAL] ReOpenPeriods: Reopen periods from a seed Diary Entry Code or when not specified, the last Closed Period for the given Abor. |
| [**UpsertAborProperties**](AborApi.md#upsertaborproperties) | **POST** /api/abor/{scope}/{code}/properties/$upsert | [EXPERIMENTAL] UpsertAborProperties: Upsert Abor properties |

<a id="adddiaryentry"></a>
# **AddDiaryEntry**
> DiaryEntry AddDiaryEntry (string scope, string code, string diaryEntryCode, DiaryEntryRequest diaryEntryRequest)

[EXPERIMENTAL] AddDiaryEntry: Add a diary entry to the specified Abor.

Adds a new diary entry to the specified Abor

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AborApi>();
            var scope = "scope_example";  // string | The scope of the Abor.
            var code = "code_example";  // string | The code of the Abor.
            var diaryEntryCode = "diaryEntryCode_example";  // string | Diary entry code
            var diaryEntryRequest = new DiaryEntryRequest(); // DiaryEntryRequest | The diary entry to add.

            try
            {
                // [EXPERIMENTAL] AddDiaryEntry: Add a diary entry to the specified Abor.
                DiaryEntry result = apiInstance.AddDiaryEntry(scope, code, diaryEntryCode, diaryEntryRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AborApi.AddDiaryEntry: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddDiaryEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] AddDiaryEntry: Add a diary entry to the specified Abor.
    ApiResponse<DiaryEntry> response = apiInstance.AddDiaryEntryWithHttpInfo(scope, code, diaryEntryCode, diaryEntryRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AborApi.AddDiaryEntryWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Abor. |  |
| **code** | **string** | The code of the Abor. |  |
| **diaryEntryCode** | **string** | Diary entry code |  |
| **diaryEntryRequest** | [**DiaryEntryRequest**](DiaryEntryRequest.md) | The diary entry to add. |  |

### Return type

[**DiaryEntry**](DiaryEntry.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly added diary entry. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="closeperiod"></a>
# **ClosePeriod**
> DiaryEntry ClosePeriod (string scope, string code, ClosePeriodDiaryEntryRequest closePeriodDiaryEntryRequest)

[EXPERIMENTAL] ClosePeriod: Closes or locks the current period for the given Abor.

Closes or Locks the current open period for the given Abor.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AborApi>();
            var scope = "scope_example";  // string | The scope of the Abor.
            var code = "code_example";  // string | The code of the Abor.
            var closePeriodDiaryEntryRequest = new ClosePeriodDiaryEntryRequest(); // ClosePeriodDiaryEntryRequest | The request body, containing details to apply to the closing/locking period.

            try
            {
                // [EXPERIMENTAL] ClosePeriod: Closes or locks the current period for the given Abor.
                DiaryEntry result = apiInstance.ClosePeriod(scope, code, closePeriodDiaryEntryRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AborApi.ClosePeriod: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClosePeriodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ClosePeriod: Closes or locks the current period for the given Abor.
    ApiResponse<DiaryEntry> response = apiInstance.ClosePeriodWithHttpInfo(scope, code, closePeriodDiaryEntryRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AborApi.ClosePeriodWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Abor. |  |
| **code** | **string** | The code of the Abor. |  |
| **closePeriodDiaryEntryRequest** | [**ClosePeriodDiaryEntryRequest**](ClosePeriodDiaryEntryRequest.md) | The request body, containing details to apply to the closing/locking period. |  |

### Return type

[**DiaryEntry**](DiaryEntry.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The DiaryEntry created as a result of the closing of the Period. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createabor"></a>
# **CreateAbor**
> Abor CreateAbor (string scope, AborRequest aborRequest)

[EXPERIMENTAL] CreateAbor: Create an Abor.

Create the given Abor.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AborApi>();
            var scope = "scope_example";  // string | The scope of the Abor.
            var aborRequest = new AborRequest(); // AborRequest | The definition of the Abor.

            try
            {
                // [EXPERIMENTAL] CreateAbor: Create an Abor.
                Abor result = apiInstance.CreateAbor(scope, aborRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AborApi.CreateAbor: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAborWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateAbor: Create an Abor.
    ApiResponse<Abor> response = apiInstance.CreateAborWithHttpInfo(scope, aborRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AborApi.CreateAborWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Abor. |  |
| **aborRequest** | [**AborRequest**](AborRequest.md) | The definition of the Abor. |  |

### Return type

[**Abor**](Abor.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created abor. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteabor"></a>
# **DeleteAbor**
> DeletedEntityResponse DeleteAbor (string scope, string code)

[EXPERIMENTAL] DeleteAbor: Delete an Abor.

Delete the given Abor.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AborApi>();
            var scope = "scope_example";  // string | The scope of the Abor to be deleted.
            var code = "code_example";  // string | The code of the Abor to be deleted. Together with the scope this uniquely identifies the Abor.

            try
            {
                // [EXPERIMENTAL] DeleteAbor: Delete an Abor.
                DeletedEntityResponse result = apiInstance.DeleteAbor(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AborApi.DeleteAbor: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAborWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteAbor: Delete an Abor.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteAborWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AborApi.DeleteAborWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Abor to be deleted. |  |
| **code** | **string** | The code of the Abor to be deleted. Together with the scope this uniquely identifies the Abor. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the Abor was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getabor"></a>
# **GetAbor**
> Abor GetAbor (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetAbor: Get Abor.

Retrieve the definition of a particular Abor.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AborApi>();
            var scope = "scope_example";  // string | The scope of the Abor.
            var code = "code_example";  // string | The code of the Abor. Together with the scope this uniquely identifies the Abor.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the Abor properties. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Abor definition. Defaults to returning the latest version of the Abor definition if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Abor' domain to decorate onto the Abor.              These must take the format {domain}/{scope}/{code}, for example 'Abor/Manager/Id'. If no properties are specified, then no properties will be returned. (optional) 

            try
            {
                // [EXPERIMENTAL] GetAbor: Get Abor.
                Abor result = apiInstance.GetAbor(scope, code, effectiveAt, asAt, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AborApi.GetAbor: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAborWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetAbor: Get Abor.
    ApiResponse<Abor> response = apiInstance.GetAborWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AborApi.GetAborWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Abor. |  |
| **code** | **string** | The code of the Abor. Together with the scope this uniquely identifies the Abor. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the Abor properties. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Abor definition. Defaults to returning the latest version of the Abor definition if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Abor&#39; domain to decorate onto the Abor.              These must take the format {domain}/{scope}/{code}, for example &#39;Abor/Manager/Id&#39;. If no properties are specified, then no properties will be returned. | [optional]  |

### Return type

[**Abor**](Abor.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Abor definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getjournalentrylines"></a>
# **GetJournalEntryLines**
> VersionedResourceListOfJournalEntryLine GetJournalEntryLines (string scope, string code, JournalEntryLinesQueryParameters journalEntryLinesQueryParameters, DateTimeOffset? asAt = null, string? filter = null, int? limit = null, string? page = null)

[EXPERIMENTAL] GetJournalEntryLines: Get the Journal Entry lines for the given Abor.

Gets the Journal Entry lines for the given Abor                The Journal Entry lines have been generated from transactions and translated via posting rules

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AborApi>();
            var scope = "scope_example";  // string | The scope of the Abor.
            var code = "code_example";  // string | The code of the Abor. Together with the scope is creating the unique identifier for the given Abor.
            var journalEntryLinesQueryParameters = new JournalEntryLinesQueryParameters(); // JournalEntryLinesQueryParameters | The query parameters used in running the generation of the Journal Entry lines.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve Journal Entry lines. Defaults to returning the latest version               of each transaction if not specified. (optional) 
            var filter = "filter_example";  // string? | \"Expression to filter the result set.\" (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Journal Entry lines from a previous call to GetJournalEntryLines. (optional) 

            try
            {
                // [EXPERIMENTAL] GetJournalEntryLines: Get the Journal Entry lines for the given Abor.
                VersionedResourceListOfJournalEntryLine result = apiInstance.GetJournalEntryLines(scope, code, journalEntryLinesQueryParameters, asAt, filter, limit, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AborApi.GetJournalEntryLines: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetJournalEntryLinesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetJournalEntryLines: Get the Journal Entry lines for the given Abor.
    ApiResponse<VersionedResourceListOfJournalEntryLine> response = apiInstance.GetJournalEntryLinesWithHttpInfo(scope, code, journalEntryLinesQueryParameters, asAt, filter, limit, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AborApi.GetJournalEntryLinesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Abor. |  |
| **code** | **string** | The code of the Abor. Together with the scope is creating the unique identifier for the given Abor. |  |
| **journalEntryLinesQueryParameters** | [**JournalEntryLinesQueryParameters**](JournalEntryLinesQueryParameters.md) | The query parameters used in running the generation of the Journal Entry lines. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve Journal Entry lines. Defaults to returning the latest version               of each transaction if not specified. | [optional]  |
| **filter** | **string?** | \&quot;Expression to filter the result set.\&quot; | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Journal Entry lines from a previous call to GetJournalEntryLines. | [optional]  |

### Return type

[**VersionedResourceListOfJournalEntryLine**](VersionedResourceListOfJournalEntryLine.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Journal Entry lines for the specified Abor. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="gettrialbalance"></a>
# **GetTrialBalance**
> VersionedResourceListOfTrialBalance GetTrialBalance (string scope, string code, TrialBalanceQueryParameters trialBalanceQueryParameters, DateTimeOffset? asAt = null, string? filter = null, int? limit = null, string? page = null)

[EXPERIMENTAL] GetTrialBalance: Get the Trial balance for the given Abor.

Gets the Trial balance for the given Abor    The Trial balance has been generated from transactions, translated via posting rules and aggregated based on a General Ledger Profile (where specified)

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AborApi>();
            var scope = "scope_example";  // string | The scope of the Abor.
            var code = "code_example";  // string | The code of the Abor. Together with the scope is the unique identifier for the given Abor.
            var trialBalanceQueryParameters = new TrialBalanceQueryParameters(); // TrialBalanceQueryParameters | The query parameters used in running the generation of the Trial Balance.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve trial balance. Defaults to returning the latest version              of each transaction if not specified. (optional) 
            var filter = "filter_example";  // string? | \"Expression to filter the result set.\" (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Trial balance from a previous call to Trial balance. (optional) 

            try
            {
                // [EXPERIMENTAL] GetTrialBalance: Get the Trial balance for the given Abor.
                VersionedResourceListOfTrialBalance result = apiInstance.GetTrialBalance(scope, code, trialBalanceQueryParameters, asAt, filter, limit, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AborApi.GetTrialBalance: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTrialBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetTrialBalance: Get the Trial balance for the given Abor.
    ApiResponse<VersionedResourceListOfTrialBalance> response = apiInstance.GetTrialBalanceWithHttpInfo(scope, code, trialBalanceQueryParameters, asAt, filter, limit, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AborApi.GetTrialBalanceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Abor. |  |
| **code** | **string** | The code of the Abor. Together with the scope is the unique identifier for the given Abor. |  |
| **trialBalanceQueryParameters** | [**TrialBalanceQueryParameters**](TrialBalanceQueryParameters.md) | The query parameters used in running the generation of the Trial Balance. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve trial balance. Defaults to returning the latest version              of each transaction if not specified. | [optional]  |
| **filter** | **string?** | \&quot;Expression to filter the result set.\&quot; | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Trial balance from a previous call to Trial balance. | [optional]  |

### Return type

[**VersionedResourceListOfTrialBalance**](VersionedResourceListOfTrialBalance.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Trial Balance for the specified Abor. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listabors"></a>
# **ListAbors**
> PagedResourceListOfAbor ListAbors (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListAbors: List Abors.

List all the Abors matching particular criteria.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AborApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the TimeVariant properties for the Abor. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Abor. Defaults to returning the latest version of each Abor if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Abor; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the Abor type, specify \"id.Code eq 'Abor1'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Abor' domain to decorate onto each Abor.              These must take the format {domain}/{scope}/{code}, for example 'Abor/Manager/Id'. (optional) 

            try
            {
                // [EXPERIMENTAL] ListAbors: List Abors.
                PagedResourceListOfAbor result = apiInstance.ListAbors(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AborApi.ListAbors: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAborsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListAbors: List Abors.
    ApiResponse<PagedResourceListOfAbor> response = apiInstance.ListAborsWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AborApi.ListAborsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the TimeVariant properties for the Abor. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Abor. Defaults to returning the latest version of each Abor if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Abor; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the Abor type, specify \&quot;id.Code eq &#39;Abor1&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Abor&#39; domain to decorate onto each Abor.              These must take the format {domain}/{scope}/{code}, for example &#39;Abor/Manager/Id&#39;. | [optional]  |

### Return type

[**PagedResourceListOfAbor**](PagedResourceListOfAbor.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested abors. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listdiaryentries"></a>
# **ListDiaryEntries**
> PagedResourceListOfDiaryEntry ListDiaryEntries (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListDiaryEntries: List diary entries.

List all the diary entries matching particular criteria.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AborApi>();
            var scope = "scope_example";  // string | The scope of the Abor.
            var code = "code_example";  // string | The code of the Abor.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the TimeVariant properties for the Diary Entries. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the DiaryEntry. Defaults to returning the latest version of each DiaryEntry if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing diary entries; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the DiaryEntry type, specify \"type eq 'PeriodBoundary'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'DiaryEntry' domain to decorate onto each DiaryEntry.              These must take the format {domain}/{scope}/{code}, for example 'DiaryEntry/Report/Id'. (optional) 

            try
            {
                // [EXPERIMENTAL] ListDiaryEntries: List diary entries.
                PagedResourceListOfDiaryEntry result = apiInstance.ListDiaryEntries(scope, code, effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AborApi.ListDiaryEntries: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDiaryEntriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListDiaryEntries: List diary entries.
    ApiResponse<PagedResourceListOfDiaryEntry> response = apiInstance.ListDiaryEntriesWithHttpInfo(scope, code, effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AborApi.ListDiaryEntriesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Abor. |  |
| **code** | **string** | The code of the Abor. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the TimeVariant properties for the Diary Entries. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the DiaryEntry. Defaults to returning the latest version of each DiaryEntry if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing diary entries; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the DiaryEntry type, specify \&quot;type eq &#39;PeriodBoundary&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;DiaryEntry&#39; domain to decorate onto each DiaryEntry.              These must take the format {domain}/{scope}/{code}, for example &#39;DiaryEntry/Report/Id&#39;. | [optional]  |

### Return type

[**PagedResourceListOfDiaryEntry**](PagedResourceListOfDiaryEntry.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested diary entries. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="lockperiod"></a>
# **LockPeriod**
> DiaryEntry LockPeriod (string scope, string code, LockPeriodDiaryEntryRequest? lockPeriodDiaryEntryRequest = null)

[EXPERIMENTAL] LockPeriod: Locks the last Closed or given Closed Period.

Locks the specified or last locked period for the given Abor.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AborApi>();
            var scope = "scope_example";  // string | The scope of the Abor.
            var code = "code_example";  // string | The code of the Abor.
            var lockPeriodDiaryEntryRequest = new LockPeriodDiaryEntryRequest?(); // LockPeriodDiaryEntryRequest? | The request body, detailing lock details (optional) 

            try
            {
                // [EXPERIMENTAL] LockPeriod: Locks the last Closed or given Closed Period.
                DiaryEntry result = apiInstance.LockPeriod(scope, code, lockPeriodDiaryEntryRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AborApi.LockPeriod: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the LockPeriodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] LockPeriod: Locks the last Closed or given Closed Period.
    ApiResponse<DiaryEntry> response = apiInstance.LockPeriodWithHttpInfo(scope, code, lockPeriodDiaryEntryRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AborApi.LockPeriodWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Abor. |  |
| **code** | **string** | The code of the Abor. |  |
| **lockPeriodDiaryEntryRequest** | [**LockPeriodDiaryEntryRequest?**](LockPeriodDiaryEntryRequest?.md) | The request body, detailing lock details | [optional]  |

### Return type

[**DiaryEntry**](DiaryEntry.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated DiaryEntry as a result of the locking of the Period. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="patchabor"></a>
# **PatchAbor**
> Abor PatchAbor (string scope, string code, List<Operation> operation)

[EXPERIMENTAL] PatchAbor: Patch Abor.

Create or update certain fields for a particular Abor.  The behaviour is defined by the JSON Patch specification.                Currently supported fields are: PortfolioIds.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AborApi>();
            var scope = "scope_example";  // string | The scope of the Abor.
            var code = "code_example";  // string | The code of the Abor. Together with the               scope this uniquely identifies the Abor.
            var operation = new List<Operation>(); // List<Operation> | The json patch document. For more information see: https://datatracker.ietf.org/doc/html/rfc6902.

            try
            {
                // [EXPERIMENTAL] PatchAbor: Patch Abor.
                Abor result = apiInstance.PatchAbor(scope, code, operation);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AborApi.PatchAbor: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchAborWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PatchAbor: Patch Abor.
    ApiResponse<Abor> response = apiInstance.PatchAborWithHttpInfo(scope, code, operation);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AborApi.PatchAborWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Abor. |  |
| **code** | **string** | The code of the Abor. Together with the               scope this uniquely identifies the Abor. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | The json patch document. For more information see: https://datatracker.ietf.org/doc/html/rfc6902. |  |

### Return type

[**Abor**](Abor.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The newly patched Abor |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="reopenperiods"></a>
# **ReOpenPeriods**
> PeriodDiaryEntriesReopenedResponse ReOpenPeriods (string scope, string code, ReOpenPeriodDiaryEntryRequest? reOpenPeriodDiaryEntryRequest = null)

[EXPERIMENTAL] ReOpenPeriods: Reopen periods from a seed Diary Entry Code or when not specified, the last Closed Period for the given Abor.

Reopens one or more periods.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AborApi>();
            var scope = "scope_example";  // string | The scope of the Abor to be deleted.
            var code = "code_example";  // string | The code of the Abor to be deleted. Together with the scope this uniquely identifies the Abor.
            var reOpenPeriodDiaryEntryRequest = new ReOpenPeriodDiaryEntryRequest?(); // ReOpenPeriodDiaryEntryRequest? | The request body, detailing re open details (optional) 

            try
            {
                // [EXPERIMENTAL] ReOpenPeriods: Reopen periods from a seed Diary Entry Code or when not specified, the last Closed Period for the given Abor.
                PeriodDiaryEntriesReopenedResponse result = apiInstance.ReOpenPeriods(scope, code, reOpenPeriodDiaryEntryRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AborApi.ReOpenPeriods: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReOpenPeriodsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ReOpenPeriods: Reopen periods from a seed Diary Entry Code or when not specified, the last Closed Period for the given Abor.
    ApiResponse<PeriodDiaryEntriesReopenedResponse> response = apiInstance.ReOpenPeriodsWithHttpInfo(scope, code, reOpenPeriodDiaryEntryRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AborApi.ReOpenPeriodsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Abor to be deleted. |  |
| **code** | **string** | The code of the Abor to be deleted. Together with the scope this uniquely identifies the Abor. |  |
| **reOpenPeriodDiaryEntryRequest** | [**ReOpenPeriodDiaryEntryRequest?**](ReOpenPeriodDiaryEntryRequest?.md) | The request body, detailing re open details | [optional]  |

### Return type

[**PeriodDiaryEntriesReopenedResponse**](PeriodDiaryEntriesReopenedResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the DiaryEntryCodes were deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertaborproperties"></a>
# **UpsertAborProperties**
> AborProperties UpsertAborProperties (string scope, string code, Dictionary<string, Property>? requestBody = null)

[EXPERIMENTAL] UpsertAborProperties: Upsert Abor properties

Update or insert one or more properties onto a single Abor. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain 'Abor'.                Upserting a property that exists for an Abor, with a null value, will delete the instance of the property for that group.                Properties have an <i>effectiveFrom</i> datetime for which the property is valid, and an <i>effectiveUntil</i>  datetime until which the property is valid. Not supplying an <i>effectiveUntil</i> datetime results in the property being  valid indefinitely, or until the next <i>effectiveFrom</i> datetime of the property.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AborApi>();
            var scope = "scope_example";  // string | The scope of the Abor to update or insert the properties onto.
            var code = "code_example";  // string | The code of the Abor to update or insert the properties onto. Together with the scope this uniquely identifies the Abor.
            var requestBody = new Dictionary<string, Property>?(); // Dictionary<string, Property>? | The properties to be updated or inserted onto the Abor. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \"Abor/Manager/Id\". (optional) 

            try
            {
                // [EXPERIMENTAL] UpsertAborProperties: Upsert Abor properties
                AborProperties result = apiInstance.UpsertAborProperties(scope, code, requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AborApi.UpsertAborProperties: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertAborPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertAborProperties: Upsert Abor properties
    ApiResponse<AborProperties> response = apiInstance.UpsertAborPropertiesWithHttpInfo(scope, code, requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AborApi.UpsertAborPropertiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Abor to update or insert the properties onto. |  |
| **code** | **string** | The code of the Abor to update or insert the properties onto. Together with the scope this uniquely identifies the Abor. |  |
| **requestBody** | [**Dictionary&lt;string, Property&gt;?**](Property.md) | The properties to be updated or inserted onto the Abor. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;Abor/Manager/Id\&quot;. | [optional]  |

### Return type

[**AborProperties**](AborProperties.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated or inserted properties |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

