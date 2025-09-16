# Lusid.Sdk.Model.ComplianceRunInfoV2

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | [**ResourceId**](ResourceId.md) |  | 
**InstigatedAt** | **DateTimeOffset** |  | 
**CompletedAt** | **DateTimeOffset** |  | 
**Schedule** | **string** |  | 
**InstigatedBy** | **string** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId runId = new ResourceId();
string schedule = "schedule";
string instigatedBy = "instigatedBy";

ComplianceRunInfoV2 complianceRunInfoV2Instance = new ComplianceRunInfoV2(
    runId: runId,
    instigatedAt: instigatedAt,
    completedAt: completedAt,
    schedule: schedule,
    instigatedBy: instigatedBy);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
