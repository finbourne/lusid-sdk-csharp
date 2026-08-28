# Lusid.Sdk.Model.RecInstanceSummary
A lightweight view of the rec instance, nested on each result set. It carries the instance-level  status, which is how a result set surfaces the instance's running/locked state to the dashboard.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**RecInstanceId**](RecInstanceId.md) |  | 
**RecDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**RecDefinitionDisplayName** | **string** | The display name of the rec definition the rec was instantiated for, as it stood as-at instantiation. Not re-synchronised if the definition is later renamed. | 
**AsAtInstantiated** | **DateTimeOffset** | The asAt datetime at which the instance was first created. | 
**Status** | **string** | The instance-level lifecycle rollup. Available values: Running, Failures, ReviewAndApproval, AllApproved, Locked. | 
**AsAtLocked** | **DateTimeOffset?** | The wall-clock time the lock action was performed. Null when the instance has not been locked. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

RecInstanceId id = new RecInstanceId();
ResourceId recDefinitionId = new ResourceId();
string recDefinitionDisplayName = "recDefinitionDisplayName";
string status = "status";

RecInstanceSummary recInstanceSummaryInstance = new RecInstanceSummary(
    id: id,
    recDefinitionId: recDefinitionId,
    recDefinitionDisplayName: recDefinitionDisplayName,
    asAtInstantiated: asAtInstantiated,
    status: status,
    asAtLocked: asAtLocked);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
