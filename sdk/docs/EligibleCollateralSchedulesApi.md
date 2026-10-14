# Lusid.Sdk.Api.EligibleCollateralSchedulesApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateEligibleCollateralSchedule**](EligibleCollateralSchedulesApi.md#createeligiblecollateralschedule) | **POST** /api/eligiblecollateralschedules/{scope} | [EXPERIMENTAL] CreateEligibleCollateralSchedule: Create an Eligible Collateral Schedule. |
| [**DeleteEligibleCollateralSchedule**](EligibleCollateralSchedulesApi.md#deleteeligiblecollateralschedule) | **DELETE** /api/eligiblecollateralschedules/{scope}/{code} | [EXPERIMENTAL] DeleteEligibleCollateralSchedule: Delete an Eligible Collateral Schedule. |
| [**GetEligibleCollateralSchedule**](EligibleCollateralSchedulesApi.md#geteligiblecollateralschedule) | **GET** /api/eligiblecollateralschedules/{scope}/{code} | [EXPERIMENTAL] GetEligibleCollateralSchedule: Get an Eligible Collateral Schedule. |
| [**ListEligibleCollateralSchedules**](EligibleCollateralSchedulesApi.md#listeligiblecollateralschedules) | **GET** /api/eligiblecollateralschedules | [EXPERIMENTAL] ListEligibleCollateralSchedules: List Eligible Collateral Schedules. |
| [**UpsertEligibleCollateralSchedule**](EligibleCollateralSchedulesApi.md#upserteligiblecollateralschedule) | **PUT** /api/eligiblecollateralschedules/{scope}/{code} | [EXPERIMENTAL] UpsertEligibleCollateralSchedule: Upsert an Eligible Collateral Schedule. |

<a id="createeligiblecollateralschedule"></a>
# **CreateEligibleCollateralSchedule**
> EligibleCollateralSchedule CreateEligibleCollateralSchedule (string scope, EligibleCollateralScheduleRequest eligibleCollateralScheduleRequest)

[EXPERIMENTAL] CreateEligibleCollateralSchedule: Create an Eligible Collateral Schedule.

Create a new Eligible Collateral Schedule. The scope of the schedule is in the route and its code is in the request body.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<EligibleCollateralSchedulesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EligibleCollateralSchedulesApi>();
            var scope = "scope_example";  // string | The scope of the Eligible Collateral Schedule.
            var eligibleCollateralScheduleRequest = new EligibleCollateralScheduleRequest(); // EligibleCollateralScheduleRequest | The definition of the Eligible Collateral Schedule.

            try
            {
                // uncomment the below to set overrides at the request level
                // EligibleCollateralSchedule result = apiInstance.CreateEligibleCollateralSchedule(scope, eligibleCollateralScheduleRequest, opts: opts);

                // [EXPERIMENTAL] CreateEligibleCollateralSchedule: Create an Eligible Collateral Schedule.
                EligibleCollateralSchedule result = apiInstance.CreateEligibleCollateralSchedule(scope, eligibleCollateralScheduleRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EligibleCollateralSchedulesApi.CreateEligibleCollateralSchedule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEligibleCollateralScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateEligibleCollateralSchedule: Create an Eligible Collateral Schedule.
    ApiResponse<EligibleCollateralSchedule> response = apiInstance.CreateEligibleCollateralScheduleWithHttpInfo(scope, eligibleCollateralScheduleRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EligibleCollateralSchedulesApi.CreateEligibleCollateralScheduleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Eligible Collateral Schedule. |  |
| **eligibleCollateralScheduleRequest** | [**EligibleCollateralScheduleRequest**](EligibleCollateralScheduleRequest.md) | The definition of the Eligible Collateral Schedule. |  |

### Return type

[**EligibleCollateralSchedule**](EligibleCollateralSchedule.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created Eligible Collateral Schedule. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteeligiblecollateralschedule"></a>
# **DeleteEligibleCollateralSchedule**
> DeletedEntityResponse DeleteEligibleCollateralSchedule (string scope, string code, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] DeleteEligibleCollateralSchedule: Delete an Eligible Collateral Schedule.

Delete an Eligible Collateral Schedule from the given effective datetime. It remains retrievable at earlier effective datetimes.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<EligibleCollateralSchedulesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EligibleCollateralSchedulesApi>();
            var scope = "scope_example";  // string | The scope of the Eligible Collateral Schedule to be deleted.
            var code = "code_example";  // string | The code of the Eligible Collateral Schedule to be deleted. Together with the scope this uniquely identifies the Eligible Collateral Schedule.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label from which the Eligible Collateral Schedule is deleted. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteEligibleCollateralSchedule(scope, code, effectiveAt, opts: opts);

                // [EXPERIMENTAL] DeleteEligibleCollateralSchedule: Delete an Eligible Collateral Schedule.
                DeletedEntityResponse result = apiInstance.DeleteEligibleCollateralSchedule(scope, code, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EligibleCollateralSchedulesApi.DeleteEligibleCollateralSchedule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEligibleCollateralScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteEligibleCollateralSchedule: Delete an Eligible Collateral Schedule.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteEligibleCollateralScheduleWithHttpInfo(scope, code, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EligibleCollateralSchedulesApi.DeleteEligibleCollateralScheduleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Eligible Collateral Schedule to be deleted. |  |
| **code** | **string** | The code of the Eligible Collateral Schedule to be deleted. Together with the scope this uniquely identifies the Eligible Collateral Schedule. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label from which the Eligible Collateral Schedule is deleted. Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the Eligible Collateral Schedule was deleted. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="geteligiblecollateralschedule"></a>
# **GetEligibleCollateralSchedule**
> EligibleCollateralSchedule GetEligibleCollateralSchedule (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetEligibleCollateralSchedule: Get an Eligible Collateral Schedule.

Retrieve the definition of a particular Eligible Collateral Schedule at an effective and asAt datetime.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<EligibleCollateralSchedulesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EligibleCollateralSchedulesApi>();
            var scope = "scope_example";  // string | The scope of the Eligible Collateral Schedule.
            var code = "code_example";  // string | The code of the Eligible Collateral Schedule. Together with the scope this uniquely identifies the Eligible Collateral Schedule.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the Eligible Collateral Schedule. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Eligible Collateral Schedule. Defaults to returning the latest version if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'EligibleCollateralSchedule' domain to decorate onto the Eligible Collateral Schedule.              These must take the format {domain}/{scope}/{code}, for example 'EligibleCollateralSchedule/Manager/Id'. If no properties are specified, then no properties will be returned. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // EligibleCollateralSchedule result = apiInstance.GetEligibleCollateralSchedule(scope, code, effectiveAt, asAt, propertyKeys, opts: opts);

                // [EXPERIMENTAL] GetEligibleCollateralSchedule: Get an Eligible Collateral Schedule.
                EligibleCollateralSchedule result = apiInstance.GetEligibleCollateralSchedule(scope, code, effectiveAt, asAt, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EligibleCollateralSchedulesApi.GetEligibleCollateralSchedule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEligibleCollateralScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetEligibleCollateralSchedule: Get an Eligible Collateral Schedule.
    ApiResponse<EligibleCollateralSchedule> response = apiInstance.GetEligibleCollateralScheduleWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EligibleCollateralSchedulesApi.GetEligibleCollateralScheduleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Eligible Collateral Schedule. |  |
| **code** | **string** | The code of the Eligible Collateral Schedule. Together with the scope this uniquely identifies the Eligible Collateral Schedule. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the Eligible Collateral Schedule. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Eligible Collateral Schedule. Defaults to returning the latest version if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;EligibleCollateralSchedule&#39; domain to decorate onto the Eligible Collateral Schedule.              These must take the format {domain}/{scope}/{code}, for example &#39;EligibleCollateralSchedule/Manager/Id&#39;. If no properties are specified, then no properties will be returned. | [optional]  |

### Return type

[**EligibleCollateralSchedule**](EligibleCollateralSchedule.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Eligible Collateral Schedule. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listeligiblecollateralschedules"></a>
# **ListEligibleCollateralSchedules**
> PagedResourceListOfEligibleCollateralSchedule ListEligibleCollateralSchedules (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListEligibleCollateralSchedules: List Eligible Collateral Schedules.

List all the Eligible Collateral Schedules matching the given criteria.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<EligibleCollateralSchedulesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EligibleCollateralSchedulesApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the Eligible Collateral Schedules. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list Eligible Collateral Schedules. Defaults to returning the latest version of each Eligible Collateral Schedule if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Eligible Collateral Schedules; this value is returned from the previous call. If a pagination token is provided, the filter and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. The filterable fields are Id.Scope, Id.Code, Description, Properties and Version. The rows can be filtered with a single-condition any expression on Rows over Code, Description, Selector.Kind, Selector.Currency, Selector.InstrumentFilter, ValuationPercentage, FxHaircut, MinResidualMaturityYears or MaxResidualMaturityYears. For example, to filter on the schedule code, specify \"Id.Code eq 'UsdCashAndGovies'\", and to find schedules with a row for a given asset kind, specify \"Rows any (Selector.Kind eq 'Cash')\". For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'EligibleCollateralSchedule' domain to decorate onto each Eligible Collateral Schedule.              These must take the format {domain}/{scope}/{code}, for example 'EligibleCollateralSchedule/Manager/Id'. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfEligibleCollateralSchedule result = apiInstance.ListEligibleCollateralSchedules(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys, opts: opts);

                // [EXPERIMENTAL] ListEligibleCollateralSchedules: List Eligible Collateral Schedules.
                PagedResourceListOfEligibleCollateralSchedule result = apiInstance.ListEligibleCollateralSchedules(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EligibleCollateralSchedulesApi.ListEligibleCollateralSchedules: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListEligibleCollateralSchedulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListEligibleCollateralSchedules: List Eligible Collateral Schedules.
    ApiResponse<PagedResourceListOfEligibleCollateralSchedule> response = apiInstance.ListEligibleCollateralSchedulesWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EligibleCollateralSchedulesApi.ListEligibleCollateralSchedulesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the Eligible Collateral Schedules. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list Eligible Collateral Schedules. Defaults to returning the latest version of each Eligible Collateral Schedule if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Eligible Collateral Schedules; this value is returned from the previous call. If a pagination token is provided, the filter and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. The filterable fields are Id.Scope, Id.Code, Description, Properties and Version. The rows can be filtered with a single-condition any expression on Rows over Code, Description, Selector.Kind, Selector.Currency, Selector.InstrumentFilter, ValuationPercentage, FxHaircut, MinResidualMaturityYears or MaxResidualMaturityYears. For example, to filter on the schedule code, specify \&quot;Id.Code eq &#39;UsdCashAndGovies&#39;\&quot;, and to find schedules with a row for a given asset kind, specify \&quot;Rows any (Selector.Kind eq &#39;Cash&#39;)\&quot;. For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;EligibleCollateralSchedule&#39; domain to decorate onto each Eligible Collateral Schedule.              These must take the format {domain}/{scope}/{code}, for example &#39;EligibleCollateralSchedule/Manager/Id&#39;. | [optional]  |

### Return type

[**PagedResourceListOfEligibleCollateralSchedule**](PagedResourceListOfEligibleCollateralSchedule.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Eligible Collateral Schedules. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upserteligiblecollateralschedule"></a>
# **UpsertEligibleCollateralSchedule**
> EligibleCollateralSchedule UpsertEligibleCollateralSchedule (string scope, string code, UpsertEligibleCollateralScheduleRequest upsertEligibleCollateralScheduleRequest)

[EXPERIMENTAL] UpsertEligibleCollateralSchedule: Upsert an Eligible Collateral Schedule.

Create or replace the full definition of an Eligible Collateral Schedule from an effective datetime. A change to the  definition becomes a new bitemporal version: the schedule as it was declared at earlier effective datetimes,  and as of earlier asAt datetimes, remains retrievable.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<EligibleCollateralSchedulesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EligibleCollateralSchedulesApi>();
            var scope = "scope_example";  // string | The scope of the Eligible Collateral Schedule.
            var code = "code_example";  // string | The code of the Eligible Collateral Schedule. Together with the scope this uniquely identifies the Eligible Collateral Schedule.
            var upsertEligibleCollateralScheduleRequest = new UpsertEligibleCollateralScheduleRequest(); // UpsertEligibleCollateralScheduleRequest | The full definition of the Eligible Collateral Schedule from the effective datetime in the request, or the current LUSID system datetime if not specified.

            try
            {
                // uncomment the below to set overrides at the request level
                // EligibleCollateralSchedule result = apiInstance.UpsertEligibleCollateralSchedule(scope, code, upsertEligibleCollateralScheduleRequest, opts: opts);

                // [EXPERIMENTAL] UpsertEligibleCollateralSchedule: Upsert an Eligible Collateral Schedule.
                EligibleCollateralSchedule result = apiInstance.UpsertEligibleCollateralSchedule(scope, code, upsertEligibleCollateralScheduleRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EligibleCollateralSchedulesApi.UpsertEligibleCollateralSchedule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertEligibleCollateralScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertEligibleCollateralSchedule: Upsert an Eligible Collateral Schedule.
    ApiResponse<EligibleCollateralSchedule> response = apiInstance.UpsertEligibleCollateralScheduleWithHttpInfo(scope, code, upsertEligibleCollateralScheduleRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EligibleCollateralSchedulesApi.UpsertEligibleCollateralScheduleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Eligible Collateral Schedule. |  |
| **code** | **string** | The code of the Eligible Collateral Schedule. Together with the scope this uniquely identifies the Eligible Collateral Schedule. |  |
| **upsertEligibleCollateralScheduleRequest** | [**UpsertEligibleCollateralScheduleRequest**](UpsertEligibleCollateralScheduleRequest.md) | The full definition of the Eligible Collateral Schedule from the effective datetime in the request, or the current LUSID system datetime if not specified. |  |

### Return type

[**EligibleCollateralSchedule**](EligibleCollateralSchedule.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Eligible Collateral Schedule as it stands from the effective datetime. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

