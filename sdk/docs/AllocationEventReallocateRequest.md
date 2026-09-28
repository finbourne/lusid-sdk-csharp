# Lusid.Sdk.Model.AllocationEventReallocateRequest
The request used to recompute an unbooked Allocation Event: why, and with which basis values.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reason** | **string** | Why the event is being recomputed. | 
**BasisValues** | [**List&lt;AllocationMapBasisValue&gt;**](AllocationMapBasisValue.md) | Optional replacement basis values per investor record. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string reason = "reason";
List<AllocationMapBasisValue> basisValues = new List<AllocationMapBasisValue>();

AllocationEventReallocateRequest allocationEventReallocateRequestInstance = new AllocationEventReallocateRequest(
    reason: reason,
    basisValues: basisValues);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
