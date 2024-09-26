# Lusid.Sdk.Model.ValuationPointDataResponse
The Valuation Point Data Response for the Fund and specified date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Type** | **string** | The Type of the associated Diary Entry (&#39;PeriodBoundary&#39;,&#39;ValuationPoint&#39;,&#39;Other&#39; or &#39;Adhoc&#39; when a diary entry wasn&#39;t used). | 
**Status** | **string** | The status of a Diary Entry of Type &#39;ValuationPoint&#39;. Defaults to &#39;Estimate&#39; when upserting a diary entry, moves to &#39;Candidate&#39; or &#39;Final&#39; when a ValuationPoint is accepted, and &#39;Final&#39; when it is finalised. The status of a Diary Entry becomes &#39;Unofficial&#39; when a diary entry wasn&#39;t used. | 
**Backout** | **Dictionary&lt;string, decimal&gt;** | DEPRECATED. Bucket of detail for the Valuation Point, where data points have been &#39;backed out&#39;. | 
**Dealing** | **Dictionary&lt;string, decimal&gt;** | DEPRECATED. Bucket of detail for any &#39;Dealing&#39; that has occured inside the queried period. | 
**PnL** | **Dictionary&lt;string, decimal&gt;** | DEPRECATED. Bucket of detail for &#39;PnL&#39; that has occured inside the queried period. | 
**Gav** | **decimal** | DEPRECATED. The Gross Asset Value of the Fund at the Period end. This is effectively a summation of all Trial balance entries linked to accounts of types &#39;Asset&#39; and &#39;Liabilities&#39;. | 
**Fees** | [**Dictionary&lt;string, FeeAccrual&gt;**](FeeAccrual.md) | DEPRECATED. Bucket of detail for any &#39;Fees&#39; that have been charged in the selected period. | 
**Nav** | **decimal** | DEPRECATED. The Net Asset Value of the Fund at the Period end. This represents the GAV with any fees applied in the period. | 
**PreviousNav** | **decimal** | DEPRECATED. The Net Asset Value of the Fund at the End of the last Period. | 
**FundDetails** | [**FundDetails**](FundDetails.md) |  | 
**FundValuationPointData** | [**FundValuationPointData**](FundValuationPointData.md) |  | 
**ShareClassData** | [**List&lt;ShareClassData&gt;**](ShareClassData.md) | The data for all share classes in fund. Share classes are identified by their short codes. | 
**ValuationPointCode** | **string** | The code of the valuation point. | [optional] 
**PreviousValuationPointCode** | **string** | The code of the previous valuation point. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

