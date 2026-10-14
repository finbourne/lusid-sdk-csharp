# Lusid.Sdk.Api.CollateralAgreementsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCollateralAgreement**](CollateralAgreementsApi.md#createcollateralagreement) | **POST** /api/collateralagreements/{scope} | [EXPERIMENTAL] CreateCollateralAgreement: Create a Collateral Agreement. |
| [**DeleteCollateralAgreement**](CollateralAgreementsApi.md#deletecollateralagreement) | **DELETE** /api/collateralagreements/{scope}/{code} | [EXPERIMENTAL] DeleteCollateralAgreement: Delete a Collateral Agreement. |
| [**GetCollateralAgreement**](CollateralAgreementsApi.md#getcollateralagreement) | **GET** /api/collateralagreements/{scope}/{code} | [EXPERIMENTAL] GetCollateralAgreement: Get a Collateral Agreement. |
| [**GetCollateralAgreementApplicability**](CollateralAgreementsApi.md#getcollateralagreementapplicability) | **GET** /api/collateralagreements/{scope}/{code}/$applicability | [EXPERIMENTAL] GetCollateralAgreementApplicability: Preview the portfolios a Collateral Agreement covers. |
| [**ListCollateralAgreements**](CollateralAgreementsApi.md#listcollateralagreements) | **GET** /api/collateralagreements | [EXPERIMENTAL] ListCollateralAgreements: List Collateral Agreements. |
| [**UpsertCollateralAgreement**](CollateralAgreementsApi.md#upsertcollateralagreement) | **PUT** /api/collateralagreements/{scope}/{code} | [EXPERIMENTAL] UpsertCollateralAgreement: Upsert a Collateral Agreement. |

<a id="createcollateralagreement"></a>
# **CreateCollateralAgreement**
> CollateralAgreement CreateCollateralAgreement (string scope, CollateralAgreementRequest collateralAgreementRequest)

[EXPERIMENTAL] CreateCollateralAgreement: Create a Collateral Agreement.

Create a new Collateral Agreement. The scope of the agreement is in the route and its code is in the request body.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CollateralAgreementsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CollateralAgreementsApi>();
            var scope = "scope_example";  // string | The scope of the Collateral Agreement.
            var collateralAgreementRequest = new CollateralAgreementRequest(); // CollateralAgreementRequest | The definition of the Collateral Agreement.

            try
            {
                // uncomment the below to set overrides at the request level
                // CollateralAgreement result = apiInstance.CreateCollateralAgreement(scope, collateralAgreementRequest, opts: opts);

                // [EXPERIMENTAL] CreateCollateralAgreement: Create a Collateral Agreement.
                CollateralAgreement result = apiInstance.CreateCollateralAgreement(scope, collateralAgreementRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralAgreementsApi.CreateCollateralAgreement: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCollateralAgreementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateCollateralAgreement: Create a Collateral Agreement.
    ApiResponse<CollateralAgreement> response = apiInstance.CreateCollateralAgreementWithHttpInfo(scope, collateralAgreementRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralAgreementsApi.CreateCollateralAgreementWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Collateral Agreement. |  |
| **collateralAgreementRequest** | [**CollateralAgreementRequest**](CollateralAgreementRequest.md) | The definition of the Collateral Agreement. |  |

### Return type

[**CollateralAgreement**](CollateralAgreement.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created Collateral Agreement. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletecollateralagreement"></a>
# **DeleteCollateralAgreement**
> DeletedEntityResponse DeleteCollateralAgreement (string scope, string code, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] DeleteCollateralAgreement: Delete a Collateral Agreement.

Delete a Collateral Agreement from the given effective datetime. It remains retrievable at earlier effective datetimes.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CollateralAgreementsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CollateralAgreementsApi>();
            var scope = "scope_example";  // string | The scope of the Collateral Agreement to be deleted.
            var code = "code_example";  // string | The code of the Collateral Agreement to be deleted. Together with the scope this uniquely identifies the Collateral Agreement.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label from which the Collateral Agreement is deleted. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteCollateralAgreement(scope, code, effectiveAt, opts: opts);

                // [EXPERIMENTAL] DeleteCollateralAgreement: Delete a Collateral Agreement.
                DeletedEntityResponse result = apiInstance.DeleteCollateralAgreement(scope, code, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralAgreementsApi.DeleteCollateralAgreement: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCollateralAgreementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteCollateralAgreement: Delete a Collateral Agreement.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteCollateralAgreementWithHttpInfo(scope, code, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralAgreementsApi.DeleteCollateralAgreementWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Collateral Agreement to be deleted. |  |
| **code** | **string** | The code of the Collateral Agreement to be deleted. Together with the scope this uniquely identifies the Collateral Agreement. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label from which the Collateral Agreement is deleted. Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the Collateral Agreement was deleted. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getcollateralagreement"></a>
# **GetCollateralAgreement**
> CollateralAgreement GetCollateralAgreement (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetCollateralAgreement: Get a Collateral Agreement.

Retrieve the definition of a particular Collateral Agreement at an effective and asAt datetime.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CollateralAgreementsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CollateralAgreementsApi>();
            var scope = "scope_example";  // string | The scope of the Collateral Agreement.
            var code = "code_example";  // string | The code of the Collateral Agreement. Together with the scope this uniquely identifies the Collateral Agreement.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the Collateral Agreement. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Collateral Agreement. Defaults to returning the latest version if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'CollateralAgreement' domain to decorate onto the Collateral Agreement.              These must take the format {domain}/{scope}/{code}, for example 'CollateralAgreement/Manager/Id'. If no properties are specified, then no properties will be returned. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // CollateralAgreement result = apiInstance.GetCollateralAgreement(scope, code, effectiveAt, asAt, propertyKeys, opts: opts);

                // [EXPERIMENTAL] GetCollateralAgreement: Get a Collateral Agreement.
                CollateralAgreement result = apiInstance.GetCollateralAgreement(scope, code, effectiveAt, asAt, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralAgreementsApi.GetCollateralAgreement: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCollateralAgreementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetCollateralAgreement: Get a Collateral Agreement.
    ApiResponse<CollateralAgreement> response = apiInstance.GetCollateralAgreementWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralAgreementsApi.GetCollateralAgreementWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Collateral Agreement. |  |
| **code** | **string** | The code of the Collateral Agreement. Together with the scope this uniquely identifies the Collateral Agreement. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the Collateral Agreement. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Collateral Agreement. Defaults to returning the latest version if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;CollateralAgreement&#39; domain to decorate onto the Collateral Agreement.              These must take the format {domain}/{scope}/{code}, for example &#39;CollateralAgreement/Manager/Id&#39;. If no properties are specified, then no properties will be returned. | [optional]  |

### Return type

[**CollateralAgreement**](CollateralAgreement.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Collateral Agreement. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getcollateralagreementapplicability"></a>
# **GetCollateralAgreementApplicability**
> CollateralAgreementApplicability GetCollateralAgreementApplicability (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, int? limit = null)

[EXPERIMENTAL] GetCollateralAgreementApplicability: Preview the portfolios a Collateral Agreement covers.

Evaluate the applicability filter of a Collateral Agreement against portfolios, using the same filter syntax as  listing portfolios, and return the portfolios it selects.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CollateralAgreementsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CollateralAgreementsApi>();
            var scope = "scope_example";  // string | The scope of the Collateral Agreement.
            var code = "code_example";  // string | The code of the Collateral Agreement. Together with the scope this uniquely identifies the Collateral Agreement.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to evaluate the agreement and portfolios. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to evaluate the agreement and portfolios. Defaults to returning the latest version if not specified. (optional) 
            var limit = 56;  // int? | The maximum number of portfolios to return. Defaults to 100 if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // CollateralAgreementApplicability result = apiInstance.GetCollateralAgreementApplicability(scope, code, effectiveAt, asAt, limit, opts: opts);

                // [EXPERIMENTAL] GetCollateralAgreementApplicability: Preview the portfolios a Collateral Agreement covers.
                CollateralAgreementApplicability result = apiInstance.GetCollateralAgreementApplicability(scope, code, effectiveAt, asAt, limit);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralAgreementsApi.GetCollateralAgreementApplicability: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCollateralAgreementApplicabilityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetCollateralAgreementApplicability: Preview the portfolios a Collateral Agreement covers.
    ApiResponse<CollateralAgreementApplicability> response = apiInstance.GetCollateralAgreementApplicabilityWithHttpInfo(scope, code, effectiveAt, asAt, limit);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralAgreementsApi.GetCollateralAgreementApplicabilityWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Collateral Agreement. |  |
| **code** | **string** | The code of the Collateral Agreement. Together with the scope this uniquely identifies the Collateral Agreement. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to evaluate the agreement and portfolios. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to evaluate the agreement and portfolios. Defaults to returning the latest version if not specified. | [optional]  |
| **limit** | **int?** | The maximum number of portfolios to return. Defaults to 100 if not specified. | [optional]  |

### Return type

[**CollateralAgreementApplicability**](CollateralAgreementApplicability.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The portfolios the Collateral Agreement covers. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listcollateralagreements"></a>
# **ListCollateralAgreements**
> PagedResourceListOfCollateralAgreement ListCollateralAgreements (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListCollateralAgreements: List Collateral Agreements.

List all the Collateral Agreements matching the given criteria.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CollateralAgreementsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CollateralAgreementsApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the Collateral Agreements. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list Collateral Agreements. Defaults to returning the latest version of each Collateral Agreement if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Collateral Agreements; this value is returned from the previous call. If a pagination token is provided, the filter and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. The filterable fields are Id.Scope, Id.Code, BaseCurrency, CounterpartyId.Code, CounterpartyId.IdTypeScope, CounterpartyId.IdTypeCode, ApplicabilityFilter, CutLabel, RecipeId.Scope, RecipeId.Code, MinimumTransferAmount, MatchTolerance, Rounding.Amount, Rounding.Deliveries, Rounding.Returns, SettlementLag.Cash, SettlementLag.Securities, Properties and Version. The margin items can be filtered with a single-condition any expression on either VariationMargin or InitialMargin over Code or Calculation.Method. For example, to filter on the counterparty code, specify \"CounterpartyId.Code eq 'Acme'\", and to find agreements with a variation margin item, specify \"VariationMargin any (Code eq 'VM1')\". For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'CollateralAgreement' domain to decorate onto each Collateral Agreement.              These must take the format {domain}/{scope}/{code}, for example 'CollateralAgreement/Manager/Id'. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfCollateralAgreement result = apiInstance.ListCollateralAgreements(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys, opts: opts);

                // [EXPERIMENTAL] ListCollateralAgreements: List Collateral Agreements.
                PagedResourceListOfCollateralAgreement result = apiInstance.ListCollateralAgreements(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralAgreementsApi.ListCollateralAgreements: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCollateralAgreementsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListCollateralAgreements: List Collateral Agreements.
    ApiResponse<PagedResourceListOfCollateralAgreement> response = apiInstance.ListCollateralAgreementsWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralAgreementsApi.ListCollateralAgreementsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the Collateral Agreements. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list Collateral Agreements. Defaults to returning the latest version of each Collateral Agreement if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Collateral Agreements; this value is returned from the previous call. If a pagination token is provided, the filter and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. The filterable fields are Id.Scope, Id.Code, BaseCurrency, CounterpartyId.Code, CounterpartyId.IdTypeScope, CounterpartyId.IdTypeCode, ApplicabilityFilter, CutLabel, RecipeId.Scope, RecipeId.Code, MinimumTransferAmount, MatchTolerance, Rounding.Amount, Rounding.Deliveries, Rounding.Returns, SettlementLag.Cash, SettlementLag.Securities, Properties and Version. The margin items can be filtered with a single-condition any expression on either VariationMargin or InitialMargin over Code or Calculation.Method. For example, to filter on the counterparty code, specify \&quot;CounterpartyId.Code eq &#39;Acme&#39;\&quot;, and to find agreements with a variation margin item, specify \&quot;VariationMargin any (Code eq &#39;VM1&#39;)\&quot;. For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;CollateralAgreement&#39; domain to decorate onto each Collateral Agreement.              These must take the format {domain}/{scope}/{code}, for example &#39;CollateralAgreement/Manager/Id&#39;. | [optional]  |

### Return type

[**PagedResourceListOfCollateralAgreement**](PagedResourceListOfCollateralAgreement.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Collateral Agreements. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertcollateralagreement"></a>
# **UpsertCollateralAgreement**
> CollateralAgreement UpsertCollateralAgreement (string scope, string code, UpsertCollateralAgreementRequest upsertCollateralAgreementRequest)

[EXPERIMENTAL] UpsertCollateralAgreement: Upsert a Collateral Agreement.

Create or replace the full definition of a Collateral Agreement from an effective datetime. A change to the  definition becomes a new bitemporal version: the agreement as it was declared at earlier effective datetimes,  and as of earlier asAt datetimes, remains retrievable.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CollateralAgreementsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CollateralAgreementsApi>();
            var scope = "scope_example";  // string | The scope of the Collateral Agreement.
            var code = "code_example";  // string | The code of the Collateral Agreement. Together with the scope this uniquely identifies the Collateral Agreement.
            var upsertCollateralAgreementRequest = new UpsertCollateralAgreementRequest(); // UpsertCollateralAgreementRequest | The full definition of the Collateral Agreement from the effective datetime in the request, or the current LUSID system datetime if not specified.

            try
            {
                // uncomment the below to set overrides at the request level
                // CollateralAgreement result = apiInstance.UpsertCollateralAgreement(scope, code, upsertCollateralAgreementRequest, opts: opts);

                // [EXPERIMENTAL] UpsertCollateralAgreement: Upsert a Collateral Agreement.
                CollateralAgreement result = apiInstance.UpsertCollateralAgreement(scope, code, upsertCollateralAgreementRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralAgreementsApi.UpsertCollateralAgreement: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertCollateralAgreementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertCollateralAgreement: Upsert a Collateral Agreement.
    ApiResponse<CollateralAgreement> response = apiInstance.UpsertCollateralAgreementWithHttpInfo(scope, code, upsertCollateralAgreementRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralAgreementsApi.UpsertCollateralAgreementWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Collateral Agreement. |  |
| **code** | **string** | The code of the Collateral Agreement. Together with the scope this uniquely identifies the Collateral Agreement. |  |
| **upsertCollateralAgreementRequest** | [**UpsertCollateralAgreementRequest**](UpsertCollateralAgreementRequest.md) | The full definition of the Collateral Agreement from the effective datetime in the request, or the current LUSID system datetime if not specified. |  |

### Return type

[**CollateralAgreement**](CollateralAgreement.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Collateral Agreement as it stands from the effective datetime. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

