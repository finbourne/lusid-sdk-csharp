# Lusid.Sdk.Model.AllocationEventReversal
How a booked Allocation Event was reversed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reference** | **string** | The reference the mirror postings were written under: the original booking reference with a -REV suffix. | [optional] 
**Reason** | **string** | Why the event was reversed. | [optional] 
**ReversedAt** | **DateTimeOffset** | The datetime at which the event was reversed. | [optional] 
**EffectiveAt** | **DateTimeOffset** | The date the mirror postings were posted at. | [optional] 
**Backdated** | **bool** | Whether the mirror postings were posted at the original event date despite the period being closed. | [optional] 
**RefundPayable** | [**List&lt;AllocationEventRefund&gt;**](AllocationEventRefund.md) | Cash owed back to investors who had already paid in when the event was reversed. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string reference = "example reference";
string reason = "example reason";
bool backdated = //"True";
List<AllocationEventRefund> refundPayable = new List<AllocationEventRefund>();

AllocationEventReversal allocationEventReversalInstance = new AllocationEventReversal(
    reference: reference,
    reason: reason,
    reversedAt: reversedAt,
    effectiveAt: effectiveAt,
    backdated: backdated,
    refundPayable: refundPayable);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
