# Lusid.Sdk.Model.AllocationEventNoticePartnerLine
One register line a notice's partner was allocated on: the line, the fund whose register holds it, the line's  commitment at the event date and the partner's share landing on it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CommitmentLineId** | **string** | The identifier of the register line. | 
**FundId** | [**ResourceId**](ResourceId.md) |  | 
**Commitment** | **decimal** | The line&#39;s committed capital at the event date. | 
**Amount** | **decimal** | The partner&#39;s share of the event landing on the line, signed as the net amount due is. On a transfer, the committed capital moving on the line. | 

```csharp
using Lusid.Sdk.Model;
using System;

string commitmentLineId = "commitmentLineId";
ResourceId fundId = new ResourceId();decimal commitment = "commitment";
decimal amount = "amount";


AllocationEventNoticePartnerLine allocationEventNoticePartnerLineInstance = new AllocationEventNoticePartnerLine(
    commitmentLineId: commitmentLineId,
    fundId: fundId,
    commitment: commitment,
    amount: amount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
