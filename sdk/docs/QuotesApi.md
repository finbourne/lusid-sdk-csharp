# Lusid.Sdk.Api.QuotesApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteQuoteAccessMetadataRule**](QuotesApi.md#deletequoteaccessmetadatarule) | **DELETE** /api/metadata/quotes/rules/{scope} | [EXPERIMENTAL] DeleteQuoteAccessMetadataRule: Delete a Quote Access Metadata Rule |
| [**DeleteQuotes**](QuotesApi.md#deletequotes) | **POST** /api/quotes/{scope}/$delete | DeleteQuotes: Delete quotes |
| [**GetQuotes**](QuotesApi.md#getquotes) | **POST** /api/quotes/{scope}/$get | GetQuotes: Get quotes |
| [**GetQuotesAccessMetadataRule**](QuotesApi.md#getquotesaccessmetadatarule) | **GET** /api/metadata/quotes/rules | [EXPERIMENTAL] GetQuotesAccessMetadataRule: Get a quote access metadata rule |
| [**ListQuotes**](QuotesApi.md#listquotes) | **GET** /api/quotes/{scope}/$deprecated | [DEPRECATED] ListQuotes: List quotes |
| [**ListQuotesAccessMetadataRules**](QuotesApi.md#listquotesaccessmetadatarules) | **GET** /api/metadata/quotes/rules/{scope} | [EXPERIMENTAL] ListQuotesAccessMetadataRules: List all quote access metadata rules in a scope |
| [**ListQuotesForScope**](QuotesApi.md#listquotesforscope) | **GET** /api/quotes/{scope} | ListQuotesForScope: List quotes for scope |
| [**UpsertQuoteAccessMetadataRule**](QuotesApi.md#upsertquoteaccessmetadatarule) | **POST** /api/metadata/quotes/rules/{scope} | [EXPERIMENTAL] UpsertQuoteAccessMetadataRule: Upsert a Quote Access Metadata Rule. This creates or updates the data in LUSID. |
| [**UpsertQuotes**](QuotesApi.md#upsertquotes) | **POST** /api/quotes/{scope} | UpsertQuotes: Upsert quotes |

<a id="deletequoteaccessmetadatarule"></a>
# **DeleteQuoteAccessMetadataRule**
> QuoteAccessMetadataRule DeleteQuoteAccessMetadataRule (string scope, string? provider = null, string? priceSource = null, string? instrumentIdType = null, string? instrumentId = null, string? quoteType = null, string? field = null, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] DeleteQuoteAccessMetadataRule: Delete a Quote Access Metadata Rule

Delete the Quote Access Metadata Rule that exactly matches the provided identifier parts

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<QuotesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<QuotesApi>();
            var scope = "scope_example";  // string | The scope of the Quote Access Metadata Rule to retrieve.
            var provider = "provider_example";  // string? | The Provider of the rule (optional) 
            var priceSource = "priceSource_example";  // string? | The PriceSource of the rule (optional) 
            var instrumentIdType = "instrumentIdType_example";  // string? | The InstrumentIdType of the rule (optional) 
            var instrumentId = "instrumentId_example";  // string? | The InstrumentId of the rule (optional) 
            var quoteType = "quoteType_example";  // string? | The QuoteType of the rule (optional) 
            var field = "field_example";  // string? | The Field of the rule (optional) 
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective date to delete at, if this is not supplied, it will delete all data found (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // QuoteAccessMetadataRule result = apiInstance.DeleteQuoteAccessMetadataRule(scope, provider, priceSource, instrumentIdType, instrumentId, quoteType, field, effectiveAt, opts: opts);

                // [EXPERIMENTAL] DeleteQuoteAccessMetadataRule: Delete a Quote Access Metadata Rule
                QuoteAccessMetadataRule result = apiInstance.DeleteQuoteAccessMetadataRule(scope, provider, priceSource, instrumentIdType, instrumentId, quoteType, field, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling QuotesApi.DeleteQuoteAccessMetadataRule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteQuoteAccessMetadataRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteQuoteAccessMetadataRule: Delete a Quote Access Metadata Rule
    ApiResponse<QuoteAccessMetadataRule> response = apiInstance.DeleteQuoteAccessMetadataRuleWithHttpInfo(scope, provider, priceSource, instrumentIdType, instrumentId, quoteType, field, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling QuotesApi.DeleteQuoteAccessMetadataRuleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Quote Access Metadata Rule to retrieve. |  |
| **provider** | **string?** | The Provider of the rule | [optional]  |
| **priceSource** | **string?** | The PriceSource of the rule | [optional]  |
| **instrumentIdType** | **string?** | The InstrumentIdType of the rule | [optional]  |
| **instrumentId** | **string?** | The InstrumentId of the rule | [optional]  |
| **quoteType** | **string?** | The QuoteType of the rule | [optional]  |
| **field** | **string?** | The Field of the rule | [optional]  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective date to delete at, if this is not supplied, it will delete all data found | [optional]  |

### Return type

[**QuoteAccessMetadataRule**](QuoteAccessMetadataRule.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The rule that has been deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletequotes"></a>
# **DeleteQuotes**
> AnnulQuotesResponse DeleteQuotes (string scope, Dictionary<string, QuoteId>? requestBody = null)

DeleteQuotes: Delete quotes

Delete one or more specified quotes from a single scope. A quote is identified by its unique id which includes information about  the type of quote as well as the exact effective datetime (to the microsecond) from which it became valid.                In the request each quote must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each quote in the response.                The response will return both the collection of successfully deleted quotes, as well as those that failed.  For the failures a reason will be provided explaining why the quote could not be deleted.                It is important to always check the failed set for any unsuccessful results.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<QuotesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<QuotesApi>();
            var scope = "scope_example";  // string | The scope of the quotes to delete.
            var requestBody = new Dictionary<string, QuoteId>?(); // Dictionary<string, QuoteId>? | The quotes to delete keyed by a unique correlation id. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AnnulQuotesResponse result = apiInstance.DeleteQuotes(scope, requestBody, opts: opts);

                // DeleteQuotes: Delete quotes
                AnnulQuotesResponse result = apiInstance.DeleteQuotes(scope, requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling QuotesApi.DeleteQuotes: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteQuotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteQuotes: Delete quotes
    ApiResponse<AnnulQuotesResponse> response = apiInstance.DeleteQuotesWithHttpInfo(scope, requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling QuotesApi.DeleteQuotesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the quotes to delete. |  |
| **requestBody** | [**Dictionary&lt;string, QuoteId&gt;?**](QuoteId.md) | The quotes to delete keyed by a unique correlation id. | [optional]  |

### Return type

[**AnnulQuotesResponse**](AnnulQuotesResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully deleted quotes along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getquotes"></a>
# **GetQuotes**
> GetQuotesResponse GetQuotes (string scope, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? maxAge = null, Dictionary<string, QuoteSeriesId>? requestBody = null)

GetQuotes: Get quotes

Get one or more quotes from a single scope.                Each quote can be identified by its time invariant quote series id.                For each quote series id LUSID will return the most recent quote with respect to the provided (or default) effective datetime.                 An optional maximum age range window can be specified which defines how far back to look back for a quote from the specified effective datetime.  LUSID will return the most recent quote within this window.                In the request each quote series id must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each quote in the response.                The response will return three collections. One, the successfully retrieved quotes. Two, those that had a  valid quote series id but could not be found. Three, those that failed because LUSID could not construct a valid quote series id from the request.    For the quotes that failed or could not be found a reason will be provided explaining why the quote could not be retrieved.                It is important to always check the failed and not found sets for any unsuccessful results.  The maximum number of quotes that this method can get per request is 2,000.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<QuotesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<QuotesApi>();
            var scope = "scope_example";  // string | The scope of the quotes to retrieve.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the quotes. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the quotes. Defaults to return the latest version of each quote if not specified. (optional) 
            var maxAge = "maxAge_example";  // string? | The duration of the look back window in an ISO8601 time interval format e.g. P1Y2M3DT4H30M (1 year, 2 months, 3 days, 4 hours and 30 minutes).               This is subtracted from the provided effectiveAt datetime or cut label to generate a effective datetime window inside which a quote must exist to be retrieved. (optional) 
            var requestBody = new Dictionary<string, QuoteSeriesId>?(); // Dictionary<string, QuoteSeriesId>? | The time invariant quote series ids of the quotes to retrieve. These need to be               keyed by a unique correlation id allowing the retrieved quote to be identified in the response. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // GetQuotesResponse result = apiInstance.GetQuotes(scope, effectiveAt, asAt, maxAge, requestBody, opts: opts);

                // GetQuotes: Get quotes
                GetQuotesResponse result = apiInstance.GetQuotes(scope, effectiveAt, asAt, maxAge, requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling QuotesApi.GetQuotes: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetQuotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetQuotes: Get quotes
    ApiResponse<GetQuotesResponse> response = apiInstance.GetQuotesWithHttpInfo(scope, effectiveAt, asAt, maxAge, requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling QuotesApi.GetQuotesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the quotes to retrieve. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the quotes. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the quotes. Defaults to return the latest version of each quote if not specified. | [optional]  |
| **maxAge** | **string?** | The duration of the look back window in an ISO8601 time interval format e.g. P1Y2M3DT4H30M (1 year, 2 months, 3 days, 4 hours and 30 minutes).               This is subtracted from the provided effectiveAt datetime or cut label to generate a effective datetime window inside which a quote must exist to be retrieved. | [optional]  |
| **requestBody** | [**Dictionary&lt;string, QuoteSeriesId&gt;?**](QuoteSeriesId.md) | The time invariant quote series ids of the quotes to retrieve. These need to be               keyed by a unique correlation id allowing the retrieved quote to be identified in the response. | [optional]  |

### Return type

[**GetQuotesResponse**](GetQuotesResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved quotes along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getquotesaccessmetadatarule"></a>
# **GetQuotesAccessMetadataRule**
> QuoteAccessMetadataRule GetQuotesAccessMetadataRule (string scope, string? provider = null, string? priceSource = null, string? instrumentIdType = null, string? instrumentId = null, string? quoteType = null, string? field = null, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetQuotesAccessMetadataRule: Get a quote access metadata rule

Get a specific quote access metadata rule by specifying the corresponding identifier parts                No matching will be performed through this endpoint. To retrieve a rule, it is necessary to specify, exactly, the identifier of the rule

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<QuotesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<QuotesApi>();
            var scope = "scope_example";  // string | The scope of the Quote Access Metadata Rule to retrieve.
            var provider = "provider_example";  // string? | The Provider of the rule (optional) 
            var priceSource = "priceSource_example";  // string? | The PriceSource of the rule (optional) 
            var instrumentIdType = "instrumentIdType_example";  // string? | The InstrumentIdType of the rule (optional) 
            var instrumentId = "instrumentId_example";  // string? | The InstrumentId of the rule (optional) 
            var quoteType = "quoteType_example";  // string? | The QuoteType of the rule (optional) 
            var field = "field_example";  // string? | The Field of the rule (optional) 
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective date of the rule (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the access metadata rule. Defaults to return the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // QuoteAccessMetadataRule result = apiInstance.GetQuotesAccessMetadataRule(scope, provider, priceSource, instrumentIdType, instrumentId, quoteType, field, effectiveAt, asAt, opts: opts);

                // [EXPERIMENTAL] GetQuotesAccessMetadataRule: Get a quote access metadata rule
                QuoteAccessMetadataRule result = apiInstance.GetQuotesAccessMetadataRule(scope, provider, priceSource, instrumentIdType, instrumentId, quoteType, field, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling QuotesApi.GetQuotesAccessMetadataRule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetQuotesAccessMetadataRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetQuotesAccessMetadataRule: Get a quote access metadata rule
    ApiResponse<QuoteAccessMetadataRule> response = apiInstance.GetQuotesAccessMetadataRuleWithHttpInfo(scope, provider, priceSource, instrumentIdType, instrumentId, quoteType, field, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling QuotesApi.GetQuotesAccessMetadataRuleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Quote Access Metadata Rule to retrieve. |  |
| **provider** | **string?** | The Provider of the rule | [optional]  |
| **priceSource** | **string?** | The PriceSource of the rule | [optional]  |
| **instrumentIdType** | **string?** | The InstrumentIdType of the rule | [optional]  |
| **instrumentId** | **string?** | The InstrumentId of the rule | [optional]  |
| **quoteType** | **string?** | The QuoteType of the rule | [optional]  |
| **field** | **string?** | The Field of the rule | [optional]  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective date of the rule | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the access metadata rule. Defaults to return the latest version if not specified. | [optional]  |

### Return type

[**QuoteAccessMetadataRule**](QuoteAccessMetadataRule.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved Quote Access Metadata Rule or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listquotes"></a>
# **ListQuotes**
> ResourceListOfQuote ListQuotes (string scope, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null)

[DEPRECATED] ListQuotes: List quotes

List all the quotes from a single scope at the specified date/time  Please use M:Finbourne.WebApi.Controllers.QuotesController.ListQuotesForScope(System.String,System.Nullable{System.DateTimeOffset},System.String,System.Nullable{System.Int32},System.String) - the signature and behaviour of this endpoint will be changing to omit scope

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<QuotesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<QuotesApi>();
            var scope = "scope_example";  // string | The scope of the quotes to list.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the quotes. Defaults to latest if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing quotes from a previous call to list quotes.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfQuote result = apiInstance.ListQuotes(scope, asAt, page, limit, filter, opts: opts);

                // [DEPRECATED] ListQuotes: List quotes
                ResourceListOfQuote result = apiInstance.ListQuotes(scope, asAt, page, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling QuotesApi.ListQuotes: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListQuotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [DEPRECATED] ListQuotes: List quotes
    ApiResponse<ResourceListOfQuote> response = apiInstance.ListQuotesWithHttpInfo(scope, asAt, page, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling QuotesApi.ListQuotesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the quotes to list. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the quotes. Defaults to latest if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing quotes from a previous call to list quotes.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**ResourceListOfQuote**](ResourceListOfQuote.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested quotes |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listquotesaccessmetadatarules"></a>
# **ListQuotesAccessMetadataRules**
> ResourceListOfQuoteAccessMetadataRule ListQuotesAccessMetadataRules (string scope, DateTimeOffset? asAt = null)

[EXPERIMENTAL] ListQuotesAccessMetadataRules: List all quote access metadata rules in a scope

Get all the quote access metadata rules in the specified scope

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<QuotesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<QuotesApi>();
            var scope = "scope_example";  // string | The scope of the Quote Access Metadata Rule to retrieve.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the access metadata rule. Defaults to return the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfQuoteAccessMetadataRule result = apiInstance.ListQuotesAccessMetadataRules(scope, asAt, opts: opts);

                // [EXPERIMENTAL] ListQuotesAccessMetadataRules: List all quote access metadata rules in a scope
                ResourceListOfQuoteAccessMetadataRule result = apiInstance.ListQuotesAccessMetadataRules(scope, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling QuotesApi.ListQuotesAccessMetadataRules: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListQuotesAccessMetadataRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListQuotesAccessMetadataRules: List all quote access metadata rules in a scope
    ApiResponse<ResourceListOfQuoteAccessMetadataRule> response = apiInstance.ListQuotesAccessMetadataRulesWithHttpInfo(scope, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling QuotesApi.ListQuotesAccessMetadataRulesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Quote Access Metadata Rule to retrieve. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the access metadata rule. Defaults to return the latest version if not specified. | [optional]  |

### Return type

[**ResourceListOfQuoteAccessMetadataRule**](ResourceListOfQuoteAccessMetadataRule.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The filtered list of results |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listquotesforscope"></a>
# **ListQuotesForScope**
> ResourceListOfQuote ListQuotesForScope (string scope, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null)

ListQuotesForScope: List quotes for scope

List all the quotes from a single scope at the specified date/time

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<QuotesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<QuotesApi>();
            var scope = "scope_example";  // string | The scope of the quotes to list.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the quotes. Defaults to latest if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing quotes from a previous call to list quotes.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfQuote result = apiInstance.ListQuotesForScope(scope, asAt, page, limit, filter, opts: opts);

                // ListQuotesForScope: List quotes for scope
                ResourceListOfQuote result = apiInstance.ListQuotesForScope(scope, asAt, page, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling QuotesApi.ListQuotesForScope: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListQuotesForScopeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListQuotesForScope: List quotes for scope
    ApiResponse<ResourceListOfQuote> response = apiInstance.ListQuotesForScopeWithHttpInfo(scope, asAt, page, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling QuotesApi.ListQuotesForScopeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the quotes to list. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the quotes. Defaults to latest if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing quotes from a previous call to list quotes.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**ResourceListOfQuote**](ResourceListOfQuote.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested quotes |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertquoteaccessmetadatarule"></a>
# **UpsertQuoteAccessMetadataRule**
> QuoteAccessMetadataRule UpsertQuoteAccessMetadataRule (string scope, UpsertQuoteAccessMetadataRuleRequest upsertQuoteAccessMetadataRuleRequest, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? effectiveUntil = null)

[EXPERIMENTAL] UpsertQuoteAccessMetadataRule: Upsert a Quote Access Metadata Rule. This creates or updates the data in LUSID.

Update or insert one Quote Access Metadata Rule in a single scope. An item will be updated if it already exists  and inserted if it does not.    The response will return the successfully updated or inserted Quote Access Metadata Rule or failure message if unsuccessful    It is important to always check to verify success (or failure).                Multiple rules for a key can exists with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<QuotesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<QuotesApi>();
            var scope = "scope_example";  // string | The scope to use when updating or inserting the Quote Access Metadata Rule.
            var upsertQuoteAccessMetadataRuleRequest = new UpsertQuoteAccessMetadataRuleRequest(); // UpsertQuoteAccessMetadataRuleRequest | The Quote Access Metadata Rule to update or insert
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The date this rule will effective from (optional) 
            var effectiveUntil = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' date of the Access Metadata (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // QuoteAccessMetadataRule result = apiInstance.UpsertQuoteAccessMetadataRule(scope, upsertQuoteAccessMetadataRuleRequest, effectiveAt, effectiveUntil, opts: opts);

                // [EXPERIMENTAL] UpsertQuoteAccessMetadataRule: Upsert a Quote Access Metadata Rule. This creates or updates the data in LUSID.
                QuoteAccessMetadataRule result = apiInstance.UpsertQuoteAccessMetadataRule(scope, upsertQuoteAccessMetadataRuleRequest, effectiveAt, effectiveUntil);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling QuotesApi.UpsertQuoteAccessMetadataRule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertQuoteAccessMetadataRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertQuoteAccessMetadataRule: Upsert a Quote Access Metadata Rule. This creates or updates the data in LUSID.
    ApiResponse<QuoteAccessMetadataRule> response = apiInstance.UpsertQuoteAccessMetadataRuleWithHttpInfo(scope, upsertQuoteAccessMetadataRuleRequest, effectiveAt, effectiveUntil);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling QuotesApi.UpsertQuoteAccessMetadataRuleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope to use when updating or inserting the Quote Access Metadata Rule. |  |
| **upsertQuoteAccessMetadataRuleRequest** | [**UpsertQuoteAccessMetadataRuleRequest**](UpsertQuoteAccessMetadataRuleRequest.md) | The Quote Access Metadata Rule to update or insert |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The date this rule will effective from | [optional]  |
| **effectiveUntil** | **DateTimeOffset?** | The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata | [optional]  |

### Return type

[**QuoteAccessMetadataRule**](QuoteAccessMetadataRule.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully updated or inserted item or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertquotes"></a>
# **UpsertQuotes**
> UpsertQuotesResponse UpsertQuotes (string scope, Dictionary<string, UpsertQuoteRequest>? requestBody = null)

UpsertQuotes: Upsert quotes

Update or insert one or more quotes in a single scope. A quote will be updated if it already exists  and inserted if it does not.                In the request each quote must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each quote in the response.                The response will return both the collection of successfully updated or inserted quotes, as well as those that failed.  For the failures a reason will be provided explaining why the quote could not be updated or inserted.                It is important to always check the failed set for any unsuccessful results.  The maximum number of quotes that this method can upsert per request is 2,000.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<QuotesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<QuotesApi>();
            var scope = "scope_example";  // string | The scope to use when updating or inserting the quotes.
            var requestBody = new Dictionary<string, UpsertQuoteRequest>?(); // Dictionary<string, UpsertQuoteRequest>? | The quotes to update or insert keyed by a unique correlation id. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertQuotesResponse result = apiInstance.UpsertQuotes(scope, requestBody, opts: opts);

                // UpsertQuotes: Upsert quotes
                UpsertQuotesResponse result = apiInstance.UpsertQuotes(scope, requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling QuotesApi.UpsertQuotes: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertQuotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpsertQuotes: Upsert quotes
    ApiResponse<UpsertQuotesResponse> response = apiInstance.UpsertQuotesWithHttpInfo(scope, requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling QuotesApi.UpsertQuotesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope to use when updating or inserting the quotes. |  |
| **requestBody** | [**Dictionary&lt;string, UpsertQuoteRequest&gt;?**](UpsertQuoteRequest.md) | The quotes to update or insert keyed by a unique correlation id. | [optional]  |

### Return type

[**UpsertQuotesResponse**](UpsertQuotesResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully updated or inserted quotes along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

