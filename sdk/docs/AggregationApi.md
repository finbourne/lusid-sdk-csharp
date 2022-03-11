# Lusid.Sdk.Api.AggregationApi

All URIs are relative to *http://local-unit-test-server.lusid.com:37484*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetValuation**](AggregationApi.md#getvaluation) | **POST** /api/aggregation/$valuation | GetValuation: Perform valuation for a list of portfolios and/or portfolio groups
[**GetValuationOfWeightedInstruments**](AggregationApi.md#getvaluationofweightedinstruments) | **POST** /api/aggregation/$valuationinlined | GetValuationOfWeightedInstruments: Perform valuation for an inlined portfolio


<a name="getvaluation"></a>
# **GetValuation**
> ListAggregationResponse GetValuation (ValuationRequest valuationRequest = null)

GetValuation: Perform valuation for a list of portfolios and/or portfolio groups

Perform valuation on specified list of portfolio and/or portfolio groups for a set of dates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetValuationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:37484";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AggregationApi(config);
            var valuationRequest = new ValuationRequest(); // ValuationRequest | The request specifying the set of portfolios and dates on which to calculate a set of valuation metrics (optional) 

            try
            {
                // GetValuation: Perform valuation for a list of portfolios and/or portfolio groups
                ListAggregationResponse result = apiInstance.GetValuation(valuationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AggregationApi.GetValuation: " + e.Message );
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
 **valuationRequest** | [**ValuationRequest**](ValuationRequest.md)| The request specifying the set of portfolios and dates on which to calculate a set of valuation metrics | [optional] 

### Return type

[**ListAggregationResponse**](ListAggregationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvaluationofweightedinstruments"></a>
# **GetValuationOfWeightedInstruments**
> ListAggregationResponse GetValuationOfWeightedInstruments (InlineValuationRequest inlineValuationRequest = null)

GetValuationOfWeightedInstruments: Perform valuation for an inlined portfolio

Perform valuation on the portfolio that is defined by the weighted set of instruments passed to the request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetValuationOfWeightedInstrumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:37484";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AggregationApi(config);
            var inlineValuationRequest = new InlineValuationRequest(); // InlineValuationRequest | The request specifying the set of portfolios and dates on which to calculate a set of valuation metrics (optional) 

            try
            {
                // GetValuationOfWeightedInstruments: Perform valuation for an inlined portfolio
                ListAggregationResponse result = apiInstance.GetValuationOfWeightedInstruments(inlineValuationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AggregationApi.GetValuationOfWeightedInstruments: " + e.Message );
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
 **inlineValuationRequest** | [**InlineValuationRequest**](InlineValuationRequest.md)| The request specifying the set of portfolios and dates on which to calculate a set of valuation metrics | [optional] 

### Return type

[**ListAggregationResponse**](ListAggregationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

