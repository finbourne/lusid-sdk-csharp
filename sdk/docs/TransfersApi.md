# Lusid.Sdk.Api.TransfersApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTransfer**](TransfersApi.md#createtransfer) | **POST** /api/transfers | [EXPERIMENTAL] CreateTransfer: Create a transfer. |
| [**DeleteTransfer**](TransfersApi.md#deletetransfer) | **DELETE** /api/transfers/{scope}/{code} | [EXPERIMENTAL] DeleteTransfer: Delete a transfer. |
| [**GetTransfer**](TransfersApi.md#gettransfer) | **POST** /api/transfers/$get | [EXPERIMENTAL] GetTransfer: Get a transfer |

<a id="createtransfer"></a>
# **CreateTransfer**
> CreateTransferResponse CreateTransfer (CreateTransferRequest createTransferRequest)

[EXPERIMENTAL] CreateTransfer: Create a transfer.

Move a position between two portfolios, exchange one instrument for another within a portfolio, or do  both at once.  The outgoing and incoming transaction legs and the Transfer entity recording them are written as a single  atomic operation: if any part of the request is rejected, nothing is written.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransfersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransfersApi>();
            var createTransferRequest = new CreateTransferRequest(); // CreateTransferRequest | The transfer to create.

            try
            {
                // uncomment the below to set overrides at the request level
                // CreateTransferResponse result = apiInstance.CreateTransfer(createTransferRequest, opts: opts);

                // [EXPERIMENTAL] CreateTransfer: Create a transfer.
                CreateTransferResponse result = apiInstance.CreateTransfer(createTransferRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransfersApi.CreateTransfer: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTransferWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateTransfer: Create a transfer.
    ApiResponse<CreateTransferResponse> response = apiInstance.CreateTransferWithHttpInfo(createTransferRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransfersApi.CreateTransferWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTransferRequest** | [**CreateTransferRequest**](CreateTransferRequest.md) | The transfer to create. |  |

### Return type

[**CreateTransferResponse**](CreateTransferResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The transfer that was created. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletetransfer"></a>
# **DeleteTransfer**
> DeletedEntityResponse DeleteTransfer (string scope, string code, string portfolioScopeOut, string portfolioCodeOut, string portfolioScopeIn, string portfolioCodeIn)

[EXPERIMENTAL] DeleteTransfer: Delete a transfer.

Delete the Transfer entity recording a transfer and cancel the transaction legs it still has, as a single  atomic operation: if any part of the request is rejected, nothing is changed. A leg that has already gone is  skipped, so a transfer with no legs left can still be deleted to clear the record.                A transfer is identified by its scope, its code and both of its portfolios, so all four are required. Where  no transfer matches all four, the request is reported as not found.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransfersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransfersApi>();
            var scope = "scope_example";  // string | The scope of the transfer.
            var code = "code_example";  // string | The code of the transfer. Together with the scope and both portfolios this uniquely               identifies the transfer.
            var portfolioScopeOut = "portfolioScopeOut_example";  // string | The scope of the portfolio the outgoing leg is booked in.
            var portfolioCodeOut = "portfolioCodeOut_example";  // string | The code of the portfolio the outgoing leg is booked in.
            var portfolioScopeIn = "portfolioScopeIn_example";  // string | The scope of the portfolio the incoming leg is booked in.
            var portfolioCodeIn = "portfolioCodeIn_example";  // string | The code of the portfolio the incoming leg is booked in. Equal to               portfolioCodeOut for a switch between instruments within one portfolio.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteTransfer(scope, code, portfolioScopeOut, portfolioCodeOut, portfolioScopeIn, portfolioCodeIn, opts: opts);

                // [EXPERIMENTAL] DeleteTransfer: Delete a transfer.
                DeletedEntityResponse result = apiInstance.DeleteTransfer(scope, code, portfolioScopeOut, portfolioCodeOut, portfolioScopeIn, portfolioCodeIn);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransfersApi.DeleteTransfer: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTransferWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteTransfer: Delete a transfer.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteTransferWithHttpInfo(scope, code, portfolioScopeOut, portfolioCodeOut, portfolioScopeIn, portfolioCodeIn);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransfersApi.DeleteTransferWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transfer. |  |
| **code** | **string** | The code of the transfer. Together with the scope and both portfolios this uniquely               identifies the transfer. |  |
| **portfolioScopeOut** | **string** | The scope of the portfolio the outgoing leg is booked in. |  |
| **portfolioCodeOut** | **string** | The code of the portfolio the outgoing leg is booked in. |  |
| **portfolioScopeIn** | **string** | The scope of the portfolio the incoming leg is booked in. |  |
| **portfolioCodeIn** | **string** | The code of the portfolio the incoming leg is booked in. Equal to               portfolioCodeOut for a switch between instruments within one portfolio. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The asAt the deletion landed at. |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No transfer with the given scope, code and portfolios. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="gettransfer"></a>
# **GetTransfer**
> GetTransferResponse GetTransfer (GetTransferRequest getTransferRequest, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetTransfer: Get a transfer

Retrieve a transfer and both of the transactions it booked.  A transfer is identified by its scope, its code and both of its portfolios, so all four are supplied in  the request body rather than in the path.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransfersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransfersApi>();
            var getTransferRequest = new GetTransferRequest(); // GetTransferRequest | The transfer to retrieve.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the transfer. Defaults to latest              version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // GetTransferResponse result = apiInstance.GetTransfer(getTransferRequest, asAt, opts: opts);

                // [EXPERIMENTAL] GetTransfer: Get a transfer
                GetTransferResponse result = apiInstance.GetTransfer(getTransferRequest, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransfersApi.GetTransfer: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransferWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetTransfer: Get a transfer
    ApiResponse<GetTransferResponse> response = apiInstance.GetTransferWithHttpInfo(getTransferRequest, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransfersApi.GetTransferWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getTransferRequest** | [**GetTransferRequest**](GetTransferRequest.md) | The transfer to retrieve. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the transfer. Defaults to latest              version if not specified. | [optional]  |

### Return type

[**GetTransferResponse**](GetTransferResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested transfer and both of its transactions. |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No transfer exists with the requested scope, code and portfolios. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

