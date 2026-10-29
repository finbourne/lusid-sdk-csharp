# Lusid.Sdk.Model.AllocationServiceRunResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The placements that were allocated successfully. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The placements that could not be allocated, keyed by placement, with the reason. | [optional] 
**Allocations** | [**List&lt;AllocationServiceRunAllocation&gt;**](AllocationServiceRunAllocation.md) | Every allocation the run touched across the successful placements, each with its outcome. | [optional] 
**Warnings** | [**List&lt;AllocationServiceRunWarning&gt;**](AllocationServiceRunWarning.md) | Warnings raised while allocating the successful placements. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ResourceId> values = new List<ResourceId>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<AllocationServiceRunAllocation> allocations = new List<AllocationServiceRunAllocation>();
List<AllocationServiceRunWarning> warnings = new List<AllocationServiceRunWarning>();

AllocationServiceRunResponse allocationServiceRunResponseInstance = new AllocationServiceRunResponse(
    values: values,
    failed: failed,
    allocations: allocations,
    warnings: warnings);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
