# Lusid.Sdk.Model.ManagementFeeLine
One partner's management fee for the period.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record the fee belongs to. | 
**BasisAmount** | **decimal** | The capital the fee was charged on. | 
**Rate** | **decimal** | The annual fee rate applied. | 
**DayCountFraction** | **decimal** | The fraction of a year the period covers, on an ACT/365 basis. | 
**Gross** | **decimal** | The fee before offsets. | 
**Offset** | **decimal** | The offset applied to the fee. | 
**Net** | **decimal** | The fee after offsets. | 
**CarriedForward** | **decimal** | Offset in excess of the fee, carried forward to the next period. | 
**Waived** | **bool** | Whether the partner is fee-exempt and the fee was waived. | 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "investorRecordId";decimal basisAmount = "basisAmount";
decimal rate = "rate";
decimal dayCountFraction = "dayCountFraction";
decimal gross = "gross";
decimal offset = "offset";
decimal net = "net";
decimal carriedForward = "carriedForward";

bool waived = //"True";

ManagementFeeLine managementFeeLineInstance = new ManagementFeeLine(
    investorRecordId: investorRecordId,
    basisAmount: basisAmount,
    rate: rate,
    dayCountFraction: dayCountFraction,
    gross: gross,
    offset: offset,
    net: net,
    carriedForward: carriedForward,
    waived: waived);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
