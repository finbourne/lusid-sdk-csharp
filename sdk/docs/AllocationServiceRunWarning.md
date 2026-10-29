# Lusid.Sdk.Model.AllocationServiceRunWarning

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PlacementId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Code** | **string** | The kind of warning. One of: OffMinimumIncrement (an allocation&#39;s quantity is not a multiple of the  instrument&#39;s minimum increment), SkippedBooked (an allocation was not changed because transactions are  already booked against it), ExecutionNotAllocated (an execution was excluded from the run). | [optional] 
**Message** | **string** | A description of the warning and, where known, why it arose. | [optional] 
**AllocationId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**ExecutionId** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? placementId = new ResourceId();

string code = "example code";
string message = "example message";
ResourceId? allocationId = new ResourceId();

ResourceId? portfolioId = new ResourceId();

ResourceId? executionId = new ResourceId();


AllocationServiceRunWarning allocationServiceRunWarningInstance = new AllocationServiceRunWarning(
    placementId: placementId,
    code: code,
    message: message,
    allocationId: allocationId,
    portfolioId: portfolioId,
    executionId: executionId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
