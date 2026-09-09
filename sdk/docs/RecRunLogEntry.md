# Lusid.Sdk.Model.RecRunLogEntry
A summary of a single run of a single rec type within an instance's run log, carrying the per-run outcome  detail the grouped-by-instance overview renders. Every entry comes off a result set, so only a run that has  completed or failed appears: a run still in flight is not logged until it lands.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunNumber** | **int** | The run number within the instance. Increments with each re-run. | 
**RunAsAt** | **DateTimeOffset** | The asAt datetime at which the run happened. | 
**SupersededAsAt** | **DateTimeOffset?** | The asAt datetime at which this run was superseded by a subsequent run. | [optional] 
**DatesReconciled** | [**RecDatesReconciled**](RecDatesReconciled.md) |  | 
**Execution** | [**RecExecution**](RecExecution.md) |  | 
**ApprovalStatus** | **string** | The position of this result set in the approval ceremony. Available values: UnderReview, PendingApproval, RevisionsRequested, Approved, NotApplicable. | 
**ResultCounts** | [**RecResultCounts**](RecResultCounts.md) |  | [optional] 
**Review** | [**RecReview**](RecReview.md) |  | [optional] 
**RecResultSetHref** | **string** | The specific Uniform Resource Identifier (URI) of the full rec result set this run belongs to. | 

```csharp
using Lusid.Sdk.Model;
using System;

RecDatesReconciled datesReconciled = new RecDatesReconciled();
RecExecution execution = new RecExecution();
string approvalStatus = "approvalStatus";
RecResultCounts? resultCounts = new RecResultCounts();

RecReview? review = new RecReview();

string recResultSetHref = "recResultSetHref";

RecRunLogEntry recRunLogEntryInstance = new RecRunLogEntry(
    runNumber: runNumber,
    runAsAt: runAsAt,
    supersededAsAt: supersededAsAt,
    datesReconciled: datesReconciled,
    execution: execution,
    approvalStatus: approvalStatus,
    resultCounts: resultCounts,
    review: review,
    recResultSetHref: recResultSetHref);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
