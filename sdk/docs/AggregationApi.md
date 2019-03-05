# Lusid.Sdk.Api.AggregationApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAggregationByGroup**](AggregationApi.md#getaggregationbygroup) | **POST** /api/portfoliogroups/{scope}/{code}/$aggregate | Aggregate data in a portfolio group
[**GetAggregationByPortfolio**](AggregationApi.md#getaggregationbyportfolio) | **POST** /api/portfolios/{scope}/{code}/$aggregate | Aggregate data in a portfolio
[**GetAggregationByResultSet**](AggregationApi.md#getaggregationbyresultset) | **POST** /api/results/{scope}/{resultsKey}/$aggregate | Aggregate using result data
[**GetNestedAggregationByGroup**](AggregationApi.md#getnestedaggregationbygroup) | **POST** /api/portfoliogroups/{scope}/{code}/$aggregatenested | Aggregate data in a portfolio group, as nested


<a name="getaggregationbygroup"></a>
# **GetAggregationByGroup**
> ListAggregationResponse GetAggregationByGroup (string scope, string code, AggregationRequest request = null, List<string> sortBy = null, int? start = null, int? limit = null)

Aggregate data in a portfolio group

Aggregate data sourced from the specified portfolio group

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetAggregationByGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AggregationApi();
            var scope = scope_example;  // string | The scope of the portfolio group
            var code = code_example;  // string | The code of the portfolio group
            var request = new AggregationRequest(); // AggregationRequest | The request specifying the parameters of the aggregation (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 

            try
            {
                // Aggregate data in a portfolio group
                ListAggregationResponse result = apiInstance.GetAggregationByGroup(scope, code, request, sortBy, start, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AggregationApi.GetAggregationByGroup: " + e.Message );
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
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 

### Return type

[**ListAggregationResponse**](ListAggregationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaggregationbyportfolio"></a>
# **GetAggregationByPortfolio**
> ListAggregationResponse GetAggregationByPortfolio (string scope, string code, AggregationRequest request = null, List<string> sortBy = null, int? start = null, int? limit = null)

Aggregate data in a portfolio

Aggregate data sourced from the specified portfolio

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetAggregationByPortfolioExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AggregationApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var request = new AggregationRequest(); // AggregationRequest | The request specifying the parameters of the aggregation (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 

            try
            {
                // Aggregate data in a portfolio
                ListAggregationResponse result = apiInstance.GetAggregationByPortfolio(scope, code, request, sortBy, start, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AggregationApi.GetAggregationByPortfolio: " + e.Message );
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
 **request** | [**AggregationRequest**](AggregationRequest.md)| The request specifying the parameters of the aggregation | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 

### Return type

[**ListAggregationResponse**](ListAggregationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaggregationbyresultset"></a>
# **GetAggregationByResultSet**
> ListAggregationResponse GetAggregationByResultSet (string scope, string resultsKey, AggregationRequest request = null, List<string> sortBy = null, int? start = null, int? limit = null)

Aggregate using result data

Aggregate data from a previously-run Result data set into a flat row of results

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetAggregationByResultSetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AggregationApi();
            var scope = scope_example;  // string | The scope of the Result data set
            var resultsKey = resultsKey_example;  // string | The key of the Result data set
            var request = new AggregationRequest(); // AggregationRequest | The request specifying the parameters of the aggregation (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 

            try
            {
                // Aggregate using result data
                ListAggregationResponse result = apiInstance.GetAggregationByResultSet(scope, resultsKey, request, sortBy, start, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AggregationApi.GetAggregationByResultSet: " + e.Message );
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
 **request** | [**AggregationRequest**](AggregationRequest.md)| The request specifying the parameters of the aggregation | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 

### Return type

[**ListAggregationResponse**](ListAggregationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnestedaggregationbygroup"></a>
# **GetNestedAggregationByGroup**
> NestedAggregationResponse GetNestedAggregationByGroup (string scope, string code, AggregationRequest request = null)

Aggregate data in a portfolio group, as nested

Obsolete - Aggregate data sourced from the specified portfolio group into a nested structure. Data is nested following the group-by specifications.

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetNestedAggregationByGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AggregationApi();
            var scope = scope_example;  // string | The scope of the portfolio group
            var code = code_example;  // string | The code of the portfolio group
            var request = new AggregationRequest(); // AggregationRequest | The request specifying the parameters of the aggregation (optional) 

            try
            {
                // Aggregate data in a portfolio group, as nested
                NestedAggregationResponse result = apiInstance.GetNestedAggregationByGroup(scope, code, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AggregationApi.GetNestedAggregationByGroup: " + e.Message );
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

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

