# Lusid.Sdk.Model.AllocationEventEqualisationMark
A valuation move already allocated to the existing partners that the close re-trues to the admitted partners.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OriginMemberShortCode** | **string** | The member of the structure the mark belongs to. | 
**Amount** | **decimal** | The valuation move already allocated, in the event currency. Negative for a fall in value or an expense. | 

```csharp
using Lusid.Sdk.Model;
using System;

string originMemberShortCode = "originMemberShortCode";decimal amount = "amount";


AllocationEventEqualisationMark allocationEventEqualisationMarkInstance = new AllocationEventEqualisationMark(
    originMemberShortCode: originMemberShortCode,
    amount: amount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
