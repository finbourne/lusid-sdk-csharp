# Lusid.Sdk.Api.TransactionFeesApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteTransactionFeeRule**](TransactionFeesApi.md#deletetransactionfeerule) | **DELETE** /api/transactions/fees/rules/{code} | DeleteTransactionFeeRule: Deletes a fee rule. |
| [**GetApplicableTransactionFees**](TransactionFeesApi.md#getapplicabletransactionfees) | **POST** /api/transactions/fees/$GetApplicableFees | GetApplicableTransactionFees: Get the Fees and Commissions that may be applicable to a transaction. |
| [**GetTransactionFeeRule**](TransactionFeesApi.md#gettransactionfeerule) | **GET** /api/transactions/fees/rules/{code} | GetTransactionFeeRule: Retrieve the definition of single fee rule. |
| [**ListTransactionFeeRules**](TransactionFeesApi.md#listtransactionfeerules) | **GET** /api/transactions/fees/rules | ListTransactionFeeRules: List fee rules, with optional filtering. |
| [**UpsertTransactionFeeRules**](TransactionFeesApi.md#upserttransactionfeerules) | **POST** /api/transactions/fees/rules | UpsertTransactionFeeRules: Upsert fee rules. |

<a id="deletetransactionfeerule"></a>
# **DeleteTransactionFeeRule**
> DeletedEntityResponse DeleteTransactionFeeRule (string code)

DeleteTransactionFeeRule: Deletes a fee rule.

Deletes the rule for all effective time.    The rule will remain viewable at previous as at times, but it will no longer be considered by  GetApplicableFees.    This cannot be undone.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionFeesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionFeesApi>();
            var code = "code_example";  // string | The fee rule code.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteTransactionFeeRule(code, opts: opts);

                // DeleteTransactionFeeRule: Deletes a fee rule.
                DeletedEntityResponse result = apiInstance.DeleteTransactionFeeRule(code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionFeesApi.DeleteTransactionFeeRule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTransactionFeeRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteTransactionFeeRule: Deletes a fee rule.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteTransactionFeeRuleWithHttpInfo(code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionFeesApi.DeleteTransactionFeeRuleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The fee rule code. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getapplicabletransactionfees"></a>
# **GetApplicableTransactionFees**
> ResourceListOfFeeRule GetApplicableTransactionFees (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? instrumentIdentifierType = null, string? instrumentIdentifier = null, string? portfolioScope = null, string? portfolioCode = null, Dictionary<string, string>? requestBody = null)

GetApplicableTransactionFees: Get the Fees and Commissions that may be applicable to a transaction.

Additionally, matching can be based on the instrument's properties, its portfolio properties, and any additional property keys present in the data file.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionFeesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionFeesApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to match rule definitions. Defaults to the current LUSID  system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to match rule definitions. Defaults to returning the latest version if not  specified. (optional) 
            var instrumentIdentifierType = "instrumentIdentifierType_example";  // string? | Optional. The unique identifier type to use, eg 'Figi' or 'LusidInstrumentId'. (optional) 
            var instrumentIdentifier = "instrumentIdentifier_example";  // string? | Optional. The Instrument Identifier to get properties for. (optional) 
            var portfolioScope = "portfolioScope_example";  // string? | Optional. The scope of the portfolio to fetch properties from. (optional) 
            var portfolioCode = "portfolioCode_example";  // string? | Optional. The code of the portfolio to fetch properties from. (optional) 
            var requestBody = new Dictionary<string, string>?(); // Dictionary<string, string>? | Any other property keys or fields, including the top-level fields of the              fee rule (e.g. \"ExecutionBroker\" and \"SettlementCurrency\" ) and those defined in AdditionalKeys, along with              their corresponding values that should be matched for fees. Eg. \"Instrument/default/Name=exampleValue\" or              \"AdditionalKey2=Value2\". (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfFeeRule result = apiInstance.GetApplicableTransactionFees(effectiveAt, asAt, instrumentIdentifierType, instrumentIdentifier, portfolioScope, portfolioCode, requestBody, opts: opts);

                // GetApplicableTransactionFees: Get the Fees and Commissions that may be applicable to a transaction.
                ResourceListOfFeeRule result = apiInstance.GetApplicableTransactionFees(effectiveAt, asAt, instrumentIdentifierType, instrumentIdentifier, portfolioScope, portfolioCode, requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionFeesApi.GetApplicableTransactionFees: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicableTransactionFeesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetApplicableTransactionFees: Get the Fees and Commissions that may be applicable to a transaction.
    ApiResponse<ResourceListOfFeeRule> response = apiInstance.GetApplicableTransactionFeesWithHttpInfo(effectiveAt, asAt, instrumentIdentifierType, instrumentIdentifier, portfolioScope, portfolioCode, requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionFeesApi.GetApplicableTransactionFeesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to match rule definitions. Defaults to the current LUSID  system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to match rule definitions. Defaults to returning the latest version if not  specified. | [optional]  |
| **instrumentIdentifierType** | **string?** | Optional. The unique identifier type to use, eg &#39;Figi&#39; or &#39;LusidInstrumentId&#39;. | [optional]  |
| **instrumentIdentifier** | **string?** | Optional. The Instrument Identifier to get properties for. | [optional]  |
| **portfolioScope** | **string?** | Optional. The scope of the portfolio to fetch properties from. | [optional]  |
| **portfolioCode** | **string?** | Optional. The code of the portfolio to fetch properties from. | [optional]  |
| **requestBody** | [**Dictionary&lt;string, string&gt;?**](string.md) | Any other property keys or fields, including the top-level fields of the              fee rule (e.g. \&quot;ExecutionBroker\&quot; and \&quot;SettlementCurrency\&quot; ) and those defined in AdditionalKeys, along with              their corresponding values that should be matched for fees. Eg. \&quot;Instrument/default/Name&#x3D;exampleValue\&quot; or              \&quot;AdditionalKey2&#x3D;Value2\&quot;. | [optional]  |

### Return type

[**ResourceListOfFeeRule**](ResourceListOfFeeRule.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of applicable fee rules. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="gettransactionfeerule"></a>
# **GetTransactionFeeRule**
> FeeRule GetTransactionFeeRule (string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

GetTransactionFeeRule: Retrieve the definition of single fee rule.

Retrieves the fee rule definition at the given effective and as at times.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionFeesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionFeesApi>();
            var code = "code_example";  // string | The fee rule code.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the rule definition. Defaults to the current LUSID  system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the rule definition. Defaults to returning the latest version if not  specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // FeeRule result = apiInstance.GetTransactionFeeRule(code, effectiveAt, asAt, opts: opts);

                // GetTransactionFeeRule: Retrieve the definition of single fee rule.
                FeeRule result = apiInstance.GetTransactionFeeRule(code, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionFeesApi.GetTransactionFeeRule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionFeeRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetTransactionFeeRule: Retrieve the definition of single fee rule.
    ApiResponse<FeeRule> response = apiInstance.GetTransactionFeeRuleWithHttpInfo(code, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionFeesApi.GetTransactionFeeRuleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The fee rule code. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the rule definition. Defaults to the current LUSID  system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the rule definition. Defaults to returning the latest version if not  specified. | [optional]  |

### Return type

[**FeeRule**](FeeRule.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Details of one fee rule. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listtransactionfeerules"></a>
# **ListTransactionFeeRules**
> ResourceListOfFeeRule ListTransactionFeeRules (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, int? limit = null, string? filter = null, string? page = null)

ListTransactionFeeRules: List fee rules, with optional filtering.

For more information about filtering results,  see https://support.lusid.com/knowledgebase/article/KA-01914.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionFeesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionFeesApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the rule definitions. Defaults to the current LUSID  system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the rule definitions. Defaults to returning the latest version if not  specified. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing entities; this value is returned from the previous call. If  a pagination token is provided, the filter, effectiveAt and asAt fields must not have changed since the  original request. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfFeeRule result = apiInstance.ListTransactionFeeRules(effectiveAt, asAt, limit, filter, page, opts: opts);

                // ListTransactionFeeRules: List fee rules, with optional filtering.
                ResourceListOfFeeRule result = apiInstance.ListTransactionFeeRules(effectiveAt, asAt, limit, filter, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionFeesApi.ListTransactionFeeRules: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTransactionFeeRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListTransactionFeeRules: List fee rules, with optional filtering.
    ApiResponse<ResourceListOfFeeRule> response = apiInstance.ListTransactionFeeRulesWithHttpInfo(effectiveAt, asAt, limit, filter, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionFeesApi.ListTransactionFeeRulesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the rule definitions. Defaults to the current LUSID  system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the rule definitions. Defaults to returning the latest version if not  specified. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing entities; this value is returned from the previous call. If  a pagination token is provided, the filter, effectiveAt and asAt fields must not have changed since the  original request. | [optional]  |

### Return type

[**ResourceListOfFeeRule**](ResourceListOfFeeRule.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A filtered list of fee rules available. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upserttransactionfeerules"></a>
# **UpsertTransactionFeeRules**
> FeeRuleUpsertResponse UpsertTransactionFeeRules (Dictionary<string, FeeRuleUpsertRequest> requestBody, DateTimeOrCutLabel? effectiveAt = null)

UpsertTransactionFeeRules: Upsert fee rules.

To upsert a new rule, the code field must be left empty, a code will then be assigned and returned as part  of the response. To update an existing rule, include the fee code. It is possible to both create and update  fee rules in the same request.    The upsert is transactional - either all create/update operations will succeed or none of them will.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionFeesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionFeesApi>();
            var requestBody = new Dictionary<string, FeeRuleUpsertRequest>(); // Dictionary<string, FeeRuleUpsertRequest> | A dictionary of upsert request identifiers to rule upsert requests. The request              identifiers are valid for the request only and can be used to link the upserted fee rule to the code of a              created fee rule.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which the rule will take effect. Defaults to the current LUSID  system datetime if not specified. In the case of an update, the changes will take place from this effective  time until the next effective time that the rule as been upserted at. For example, consider a rule that  already exists, and has previously had an update applied so that the definition will change on the first day  of the coming month. An upsert effective from the current day will only change the definition until the  first day of the coming month. An additional upsert at the same time (first day of the month) is required  if the newly-updated definition is to supersede the future definition. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // FeeRuleUpsertResponse result = apiInstance.UpsertTransactionFeeRules(requestBody, effectiveAt, opts: opts);

                // UpsertTransactionFeeRules: Upsert fee rules.
                FeeRuleUpsertResponse result = apiInstance.UpsertTransactionFeeRules(requestBody, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionFeesApi.UpsertTransactionFeeRules: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertTransactionFeeRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpsertTransactionFeeRules: Upsert fee rules.
    ApiResponse<FeeRuleUpsertResponse> response = apiInstance.UpsertTransactionFeeRulesWithHttpInfo(requestBody, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionFeesApi.UpsertTransactionFeeRulesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, FeeRuleUpsertRequest&gt;**](FeeRuleUpsertRequest.md) | A dictionary of upsert request identifiers to rule upsert requests. The request              identifiers are valid for the request only and can be used to link the upserted fee rule to the code of a              created fee rule. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which the rule will take effect. Defaults to the current LUSID  system datetime if not specified. In the case of an update, the changes will take place from this effective  time until the next effective time that the rule as been upserted at. For example, consider a rule that  already exists, and has previously had an update applied so that the definition will change on the first day  of the coming month. An upsert effective from the current day will only change the definition until the  first day of the coming month. An additional upsert at the same time (first day of the month) is required  if the newly-updated definition is to supersede the future definition. | [optional]  |

### Return type

[**FeeRuleUpsertResponse**](FeeRuleUpsertResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Upsert fee rules. New fee rules must have an empty code field. Where a code is given, this rule must already exist and will be updated. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

