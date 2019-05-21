# Lusid.Sdk.Api.ReconciliationsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReconcileHoldings**](ReconciliationsApi.md#reconcileholdings) | **POST** /api/portfolios/$reconcileholdings | Reconcile portfolio holdings
[**ReconcileValuation**](ReconciliationsApi.md#reconcilevaluation) | **POST** /api/portfolios/$reconcileValuation | Reconcile valuations performed on one or two sets of holdings using one or two configuration recipes.


<a name="reconcileholdings"></a>
# **ReconcileHoldings**
> ResourceListOfReconciliationBreak ReconcileHoldings (PortfoliosReconciliationRequest request = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)

Reconcile portfolio holdings

Reconcile the holdings of two portfolios.

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ReconcileHoldingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi();
            var request = new PortfoliosReconciliationRequest(); // PortfoliosReconciliationRequest | The specifications of the inputs to the reconciliation (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 

            try
            {
                // Reconcile portfolio holdings
                ResourceListOfReconciliationBreak result = apiInstance.ReconcileHoldings(request, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.ReconcileHoldings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**PortfoliosReconciliationRequest**](PortfoliosReconciliationRequest.md)| The specifications of the inputs to the reconciliation | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 

### Return type

[**ResourceListOfReconciliationBreak**](ResourceListOfReconciliationBreak.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reconcilevaluation"></a>
# **ReconcileValuation**
> ResourceListOfReconciliationBreak ReconcileValuation (ValuationsReconciliationRequest request = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)

Reconcile valuations performed on one or two sets of holdings using one or two configuration recipes.

Perform valuation of one or two set of holdings using different one or two configuration recipes. Produce a breakdown of the resulting differences in valuation.

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ReconcileValuationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReconciliationsApi();
            var request = new ValuationsReconciliationRequest(); // ValuationsReconciliationRequest | The specifications of the inputs to the reconciliation (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 

            try
            {
                // Reconcile valuations performed on one or two sets of holdings using one or two configuration recipes.
                ResourceListOfReconciliationBreak result = apiInstance.ReconcileValuation(request, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReconciliationsApi.ReconcileValuation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ValuationsReconciliationRequest**](ValuationsReconciliationRequest.md)| The specifications of the inputs to the reconciliation | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 

### Return type

[**ResourceListOfReconciliationBreak**](ResourceListOfReconciliationBreak.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

