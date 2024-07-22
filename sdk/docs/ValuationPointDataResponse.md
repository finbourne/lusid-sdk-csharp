# Lusid.Sdk.Model.ValuationPointDataResponse
The Valuation Point Data Response for the Fund and specified date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Type** | **string** | The Type of the associated Diary Entry (&#39;PeriodBoundary&#39;,&#39;ValuationPoint&#39;,&#39;Other&#39; or &#39;Adhoc&#39; when a diary entry wasn&#39;t used). | 
**Status** | **string** | The Status of the associated Diary Entry (&#39;Estimate&#39;,&#39;Final&#39;,&#39;Candidate&#39; or &#39;Unofficial&#39;). | 
**Backout** | **Dictionary&lt;string, decimal&gt;** | DEPRECATED. Bucket of detail for the Valuation Point, where data points have been &#39;backed out&#39;. | 
**Dealing** | **Dictionary&lt;string, decimal&gt;** | DEPRECATED. Bucket of detail for any &#39;Dealing&#39; that has occured inside the queried period. | 
**PnL** | **Dictionary&lt;string, decimal&gt;** | DEPRECATED. Bucket of detail for &#39;PnL&#39; that has occured inside the queried period. | 
**Gav** | **decimal** | DEPRECATED. The Gross Asset Value of the Fund at the Period end. This is effectively a summation of all Trial balance entries linked to accounts of types &#39;Asset&#39; and &#39;Liabilities&#39;. | 
**Fees** | [**Dictionary&lt;string, FeeAccrual&gt;**](FeeAccrual.md) | DEPRECATED. Bucket of detail for any &#39;Fees&#39; that have been charged in the selected period. | 
**Nav** | **decimal** | DEPRECATED. The Net Asset Value of the Fund at the Period end. This represents the GAV with any fees applied in the period. | 
**PreviousNav** | **decimal** | DEPRECATED. The Net Asset Value of the Fund at the End of the last Period. | 
**FundValuationPointData** | [**FundValuationPointData**](FundValuationPointData.md) |  | 
**ShareClassData** | [**Dictionary&lt;string, ShareClassData&gt;**](ShareClassData.md) | The data for all share classes in fund. Share classes are identified by their short codes. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

