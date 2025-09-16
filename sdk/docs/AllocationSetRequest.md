# Lusid.Sdk.Model.AllocationSetRequest
A request to create or update multiple Allocations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllocationRequests** | [**List&lt;AllocationRequest&gt;**](AllocationRequest.md) | A collection of AllocationRequests. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<AllocationRequest> allocationRequests = new List<AllocationRequest>();

AllocationSetRequest allocationSetRequestInstance = new AllocationSetRequest(
    allocationRequests: allocationRequests);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
