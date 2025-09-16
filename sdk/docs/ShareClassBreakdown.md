# Lusid.Sdk.Model.ShareClassBreakdown
The Valuation Point Data for a Share Class on a specified date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BackOut** | [**Dictionary&lt;string, ShareClassAmount&gt;**](ShareClassAmount.md) | Bucket of detail for the Valuation Point where data points have been &#39;backed out&#39;. | 
**Dealing** | [**ShareClassDealingBreakdown**](ShareClassDealingBreakdown.md) |  | 
**PnL** | [**ShareClassPnlBreakdown**](ShareClassPnlBreakdown.md) |  | 
**Gav** | [**ShareClassAmount**](ShareClassAmount.md) |  | 
**Fees** | [**Dictionary&lt;string, FeeAccrual&gt;**](FeeAccrual.md) | Bucket of detail for any &#39;Fees&#39; that have been charged in the selected period. | 
**Nav** | [**ShareClassAmount**](ShareClassAmount.md) |  | 
**Unitisation** | [**UnitisationData**](UnitisationData.md) |  | [optional] 
**Miscellaneous** | [**Dictionary&lt;string, ShareClassAmount&gt;**](ShareClassAmount.md) | Not used directly by the LUSID engines but serves as a holding area for any custom derived data points that may be useful in, for example, fee calculations). | [optional] 
**ShareClassToFundFxRate** | **decimal** | The fx rate from the Share Class currency to the fund currency at this valuation point. | 
**CapitalRatio** | **decimal** | The proportion of the fund&#39;s adjusted beginning equity (ie: the sum of the previous NAV and the net dealing) that is invested in the share class. | 
**PreviousShareClassBreakdown** | [**PreviousShareClassBreakdown**](PreviousShareClassBreakdown.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, ShareClassAmount> backOut = new Dictionary<string, ShareClassAmount>();
ShareClassDealingBreakdown dealing = new ShareClassDealingBreakdown();
ShareClassPnlBreakdown pnL = new ShareClassPnlBreakdown();
ShareClassAmount gav = new ShareClassAmount();
Dictionary<string, FeeAccrual> fees = new Dictionary<string, FeeAccrual>();
ShareClassAmount nav = new ShareClassAmount();
UnitisationData? unitisation = new UnitisationData();

Dictionary<string, ShareClassAmount> miscellaneous = new Dictionary<string, ShareClassAmount>();decimal shareClassToFundFxRate = "shareClassToFundFxRate";
decimal capitalRatio = "capitalRatio";

PreviousShareClassBreakdown previousShareClassBreakdown = new PreviousShareClassBreakdown();

ShareClassBreakdown shareClassBreakdownInstance = new ShareClassBreakdown(
    backOut: backOut,
    dealing: dealing,
    pnL: pnL,
    gav: gav,
    fees: fees,
    nav: nav,
    unitisation: unitisation,
    miscellaneous: miscellaneous,
    shareClassToFundFxRate: shareClassToFundFxRate,
    capitalRatio: capitalRatio,
    previousShareClassBreakdown: previousShareClassBreakdown);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
