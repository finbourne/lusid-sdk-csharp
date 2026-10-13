# Lusid.Sdk.Model.AllocationEventReverseRequest
The request used to reverse a booked Allocation Event: why, and when the mirror postings are dated.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reason** | **string** | Why the booked event is being reversed. | 
**EffectiveAt** | **DateTimeOffset?** | The date to post the mirror entries at. Defaults to the original event date unless that period is closed, when it defaults to the current date. | [optional] 
**Backdated** | **bool** | Whether to post the mirror entries at the original event date even when that period is closed. Defaults to false. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string reason = "reason";
bool backdated = //"True";

AllocationEventReverseRequest allocationEventReverseRequestInstance = new AllocationEventReverseRequest(
    reason: reason,
    effectiveAt: effectiveAt,
    backdated: backdated);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
