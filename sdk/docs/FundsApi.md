# Lusid.Sdk.Api.FundsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AcceptEstimatePoint**](FundsApi.md#acceptestimatepoint) | **POST** /api/funds/{scope}/{code}/valuationpoints/$acceptestimate | [EXPERIMENTAL] AcceptEstimatePoint: Accepts an Estimate Valuation Point. |
| [**CreateFee**](FundsApi.md#createfee) | **POST** /api/funds/{scope}/{code}/fees/{feeCode} | [EXPERIMENTAL] CreateFee: Create a Fee. |
| [**CreateFund**](FundsApi.md#createfund) | **POST** /api/funds/{scope} | [EXPERIMENTAL] CreateFund: Create a Fund. |
| [**DeleteFee**](FundsApi.md#deletefee) | **DELETE** /api/funds/{scope}/{code}/fees/{feeCode} | [EXPERIMENTAL] DeleteFee: Delete a Fee. |
| [**DeleteFund**](FundsApi.md#deletefund) | **DELETE** /api/funds/{scope}/{code} | [EXPERIMENTAL] DeleteFund: Delete a Fund. |
| [**DeleteValuationPoint**](FundsApi.md#deletevaluationpoint) | **DELETE** /api/funds/{scope}/{code}/valuationpoints/{diaryEntryCode} | [EXPERIMENTAL] DeleteValuationPoint: Delete a Valuation Point. |
| [**FinaliseCandidateValuation**](FundsApi.md#finalisecandidatevaluation) | **POST** /api/funds/{scope}/{code}/valuationpoints/$finalisecandidate | [EXPERIMENTAL] FinaliseCandidateValuation: Finalise Candidate. |
| [**GetFee**](FundsApi.md#getfee) | **GET** /api/funds/{scope}/{code}/fees/{feeCode} | [EXPERIMENTAL] GetFee: Get a Fee for a specified Fund. |
| [**GetFund**](FundsApi.md#getfund) | **GET** /api/funds/{scope}/{code} | [EXPERIMENTAL] GetFund: Get a Fund. |
| [**GetValuationPointData**](FundsApi.md#getvaluationpointdata) | **POST** /api/funds/{scope}/{code}/valuationpoints | [EXPERIMENTAL] GetValuationPointData: Get Valuation Point Data for a Fund. |
| [**ListFees**](FundsApi.md#listfees) | **GET** /api/funds/{scope}/{code}/fees | [EXPERIMENTAL] ListFees: List Fees for a specified Fund. |
| [**ListFunds**](FundsApi.md#listfunds) | **GET** /api/funds | [EXPERIMENTAL] ListFunds: List Funds. |
| [**PatchFee**](FundsApi.md#patchfee) | **PATCH** /api/funds/{scope}/{code}/fees/{feeCode} | [EXPERIMENTAL] PatchFee: Patch Fee. |
| [**SetShareClassInstruments**](FundsApi.md#setshareclassinstruments) | **PUT** /api/funds/{scope}/{code}/shareclasses | [EXPERIMENTAL] SetShareClassInstruments: Set the ShareClass Instruments on a fund. |
| [**UpsertFundProperties**](FundsApi.md#upsertfundproperties) | **POST** /api/funds/{scope}/{code}/properties/$upsert | [EXPERIMENTAL] UpsertFundProperties: Upsert Fund properties. |
| [**UpsertValuationPoint**](FundsApi.md#upsertvaluationpoint) | **POST** /api/funds/{scope}/{code}/valuationpoints/$upsert | [EXPERIMENTAL] UpsertValuationPoint: Upsert Valuation Point. |

<a id="acceptestimatepoint"></a>
# **AcceptEstimatePoint**
> ValuationPointDataResponse AcceptEstimatePoint (string scope, string code, ValuationPointDataRequest valuationPointDataRequest)

[EXPERIMENTAL] AcceptEstimatePoint: Accepts an Estimate Valuation Point.

Accepts the specified estimate Valuation Point. Should the Valuation Point differ since the valuation Point was last run, status will be marked as 'Candidate', otherwise it will be marked as 'Final'

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class AcceptEstimatePointExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var valuationPointDataRequest = new ValuationPointDataRequest(); // ValuationPointDataRequest | The valuationPointDataRequest which contains the Diary Entry code for the Estimate Valuation Point to move to Final state.

            try
            {
                // [EXPERIMENTAL] AcceptEstimatePoint: Accepts an Estimate Valuation Point.
                ValuationPointDataResponse result = apiInstance.AcceptEstimatePoint(scope, code, valuationPointDataRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.AcceptEstimatePoint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AcceptEstimatePointWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] AcceptEstimatePoint: Accepts an Estimate Valuation Point.
    ApiResponse<ValuationPointDataResponse> response = apiInstance.AcceptEstimatePointWithHttpInfo(scope, code, valuationPointDataRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.AcceptEstimatePointWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **valuationPointDataRequest** | [**ValuationPointDataRequest**](ValuationPointDataRequest.md) | The valuationPointDataRequest which contains the Diary Entry code for the Estimate Valuation Point to move to Final state. |  |

### Return type

[**ValuationPointDataResponse**](ValuationPointDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Accepted Estimate point and status after being Accepted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createfee"></a>
# **CreateFee**
> Fee CreateFee (string scope, string code, string feeCode, FeeRequest feeRequest)

[EXPERIMENTAL] CreateFee: Create a Fee.

Create the given Fee.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var feeCode = "feeCode_example";  // string | The code of the Fee.
            var feeRequest = new FeeRequest(); // FeeRequest | The Fee to create.

            try
            {
                // [EXPERIMENTAL] CreateFee: Create a Fee.
                Fee result = apiInstance.CreateFee(scope, code, feeCode, feeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.CreateFee: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFeeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateFee: Create a Fee.
    ApiResponse<Fee> response = apiInstance.CreateFeeWithHttpInfo(scope, code, feeCode, feeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.CreateFeeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **feeCode** | **string** | The code of the Fee. |  |
| **feeRequest** | [**FeeRequest**](FeeRequest.md) | The Fee to create. |  |

### Return type

[**Fee**](Fee.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created Fee. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createfund"></a>
# **CreateFund**
> Fund CreateFund (string scope, FundRequest fundRequest)

[EXPERIMENTAL] CreateFund: Create a Fund.

Create the given Fund.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateFundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var scope = "scope_example";  // string | The scope of the Fund.
            var fundRequest = new FundRequest(); // FundRequest | The definition of the Fund.

            try
            {
                // [EXPERIMENTAL] CreateFund: Create a Fund.
                Fund result = apiInstance.CreateFund(scope, fundRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.CreateFund: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateFund: Create a Fund.
    ApiResponse<Fund> response = apiInstance.CreateFundWithHttpInfo(scope, fundRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.CreateFundWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **fundRequest** | [**FundRequest**](FundRequest.md) | The definition of the Fund. |  |

### Return type

[**Fund**](Fund.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created Fund. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletefee"></a>
# **DeleteFee**
> DeletedEntityResponse DeleteFee (string scope, string code, string feeCode)

[EXPERIMENTAL] DeleteFee: Delete a Fee.

Delete the given Fee.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var scope = "scope_example";  // string | The scope of the Fund
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var feeCode = "feeCode_example";  // string | The code of the Fee to be deleted.

            try
            {
                // [EXPERIMENTAL] DeleteFee: Delete a Fee.
                DeletedEntityResponse result = apiInstance.DeleteFee(scope, code, feeCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.DeleteFee: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFeeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteFee: Delete a Fee.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteFeeWithHttpInfo(scope, code, feeCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.DeleteFeeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **feeCode** | **string** | The code of the Fee to be deleted. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the Fee was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletefund"></a>
# **DeleteFund**
> DeletedEntityResponse DeleteFund (string scope, string code)

[EXPERIMENTAL] DeleteFund: Delete a Fund.

Delete the given Fund.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteFundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var scope = "scope_example";  // string | The scope of the Fund to be deleted.
            var code = "code_example";  // string | The code of the Fund to be deleted. Together with the scope this uniquely identifies the Fund.

            try
            {
                // [EXPERIMENTAL] DeleteFund: Delete a Fund.
                DeletedEntityResponse result = apiInstance.DeleteFund(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.DeleteFund: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteFund: Delete a Fund.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteFundWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.DeleteFundWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund to be deleted. |  |
| **code** | **string** | The code of the Fund to be deleted. Together with the scope this uniquely identifies the Fund. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the Fund was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletevaluationpoint"></a>
# **DeleteValuationPoint**
> DeletedEntityResponse DeleteValuationPoint (string scope, string code, string diaryEntryCode)

[EXPERIMENTAL] DeleteValuationPoint: Delete a Valuation Point.

Deletes the given Valuation Point.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteValuationPointExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var scope = "scope_example";  // string | The scope of the Fund for the valuation point to be deleted.
            var code = "code_example";  // string | The code of the Fund containing the Valuation Point to be deleted. Together with the scope this uniquely identifies the Fund.
            var diaryEntryCode = "diaryEntryCode_example";  // string | The diary entry code for the valuation Point to be deleted.

            try
            {
                // [EXPERIMENTAL] DeleteValuationPoint: Delete a Valuation Point.
                DeletedEntityResponse result = apiInstance.DeleteValuationPoint(scope, code, diaryEntryCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.DeleteValuationPoint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteValuationPointWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteValuationPoint: Delete a Valuation Point.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteValuationPointWithHttpInfo(scope, code, diaryEntryCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.DeleteValuationPointWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund for the valuation point to be deleted. |  |
| **code** | **string** | The code of the Fund containing the Valuation Point to be deleted. Together with the scope this uniquely identifies the Fund. |  |
| **diaryEntryCode** | **string** | The diary entry code for the valuation Point to be deleted. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the Valuation Point was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="finalisecandidatevaluation"></a>
# **FinaliseCandidateValuation**
> ValuationPointDataResponse FinaliseCandidateValuation (string scope, string code, ValuationPointDataRequest valuationPointDataRequest)

[EXPERIMENTAL] FinaliseCandidateValuation: Finalise Candidate.

Moves a 'Candidate' status Valuation Point to status 'Final'.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class FinaliseCandidateValuationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var valuationPointDataRequest = new ValuationPointDataRequest(); // ValuationPointDataRequest | The valuationPointDataRequest which contains the diary entry code to mark as final.

            try
            {
                // [EXPERIMENTAL] FinaliseCandidateValuation: Finalise Candidate.
                ValuationPointDataResponse result = apiInstance.FinaliseCandidateValuation(scope, code, valuationPointDataRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.FinaliseCandidateValuation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FinaliseCandidateValuationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] FinaliseCandidateValuation: Finalise Candidate.
    ApiResponse<ValuationPointDataResponse> response = apiInstance.FinaliseCandidateValuationWithHttpInfo(scope, code, valuationPointDataRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.FinaliseCandidateValuationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **valuationPointDataRequest** | [**ValuationPointDataRequest**](ValuationPointDataRequest.md) | The valuationPointDataRequest which contains the diary entry code to mark as final. |  |

### Return type

[**ValuationPointDataResponse**](ValuationPointDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated Valuation Point response as a result of it be marked as Final. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfee"></a>
# **GetFee**
> Fee GetFee (string scope, string code, string feeCode, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetFee: Get a Fee for a specified Fund.

Retrieve a fee for a specified Fund

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var feeCode = "feeCode_example";  // string | The code of the Fee.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the Fee properties. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Fee. Defaults to returning the latest version of the Fee if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Fee' domain to decorate onto the Fee.              These must take the format {domain}/{scope}/{code}, for example 'Fee/Account/Id'. If no properties are specified, then no properties will be returned. (optional) 

            try
            {
                // [EXPERIMENTAL] GetFee: Get a Fee for a specified Fund.
                Fee result = apiInstance.GetFee(scope, code, feeCode, effectiveAt, asAt, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.GetFee: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFeeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetFee: Get a Fee for a specified Fund.
    ApiResponse<Fee> response = apiInstance.GetFeeWithHttpInfo(scope, code, feeCode, effectiveAt, asAt, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.GetFeeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **feeCode** | **string** | The code of the Fee. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the Fee properties. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Fee. Defaults to returning the latest version of the Fee if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Fee&#39; domain to decorate onto the Fee.              These must take the format {domain}/{scope}/{code}, for example &#39;Fee/Account/Id&#39;. If no properties are specified, then no properties will be returned. | [optional]  |

### Return type

[**Fee**](Fee.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Fee definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfund"></a>
# **GetFund**
> Fund GetFund (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetFund: Get a Fund.

Retrieve the definition of a particular Fund.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetFundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the Fund properties. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Fund definition. Defaults to returning the latest version of the Fund definition if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Fund' domain to decorate onto the Fund.              These must take the format {domain}/{scope}/{code}, for example 'Fund/Manager/Id'. If no properties are specified, then no properties will be returned. (optional) 

            try
            {
                // [EXPERIMENTAL] GetFund: Get a Fund.
                Fund result = apiInstance.GetFund(scope, code, effectiveAt, asAt, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.GetFund: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetFund: Get a Fund.
    ApiResponse<Fund> response = apiInstance.GetFundWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.GetFundWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the Fund properties. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Fund definition. Defaults to returning the latest version of the Fund definition if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Fund&#39; domain to decorate onto the Fund.              These must take the format {domain}/{scope}/{code}, for example &#39;Fund/Manager/Id&#39;. If no properties are specified, then no properties will be returned. | [optional]  |

### Return type

[**Fund**](Fund.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Fund definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getvaluationpointdata"></a>
# **GetValuationPointData**
> ValuationPointDataResponse GetValuationPointData (string scope, string code, ValuationPointDataQueryParameters valuationPointDataQueryParameters, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetValuationPointData: Get Valuation Point Data for a Fund.

Retrieves the Valuation Point data for a date or specified Diary Entry Id.  The endpoint will internally extract all 'Assets' and 'Liabilities' from the related ABOR's Trial balance to produce a GAV.  Start date will be assumed from the last 'official' DiaryEntry and EndDate will be as provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetValuationPointDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var valuationPointDataQueryParameters = new ValuationPointDataQueryParameters(); // ValuationPointDataQueryParameters | The arguments to use for querying the Valuation Point data
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Fund definition. Defaults to returning the latest version of the Fund definition if not specified. (optional) 

            try
            {
                // [EXPERIMENTAL] GetValuationPointData: Get Valuation Point Data for a Fund.
                ValuationPointDataResponse result = apiInstance.GetValuationPointData(scope, code, valuationPointDataQueryParameters, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.GetValuationPointData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetValuationPointDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetValuationPointData: Get Valuation Point Data for a Fund.
    ApiResponse<ValuationPointDataResponse> response = apiInstance.GetValuationPointDataWithHttpInfo(scope, code, valuationPointDataQueryParameters, asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.GetValuationPointDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **valuationPointDataQueryParameters** | [**ValuationPointDataQueryParameters**](ValuationPointDataQueryParameters.md) | The arguments to use for querying the Valuation Point data |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Fund definition. Defaults to returning the latest version of the Fund definition if not specified. | [optional]  |

### Return type

[**ValuationPointDataResponse**](ValuationPointDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The specified Valuation Point for the Fund. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listfees"></a>
# **ListFees**
> PagedResourceListOfFee ListFees (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListFees: List Fees for a specified Fund.

List all the Fees matching a particular criteria.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListFeesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the TimeVariant properties for the Fees. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Fees. Defaults to returning the latest version of each Fee if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing fees; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the treatment, specify \"treatment eq 'Monthly'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Fee' domain to decorate onto each Fee.              These must take the format {domain}/{scope}/{code}, for example 'Fee/Account/Id'. (optional) 

            try
            {
                // [EXPERIMENTAL] ListFees: List Fees for a specified Fund.
                PagedResourceListOfFee result = apiInstance.ListFees(scope, code, effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.ListFees: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListFeesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListFees: List Fees for a specified Fund.
    ApiResponse<PagedResourceListOfFee> response = apiInstance.ListFeesWithHttpInfo(scope, code, effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.ListFeesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the TimeVariant properties for the Fees. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Fees. Defaults to returning the latest version of each Fee if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing fees; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the treatment, specify \&quot;treatment eq &#39;Monthly&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Fee&#39; domain to decorate onto each Fee.              These must take the format {domain}/{scope}/{code}, for example &#39;Fee/Account/Id&#39;. | [optional]  |

### Return type

[**PagedResourceListOfFee**](PagedResourceListOfFee.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Fees. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listfunds"></a>
# **ListFunds**
> PagedResourceListOfFund ListFunds (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListFunds: List Funds.

List all the Funds matching particular criteria.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListFundsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the TimeVariant properties for the Funds. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Funds. Defaults to returning the latest version of each Fund if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Funds; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the Fund type, specify \"id.Code eq 'Fund1'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Fund' domain to decorate onto each Fund.              These must take the format {domain}/{scope}/{code}, for example 'Fund/Manager/Id'. (optional) 

            try
            {
                // [EXPERIMENTAL] ListFunds: List Funds.
                PagedResourceListOfFund result = apiInstance.ListFunds(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.ListFunds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListFundsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListFunds: List Funds.
    ApiResponse<PagedResourceListOfFund> response = apiInstance.ListFundsWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.ListFundsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the TimeVariant properties for the Funds. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Funds. Defaults to returning the latest version of each Fund if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Funds; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the Fund type, specify \&quot;id.Code eq &#39;Fund1&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Fund&#39; domain to decorate onto each Fund.              These must take the format {domain}/{scope}/{code}, for example &#39;Fund/Manager/Id&#39;. | [optional]  |

### Return type

[**PagedResourceListOfFund**](PagedResourceListOfFund.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Funds. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="patchfee"></a>
# **PatchFee**
> Fee PatchFee (string scope, string code, string feeCode, List<Operation> operation)

[EXPERIMENTAL] PatchFee: Patch Fee.

Create or update certain fields for a particular Fee.  The behaviour is defined by the JSON Patch specification.                Currently supported fields are: EndDate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class PatchFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var feeCode = "feeCode_example";  // string | The code of the Fee.
            var operation = new List<Operation>(); // List<Operation> | The json patch document. For more information see: https://datatracker.ietf.org/doc/html/rfc6902.

            try
            {
                // [EXPERIMENTAL] PatchFee: Patch Fee.
                Fee result = apiInstance.PatchFee(scope, code, feeCode, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.PatchFee: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchFeeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PatchFee: Patch Fee.
    ApiResponse<Fee> response = apiInstance.PatchFeeWithHttpInfo(scope, code, feeCode, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.PatchFeeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **feeCode** | **string** | The code of the Fee. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | The json patch document. For more information see: https://datatracker.ietf.org/doc/html/rfc6902. |  |

### Return type

[**Fee**](Fee.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The newly patched Fee. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setshareclassinstruments"></a>
# **SetShareClassInstruments**
> Fund SetShareClassInstruments (string scope, string code, SetShareClassInstrumentsRequest setShareClassInstrumentsRequest)

[EXPERIMENTAL] SetShareClassInstruments: Set the ShareClass Instruments on a fund.

Update the ShareClass Instruments on an existing fund with the set of instruments provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class SetShareClassInstrumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund.
            var setShareClassInstrumentsRequest = new SetShareClassInstrumentsRequest(); // SetShareClassInstrumentsRequest | The scopes and instrument identifiers for the instruments to be set.

            try
            {
                // [EXPERIMENTAL] SetShareClassInstruments: Set the ShareClass Instruments on a fund.
                Fund result = apiInstance.SetShareClassInstruments(scope, code, setShareClassInstrumentsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.SetShareClassInstruments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetShareClassInstrumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] SetShareClassInstruments: Set the ShareClass Instruments on a fund.
    ApiResponse<Fund> response = apiInstance.SetShareClassInstrumentsWithHttpInfo(scope, code, setShareClassInstrumentsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.SetShareClassInstrumentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. |  |
| **setShareClassInstrumentsRequest** | [**SetShareClassInstrumentsRequest**](SetShareClassInstrumentsRequest.md) | The scopes and instrument identifiers for the instruments to be set. |  |

### Return type

[**Fund**](Fund.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The updated fund. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertfundproperties"></a>
# **UpsertFundProperties**
> FundProperties UpsertFundProperties (string scope, string code, Dictionary<string, Property>? requestBody = null)

[EXPERIMENTAL] UpsertFundProperties: Upsert Fund properties.

Update or insert one or more properties onto a single Fund. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain 'Fund'.                Upserting a property that exists for an Fund, with a null value, will delete the instance of the property for that group.                Properties have an <i>effectiveFrom</i> datetime for which the property is valid, and an <i>effectiveUntil</i>  datetime until which the property is valid. Not supplying an <i>effectiveUntil</i> datetime results in the property being  valid indefinitely, or until the next <i>effectiveFrom</i> datetime of the property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertFundPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var scope = "scope_example";  // string | The scope of the Fund to update or insert the properties onto.
            var code = "code_example";  // string | The code of the Fund to update or insert the properties onto. Together with the scope this uniquely identifies the Fund.
            var requestBody = new Dictionary<string, Property>?(); // Dictionary<string, Property>? | The properties to be updated or inserted onto the Fund. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \"Fund/Manager/Id\". (optional) 

            try
            {
                // [EXPERIMENTAL] UpsertFundProperties: Upsert Fund properties.
                FundProperties result = apiInstance.UpsertFundProperties(scope, code, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.UpsertFundProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertFundPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertFundProperties: Upsert Fund properties.
    ApiResponse<FundProperties> response = apiInstance.UpsertFundPropertiesWithHttpInfo(scope, code, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.UpsertFundPropertiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund to update or insert the properties onto. |  |
| **code** | **string** | The code of the Fund to update or insert the properties onto. Together with the scope this uniquely identifies the Fund. |  |
| **requestBody** | [**Dictionary&lt;string, Property&gt;?**](Property.md) | The properties to be updated or inserted onto the Fund. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;Fund/Manager/Id\&quot;. | [optional]  |

### Return type

[**FundProperties**](FundProperties.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated or inserted properties |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertvaluationpoint"></a>
# **UpsertValuationPoint**
> DiaryEntry UpsertValuationPoint (string scope, string code, UpsertValuationPointRequest upsertValuationPointRequest)

[EXPERIMENTAL] UpsertValuationPoint: Upsert Valuation Point.

Update or insert the estimate Valuation Point.                If the Valuation Point does not exist, this method will create it in estimate state.                If the Valuation Point already exists and is in estimate state, the Valuation Point will be updated with the newly specified information in this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertValuationPointExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var upsertValuationPointRequest = new UpsertValuationPointRequest(); // UpsertValuationPointRequest | The Valuation Point Estimate definition to Upsert

            try
            {
                // [EXPERIMENTAL] UpsertValuationPoint: Upsert Valuation Point.
                DiaryEntry result = apiInstance.UpsertValuationPoint(scope, code, upsertValuationPointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.UpsertValuationPoint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertValuationPointWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertValuationPoint: Upsert Valuation Point.
    ApiResponse<DiaryEntry> response = apiInstance.UpsertValuationPointWithHttpInfo(scope, code, upsertValuationPointRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.UpsertValuationPointWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **upsertValuationPointRequest** | [**UpsertValuationPointRequest**](UpsertValuationPointRequest.md) | The Valuation Point Estimate definition to Upsert |  |

### Return type

[**DiaryEntry**](DiaryEntry.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated or inserted estimated Valuation Point |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

