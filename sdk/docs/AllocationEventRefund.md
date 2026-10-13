# Lusid.Sdk.Model.AllocationEventRefund
Cash the fund owes back to an investor record.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record the refund is owed to. | [optional] 
**Amount** | **decimal** | The amount owed back, in the event currency. | [optional] 
**Reason** | **string** | Why the refund arose: Overpayment or Reversal. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "example investorRecordId";decimal? amount = "example amount";
string reason = "example reason";

AllocationEventRefund allocationEventRefundInstance = new AllocationEventRefund(
    investorRecordId: investorRecordId,
    amount: amount,
    reason: reason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
