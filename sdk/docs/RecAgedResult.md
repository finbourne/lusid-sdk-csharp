# Lusid.Sdk.Model.RecAgedResult
A summary of a rec result in another instance, as at the stamp, or as last recorded if the result can no longer be read.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the result within its instance, e.g. &#39;Holding-break-1&#39;. With instanceId, it fully qualifies the result. | 
**InstanceId** | [**RecInstanceId**](RecInstanceId.md) |  | 
**RunNumber** | **int** | The result&#39;s latest run as at the stamp, or as last recorded if the result can no longer be read. | 
**RunAsAt** | **DateTimeOffset** | The asAt datetime of the result&#39;s latest run as at the stamp, or as last recorded if the result can no longer be read. | 
**FirstRunSeen** | **int** | The run in which the result was first assigned its id. | 
**AsAtFirstSeen** | **DateTimeOffset** | The runAsAt of the run in which the result first appeared in its instance, the run numbered firstRunSeen. Written once: re-runs leave it unchanged. | 
**DatesReconciled** | [**RecDatesReconciled**](RecDatesReconciled.md) |  | 
**ExceptionStatus** | **string** | The result&#39;s exception status as at the stamp, or as last recorded if the result can no longer be read: Open or Closed. Available values: Open, Closed. | 
**ClosureType** | **string** | The result&#39;s exception closure type as at the stamp, or as last recorded if the result can no longer be read. Null while the exception is open. Available values: Cleared, Accepted, ForceMatched. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string id = "id";
RecInstanceId instanceId = new RecInstanceId();
RecDatesReconciled datesReconciled = new RecDatesReconciled();
string exceptionStatus = "exceptionStatus";
string closureType = "example closureType";

RecAgedResult recAgedResultInstance = new RecAgedResult(
    id: id,
    instanceId: instanceId,
    runNumber: runNumber,
    runAsAt: runAsAt,
    firstRunSeen: firstRunSeen,
    asAtFirstSeen: asAtFirstSeen,
    datesReconciled: datesReconciled,
    exceptionStatus: exceptionStatus,
    closureType: closureType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
