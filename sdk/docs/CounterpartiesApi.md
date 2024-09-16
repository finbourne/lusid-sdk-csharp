# Lusid.Sdk.Api.CounterpartiesApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCounterpartyAgreement**](CounterpartiesApi.md#deletecounterpartyagreement) | **DELETE** /api/counterparties/counterpartyagreements/{scope}/{code} | [EARLY ACCESS] DeleteCounterpartyAgreement: Delete the Counterparty Agreement of given scope and code |
| [**DeleteCreditSupportAnnex**](CounterpartiesApi.md#deletecreditsupportannex) | **DELETE** /api/counterparties/creditsupportannexes/{scope}/{code} | [EARLY ACCESS] DeleteCreditSupportAnnex: Delete the Credit Support Annex of given scope and code |
| [**GetCounterpartyAgreement**](CounterpartiesApi.md#getcounterpartyagreement) | **GET** /api/counterparties/counterpartyagreements/{scope}/{code} | [EARLY ACCESS] GetCounterpartyAgreement: Get Counterparty Agreement |
| [**GetCreditSupportAnnex**](CounterpartiesApi.md#getcreditsupportannex) | **GET** /api/counterparties/creditsupportannexes/{scope}/{code} | [EARLY ACCESS] GetCreditSupportAnnex: Get Credit Support Annex |
| [**ListCounterpartyAgreements**](CounterpartiesApi.md#listcounterpartyagreements) | **GET** /api/counterparties/counterpartyagreements | [EARLY ACCESS] ListCounterpartyAgreements: List the set of Counterparty Agreements |
| [**ListCreditSupportAnnexes**](CounterpartiesApi.md#listcreditsupportannexes) | **GET** /api/counterparties/creditsupportannexes | [EARLY ACCESS] ListCreditSupportAnnexes: List the set of Credit Support Annexes |
| [**UpsertCounterpartyAgreement**](CounterpartiesApi.md#upsertcounterpartyagreement) | **POST** /api/counterparties/counterpartyagreements | [EARLY ACCESS] UpsertCounterpartyAgreement: Upsert Counterparty Agreement |
| [**UpsertCreditSupportAnnex**](CounterpartiesApi.md#upsertcreditsupportannex) | **POST** /api/counterparties/creditsupportannexes | [EARLY ACCESS] UpsertCreditSupportAnnex: Upsert Credit Support Annex |

<a id="deletecounterpartyagreement"></a>
# **DeleteCounterpartyAgreement**
> AnnulSingleStructuredDataResponse DeleteCounterpartyAgreement (string scope, string code)

[EARLY ACCESS] DeleteCounterpartyAgreement: Delete the Counterparty Agreement of given scope and code

Delete the specified Counterparty Agreement from a single scope.  The response will return either detail of the deleted item, or an explanation (failure) as to why this did not succeed.                It is important to always check for any unsuccessful response.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CounterpartiesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CounterpartiesApi>();
            var scope = "scope_example";  // string | The scope of the Counterparty Agreement to delete.
            var code = "code_example";  // string | The Counterparty Agreement to delete.

            try
            {
                // uncomment the below to set overrides at the request level
                // AnnulSingleStructuredDataResponse result = apiInstance.DeleteCounterpartyAgreement(scope, code, opts: opts);

                // [EARLY ACCESS] DeleteCounterpartyAgreement: Delete the Counterparty Agreement of given scope and code
                AnnulSingleStructuredDataResponse result = apiInstance.DeleteCounterpartyAgreement(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CounterpartiesApi.DeleteCounterpartyAgreement: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCounterpartyAgreementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteCounterpartyAgreement: Delete the Counterparty Agreement of given scope and code
    ApiResponse<AnnulSingleStructuredDataResponse> response = apiInstance.DeleteCounterpartyAgreementWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CounterpartiesApi.DeleteCounterpartyAgreementWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Counterparty Agreement to delete. |  |
| **code** | **string** | The Counterparty Agreement to delete. |  |

### Return type

[**AnnulSingleStructuredDataResponse**](AnnulSingleStructuredDataResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The AsAt of deletion or failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletecreditsupportannex"></a>
# **DeleteCreditSupportAnnex**
> AnnulSingleStructuredDataResponse DeleteCreditSupportAnnex (string scope, string code)

[EARLY ACCESS] DeleteCreditSupportAnnex: Delete the Credit Support Annex of given scope and code

Delete the specified Credit Support Annex from a single scope.  The response will return either detail of the deleted item, or an explanation (failure) as to why this did not succeed.                It is important to always check for any unsuccessful response.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CounterpartiesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CounterpartiesApi>();
            var scope = "scope_example";  // string | The scope of the Credit Support Annex to delete.
            var code = "code_example";  // string | The Credit Support Annex to delete.

            try
            {
                // uncomment the below to set overrides at the request level
                // AnnulSingleStructuredDataResponse result = apiInstance.DeleteCreditSupportAnnex(scope, code, opts: opts);

                // [EARLY ACCESS] DeleteCreditSupportAnnex: Delete the Credit Support Annex of given scope and code
                AnnulSingleStructuredDataResponse result = apiInstance.DeleteCreditSupportAnnex(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CounterpartiesApi.DeleteCreditSupportAnnex: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCreditSupportAnnexWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteCreditSupportAnnex: Delete the Credit Support Annex of given scope and code
    ApiResponse<AnnulSingleStructuredDataResponse> response = apiInstance.DeleteCreditSupportAnnexWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CounterpartiesApi.DeleteCreditSupportAnnexWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Credit Support Annex to delete. |  |
| **code** | **string** | The Credit Support Annex to delete. |  |

### Return type

[**AnnulSingleStructuredDataResponse**](AnnulSingleStructuredDataResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The AsAt of deletion or failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getcounterpartyagreement"></a>
# **GetCounterpartyAgreement**
> GetCounterpartyAgreementResponse GetCounterpartyAgreement (string scope, string code, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetCounterpartyAgreement: Get Counterparty Agreement

Get a Counterparty Agreement from a single scope.  The response will return either the Counterparty Agreement that has been stored, or a failure explaining why the request was unsuccessful.  It is important to always check for any unsuccessful requests (failures).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CounterpartiesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CounterpartiesApi>();
            var scope = "scope_example";  // string | The scope of the Counterparty Agreement to retrieve.
            var code = "code_example";  // string | The name of the Counterparty Agreement to retrieve the data for.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Counterparty Agreement. Defaults to return the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // GetCounterpartyAgreementResponse result = apiInstance.GetCounterpartyAgreement(scope, code, asAt, opts: opts);

                // [EARLY ACCESS] GetCounterpartyAgreement: Get Counterparty Agreement
                GetCounterpartyAgreementResponse result = apiInstance.GetCounterpartyAgreement(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CounterpartiesApi.GetCounterpartyAgreement: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCounterpartyAgreementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetCounterpartyAgreement: Get Counterparty Agreement
    ApiResponse<GetCounterpartyAgreementResponse> response = apiInstance.GetCounterpartyAgreementWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CounterpartiesApi.GetCounterpartyAgreementWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Counterparty Agreement to retrieve. |  |
| **code** | **string** | The name of the Counterparty Agreement to retrieve the data for. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Counterparty Agreement. Defaults to return the latest version if not specified. | [optional]  |

### Return type

[**GetCounterpartyAgreementResponse**](GetCounterpartyAgreementResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved Counterparty Agreement or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getcreditsupportannex"></a>
# **GetCreditSupportAnnex**
> GetCreditSupportAnnexResponse GetCreditSupportAnnex (string scope, string code, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetCreditSupportAnnex: Get Credit Support Annex

Get a Credit Support Annex from a single scope.  The response will return either the Credit Support Annex that has been stored, or a failure explaining why the request was unsuccessful.  It is important to always check for any unsuccessful requests (failures).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CounterpartiesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CounterpartiesApi>();
            var scope = "scope_example";  // string | The scope of the Credit Support Annex to retrieve.
            var code = "code_example";  // string | The name of the Credit Support Annex to retrieve the data for.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Credit Support Annex . Defaults to return the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // GetCreditSupportAnnexResponse result = apiInstance.GetCreditSupportAnnex(scope, code, asAt, opts: opts);

                // [EARLY ACCESS] GetCreditSupportAnnex: Get Credit Support Annex
                GetCreditSupportAnnexResponse result = apiInstance.GetCreditSupportAnnex(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CounterpartiesApi.GetCreditSupportAnnex: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCreditSupportAnnexWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetCreditSupportAnnex: Get Credit Support Annex
    ApiResponse<GetCreditSupportAnnexResponse> response = apiInstance.GetCreditSupportAnnexWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CounterpartiesApi.GetCreditSupportAnnexWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Credit Support Annex to retrieve. |  |
| **code** | **string** | The name of the Credit Support Annex to retrieve the data for. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Credit Support Annex . Defaults to return the latest version if not specified. | [optional]  |

### Return type

[**GetCreditSupportAnnexResponse**](GetCreditSupportAnnexResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved credit support annexes or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listcounterpartyagreements"></a>
# **ListCounterpartyAgreements**
> ResourceListOfGetCounterpartyAgreementResponse ListCounterpartyAgreements (DateTimeOffset? asAt = null)

[EARLY ACCESS] ListCounterpartyAgreements: List the set of Counterparty Agreements

List the set of Counterparty Agreements at the specified AsAt date/time

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CounterpartiesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CounterpartiesApi>();
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Counterparty Agreements. Defaults to latest if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfGetCounterpartyAgreementResponse result = apiInstance.ListCounterpartyAgreements(asAt, opts: opts);

                // [EARLY ACCESS] ListCounterpartyAgreements: List the set of Counterparty Agreements
                ResourceListOfGetCounterpartyAgreementResponse result = apiInstance.ListCounterpartyAgreements(asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CounterpartiesApi.ListCounterpartyAgreements: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCounterpartyAgreementsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListCounterpartyAgreements: List the set of Counterparty Agreements
    ApiResponse<ResourceListOfGetCounterpartyAgreementResponse> response = apiInstance.ListCounterpartyAgreementsWithHttpInfo(asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CounterpartiesApi.ListCounterpartyAgreementsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Counterparty Agreements. Defaults to latest if not specified. | [optional]  |

### Return type

[**ResourceListOfGetCounterpartyAgreementResponse**](ResourceListOfGetCounterpartyAgreementResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Counterparty Agreements |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listcreditsupportannexes"></a>
# **ListCreditSupportAnnexes**
> ResourceListOfGetCreditSupportAnnexResponse ListCreditSupportAnnexes (DateTimeOffset? asAt = null)

[EARLY ACCESS] ListCreditSupportAnnexes: List the set of Credit Support Annexes

List the set of Credit Support Annexes at the specified AsAt date/time

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CounterpartiesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CounterpartiesApi>();
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Credit Support Annexes. Defaults to latest if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfGetCreditSupportAnnexResponse result = apiInstance.ListCreditSupportAnnexes(asAt, opts: opts);

                // [EARLY ACCESS] ListCreditSupportAnnexes: List the set of Credit Support Annexes
                ResourceListOfGetCreditSupportAnnexResponse result = apiInstance.ListCreditSupportAnnexes(asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CounterpartiesApi.ListCreditSupportAnnexes: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCreditSupportAnnexesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListCreditSupportAnnexes: List the set of Credit Support Annexes
    ApiResponse<ResourceListOfGetCreditSupportAnnexResponse> response = apiInstance.ListCreditSupportAnnexesWithHttpInfo(asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CounterpartiesApi.ListCreditSupportAnnexesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Credit Support Annexes. Defaults to latest if not specified. | [optional]  |

### Return type

[**ResourceListOfGetCreditSupportAnnexResponse**](ResourceListOfGetCreditSupportAnnexResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Credit Support Annexes |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertcounterpartyagreement"></a>
# **UpsertCounterpartyAgreement**
> UpsertSingleStructuredDataResponse UpsertCounterpartyAgreement (UpsertCounterpartyAgreementRequest upsertCounterpartyAgreementRequest)

[EARLY ACCESS] UpsertCounterpartyAgreement: Upsert Counterparty Agreement

Update or insert Counterparty Agreement in a single scope. An item will be updated if it already exists and inserted if it does not.                The response will return the successfully updated or inserted Counterparty Agreement or failure message if unsuccessful                It is important to always check to verify success (or failure).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CounterpartiesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CounterpartiesApi>();
            var upsertCounterpartyAgreementRequest = new UpsertCounterpartyAgreementRequest(); // UpsertCounterpartyAgreementRequest | The Counterparty Agreement to update or insert

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertSingleStructuredDataResponse result = apiInstance.UpsertCounterpartyAgreement(upsertCounterpartyAgreementRequest, opts: opts);

                // [EARLY ACCESS] UpsertCounterpartyAgreement: Upsert Counterparty Agreement
                UpsertSingleStructuredDataResponse result = apiInstance.UpsertCounterpartyAgreement(upsertCounterpartyAgreementRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CounterpartiesApi.UpsertCounterpartyAgreement: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertCounterpartyAgreementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpsertCounterpartyAgreement: Upsert Counterparty Agreement
    ApiResponse<UpsertSingleStructuredDataResponse> response = apiInstance.UpsertCounterpartyAgreementWithHttpInfo(upsertCounterpartyAgreementRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CounterpartiesApi.UpsertCounterpartyAgreementWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **upsertCounterpartyAgreementRequest** | [**UpsertCounterpartyAgreementRequest**](UpsertCounterpartyAgreementRequest.md) | The Counterparty Agreement to update or insert |  |

### Return type

[**UpsertSingleStructuredDataResponse**](UpsertSingleStructuredDataResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully updated or inserted Counterparty Agreement or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertcreditsupportannex"></a>
# **UpsertCreditSupportAnnex**
> UpsertSingleStructuredDataResponse UpsertCreditSupportAnnex (UpsertCreditSupportAnnexRequest upsertCreditSupportAnnexRequest)

[EARLY ACCESS] UpsertCreditSupportAnnex: Upsert Credit Support Annex

Update or insert Credit Support Annex in a single scope. An item will be updated if it already exists and inserted if it does not.                The response will return the successfully updated or inserted Credit Support Annex or failure message if unsuccessful                It is important to always check to verify success (or failure).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CounterpartiesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CounterpartiesApi>();
            var upsertCreditSupportAnnexRequest = new UpsertCreditSupportAnnexRequest(); // UpsertCreditSupportAnnexRequest | The Credit Support Annex to update or insert

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertSingleStructuredDataResponse result = apiInstance.UpsertCreditSupportAnnex(upsertCreditSupportAnnexRequest, opts: opts);

                // [EARLY ACCESS] UpsertCreditSupportAnnex: Upsert Credit Support Annex
                UpsertSingleStructuredDataResponse result = apiInstance.UpsertCreditSupportAnnex(upsertCreditSupportAnnexRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CounterpartiesApi.UpsertCreditSupportAnnex: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertCreditSupportAnnexWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpsertCreditSupportAnnex: Upsert Credit Support Annex
    ApiResponse<UpsertSingleStructuredDataResponse> response = apiInstance.UpsertCreditSupportAnnexWithHttpInfo(upsertCreditSupportAnnexRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CounterpartiesApi.UpsertCreditSupportAnnexWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **upsertCreditSupportAnnexRequest** | [**UpsertCreditSupportAnnexRequest**](UpsertCreditSupportAnnexRequest.md) | The Credit Support Annex to update or insert |  |

### Return type

[**UpsertSingleStructuredDataResponse**](UpsertSingleStructuredDataResponse.md)

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

