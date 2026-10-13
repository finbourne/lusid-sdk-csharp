# Lusid.Sdk.Model.AllocationEventUnbookRequest
The request used to take a half-booked Allocation Event back to Computed, cancelling what it wrote.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reason** | **string** | Why the half-booked event is being taken back to Computed. | 

```csharp
using Lusid.Sdk.Model;
using System;

string reason = "reason";

AllocationEventUnbookRequest allocationEventUnbookRequestInstance = new AllocationEventUnbookRequest(
    reason: reason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
