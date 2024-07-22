# Lusid.Sdk.Model.FundValuationPointData
The Valuation Point Data for a Fund on a specified date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BackOut** | [**Dictionary&lt;string, FundAmount&gt;**](FundAmount.md) | Bucket of detail for the Valuation Point where data points have been &#39;backed out&#39;. | 
**Dealing** | [**Dictionary&lt;string, FundAmount&gt;**](FundAmount.md) | Bucket of detail for any &#39;Dealing&#39; that has occured inside the queried period. | 
**PnL** | [**Dictionary&lt;string, FundAmount&gt;**](FundAmount.md) | Bucket of detail for &#39;PnL&#39; that has occured inside the queried period. | 
**Gav** | **decimal** | The Gross Asset Value of the Fund or Share Class at the Valuation Point. This is effectively a summation of all Trial balance entries linked to accounts of types &#39;Asset&#39; and &#39;Liabilities&#39;. | 
**Fees** | [**Dictionary&lt;string, FeeAccrual&gt;**](FeeAccrual.md) | Bucket of detail for any &#39;Fees&#39; that have been charged in the selected period. | 
**Nav** | **decimal** | The Net Asset Value of the Fund or Share Class at the Valuation Point. This represents the GAV with any fees applied in the period. | 
**Unitisation** | [**UnitisationData**](UnitisationData.md) |  | [optional] 
**Miscellaneous** | [**Dictionary&lt;string, FundAmount&gt;**](FundAmount.md) | Not used directly by the LUSID engines but serves as a holding area for any custom derived data points that may be useful in, for example, fee calculations). | [optional] 
**PreviousValuationPointData** | [**PreviousFundValuationPointData**](PreviousFundValuationPointData.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

