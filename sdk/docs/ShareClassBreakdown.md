# Lusid.Sdk.Model.ShareClassBreakdown
The Valuation Point Data for a Share Class on a specified date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BackOut** | [**Dictionary&lt;string, ShareClassAmount&gt;**](ShareClassAmount.md) | Bucket of detail for the Valuation Point where data points have been &#39;backed out&#39;. | 
**Dealing** | [**Dictionary&lt;string, ShareClassAmount&gt;**](ShareClassAmount.md) | Bucket of detail for any &#39;Dealing&#39; that has occured inside the queried period. | 
**PnL** | [**Dictionary&lt;string, ShareClassAmount&gt;**](ShareClassAmount.md) | Bucket of detail for &#39;PnL&#39; that has occured inside the queried period. | 
**Gav** | [**MultiCurrencyAmounts**](MultiCurrencyAmounts.md) |  | 
**Fees** | [**Dictionary&lt;string, FeeAccrual&gt;**](FeeAccrual.md) | Bucket of detail for any &#39;Fees&#39; that have been charged in the selected period. | 
**Nav** | [**MultiCurrencyAmounts**](MultiCurrencyAmounts.md) |  | 
**Unitisation** | [**UnitisationData**](UnitisationData.md) |  | [optional] 
**Miscellaneous** | [**Dictionary&lt;string, ShareClassAmount&gt;**](ShareClassAmount.md) | Not used directly by the LUSID engines but serves as a holding area for any custom derived data points that may be useful in, for example, fee calculations). | [optional] 
**ShareClassToFundFxRate** | **decimal** | The fx rate from the Share Class currency to the fund currency at this valuation point. | 
**CapitalRatio** | **decimal** | The proportion of the fund&#39;s adjusted beginning equity (ie: the sum of the previous NAV and the net dealing) that is invested in the share class. | 
**PreviousShareClassBreakdown** | [**PreviousShareClassBreakdown**](PreviousShareClassBreakdown.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

