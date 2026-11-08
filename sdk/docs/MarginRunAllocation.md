# Lusid.Sdk.Model.MarginRunAllocation
How far the allocation pass over a run's base calls got: whether it ran, how many calls it proposed collateral  for, and what it left out.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | How far the allocation pass got. One of Pending, Completed, Skipped or Failed. | 
**AllocatedCallCount** | **int** | How many calls the pass proposed collateral for. | 
**Detail** | **string** | Which calls the pass could not allocate and why, or why it failed. Null when every call that moves our collateral was allocated. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string status = "status";
string detail = "example detail";

MarginRunAllocation marginRunAllocationInstance = new MarginRunAllocation(
    status: status,
    allocatedCallCount: allocatedCallCount,
    detail: detail);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
