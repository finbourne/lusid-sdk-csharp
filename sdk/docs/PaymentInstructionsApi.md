# Lusid.Sdk.Api.PaymentInstructionsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeletePaymentInstruction**](PaymentInstructionsApi.md#deletepaymentinstruction) | **DELETE** /api/paymentinstructions/{scope}/{code} | [EXPERIMENTAL] DeletePaymentInstruction: Delete Payment Instruction |
| [**GetPaymentInstruction**](PaymentInstructionsApi.md#getpaymentinstruction) | **GET** /api/paymentinstructions/{scope}/{code} | [EXPERIMENTAL] GetPaymentInstruction: Get Payment Instruction |
| [**UpsertPaymentInstructions**](PaymentInstructionsApi.md#upsertpaymentinstructions) | **POST** /api/paymentinstructions | [EXPERIMENTAL] UpsertPaymentInstructions: Upsert Payment Instructions |

<a id="deletepaymentinstruction"></a>
# **DeletePaymentInstruction**
> DeletedEntityResponse DeletePaymentInstruction (string scope, string code)

[EXPERIMENTAL] DeletePaymentInstruction: Delete Payment Instruction

Delete a Payment Instruction. Deletion will be valid from the payment instruction's creation datetime.  This means that the payment instruction will no longer exist at any effective datetime from the asAt datetime  of deletion. Any payment records the instruction owns are released and become available to another instruction.  A payment instruction that has been released, instructed, sent, cancelled or failed cannot be deleted.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PaymentInstructionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PaymentInstructionsApi>();
            var scope = "scope_example";  // string | The scope of the payment instruction.
            var code = "code_example";  // string | The code of the payment instruction.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeletePaymentInstruction(scope, code, opts: opts);

                // [EXPERIMENTAL] DeletePaymentInstruction: Delete Payment Instruction
                DeletedEntityResponse result = apiInstance.DeletePaymentInstruction(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PaymentInstructionsApi.DeletePaymentInstruction: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePaymentInstructionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeletePaymentInstruction: Delete Payment Instruction
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeletePaymentInstructionWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PaymentInstructionsApi.DeletePaymentInstructionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the payment instruction. |  |
| **code** | **string** | The code of the payment instruction. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The response from deleting the payment instruction |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getpaymentinstruction"></a>
# **GetPaymentInstruction**
> PaymentInstruction GetPaymentInstruction (string scope, string code, List<string>? propertyKeys = null, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetPaymentInstruction: Get Payment Instruction

Retrieve a single Payment Instruction.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PaymentInstructionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PaymentInstructionsApi>();
            var scope = "scope_example";  // string | The scope of the payment instruction.
            var code = "code_example";  // string | The code of the payment instruction.
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the \"PaymentInstruction\" domain to decorate onto the              payment instruction. These take the format {domain}/{scope}/{code} e.g. \"PaymentInstruction/myScope/myProperty\". (optional) 
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the payment instruction.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the payment instruction. Defaults to return the latest              version of the payment instruction if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PaymentInstruction result = apiInstance.GetPaymentInstruction(scope, code, propertyKeys, effectiveAt, asAt, opts: opts);

                // [EXPERIMENTAL] GetPaymentInstruction: Get Payment Instruction
                PaymentInstruction result = apiInstance.GetPaymentInstruction(scope, code, propertyKeys, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PaymentInstructionsApi.GetPaymentInstruction: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPaymentInstructionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetPaymentInstruction: Get Payment Instruction
    ApiResponse<PaymentInstruction> response = apiInstance.GetPaymentInstructionWithHttpInfo(scope, code, propertyKeys, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PaymentInstructionsApi.GetPaymentInstructionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the payment instruction. |  |
| **code** | **string** | The code of the payment instruction. |  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the \&quot;PaymentInstruction\&quot; domain to decorate onto the              payment instruction. These take the format {domain}/{scope}/{code} e.g. \&quot;PaymentInstruction/myScope/myProperty\&quot;. | [optional]  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the payment instruction.              Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the payment instruction. Defaults to return the latest              version of the payment instruction if not specified. | [optional]  |

### Return type

[**PaymentInstruction**](PaymentInstruction.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested payment instruction |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertpaymentinstructions"></a>
# **UpsertPaymentInstructions**
> PaymentInstructionsResponse UpsertPaymentInstructions (Dictionary<string, PaymentInstructionRequest> requestBody)

[EXPERIMENTAL] UpsertPaymentInstructions: Upsert Payment Instructions

Create or update a collection of Payment Instructions.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PaymentInstructionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PaymentInstructionsApi>();
            var requestBody = new Dictionary<string, PaymentInstructionRequest>(); // Dictionary<string, PaymentInstructionRequest> | A collection of requests to create or update Payment Instructions.

            try
            {
                // uncomment the below to set overrides at the request level
                // PaymentInstructionsResponse result = apiInstance.UpsertPaymentInstructions(requestBody, opts: opts);

                // [EXPERIMENTAL] UpsertPaymentInstructions: Upsert Payment Instructions
                PaymentInstructionsResponse result = apiInstance.UpsertPaymentInstructions(requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PaymentInstructionsApi.UpsertPaymentInstructions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertPaymentInstructionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertPaymentInstructions: Upsert Payment Instructions
    ApiResponse<PaymentInstructionsResponse> response = apiInstance.UpsertPaymentInstructionsWithHttpInfo(requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PaymentInstructionsApi.UpsertPaymentInstructionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, PaymentInstructionRequest&gt;**](PaymentInstructionRequest.md) | A collection of requests to create or update Payment Instructions. |  |

### Return type

[**PaymentInstructionsResponse**](PaymentInstructionsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The successfully created or updated payment instructions along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

