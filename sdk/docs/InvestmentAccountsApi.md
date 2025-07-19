# Lusid.Sdk.Api.InvestmentAccountsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetInvestmentAccount**](InvestmentAccountsApi.md#getinvestmentaccount) | **GET** /api/investmentaccounts/{idTypeScope}/{idTypeCode}/{code} | [EARLY ACCESS] GetInvestmentAccount: Get Investment Account |
| [**UpsertInvestmentAccounts**](InvestmentAccountsApi.md#upsertinvestmentaccounts) | **POST** /api/investmentaccounts/$batchUpsert | [EARLY ACCESS] UpsertInvestmentAccounts: Upsert Investment Accounts |

<a id="getinvestmentaccount"></a>
# **GetInvestmentAccount**
> InvestmentAccount GetInvestmentAccount (string idTypeScope, string idTypeCode, string code, List<string>? propertyKeys = null, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? relationshipDefinitionIds = null)

[EARLY ACCESS] GetInvestmentAccount: Get Investment Account

Retrieve the definition of an investment account.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InvestmentAccountsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InvestmentAccountsApi>();
            var idTypeScope = "idTypeScope_example";  // string | Scope of the investment account identifier type.
            var idTypeCode = "idTypeCode_example";  // string | Code of the investment account identifier type.
            var code = "code_example";  // string | Code of the investment account under specified identifier type's scope and code. This together with stated identifier type uniquely              identifies the investment account.
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys or identifier types (as property keys) from the \"InvestmentAccount\" domain              to include for found investment account, or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \"InvestmentAccount/ContactDetails/Address\". (optional) 
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the investment account. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the investment account. Defaults to return the latest version of the investment account if not specified. (optional) 
            var relationshipDefinitionIds = new List<string>?(); // List<string>? | A list of relationship definitions that are used to decorate related entities              onto the investment account in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // InvestmentAccount result = apiInstance.GetInvestmentAccount(idTypeScope, idTypeCode, code, propertyKeys, effectiveAt, asAt, relationshipDefinitionIds, opts: opts);

                // [EARLY ACCESS] GetInvestmentAccount: Get Investment Account
                InvestmentAccount result = apiInstance.GetInvestmentAccount(idTypeScope, idTypeCode, code, propertyKeys, effectiveAt, asAt, relationshipDefinitionIds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InvestmentAccountsApi.GetInvestmentAccount: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvestmentAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetInvestmentAccount: Get Investment Account
    ApiResponse<InvestmentAccount> response = apiInstance.GetInvestmentAccountWithHttpInfo(idTypeScope, idTypeCode, code, propertyKeys, effectiveAt, asAt, relationshipDefinitionIds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InvestmentAccountsApi.GetInvestmentAccountWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **idTypeScope** | **string** | Scope of the investment account identifier type. |  |
| **idTypeCode** | **string** | Code of the investment account identifier type. |  |
| **code** | **string** | Code of the investment account under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the investment account. |  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys or identifier types (as property keys) from the \&quot;InvestmentAccount\&quot; domain              to include for found investment account, or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;InvestmentAccount/ContactDetails/Address\&quot;. | [optional]  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the investment account. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the investment account. Defaults to return the latest version of the investment account if not specified. | [optional]  |
| **relationshipDefinitionIds** | [**List&lt;string&gt;?**](string.md) | A list of relationship definitions that are used to decorate related entities              onto the investment account in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional]  |

### Return type

[**InvestmentAccount**](InvestmentAccount.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested investment account |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertinvestmentaccounts"></a>
# **UpsertInvestmentAccounts**
> UpsertInvestmentAccountsResponse UpsertInvestmentAccounts (string successMode, Dictionary<string, UpsertInvestmentAccountRequest> requestBody)

[EARLY ACCESS] UpsertInvestmentAccounts: Upsert Investment Accounts

Creates or updates a collection of Investment Accounts

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InvestmentAccountsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InvestmentAccountsApi>();
            var successMode = "successMode_example";  // string | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial
            var requestBody = new Dictionary<string, UpsertInvestmentAccountRequest>(); // Dictionary<string, UpsertInvestmentAccountRequest> | A collection of requests to create or update Investment Accounts.

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertInvestmentAccountsResponse result = apiInstance.UpsertInvestmentAccounts(successMode, requestBody, opts: opts);

                // [EARLY ACCESS] UpsertInvestmentAccounts: Upsert Investment Accounts
                UpsertInvestmentAccountsResponse result = apiInstance.UpsertInvestmentAccounts(successMode, requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InvestmentAccountsApi.UpsertInvestmentAccounts: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertInvestmentAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpsertInvestmentAccounts: Upsert Investment Accounts
    ApiResponse<UpsertInvestmentAccountsResponse> response = apiInstance.UpsertInvestmentAccountsWithHttpInfo(successMode, requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InvestmentAccountsApi.UpsertInvestmentAccountsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **successMode** | **string** | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial |  |
| **requestBody** | [**Dictionary&lt;string, UpsertInvestmentAccountRequest&gt;**](UpsertInvestmentAccountRequest.md) | A collection of requests to create or update Investment Accounts. |  |

### Return type

[**UpsertInvestmentAccountsResponse**](UpsertInvestmentAccountsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The successfully created or updated Investment Accounts along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

