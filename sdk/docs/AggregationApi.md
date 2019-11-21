# Lusid.Sdk.Api.AggregationApi

All URIs are relative to *http://localhost/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAggregationByGroup**](AggregationApi.md#getaggregationbygroup) | **POST** /api/portfoliogroups/{scope}/{code}/$aggregate | [EXPERIMENTAL] Aggregate data in a portfolio group
[**GetAggregationByPortfolio**](AggregationApi.md#getaggregationbyportfolio) | **POST** /api/portfolios/{scope}/{code}/$aggregate | [EXPERIMENTAL] Aggregate data in a portfolio
[**GetAggregationByResultSet**](AggregationApi.md#getaggregationbyresultset) | **POST** /api/results/{scope}/{resultsKey}/$aggregate | [EXPERIMENTAL] Aggregate using result data
[**GetAggregationOfWeightedInstruments**](AggregationApi.md#getaggregationofweightedinstruments) | **POST** /api/portfolios/{scope}/$aggregateinlined | [EXPERIMENTAL] Aggregate data in an inlined portfolio
[**GetNestedAggregationByGroup**](AggregationApi.md#getnestedaggregationbygroup) | **POST** /api/portfoliogroups/{scope}/{code}/$aggregatenested | [EXPERIMENTAL] Aggregate data in a portfolio group, as nested


<a name="getaggregationbygroup"></a>
# **GetAggregationByGroup**
> ListAggregationResponse GetAggregationByGroup (string scope, string code, List<string> sortBy = null, int? start = null, int? limit = null, AggregationRequest request = null)

[EXPERIMENTAL] Aggregate data in a portfolio group

Aggregate data sourced from the specified portfolio group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetAggregationByGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AggregationApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio group
            var code = code_example;  // string | The code of the portfolio group
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var request = new AggregationRequest(); // AggregationRequest | The request specifying the parameters of the aggregation (optional) 

            try
            {
                // [EXPERIMENTAL] Aggregate data in a portfolio group
                ListAggregationResponse result = apiInstance.GetAggregationByGroup(scope, code, sortBy, start, limit, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AggregationApi.GetAggregationByGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio group | 
 **code** | **string**| The code of the portfolio group | 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **request** | [**AggregationRequest**](AggregationRequest.md)| The request specifying the parameters of the aggregation | [optional] 

### Return type

[**ListAggregationResponse**](ListAggregationResponse.md)

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

<a name="getaggregationbyportfolio"></a>
# **GetAggregationByPortfolio**
> ListAggregationResponse GetAggregationByPortfolio (string scope, string code, List<string> sortBy = null, int? start = null, int? limit = null, AggregationRequest request = null)

[EXPERIMENTAL] Aggregate data in a portfolio

Aggregate data sourced from the specified portfolio

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetAggregationByPortfolioExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AggregationApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var request = new AggregationRequest(); // AggregationRequest | The request specifying the parameters of the aggregation (optional) 

            try
            {
                // [EXPERIMENTAL] Aggregate data in a portfolio
                ListAggregationResponse result = apiInstance.GetAggregationByPortfolio(scope, code, sortBy, start, limit, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AggregationApi.GetAggregationByPortfolio: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio | 
 **code** | **string**| The code of the portfolio | 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **request** | [**AggregationRequest**](AggregationRequest.md)| The request specifying the parameters of the aggregation | [optional] 

### Return type

[**ListAggregationResponse**](ListAggregationResponse.md)

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

<a name="getaggregationbyresultset"></a>
# **GetAggregationByResultSet**
> ListAggregationResponse GetAggregationByResultSet (string scope, string resultsKey, List<string> sortBy = null, int? start = null, int? limit = null, AggregationRequest request = null)

[EXPERIMENTAL] Aggregate using result data

Aggregate data from a previously-run Result data set into a flat row of results

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetAggregationByResultSetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AggregationApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the Result data set
            var resultsKey = resultsKey_example;  // string | The key of the Result data set
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var request = new AggregationRequest(); // AggregationRequest | The request specifying the parameters of the aggregation (optional) 

            try
            {
                // [EXPERIMENTAL] Aggregate using result data
                ListAggregationResponse result = apiInstance.GetAggregationByResultSet(scope, resultsKey, sortBy, start, limit, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AggregationApi.GetAggregationByResultSet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the Result data set | 
 **resultsKey** | **string**| The key of the Result data set | 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **request** | [**AggregationRequest**](AggregationRequest.md)| The request specifying the parameters of the aggregation | [optional] 

### Return type

[**ListAggregationResponse**](ListAggregationResponse.md)

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

<a name="getaggregationofweightedinstruments"></a>
# **GetAggregationOfWeightedInstruments**
> ListAggregationResponse GetAggregationOfWeightedInstruments (string scope, List<string> sortBy = null, int? start = null, int? limit = null, InlineAggregationRequest inlineRequest = null)

[EXPERIMENTAL] Aggregate data in an inlined portfolio

Aggregate data sourced from the portfolio that is defined by the weighted set of instruments passed to the request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetAggregationOfWeightedInstrumentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AggregationApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the instruments should that be required
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var inlineRequest = new InlineAggregationRequest(); // InlineAggregationRequest | The request specifying the parameters of the aggregation and the inlined set of instruments to aggregate over. (optional) 

            try
            {
                // [EXPERIMENTAL] Aggregate data in an inlined portfolio
                ListAggregationResponse result = apiInstance.GetAggregationOfWeightedInstruments(scope, sortBy, start, limit, inlineRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AggregationApi.GetAggregationOfWeightedInstruments: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the instruments should that be required | 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **inlineRequest** | [**InlineAggregationRequest**](InlineAggregationRequest.md)| The request specifying the parameters of the aggregation and the inlined set of instruments to aggregate over. | [optional] 

### Return type

[**ListAggregationResponse**](ListAggregationResponse.md)

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

<a name="getnestedaggregationbygroup"></a>
# **GetNestedAggregationByGroup**
> NestedAggregationResponse GetNestedAggregationByGroup (string scope, string code, AggregationRequest request = null)

[EXPERIMENTAL] Aggregate data in a portfolio group, as nested

Obsolete - Aggregate data sourced from the specified portfolio group into a nested structure. Data is nested following the group-by specifications.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetNestedAggregationByGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AggregationApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio group
            var code = code_example;  // string | The code of the portfolio group
            var request = new AggregationRequest(); // AggregationRequest | The request specifying the parameters of the aggregation (optional) 

            try
            {
                // [EXPERIMENTAL] Aggregate data in a portfolio group, as nested
                NestedAggregationResponse result = apiInstance.GetNestedAggregationByGroup(scope, code, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AggregationApi.GetNestedAggregationByGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio group | 
 **code** | **string**| The code of the portfolio group | 
 **request** | [**AggregationRequest**](AggregationRequest.md)| The request specifying the parameters of the aggregation | [optional] 

### Return type

[**NestedAggregationResponse**](NestedAggregationResponse.md)

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

