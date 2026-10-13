# Lusid.Sdk.Model.AllocationEventEqualisationFeeCatchUp
The management fees one admitted partner owes from the first fee date to the close, as an explicit amount.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The admitted partner the fee catch-up is charged to. | 
**Amount** | **decimal** | The fee catch-up in the event currency. Must not be negative. | 
**DueDate** | **DateTimeOffset?** | The date the fee would have been due had the partner been admitted at the first close, from which interest on it accrues when charged. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "investorRecordId";decimal amount = "amount";


AllocationEventEqualisationFeeCatchUp allocationEventEqualisationFeeCatchUpInstance = new AllocationEventEqualisationFeeCatchUp(
    investorRecordId: investorRecordId,
    amount: amount,
    dueDate: dueDate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
