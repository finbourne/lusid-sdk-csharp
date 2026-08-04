# Lusid.Sdk.Model.RecRunLogEntry
A single run within an instance's run log. All runs share the same effective dates (frozen at  instantiation); each has a different asAt, advanced on re-run.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunNumber** | **int** | The run number within the instance. Increments with each re-run. | 
**RunAsAt** | **DateTimeOffset** | The asAt datetime at which the run happened. | 
**SupersededAsAt** | **DateTimeOffset?** | The asAt datetime at which this run was superseded by a subsequent run. | [optional] 
**DatesReconciled** | [**RecDatesReconciled**](RecDatesReconciled.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

RecDatesReconciled datesReconciled = new RecDatesReconciled();

RecRunLogEntry recRunLogEntryInstance = new RecRunLogEntry(
    runNumber: runNumber,
    runAsAt: runAsAt,
    supersededAsAt: supersededAsAt,
    datesReconciled: datesReconciled);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
