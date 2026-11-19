# Lusid.Sdk.Model.AllocationEventNoticeTransfer
The transfer a notice reports, from the leg the partner is on: the other party to the leg, the lines the  interest moves between, the fraction and the terms.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CounterpartyInvestorRecordId** | **string** | The investor record on the other side of the leg: the transferor on the transferee&#39;s notice, the transferee on the transferor&#39;s. Absent when the register does not say who holds the source line. | [optional] 
**FromLineId** | **string** | The register line the interest moves from. | 
**ToLineId** | **string** | The register line the interest moves to. | 
**Fraction** | **decimal** | The fraction of the source line transferred. | 
**PnlSplit** | **string** | How the period&#39;s profit and loss is split around the transfer date: InterimClose or DailyProration. | 
**Consideration** | [**AllocationEventTransferConsideration**](AllocationEventTransferConsideration.md) |  | [optional] 
**ConsentReference** | **string** | A reference to the consent obtained for the transfer, when one was. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string counterpartyInvestorRecordId = "example counterpartyInvestorRecordId";
string fromLineId = "fromLineId";
string toLineId = "toLineId";decimal fraction = "fraction";

string pnlSplit = "pnlSplit";
AllocationEventTransferConsideration? consideration = new AllocationEventTransferConsideration();

string consentReference = "example consentReference";

AllocationEventNoticeTransfer allocationEventNoticeTransferInstance = new AllocationEventNoticeTransfer(
    counterpartyInvestorRecordId: counterpartyInvestorRecordId,
    fromLineId: fromLineId,
    toLineId: toLineId,
    fraction: fraction,
    pnlSplit: pnlSplit,
    consideration: consideration,
    consentReference: consentReference);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
