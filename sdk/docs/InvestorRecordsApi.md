# Lusid.Sdk.Api.InvestorRecordsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UpsertInvestorRecords**](InvestorRecordsApi.md#upsertinvestorrecords) | **POST** /api/investorrecords/$batchUpsert | [EARLY ACCESS] UpsertInvestorRecords: Pluralised upsert of Investor Records |

<a id="upsertinvestorrecords"></a>
# **UpsertInvestorRecords**
> UpsertInvestorRecordsResponse UpsertInvestorRecords (string successMode, Dictionary<string, UpsertInvestorRecordRequest> requestBody)

[EARLY ACCESS] UpsertInvestorRecords: Pluralised upsert of Investor Records

Creates or updates a collection of Investor Records

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InvestorRecordsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InvestorRecordsApi>();
            var successMode = "successMode_example";  // string | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial
            var requestBody = new Dictionary<string, UpsertInvestorRecordRequest>(); // Dictionary<string, UpsertInvestorRecordRequest> | A collection of requests to create or update Investor Records.

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertInvestorRecordsResponse result = apiInstance.UpsertInvestorRecords(successMode, requestBody, opts: opts);

                // [EARLY ACCESS] UpsertInvestorRecords: Pluralised upsert of Investor Records
                UpsertInvestorRecordsResponse result = apiInstance.UpsertInvestorRecords(successMode, requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InvestorRecordsApi.UpsertInvestorRecords: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertInvestorRecordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpsertInvestorRecords: Pluralised upsert of Investor Records
    ApiResponse<UpsertInvestorRecordsResponse> response = apiInstance.UpsertInvestorRecordsWithHttpInfo(successMode, requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InvestorRecordsApi.UpsertInvestorRecordsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **successMode** | **string** | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial |  |
| **requestBody** | [**Dictionary&lt;string, UpsertInvestorRecordRequest&gt;**](UpsertInvestorRecordRequest.md) | A collection of requests to create or update Investor Records. |  |

### Return type

[**UpsertInvestorRecordsResponse**](UpsertInvestorRecordsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The successfully created or updated investor records along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

