# Lusid.Sdk.Model.BucketedCashFlowResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** |  | [optional] 
**Data** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** | List of dictionary bucketed cash flow result set.  Each dictionary represent a bucketed cashflow result set keyed by AddressKeys.  e.g. dictionary[\&quot;Valuation/CashFlowAmount\&quot;] for the aggregated cash flow amount for the bucket.  e.g. suppose \&quot;RoundUp\&quot; method, then dictionary[\&quot;Valuation/CashFlowDate/RoundUp\&quot;] returns the bucketed cashflow date. | [optional] 
**ReportCurrency** | **string** | Three letter ISO currency string indicating what currency to report in for ReportCcy denominated queries.  If not present then the currency of the relevant portfolio will be used in its place where relevant. | [optional] 
**DataSchema** | [**ResultDataSchema**](ResultDataSchema.md) |  | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | Information about where instruments have failed to return cashflows in so far as it is available.  e.g., failure to retrieve a market quote for a floating rate instrument. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

