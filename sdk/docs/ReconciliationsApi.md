# Lusid.Sdk.Api.ReconciliationsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateScheduledReconciliation**](ReconciliationsApi.md#createscheduledreconciliation) | **POST** /api/portfolios/$scheduledReconciliations/{scope} | [EXPERIMENTAL] CreateScheduledReconciliation: Create a scheduled reconciliation |
| [**DeleteReconciliation**](ReconciliationsApi.md#deletereconciliation) | **DELETE** /api/portfolios/$scheduledReconciliations/{scope}/{code} | [EXPERIMENTAL] DeleteReconciliation: Delete scheduled reconciliation |
| [**DeleteReconciliationBreak**](ReconciliationsApi.md#deletereconciliationbreak) | **DELETE** /api/portfolios/$scheduledReconciliations/{scope}/{code}/runs/{runDate}/{version}/breaks/{breakId} | [EXPERIMENTAL] DeleteReconciliationBreak: Delete reconciliation break |
| [**DeleteReconciliationMapping**](ReconciliationsApi.md#deletereconciliationmapping) | **DELETE** /api/portfolios/mapping/{scope}/{code} | [EARLY ACCESS] DeleteReconciliationMapping: Delete a mapping |
| [**DeleteReconciliationRun**](ReconciliationsApi.md#deletereconciliationrun) | **DELETE** /api/portfolios/$scheduledReconciliations/{scope}/{code}/runs/{runDate}/{version} | [EXPERIMENTAL] DeleteReconciliationRun: Delete reconciliation run |
| [**GetReconciliation**](ReconciliationsApi.md#getreconciliation) | **GET** /api/portfolios/$scheduledReconciliations/{scope}/{code} | [EXPERIMENTAL] GetReconciliation: Get scheduled reconciliation |
| [**GetReconciliationBreak**](ReconciliationsApi.md#getreconciliationbreak) | **GET** /api/portfolios/$scheduledReconciliations/{scope}/{code}/runs/{runDate}/{version}/breaks/{breakId} | [EXPERIMENTAL] GetReconciliationBreak: Get reconciliation break |
| [**GetReconciliationMapping**](ReconciliationsApi.md#getreconciliationmapping) | **GET** /api/portfolios/mapping/{scope}/{code} | [EARLY ACCESS] GetReconciliationMapping: Get a mapping |
| [**GetReconciliationRun**](ReconciliationsApi.md#getreconciliationrun) | **GET** /api/portfolios/$scheduledReconciliations/{scope}/{code}/runs/{runDate}/{version} | [EXPERIMENTAL] GetReconciliationRun: Get a reconciliation run |
| [**ListReconciliationBreaks**](ReconciliationsApi.md#listreconciliationbreaks) | **GET** /api/portfolios/$scheduledReconciliations/{scope}/{code}/runs/{runDate}/{version}/breaks | [EXPERIMENTAL] ListReconciliationBreaks: List reconciliation breaks |
| [**ListReconciliationMappings**](ReconciliationsApi.md#listreconciliationmappings) | **GET** /api/portfolios/mapping | [EARLY ACCESS] ListReconciliationMappings: List the reconciliation mappings |
| [**ListReconciliationRuns**](ReconciliationsApi.md#listreconciliationruns) | **GET** /api/portfolios/$scheduledReconciliations/{scope}/{code}/runs | [EXPERIMENTAL] ListReconciliationRuns: List Reconciliation runs |
| [**ListReconciliations**](ReconciliationsApi.md#listreconciliations) | **GET** /api/portfolios/$scheduledReconciliations | [EXPERIMENTAL] ListReconciliations: List scheduled reconciliations |
| [**ReconcileGeneric**](ReconciliationsApi.md#reconcilegeneric) | **POST** /api/portfolios/$reconcileGeneric | ReconcileGeneric: Reconcile either holdings or valuations performed on one or two sets of holdings using one or two configuration recipes.                The output is configurable for various types of comparisons, to allow tolerances on numerical and date-time data or case-insensitivity on strings,  and elision of resulting differences where they are &#39;empty&#39; or null or zero. |
| [**ReconcileHoldings**](ReconciliationsApi.md#reconcileholdings) | **POST** /api/portfolios/$reconcileholdings | [EARLY ACCESS] ReconcileHoldings: Reconcile portfolio holdings |
| [**ReconcileInline**](ReconciliationsApi.md#reconcileinline) | **POST** /api/portfolios/$reconcileInline | ReconcileInline: Reconcile valuations performed on one or two sets of inline instruments using one or two configuration recipes. |
| [**ReconcileTransactions**](ReconciliationsApi.md#reconciletransactions) | **POST** /api/portfolios/$reconcileTransactions | [EARLY ACCESS] ReconcileTransactions: Perform a Transactions Reconciliation. |
| [**ReconcileTransactionsV2**](ReconciliationsApi.md#reconciletransactionsv2) | **POST** /api/portfolios/$reconcileTransactionsV2 | [EXPERIMENTAL] ReconcileTransactionsV2: Perform a Transactions Reconciliation. |
| [**ReconcileValuation**](ReconciliationsApi.md#reconcilevaluation) | **POST** /api/portfolios/$reconcileValuation | ReconcileValuation: Reconcile valuations performed on one or two sets of holdings using one or two configuration recipes. |
| [**UpdateReconciliation**](ReconciliationsApi.md#updatereconciliation) | **POST** /api/portfolios/$scheduledReconciliations/{scope}/{code} | [EXPERIMENTAL] UpdateReconciliation: Update scheduled reconciliation |
| [**UpsertReconciliationBreak**](ReconciliationsApi.md#upsertreconciliationbreak) | **POST** /api/portfolios/$scheduledReconciliations/{scope}/{code}/runs/{runDate}/{version} | [EXPERIMENTAL] UpsertReconciliationBreak: Upsert a reconciliation break |
| [**UpsertReconciliationMapping**](ReconciliationsApi.md#upsertreconciliationmapping) | **POST** /api/portfolios/mapping | [EARLY ACCESS] UpsertReconciliationMapping: Create or update a mapping |
| [**UpsertReconciliationRun**](ReconciliationsApi.md#upsertreconciliationrun) | **POST** /api/portfolios/$scheduledReconciliations/{scope}/{code}/runs | [EXPERIMENTAL] UpsertReconciliationRun: Update or Create a reconciliation run |

<a id="createscheduledreconciliation"></a>
# **CreateScheduledReconciliation**
> Reconciliation CreateScheduledReconciliation (string scope, CreateReconciliationRequest? createReconciliationRequest = null)

[EXPERIMENTAL] CreateScheduledReconciliation: Create a scheduled reconciliation

Create a scheduled reconciliation for the given request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateScheduledReconciliationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var scope = "scope_example";  // string | The scope of the reconciliation
            var createReconciliationRequest = new CreateReconciliationRequest?(); // CreateReconciliationRequest? | The definition of the reconciliation (optional) 

            try
            {
                // [EXPERIMENTAL] CreateScheduledReconciliation: Create a scheduled reconciliation
                Reconciliation result = apiInstance.CreateScheduledReconciliation(scope, createReconciliationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.CreateScheduledReconciliation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateScheduledReconciliationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateScheduledReconciliation: Create a scheduled reconciliation
    ApiResponse<Reconciliation> response = apiInstance.CreateScheduledReconciliationWithHttpInfo(scope, createReconciliationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.CreateScheduledReconciliationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the reconciliation |  |
| **createReconciliationRequest** | [**CreateReconciliationRequest?**](CreateReconciliationRequest?.md) | The definition of the reconciliation | [optional]  |

### Return type

[**Reconciliation**](Reconciliation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created scheduled reconciliation |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletereconciliation"></a>
# **DeleteReconciliation**
> DeletedEntityResponse DeleteReconciliation (string scope, string code)

[EXPERIMENTAL] DeleteReconciliation: Delete scheduled reconciliation

Delete the given scheduled reconciliation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteReconciliationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var scope = "scope_example";  // string | The scope of the scheduled reconciliation
            var code = "code_example";  // string | The code of the scheduled reconciliation

            try
            {
                // [EXPERIMENTAL] DeleteReconciliation: Delete scheduled reconciliation
                DeletedEntityResponse result = apiInstance.DeleteReconciliation(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.DeleteReconciliation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteReconciliationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteReconciliation: Delete scheduled reconciliation
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteReconciliationWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.DeleteReconciliationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the scheduled reconciliation |  |
| **code** | **string** | The code of the scheduled reconciliation |  |

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
| **200** | The reconciliation at the requested as at was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletereconciliationbreak"></a>
# **DeleteReconciliationBreak**
> DeletedEntityResponse DeleteReconciliationBreak (string scope, string code, DateTimeOffset runDate, int version, string breakId)

[EXPERIMENTAL] DeleteReconciliationBreak: Delete reconciliation break

Delete the given reconciliation break

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteReconciliationBreakExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var scope = "scope_example";  // string | The scope of the reconciliation associated with the break
            var code = "code_example";  // string | The code of the reconciliation associated with the break
            var runDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset | The date of the run associated with the break
            var version = 56;  // int | The version number of the run associated with the break
            var breakId = "breakId_example";  // string | The unique identifier for the break

            try
            {
                // [EXPERIMENTAL] DeleteReconciliationBreak: Delete reconciliation break
                DeletedEntityResponse result = apiInstance.DeleteReconciliationBreak(scope, code, runDate, version, breakId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.DeleteReconciliationBreak: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteReconciliationBreakWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteReconciliationBreak: Delete reconciliation break
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteReconciliationBreakWithHttpInfo(scope, code, runDate, version, breakId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.DeleteReconciliationBreakWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the reconciliation associated with the break |  |
| **code** | **string** | The code of the reconciliation associated with the break |  |
| **runDate** | **DateTimeOffset** | The date of the run associated with the break |  |
| **version** | **int** | The version number of the run associated with the break |  |
| **breakId** | **string** | The unique identifier for the break |  |

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
| **200** | The datetime that the reconciliation break was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletereconciliationmapping"></a>
# **DeleteReconciliationMapping**
> string DeleteReconciliationMapping (string scope, string code)

[EARLY ACCESS] DeleteReconciliationMapping: Delete a mapping

Deletes the mapping identified by the scope and code

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteReconciliationMappingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var scope = "scope_example";  // string | The scope of the mapping.
            var code = "code_example";  // string | The code fof the mapping.

            try
            {
                // [EARLY ACCESS] DeleteReconciliationMapping: Delete a mapping
                string result = apiInstance.DeleteReconciliationMapping(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.DeleteReconciliationMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteReconciliationMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteReconciliationMapping: Delete a mapping
    ApiResponse<string> response = apiInstance.DeleteReconciliationMappingWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.DeleteReconciliationMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the mapping. |  |
| **code** | **string** | The code fof the mapping. |  |

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A string specifying the scope and code that were deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletereconciliationrun"></a>
# **DeleteReconciliationRun**
> DeletedEntityResponse DeleteReconciliationRun (string scope, string code, DateTimeOffset runDate, int version)

[EXPERIMENTAL] DeleteReconciliationRun: Delete reconciliation run

Delete the given reconciliation run

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteReconciliationRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var scope = "scope_example";  // string | The scope of the reconciliation associated with the run
            var code = "code_example";  // string | The code of the reconciliation associated with the run
            var runDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset | The date of the reconciliation run
            var version = 56;  // int | The version number of the reconciliation run

            try
            {
                // [EXPERIMENTAL] DeleteReconciliationRun: Delete reconciliation run
                DeletedEntityResponse result = apiInstance.DeleteReconciliationRun(scope, code, runDate, version);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.DeleteReconciliationRun: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteReconciliationRunWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteReconciliationRun: Delete reconciliation run
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteReconciliationRunWithHttpInfo(scope, code, runDate, version);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.DeleteReconciliationRunWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the reconciliation associated with the run |  |
| **code** | **string** | The code of the reconciliation associated with the run |  |
| **runDate** | **DateTimeOffset** | The date of the reconciliation run |  |
| **version** | **int** | The version number of the reconciliation run |  |

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
| **200** | The datetime that the reconciliation run was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreconciliation"></a>
# **GetReconciliation**
> Reconciliation GetReconciliation (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetReconciliation: Get scheduled reconciliation

Get the requested scheduled reconciliation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetReconciliationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var scope = "scope_example";  // string | The scope of the scheduled reconciliation
            var code = "code_example";  // string | The code of the scheduled reconciliation
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the scheduled reconciliation. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the scheduled reconciliation. Defaults to returning the latest version of the reconciliation if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Reconciliation' property domain to decorate onto the reconciliation.              These must take the form {domain}/{scope}/{code}, for example 'Reconciliation/Broker/Id'. (optional) 

            try
            {
                // [EXPERIMENTAL] GetReconciliation: Get scheduled reconciliation
                Reconciliation result = apiInstance.GetReconciliation(scope, code, effectiveAt, asAt, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.GetReconciliation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReconciliationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetReconciliation: Get scheduled reconciliation
    ApiResponse<Reconciliation> response = apiInstance.GetReconciliationWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.GetReconciliationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the scheduled reconciliation |  |
| **code** | **string** | The code of the scheduled reconciliation |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the scheduled reconciliation. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the scheduled reconciliation. Defaults to returning the latest version of the reconciliation if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Reconciliation&#39; property domain to decorate onto the reconciliation.              These must take the form {domain}/{scope}/{code}, for example &#39;Reconciliation/Broker/Id&#39;. | [optional]  |

### Return type

[**Reconciliation**](Reconciliation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested scheduled reconciliation |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreconciliationbreak"></a>
# **GetReconciliationBreak**
> ReconciliationRunBreak GetReconciliationBreak (string scope, string code, DateTimeOffset runDate, int version, string breakId, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetReconciliationBreak: Get reconciliation break

Get the requested reconciliation break

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetReconciliationBreakExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var scope = "scope_example";  // string | The scope of the reconciliation associated with the break
            var code = "code_example";  // string | The code of the reconciliation associated with the break
            var runDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset | The date of the run associated with the break
            var version = 56;  // int | The version number of the run associated with the break
            var breakId = "breakId_example";  // string | The unique identifier for the break
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the reconciliation break. Defaults to returning the latest version of the reconciliation break if not specified. (optional) 

            try
            {
                // [EXPERIMENTAL] GetReconciliationBreak: Get reconciliation break
                ReconciliationRunBreak result = apiInstance.GetReconciliationBreak(scope, code, runDate, version, breakId, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.GetReconciliationBreak: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReconciliationBreakWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetReconciliationBreak: Get reconciliation break
    ApiResponse<ReconciliationRunBreak> response = apiInstance.GetReconciliationBreakWithHttpInfo(scope, code, runDate, version, breakId, asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.GetReconciliationBreakWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the reconciliation associated with the break |  |
| **code** | **string** | The code of the reconciliation associated with the break |  |
| **runDate** | **DateTimeOffset** | The date of the run associated with the break |  |
| **version** | **int** | The version number of the run associated with the break |  |
| **breakId** | **string** | The unique identifier for the break |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the reconciliation break. Defaults to returning the latest version of the reconciliation break if not specified. | [optional]  |

### Return type

[**ReconciliationRunBreak**](ReconciliationRunBreak.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested reconciliation break |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreconciliationmapping"></a>
# **GetReconciliationMapping**
> Mapping GetReconciliationMapping (string scope, string code)

[EARLY ACCESS] GetReconciliationMapping: Get a mapping

Gets a mapping identified by the given scope and code

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetReconciliationMappingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var scope = "scope_example";  // string | The scope of the mapping.
            var code = "code_example";  // string | The code of the mapping.

            try
            {
                // [EARLY ACCESS] GetReconciliationMapping: Get a mapping
                Mapping result = apiInstance.GetReconciliationMapping(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.GetReconciliationMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReconciliationMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetReconciliationMapping: Get a mapping
    ApiResponse<Mapping> response = apiInstance.GetReconciliationMappingWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.GetReconciliationMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the mapping. |  |
| **code** | **string** | The code of the mapping. |  |

### Return type

[**Mapping**](Mapping.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The mapping with the specified scope/code. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreconciliationrun"></a>
# **GetReconciliationRun**
> ReconciliationRun GetReconciliationRun (string scope, string code, DateTimeOffset runDate, int version, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetReconciliationRun: Get a reconciliation run

Get the requested reconciliation run

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetReconciliationRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var scope = "scope_example";  // string | The scope of the reconciliation associated with the run
            var code = "code_example";  // string | The code of the reconciliation associated with the run
            var runDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset | The date of the run
            var version = 56;  // int | The version number of the run
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the reconciliation run. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the reconciliation run. Defaults to returning the latest version of the reconciliation run if not specified. (optional) 

            try
            {
                // [EXPERIMENTAL] GetReconciliationRun: Get a reconciliation run
                ReconciliationRun result = apiInstance.GetReconciliationRun(scope, code, runDate, version, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.GetReconciliationRun: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReconciliationRunWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetReconciliationRun: Get a reconciliation run
    ApiResponse<ReconciliationRun> response = apiInstance.GetReconciliationRunWithHttpInfo(scope, code, runDate, version, effectiveAt, asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.GetReconciliationRunWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the reconciliation associated with the run |  |
| **code** | **string** | The code of the reconciliation associated with the run |  |
| **runDate** | **DateTimeOffset** | The date of the run |  |
| **version** | **int** | The version number of the run |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the reconciliation run. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the reconciliation run. Defaults to returning the latest version of the reconciliation run if not specified. | [optional]  |

### Return type

[**ReconciliationRun**](ReconciliationRun.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested reconciliation run |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listreconciliationbreaks"></a>
# **ListReconciliationBreaks**
> PagedResourceListOfReconciliationRunBreak ListReconciliationBreaks (string scope, string code, DateTimeOffset runDate, int version, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? start = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListReconciliationBreaks: List reconciliation breaks

List all reconciliation breaks associated with a given run

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListReconciliationBreaksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var scope = "scope_example";  // string | The scope of the reconciliation associated with the break
            var code = "code_example";  // string | The code of the reconciliation associated with the break
            var runDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset | The date of the run associated with the break
            var version = 56;  // int | The version number of the run associated with the break
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the reconciliation runs. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the reconciliation runs. Defaults to returning the latest version              of each run if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing reconciliation runs; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. (optional) 

            try
            {
                // [EXPERIMENTAL] ListReconciliationBreaks: List reconciliation breaks
                PagedResourceListOfReconciliationRunBreak result = apiInstance.ListReconciliationBreaks(scope, code, runDate, version, effectiveAt, asAt, page, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.ListReconciliationBreaks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListReconciliationBreaksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListReconciliationBreaks: List reconciliation breaks
    ApiResponse<PagedResourceListOfReconciliationRunBreak> response = apiInstance.ListReconciliationBreaksWithHttpInfo(scope, code, runDate, version, effectiveAt, asAt, page, start, limit, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.ListReconciliationBreaksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the reconciliation associated with the break |  |
| **code** | **string** | The code of the reconciliation associated with the break |  |
| **runDate** | **DateTimeOffset** | The date of the run associated with the break |  |
| **version** | **int** | The version number of the run associated with the break |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the reconciliation runs. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the reconciliation runs. Defaults to returning the latest version              of each run if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing reconciliation runs; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional]  |
| **start** | **int?** | When paginating, skip this number of results. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. | [optional]  |

### Return type

[**PagedResourceListOfReconciliationRunBreak**](PagedResourceListOfReconciliationRunBreak.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested reconciliation breaks |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listreconciliationmappings"></a>
# **ListReconciliationMappings**
> ResourceListOfMapping ListReconciliationMappings (string? reconciliationType = null)

[EARLY ACCESS] ListReconciliationMappings: List the reconciliation mappings

Lists all mappings this user is entitled to see

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListReconciliationMappingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var reconciliationType = "reconciliationType_example";  // string? | Optional parameter to specify which type of mappings should be returned.  Defaults to Transaction if not provided. (optional) 

            try
            {
                // [EARLY ACCESS] ListReconciliationMappings: List the reconciliation mappings
                ResourceListOfMapping result = apiInstance.ListReconciliationMappings(reconciliationType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.ListReconciliationMappings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListReconciliationMappingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListReconciliationMappings: List the reconciliation mappings
    ApiResponse<ResourceListOfMapping> response = apiInstance.ListReconciliationMappingsWithHttpInfo(reconciliationType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.ListReconciliationMappingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **reconciliationType** | **string?** | Optional parameter to specify which type of mappings should be returned.  Defaults to Transaction if not provided. | [optional]  |

### Return type

[**ResourceListOfMapping**](ResourceListOfMapping.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The mappings that the caller has access to. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listreconciliationruns"></a>
# **ListReconciliationRuns**
> PagedResourceListOfReconciliationRun ListReconciliationRuns (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? start = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListReconciliationRuns: List Reconciliation runs

List all runs for a given reconciliation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListReconciliationRunsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var scope = "scope_example";  // string | The scope of the reconciliation
            var code = "code_example";  // string | The code of the reconciliation
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the reconciliation runs. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the reconciliation runs. Defaults to returning the latest version              of each run if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing reconciliation runs; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the run date, specify \"Date eq 10/03/2018\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 

            try
            {
                // [EXPERIMENTAL] ListReconciliationRuns: List Reconciliation runs
                PagedResourceListOfReconciliationRun result = apiInstance.ListReconciliationRuns(scope, code, effectiveAt, asAt, page, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.ListReconciliationRuns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListReconciliationRunsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListReconciliationRuns: List Reconciliation runs
    ApiResponse<PagedResourceListOfReconciliationRun> response = apiInstance.ListReconciliationRunsWithHttpInfo(scope, code, effectiveAt, asAt, page, start, limit, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.ListReconciliationRunsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the reconciliation |  |
| **code** | **string** | The code of the reconciliation |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the reconciliation runs. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the reconciliation runs. Defaults to returning the latest version              of each run if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing reconciliation runs; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional]  |
| **start** | **int?** | When paginating, skip this number of results. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the run date, specify \&quot;Date eq 10/03/2018\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |

### Return type

[**PagedResourceListOfReconciliationRun**](PagedResourceListOfReconciliationRun.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested reconciliation runs |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listreconciliations"></a>
# **ListReconciliations**
> PagedResourceListOfReconciliation ListReconciliations (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? start = null, int? limit = null, string? filter = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListReconciliations: List scheduled reconciliations

List all the scheduled reconciliations matching particular criteria

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListReconciliationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the TimeVariant properties for the reconciliation. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the reconciliation. Defaults to returning the latest version              of each reconciliation if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing reconciliations; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the reconciliation type, specify \"id.Code eq '001'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Reconciliation' domain to decorate onto each reconciliation.              These must take the format {domain}/{scope}/{code}, for example 'Reconciliation/Broker/Id'. (optional) 

            try
            {
                // [EXPERIMENTAL] ListReconciliations: List scheduled reconciliations
                PagedResourceListOfReconciliation result = apiInstance.ListReconciliations(effectiveAt, asAt, page, start, limit, filter, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.ListReconciliations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListReconciliationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListReconciliations: List scheduled reconciliations
    ApiResponse<PagedResourceListOfReconciliation> response = apiInstance.ListReconciliationsWithHttpInfo(effectiveAt, asAt, page, start, limit, filter, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.ListReconciliationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the TimeVariant properties for the reconciliation. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the reconciliation. Defaults to returning the latest version              of each reconciliation if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing reconciliations; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional]  |
| **start** | **int?** | When paginating, skip this number of results. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the reconciliation type, specify \&quot;id.Code eq &#39;001&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Reconciliation&#39; domain to decorate onto each reconciliation.              These must take the format {domain}/{scope}/{code}, for example &#39;Reconciliation/Broker/Id&#39;. | [optional]  |

### Return type

[**PagedResourceListOfReconciliation**](PagedResourceListOfReconciliation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of all scheduled reconciliations |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reconcilegeneric"></a>
# **ReconcileGeneric**
> ReconciliationResponse ReconcileGeneric (ReconciliationRequest? reconciliationRequest = null)

ReconcileGeneric: Reconcile either holdings or valuations performed on one or two sets of holdings using one or two configuration recipes.                The output is configurable for various types of comparisons, to allow tolerances on numerical and date-time data or case-insensitivity on strings,  and elision of resulting differences where they are 'empty' or null or zero.

Perform evaluation of one or two set of holdings (a portfolio of instruments) using one or two (potentially different) configuration recipes.  Produce a breakdown of the resulting differences in evaluation that can be iterated through.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ReconcileGenericExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var reconciliationRequest = new ReconciliationRequest?(); // ReconciliationRequest? | The specifications of the inputs to the reconciliation (optional) 

            try
            {
                // ReconcileGeneric: Reconcile either holdings or valuations performed on one or two sets of holdings using one or two configuration recipes.                The output is configurable for various types of comparisons, to allow tolerances on numerical and date-time data or case-insensitivity on strings,  and elision of resulting differences where they are 'empty' or null or zero.
                ReconciliationResponse result = apiInstance.ReconcileGeneric(reconciliationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.ReconcileGeneric: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReconcileGenericWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ReconcileGeneric: Reconcile either holdings or valuations performed on one or two sets of holdings using one or two configuration recipes.                The output is configurable for various types of comparisons, to allow tolerances on numerical and date-time data or case-insensitivity on strings,  and elision of resulting differences where they are 'empty' or null or zero.
    ApiResponse<ReconciliationResponse> response = apiInstance.ReconcileGenericWithHttpInfo(reconciliationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.ReconcileGenericWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **reconciliationRequest** | [**ReconciliationRequest?**](ReconciliationRequest?.md) | The specifications of the inputs to the reconciliation | [optional]  |

### Return type

[**ReconciliationResponse**](ReconciliationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested reconciliation |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reconcileholdings"></a>
# **ReconcileHoldings**
> ResourceListOfReconciliationBreak ReconcileHoldings (List<string>? sortBy = null, int? start = null, int? limit = null, string? filter = null, PortfoliosReconciliationRequest? portfoliosReconciliationRequest = null)

[EARLY ACCESS] ReconcileHoldings: Reconcile portfolio holdings

Reconcile the holdings of two portfolios.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ReconcileHoldingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var sortBy = new List<string>?(); // List<string>? | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Optional. Expression to filter the result set.              For example, to filter on the left portfolio Code, use \"left.portfolioId.code eq 'string'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var portfoliosReconciliationRequest = new PortfoliosReconciliationRequest?(); // PortfoliosReconciliationRequest? | The specifications of the inputs to the reconciliation (optional) 

            try
            {
                // [EARLY ACCESS] ReconcileHoldings: Reconcile portfolio holdings
                ResourceListOfReconciliationBreak result = apiInstance.ReconcileHoldings(sortBy, start, limit, filter, portfoliosReconciliationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.ReconcileHoldings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReconcileHoldingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ReconcileHoldings: Reconcile portfolio holdings
    ApiResponse<ResourceListOfReconciliationBreak> response = apiInstance.ReconcileHoldingsWithHttpInfo(sortBy, start, limit, filter, portfoliosReconciliationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.ReconcileHoldingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sortBy** | [**List&lt;string&gt;?**](string.md) | Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional]  |
| **start** | **int?** | Optional. When paginating, skip this number of results | [optional]  |
| **limit** | **int?** | Optional. When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Optional. Expression to filter the result set.              For example, to filter on the left portfolio Code, use \&quot;left.portfolioId.code eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **portfoliosReconciliationRequest** | [**PortfoliosReconciliationRequest?**](PortfoliosReconciliationRequest?.md) | The specifications of the inputs to the reconciliation | [optional]  |

### Return type

[**ResourceListOfReconciliationBreak**](ResourceListOfReconciliationBreak.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested reconciliation |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reconcileinline"></a>
# **ReconcileInline**
> ListAggregationReconciliation ReconcileInline (InlineValuationsReconciliationRequest? inlineValuationsReconciliationRequest = null)

ReconcileInline: Reconcile valuations performed on one or two sets of inline instruments using one or two configuration recipes.

Perform valuation of one or two set of inline instruments using different one or two configuration recipes. Produce a breakdown of the resulting differences in valuation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ReconcileInlineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var inlineValuationsReconciliationRequest = new InlineValuationsReconciliationRequest?(); // InlineValuationsReconciliationRequest? | The specifications of the inputs to the reconciliation (optional) 

            try
            {
                // ReconcileInline: Reconcile valuations performed on one or two sets of inline instruments using one or two configuration recipes.
                ListAggregationReconciliation result = apiInstance.ReconcileInline(inlineValuationsReconciliationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.ReconcileInline: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReconcileInlineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ReconcileInline: Reconcile valuations performed on one or two sets of inline instruments using one or two configuration recipes.
    ApiResponse<ListAggregationReconciliation> response = apiInstance.ReconcileInlineWithHttpInfo(inlineValuationsReconciliationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.ReconcileInlineWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inlineValuationsReconciliationRequest** | [**InlineValuationsReconciliationRequest?**](InlineValuationsReconciliationRequest?.md) | The specifications of the inputs to the reconciliation | [optional]  |

### Return type

[**ListAggregationReconciliation**](ListAggregationReconciliation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested reconciliation |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reconciletransactions"></a>
# **ReconcileTransactions**
> TransactionsReconciliationsResponse ReconcileTransactions (TransactionReconciliationRequest? transactionReconciliationRequest = null)

[EARLY ACCESS] ReconcileTransactions: Perform a Transactions Reconciliation.

Evaluates two sets of transactions to determine which transactions from each set likely match  using the rules of a specified mapping.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ReconcileTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var transactionReconciliationRequest = new TransactionReconciliationRequest?(); // TransactionReconciliationRequest? |  (optional) 

            try
            {
                // [EARLY ACCESS] ReconcileTransactions: Perform a Transactions Reconciliation.
                TransactionsReconciliationsResponse result = apiInstance.ReconcileTransactions(transactionReconciliationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.ReconcileTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReconcileTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ReconcileTransactions: Perform a Transactions Reconciliation.
    ApiResponse<TransactionsReconciliationsResponse> response = apiInstance.ReconcileTransactionsWithHttpInfo(transactionReconciliationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.ReconcileTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionReconciliationRequest** | [**TransactionReconciliationRequest?**](TransactionReconciliationRequest?.md) |  | [optional]  |

### Return type

[**TransactionsReconciliationsResponse**](TransactionsReconciliationsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The transaction reconciliation data for the supplied portfolios. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reconciletransactionsv2"></a>
# **ReconcileTransactionsV2**
> ReconciliationResponse ReconcileTransactionsV2 (TransactionReconciliationRequestV2? transactionReconciliationRequestV2 = null)

[EXPERIMENTAL] ReconcileTransactionsV2: Perform a Transactions Reconciliation.

Evaluates two sets of transactions to determine which transactions from each set likely match  using the rules of a specified mapping.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ReconcileTransactionsV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var transactionReconciliationRequestV2 = new TransactionReconciliationRequestV2?(); // TransactionReconciliationRequestV2? |  (optional) 

            try
            {
                // [EXPERIMENTAL] ReconcileTransactionsV2: Perform a Transactions Reconciliation.
                ReconciliationResponse result = apiInstance.ReconcileTransactionsV2(transactionReconciliationRequestV2);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.ReconcileTransactionsV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReconcileTransactionsV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ReconcileTransactionsV2: Perform a Transactions Reconciliation.
    ApiResponse<ReconciliationResponse> response = apiInstance.ReconcileTransactionsV2WithHttpInfo(transactionReconciliationRequestV2);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.ReconcileTransactionsV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionReconciliationRequestV2** | [**TransactionReconciliationRequestV2?**](TransactionReconciliationRequestV2?.md) |  | [optional]  |

### Return type

[**ReconciliationResponse**](ReconciliationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested reconciliation |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reconcilevaluation"></a>
# **ReconcileValuation**
> ListAggregationReconciliation ReconcileValuation (ValuationsReconciliationRequest? valuationsReconciliationRequest = null)

ReconcileValuation: Reconcile valuations performed on one or two sets of holdings using one or two configuration recipes.

Perform valuation of one or two set of holdings using different one or two configuration recipes. Produce a breakdown of the resulting differences in valuation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ReconcileValuationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var valuationsReconciliationRequest = new ValuationsReconciliationRequest?(); // ValuationsReconciliationRequest? | The specifications of the inputs to the reconciliation (optional) 

            try
            {
                // ReconcileValuation: Reconcile valuations performed on one or two sets of holdings using one or two configuration recipes.
                ListAggregationReconciliation result = apiInstance.ReconcileValuation(valuationsReconciliationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.ReconcileValuation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReconcileValuationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ReconcileValuation: Reconcile valuations performed on one or two sets of holdings using one or two configuration recipes.
    ApiResponse<ListAggregationReconciliation> response = apiInstance.ReconcileValuationWithHttpInfo(valuationsReconciliationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.ReconcileValuationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **valuationsReconciliationRequest** | [**ValuationsReconciliationRequest?**](ValuationsReconciliationRequest?.md) | The specifications of the inputs to the reconciliation | [optional]  |

### Return type

[**ListAggregationReconciliation**](ListAggregationReconciliation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested reconciliation |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatereconciliation"></a>
# **UpdateReconciliation**
> Reconciliation UpdateReconciliation (string scope, string code, UpdateReconciliationRequest? updateReconciliationRequest = null)

[EXPERIMENTAL] UpdateReconciliation: Update scheduled reconciliation

Update a given scheduled reconciliation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdateReconciliationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var scope = "scope_example";  // string | The scope of the reconciliation to be updated
            var code = "code_example";  // string | The code of the reconciliation to be updated
            var updateReconciliationRequest = new UpdateReconciliationRequest?(); // UpdateReconciliationRequest? | The updated definition of the reconciliation (optional) 

            try
            {
                // [EXPERIMENTAL] UpdateReconciliation: Update scheduled reconciliation
                Reconciliation result = apiInstance.UpdateReconciliation(scope, code, updateReconciliationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.UpdateReconciliation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateReconciliationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateReconciliation: Update scheduled reconciliation
    ApiResponse<Reconciliation> response = apiInstance.UpdateReconciliationWithHttpInfo(scope, code, updateReconciliationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.UpdateReconciliationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the reconciliation to be updated |  |
| **code** | **string** | The code of the reconciliation to be updated |  |
| **updateReconciliationRequest** | [**UpdateReconciliationRequest?**](UpdateReconciliationRequest?.md) | The updated definition of the reconciliation | [optional]  |

### Return type

[**Reconciliation**](Reconciliation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated scheduled reconciliation |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertreconciliationbreak"></a>
# **UpsertReconciliationBreak**
> ReconciliationRunBreak UpsertReconciliationBreak (string scope, string code, DateTimeOffset runDate, int version, UpsertReconciliationBreakRequest? upsertReconciliationBreakRequest = null)

[EXPERIMENTAL] UpsertReconciliationBreak: Upsert a reconciliation break

Update or create a given reconciliation break

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertReconciliationBreakExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var scope = "scope_example";  // string | The scope of the reconciliation associated with the break
            var code = "code_example";  // string | The code of the reconciliation associated with the break
            var runDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset | The date of the run associated with the break
            var version = 56;  // int | The version number of the run associated with the break
            var upsertReconciliationBreakRequest = new UpsertReconciliationBreakRequest?(); // UpsertReconciliationBreakRequest? | The definition of the reconciliation break request (optional) 

            try
            {
                // [EXPERIMENTAL] UpsertReconciliationBreak: Upsert a reconciliation break
                ReconciliationRunBreak result = apiInstance.UpsertReconciliationBreak(scope, code, runDate, version, upsertReconciliationBreakRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.UpsertReconciliationBreak: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertReconciliationBreakWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertReconciliationBreak: Upsert a reconciliation break
    ApiResponse<ReconciliationRunBreak> response = apiInstance.UpsertReconciliationBreakWithHttpInfo(scope, code, runDate, version, upsertReconciliationBreakRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.UpsertReconciliationBreakWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the reconciliation associated with the break |  |
| **code** | **string** | The code of the reconciliation associated with the break |  |
| **runDate** | **DateTimeOffset** | The date of the run associated with the break |  |
| **version** | **int** | The version number of the run associated with the break |  |
| **upsertReconciliationBreakRequest** | [**UpsertReconciliationBreakRequest?**](UpsertReconciliationBreakRequest?.md) | The definition of the reconciliation break request | [optional]  |

### Return type

[**ReconciliationRunBreak**](ReconciliationRunBreak.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created reconciliation break |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertreconciliationmapping"></a>
# **UpsertReconciliationMapping**
> Mapping UpsertReconciliationMapping (Mapping? mapping = null)

[EARLY ACCESS] UpsertReconciliationMapping: Create or update a mapping

If no mapping exists with the specified scope and code will create a new one.  Else will update the existing mapping

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertReconciliationMappingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var mapping = new Mapping?(); // Mapping? | The mapping to be created / updated. (optional) 

            try
            {
                // [EARLY ACCESS] UpsertReconciliationMapping: Create or update a mapping
                Mapping result = apiInstance.UpsertReconciliationMapping(mapping);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.UpsertReconciliationMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertReconciliationMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpsertReconciliationMapping: Create or update a mapping
    ApiResponse<Mapping> response = apiInstance.UpsertReconciliationMappingWithHttpInfo(mapping);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.UpsertReconciliationMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mapping** | [**Mapping?**](Mapping?.md) | The mapping to be created / updated. | [optional]  |

### Return type

[**Mapping**](Mapping.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The created / updated mapping. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertreconciliationrun"></a>
# **UpsertReconciliationRun**
> ReconciliationRun UpsertReconciliationRun (string scope, string code, UpsertReconciliationRunRequest? upsertReconciliationRunRequest = null)

[EXPERIMENTAL] UpsertReconciliationRun: Update or Create a reconciliation run

Existing reconciliations will be updated, non-existing ones will be created

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertReconciliationRunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi(config);
            var scope = "scope_example";  // string | The scope of the reconciliation associated with the run
            var code = "code_example";  // string | The code of the reconciliation associated with the run
            var upsertReconciliationRunRequest = new UpsertReconciliationRunRequest?(); // UpsertReconciliationRunRequest? | The definition of the reconciliation run (optional) 

            try
            {
                // [EXPERIMENTAL] UpsertReconciliationRun: Update or Create a reconciliation run
                ReconciliationRun result = apiInstance.UpsertReconciliationRun(scope, code, upsertReconciliationRunRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.UpsertReconciliationRun: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertReconciliationRunWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertReconciliationRun: Update or Create a reconciliation run
    ApiResponse<ReconciliationRun> response = apiInstance.UpsertReconciliationRunWithHttpInfo(scope, code, upsertReconciliationRunRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReconciliationsApi.UpsertReconciliationRunWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the reconciliation associated with the run |  |
| **code** | **string** | The code of the reconciliation associated with the run |  |
| **upsertReconciliationRunRequest** | [**UpsertReconciliationRunRequest?**](UpsertReconciliationRunRequest?.md) | The definition of the reconciliation run | [optional]  |

### Return type

[**ReconciliationRun**](ReconciliationRun.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created reconciliation run |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

