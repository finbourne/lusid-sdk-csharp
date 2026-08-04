# Lusid.Sdk.Model.RecClosedPeriodReference
A reference to a closed period created on a timeline when the instance was locked.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TimelineId** | [**ResourceId**](ResourceId.md) |  | 
**ClosedPeriodId** | **string** | The identifier of the closed period. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId timelineId = new ResourceId();
string closedPeriodId = "closedPeriodId";

RecClosedPeriodReference recClosedPeriodReferenceInstance = new RecClosedPeriodReference(
    timelineId: timelineId,
    closedPeriodId: closedPeriodId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
