# Lusid.Sdk.Model.AllocationEventTransferConsideration
The consideration paid for a transferred capital interest.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal** | The consideration amount. | 
**Currency** | **string** | The ISO 4217 code of the currency of the consideration. | 
**RecordOnly** | **bool** | Whether the consideration is recorded for reference only, with no cash movement booked. Defaults to false. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal amount = "amount";

string currency = "currency";
bool recordOnly = //"True";

AllocationEventTransferConsideration allocationEventTransferConsiderationInstance = new AllocationEventTransferConsideration(
    amount: amount,
    currency: currency,
    recordOnly: recordOnly);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
