# Lusid.Sdk.Model.CarryAccrualLine
One partner's line on a carry accrual.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record the amount belongs to. | 
**PreviousCarryToDate** | **decimal** | The cumulative carry already on the books for the partner. | 
**CarryToDate** | **decimal** | The cumulative carry the partner has earned to the period end. | 
**Delta** | **decimal** | The accrual booked: the carry to date less what was already on the books. | 
**ClawbackExposure** | **decimal** | The carry that would have to be returned if the fund liquidated at the period end. | 
**Status** | **string** | What happened to the line. Available values: Unchanged, Accrued, Released. | 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "investorRecordId";decimal previousCarryToDate = "previousCarryToDate";
decimal carryToDate = "carryToDate";
decimal delta = "delta";
decimal clawbackExposure = "clawbackExposure";

string status = "status";

CarryAccrualLine carryAccrualLineInstance = new CarryAccrualLine(
    investorRecordId: investorRecordId,
    previousCarryToDate: previousCarryToDate,
    carryToDate: carryToDate,
    delta: delta,
    clawbackExposure: clawbackExposure,
    status: status);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
