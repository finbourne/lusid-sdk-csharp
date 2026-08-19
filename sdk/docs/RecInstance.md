# Lusid.Sdk.Model.RecInstance
The expanded view of a rec instance: its identity, lifecycle status, lock state, closed periods  (for Closed Period windows) and the time-series of runs in the run log.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**RecInstanceId**](RecInstanceId.md) |  | 
**RecDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**AsAtInstantiated** | **DateTimeOffset** | The asAt datetime at which the instance was first created. | 
**Status** | **string** | The instance-level lifecycle rollup. Available values: Running, Failures, ReviewAndApproval, AllApproved, Locked. | 
**AsAtLocked** | **DateTimeOffset?** | The wall-clock time the lock action was performed. Null when the instance has not been locked. | [optional] 
**DatesLocked** | [**RecDatesReconciled**](RecDatesReconciled.md) |  | [optional] 
**ClosedPeriods** | [**RecClosedPeriods**](RecClosedPeriods.md) |  | [optional] 
**RunLog** | [**List&lt;RecRunLogEntry&gt;**](RecRunLogEntry.md) | A chronologically ordered list of all runs on the instance. Always contains at least one entry. | 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

RecInstanceId id = new RecInstanceId();
ResourceId recDefinitionId = new ResourceId();
string status = "status";
RecDatesReconciled? datesLocked = new RecDatesReconciled();

RecClosedPeriods? closedPeriods = new RecClosedPeriods();

List<RecRunLogEntry> runLog = new List<RecRunLogEntry>();
string href = "example href";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

RecInstance recInstanceInstance = new RecInstance(
    id: id,
    recDefinitionId: recDefinitionId,
    asAtInstantiated: asAtInstantiated,
    status: status,
    asAtLocked: asAtLocked,
    datesLocked: datesLocked,
    closedPeriods: closedPeriods,
    runLog: runLog,
    href: href,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
