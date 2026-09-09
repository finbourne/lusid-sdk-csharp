# Lusid.Sdk.Model.RecInstance
The expanded view of a rec instance: its identity, lifecycle status, lock state, closed periods  (for Closed Period windows) and, per rec type, the time-series of runs in that rec type's run log.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**RecInstanceId**](RecInstanceId.md) |  | 
**RecDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**RecDefinitionDisplayName** | **string** | The display name of the rec definition the rec was instantiated for, as it stood as-at instantiation. Not re-synchronised if the definition is later renamed. | 
**AsAtInstantiated** | **DateTimeOffset** | The asAt datetime at which the instance was first created. | 
**Status** | **string** | The instance-level lifecycle rollup. Available values: Running, Failures, ReviewAndApproval, AllApproved, Locked. | 
**AsAtLocked** | **DateTimeOffset?** | The wall-clock time the lock action was performed. Null when the instance has not been locked. | [optional] 
**DatesLocked** | [**RecDatesReconciled**](RecDatesReconciled.md) |  | [optional] 
**ClosedPeriods** | [**RecClosedPeriods**](RecClosedPeriods.md) |  | [optional] 
**RunLogs** | [**Dictionary&lt;string, RecRunLog&gt;**](RecRunLog.md) | The instance&#39;s run history, keyed by rec type. Contains an entry for each rec type that has produced a result set, so a run appears only once it has completed or failed. Empty while the instance&#39;s first run is still in flight. | 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

RecInstanceId id = new RecInstanceId();
ResourceId recDefinitionId = new ResourceId();
string recDefinitionDisplayName = "recDefinitionDisplayName";
string status = "status";
RecDatesReconciled? datesLocked = new RecDatesReconciled();

RecClosedPeriods? closedPeriods = new RecClosedPeriods();

Dictionary<string, RecRunLog> runLogs = new Dictionary<string, RecRunLog>();
string href = "example href";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

RecInstance recInstanceInstance = new RecInstance(
    id: id,
    recDefinitionId: recDefinitionId,
    recDefinitionDisplayName: recDefinitionDisplayName,
    asAtInstantiated: asAtInstantiated,
    status: status,
    asAtLocked: asAtLocked,
    datesLocked: datesLocked,
    closedPeriods: closedPeriods,
    runLogs: runLogs,
    href: href,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
