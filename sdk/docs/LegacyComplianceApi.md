# Lusid.Sdk.Api.LegacyComplianceApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteLegacyComplianceRule**](LegacyComplianceApi.md#deletelegacycompliancerule) | **DELETE** /api/legacy/compliance/rules/{scope}/{code} | [EXPERIMENTAL] DeleteLegacyComplianceRule: Deletes a compliance rule. |
| [**GetLegacyBreachedOrdersInfo**](LegacyComplianceApi.md#getlegacybreachedordersinfo) | **GET** /api/legacy/compliance/runs/breached/{runId} | [EXPERIMENTAL] GetLegacyBreachedOrdersInfo: Get the Ids of Breached orders in a given compliance run and the corresponding list of rules that could have caused it. |
| [**GetLegacyComplianceRule**](LegacyComplianceApi.md#getlegacycompliancerule) | **GET** /api/legacy/compliance/rules/{scope}/{code} | [EXPERIMENTAL] GetLegacyComplianceRule: Retrieve the definition of single compliance rule. |
| [**GetLegacyComplianceRunResults**](LegacyComplianceApi.md#getlegacycompliancerunresults) | **GET** /api/legacy/compliance/runs/{runId} | [EXPERIMENTAL] GetLegacyComplianceRunResults: Get the details of a single compliance run. |
| [**ListLegacyComplianceRules**](LegacyComplianceApi.md#listlegacycompliancerules) | **GET** /api/legacy/compliance/rules | [EXPERIMENTAL] ListLegacyComplianceRules: List compliance rules, with optional filtering. |
| [**ListLegacyComplianceRunInfo**](LegacyComplianceApi.md#listlegacycomplianceruninfo) | **GET** /api/legacy/compliance/runs | [EXPERIMENTAL] ListLegacyComplianceRunInfo: List historical compliance run ids. |
| [**RunLegacyCompliance**](LegacyComplianceApi.md#runlegacycompliance) | **POST** /api/legacy/compliance/runs | [EXPERIMENTAL] RunLegacyCompliance: Kick off the compliance check process |
| [**UpsertLegacyComplianceRules**](LegacyComplianceApi.md#upsertlegacycompliancerules) | **POST** /api/legacy/compliance/rules | [EXPERIMENTAL] UpsertLegacyComplianceRules: Upsert compliance rules. |

<a id="deletelegacycompliancerule"></a>
# **DeleteLegacyComplianceRule**
> DeletedEntityResponse DeleteLegacyComplianceRule (string scope, string code)

[EXPERIMENTAL] DeleteLegacyComplianceRule: Deletes a compliance rule.

Deletes the rule for all effective time.                The rule will remain viewable at previous as at times, and as part of the results of compliance runs, but it  will no longer be considered in new compliance runs.                This cannot be undone.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteLegacyComplianceRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegacyComplianceApi(config);
            var scope = "scope_example";  // string | The compliance rule scope.
            var code = "code_example";  // string | The compliance rule code.

            try
            {
                // [EXPERIMENTAL] DeleteLegacyComplianceRule: Deletes a compliance rule.
                DeletedEntityResponse result = apiInstance.DeleteLegacyComplianceRule(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegacyComplianceApi.DeleteLegacyComplianceRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteLegacyComplianceRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteLegacyComplianceRule: Deletes a compliance rule.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteLegacyComplianceRuleWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegacyComplianceApi.DeleteLegacyComplianceRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The compliance rule scope. |  |
| **code** | **string** | The compliance rule code. |  |

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
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlegacybreachedordersinfo"></a>
# **GetLegacyBreachedOrdersInfo**
> ResourceListOfComplianceBreachedOrderInfo GetLegacyBreachedOrdersInfo (string runId, string? orderScope = null, string? orderCode = null, int? limit = null)

[EXPERIMENTAL] GetLegacyBreachedOrdersInfo: Get the Ids of Breached orders in a given compliance run and the corresponding list of rules that could have caused it.

Use this endpoint to get a list or breached orders and the set of rules that may have caused the breach.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetLegacyBreachedOrdersInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegacyComplianceApi(config);
            var runId = "runId_example";  // string | The RunId that the results should be checked for
            var orderScope = "orderScope_example";  // string? | Optional. Find rules related to a specific order by providing an Order Scope/Code combination (optional) 
            var orderCode = "orderCode_example";  // string? | Optional. Find rules related to a specific order by providing an Order Scope/Code combination (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 

            try
            {
                // [EXPERIMENTAL] GetLegacyBreachedOrdersInfo: Get the Ids of Breached orders in a given compliance run and the corresponding list of rules that could have caused it.
                ResourceListOfComplianceBreachedOrderInfo result = apiInstance.GetLegacyBreachedOrdersInfo(runId, orderScope, orderCode, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegacyComplianceApi.GetLegacyBreachedOrdersInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLegacyBreachedOrdersInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetLegacyBreachedOrdersInfo: Get the Ids of Breached orders in a given compliance run and the corresponding list of rules that could have caused it.
    ApiResponse<ResourceListOfComplianceBreachedOrderInfo> response = apiInstance.GetLegacyBreachedOrdersInfoWithHttpInfo(runId, orderScope, orderCode, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegacyComplianceApi.GetLegacyBreachedOrdersInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runId** | **string** | The RunId that the results should be checked for |  |
| **orderScope** | **string?** | Optional. Find rules related to a specific order by providing an Order Scope/Code combination | [optional]  |
| **orderCode** | **string?** | Optional. Find rules related to a specific order by providing an Order Scope/Code combination | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |

### Return type

[**ResourceListOfComplianceBreachedOrderInfo**](ResourceListOfComplianceBreachedOrderInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The potentially breached orders and their rules from a specific compliance run |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlegacycompliancerule"></a>
# **GetLegacyComplianceRule**
> ComplianceRule GetLegacyComplianceRule (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetLegacyComplianceRule: Retrieve the definition of single compliance rule.

Retrieves the compliance rule definition at the given effective and as at times.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetLegacyComplianceRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegacyComplianceApi(config);
            var scope = "scope_example";  // string | The compliance rule scope.
            var code = "code_example";  // string | The compliance rule code.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the rule definition. Defaults to the current LUSID  system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the rule definition. Defaults to returning the latest version if not  specified. (optional) 

            try
            {
                // [EXPERIMENTAL] GetLegacyComplianceRule: Retrieve the definition of single compliance rule.
                ComplianceRule result = apiInstance.GetLegacyComplianceRule(scope, code, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegacyComplianceApi.GetLegacyComplianceRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLegacyComplianceRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetLegacyComplianceRule: Retrieve the definition of single compliance rule.
    ApiResponse<ComplianceRule> response = apiInstance.GetLegacyComplianceRuleWithHttpInfo(scope, code, effectiveAt, asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegacyComplianceApi.GetLegacyComplianceRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The compliance rule scope. |  |
| **code** | **string** | The compliance rule code. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the rule definition. Defaults to the current LUSID  system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the rule definition. Defaults to returning the latest version if not  specified. | [optional]  |

### Return type

[**ComplianceRule**](ComplianceRule.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Details of one compliance rule. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlegacycompliancerunresults"></a>
# **GetLegacyComplianceRunResults**
> ResourceListOfComplianceRuleResult GetLegacyComplianceRunResults (string runId, string? page = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] GetLegacyComplianceRunResults: Get the details of a single compliance run.

Use this endpoint to fetch the detail associated with a specific compliance run, including a breakdown  of the passing state of each rule, portfolio combination.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetLegacyComplianceRunResultsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegacyComplianceApi(config);
            var runId = "runId_example";  // string | The unique identifier of the compliance run requested.
            var page = "page_example";  // string? | The pagination token to use to continue listing compliance rule results from a previous call to list compliance rule result.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EXPERIMENTAL] GetLegacyComplianceRunResults: Get the details of a single compliance run.
                ResourceListOfComplianceRuleResult result = apiInstance.GetLegacyComplianceRunResults(runId, page, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegacyComplianceApi.GetLegacyComplianceRunResults: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLegacyComplianceRunResultsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetLegacyComplianceRunResults: Get the details of a single compliance run.
    ApiResponse<ResourceListOfComplianceRuleResult> response = apiInstance.GetLegacyComplianceRunResultsWithHttpInfo(runId, page, limit, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegacyComplianceApi.GetLegacyComplianceRunResultsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runId** | **string** | The unique identifier of the compliance run requested. |  |
| **page** | **string?** | The pagination token to use to continue listing compliance rule results from a previous call to list compliance rule result.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**ResourceListOfComplianceRuleResult**](ResourceListOfComplianceRuleResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The rule results of a specific compliance run |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listlegacycompliancerules"></a>
# **ListLegacyComplianceRules**
> ResourceListOfComplianceRule ListLegacyComplianceRules (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListLegacyComplianceRules: List compliance rules, with optional filtering.

For more information about filtering results,  see https://support.lusid.com/knowledgebase/article/KA-01914.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListLegacyComplianceRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegacyComplianceApi(config);
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the rule definitions. Defaults to the current LUSID  system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the rule definitions. Defaults to returning the latest version if not  specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing entities; this value is returned from the previous call. If  a pagination token is provided, the filter, effectiveAt and asAt fields must not have changed since the  original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. (optional) 

            try
            {
                // [EXPERIMENTAL] ListLegacyComplianceRules: List compliance rules, with optional filtering.
                ResourceListOfComplianceRule result = apiInstance.ListLegacyComplianceRules(effectiveAt, asAt, page, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegacyComplianceApi.ListLegacyComplianceRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListLegacyComplianceRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListLegacyComplianceRules: List compliance rules, with optional filtering.
    ApiResponse<ResourceListOfComplianceRule> response = apiInstance.ListLegacyComplianceRulesWithHttpInfo(effectiveAt, asAt, page, limit, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegacyComplianceApi.ListLegacyComplianceRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the rule definitions. Defaults to the current LUSID  system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the rule definitions. Defaults to returning the latest version if not  specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing entities; this value is returned from the previous call. If  a pagination token is provided, the filter, effectiveAt and asAt fields must not have changed since the  original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. | [optional]  |

### Return type

[**ResourceListOfComplianceRule**](ResourceListOfComplianceRule.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A filtered list of compliance rules available. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listlegacycomplianceruninfo"></a>
# **ListLegacyComplianceRunInfo**
> ResourceListOfComplianceRunInfo ListLegacyComplianceRunInfo (DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListLegacyComplianceRunInfo: List historical compliance run ids.

Use this endpoint to fetch a list of all historical compliance runs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListLegacyComplianceRunInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegacyComplianceApi(config);
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The time at which to get results from. Default : latest (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing compliance runs from a previous call to list compliance runs.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EXPERIMENTAL] ListLegacyComplianceRunInfo: List historical compliance run ids.
                ResourceListOfComplianceRunInfo result = apiInstance.ListLegacyComplianceRunInfo(asAt, page, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegacyComplianceApi.ListLegacyComplianceRunInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListLegacyComplianceRunInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListLegacyComplianceRunInfo: List historical compliance run ids.
    ApiResponse<ResourceListOfComplianceRunInfo> response = apiInstance.ListLegacyComplianceRunInfoWithHttpInfo(asAt, page, limit, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegacyComplianceApi.ListLegacyComplianceRunInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | Optional. The time at which to get results from. Default : latest | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing compliance runs from a previous call to list compliance runs.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**ResourceListOfComplianceRunInfo**](ResourceListOfComplianceRunInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The List of IDs and information for all compliance runs completed |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="runlegacycompliance"></a>
# **RunLegacyCompliance**
> ComplianceRunInfo RunLegacyCompliance (bool isPreTrade, string recipeIdScope, string? recipeIdCode = null, bool? byTaxlots = null)

[EXPERIMENTAL] RunLegacyCompliance: Kick off the compliance check process

Use this endpoint to fetch the start a compliance run, based on a pre-set mapping file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class RunLegacyComplianceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegacyComplianceApi(config);
            var isPreTrade = true;  // bool | Required: Boolean flag indicating if a run should be PreTrade (Including orders). For post-trade only, set to false
            var recipeIdScope = "recipeIdScope_example";  // string | Required: the scope of the recipe to be used
            var recipeIdCode = "recipeIdCode_example";  // string? | Optional: The code of the recipe to be used. If left blank, the default recipe will be used. (optional) 
            var byTaxlots = true;  // bool? | Optional. (optional) 

            try
            {
                // [EXPERIMENTAL] RunLegacyCompliance: Kick off the compliance check process
                ComplianceRunInfo result = apiInstance.RunLegacyCompliance(isPreTrade, recipeIdScope, recipeIdCode, byTaxlots);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegacyComplianceApi.RunLegacyCompliance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RunLegacyComplianceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] RunLegacyCompliance: Kick off the compliance check process
    ApiResponse<ComplianceRunInfo> response = apiInstance.RunLegacyComplianceWithHttpInfo(isPreTrade, recipeIdScope, recipeIdCode, byTaxlots);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegacyComplianceApi.RunLegacyComplianceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **isPreTrade** | **bool** | Required: Boolean flag indicating if a run should be PreTrade (Including orders). For post-trade only, set to false |  |
| **recipeIdScope** | **string** | Required: the scope of the recipe to be used |  |
| **recipeIdCode** | **string?** | Optional: The code of the recipe to be used. If left blank, the default recipe will be used. | [optional]  |
| **byTaxlots** | **bool?** | Optional. | [optional]  |

### Return type

[**ComplianceRunInfo**](ComplianceRunInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The identifying information of a compliance run |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertlegacycompliancerules"></a>
# **UpsertLegacyComplianceRules**
> ComplianceRuleUpsertResponse UpsertLegacyComplianceRules (Dictionary<string, ComplianceRuleUpsertRequest> requestBody, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] UpsertLegacyComplianceRules: Upsert compliance rules.

To upsert a new rule, the code field must be left empty, a code will then be assigned and returned as part  of the response. To update an existing rule, include the rule code. It is possible to both create and update  compliance rules in the same request.                The upsert is transactional - either all create/update operations will succeed or none of them will.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertLegacyComplianceRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegacyComplianceApi(config);
            var requestBody = new Dictionary<string, ComplianceRuleUpsertRequest>(); // Dictionary<string, ComplianceRuleUpsertRequest> | A dictionary of upsert request identifiers to rule upsert requests. The request               identifiers are valid for the request only and can be used to link the upserted compliance rule to the code               of a created compliance rule.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which the rule will take effect. Defaults to the current LUSID  system datetime if not specified. In the case of an update, the changes will take place from this effective  time until the next effective time that the rule as been upserted at. For example, consider a rule that  already exists, and has previously had an update applied so that the definition will change on the first day  of the coming month. An upsert effective from the current day will only change the definition until the  first day of the coming month. An additional upsert at the same time (first day of the month) is required  if the newly-updated definition is to supersede the future definition. (optional) 

            try
            {
                // [EXPERIMENTAL] UpsertLegacyComplianceRules: Upsert compliance rules.
                ComplianceRuleUpsertResponse result = apiInstance.UpsertLegacyComplianceRules(requestBody, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegacyComplianceApi.UpsertLegacyComplianceRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertLegacyComplianceRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertLegacyComplianceRules: Upsert compliance rules.
    ApiResponse<ComplianceRuleUpsertResponse> response = apiInstance.UpsertLegacyComplianceRulesWithHttpInfo(requestBody, effectiveAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LegacyComplianceApi.UpsertLegacyComplianceRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, ComplianceRuleUpsertRequest&gt;**](ComplianceRuleUpsertRequest.md) | A dictionary of upsert request identifiers to rule upsert requests. The request               identifiers are valid for the request only and can be used to link the upserted compliance rule to the code               of a created compliance rule. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which the rule will take effect. Defaults to the current LUSID  system datetime if not specified. In the case of an update, the changes will take place from this effective  time until the next effective time that the rule as been upserted at. For example, consider a rule that  already exists, and has previously had an update applied so that the definition will change on the first day  of the coming month. An upsert effective from the current day will only change the definition until the  first day of the coming month. An additional upsert at the same time (first day of the month) is required  if the newly-updated definition is to supersede the future definition. | [optional]  |

### Return type

[**ComplianceRuleUpsertResponse**](ComplianceRuleUpsertResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Upsert compliance rules. New compliance rules must have an empty code field. Where a codeis given, this rule must already exist and will be updated. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

