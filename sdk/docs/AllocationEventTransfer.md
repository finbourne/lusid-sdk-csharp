# Lusid.Sdk.Model.AllocationEventTransfer
One leg of a Transfer Allocation Event: a fraction of a capital interest line moving to another line.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromLineId** | **string** | The identifier of the capital interest line the fraction moves from, as it appears on the register of one of the map&#39;s members. | 
**ToInvestorRecordId** | **string** | The investor record that receives the transferred interest. | 
**ToLineId** | **string** | The identifier of the capital interest line the fraction moves to. Created if it does not exist. | 
**ToPortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Fraction** | **decimal** | The fraction of the source line transferred, greater than zero and at most one. One closes the source line. Each balance moved is the source balance times the fraction, truncated to the currency&#39;s minor unit, so any remainder stays with the transferor. | 
**PnlSplit** | **string** | How the profit and loss of the period containing the transfer is split: InterimClose closes the books on the transfer date; DailyProration prorates by days held. Defaults to InterimClose. Available values: InterimClose, DailyProration. | [optional] 
**Consideration** | [**AllocationEventTransferConsideration**](AllocationEventTransferConsideration.md) |  | [optional] 
**ConsentReference** | **string** | A reference to the consent obtained for the transfer, when the fund requires one. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string fromLineId = "fromLineId";
string toInvestorRecordId = "toInvestorRecordId";
string toLineId = "toLineId";
ResourceId? toPortfolioId = new ResourceId();
decimal fraction = "fraction";

string pnlSplit = "example pnlSplit";
AllocationEventTransferConsideration? consideration = new AllocationEventTransferConsideration();

string consentReference = "example consentReference";

AllocationEventTransfer allocationEventTransferInstance = new AllocationEventTransfer(
    fromLineId: fromLineId,
    toInvestorRecordId: toInvestorRecordId,
    toLineId: toLineId,
    toPortfolioId: toPortfolioId,
    fraction: fraction,
    pnlSplit: pnlSplit,
    consideration: consideration,
    consentReference: consentReference);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
