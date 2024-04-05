# Lusid.Sdk.Model.ValuationPointDataResponse
The Valuation Point Data Response for the Fund and specified date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Type** | **string** | The Type of the associated Diary Entry (&#39;PeriodBoundary&#39;,&#39;ValuationPoint&#39;,&#39;Other&#39; or &#39;Adhoc&#39; when a diary Entry wasn&#39;t used). | 
**Status** | **string** | The Status of the associated Diary Entry (&#39;Estimate&#39;,&#39;Final&#39;,&#39;Candidate&#39; or &#39;Unofficial&#39;). | 
**Backout** | **Dictionary&lt;string, decimal&gt;** | Bucket of detail for the Valuation Point, where data points have been &#39;backed out&#39;. | 
**Dealing** | **Dictionary&lt;string, decimal&gt;** | Bucket of detail for any &#39;Dealing&#39; that has occured inside the queried period. | 
**PnL** | **Dictionary&lt;string, decimal&gt;** | Bucket of detail for &#39;PnL&#39; that has occured inside the queried period. | 
**Gav** | **decimal** | The Gross Asset Value of the Fund at the Period end. This is effectively a summation of all Trial balance entries linked to accounts of types &#39;Asset&#39; and &#39;Liabilities&#39;. | 
**Fees** | **Dictionary&lt;string, decimal&gt;** | Bucket of detail for any &#39;Fees&#39; that have been charged in the selected period. | 
**Nav** | **decimal** | The Net Asset Value of the Fund at the Period end. This represents the GAV with any fees applied in the period. | 
**PreviousNav** | **decimal** | The Net Asset Value of the Fund at the End of the last Period. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

