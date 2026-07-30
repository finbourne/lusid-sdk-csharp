# Lusid.Sdk.Model.RecResultSet
The collection of reconciliation results for a given rec type within a rec instance. Identified by  its rec type and instance. The latest run's data is promoted to the root; prior runs are available  via previousRuns.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecType** | **string** | The type of rec that this result set belongs to (e.g. Holding). Together with the rec instance, this uniquely identifies the result set. Available values: Holding, Transaction, Valuation, CashHolding. | 
**RecInstance** | [**RecInstanceSummary**](RecInstanceSummary.md) |  | 
**RunNumber** | **int** | The run number within the instance. Increments with each re-run. | 
**RunAsAt** | **DateTimeOffset** | The asAt datetime at which the run happened. | 
**Execution** | [**RecExecution**](RecExecution.md) |  | 
**DatesReconciled** | [**RecDatesReconciled**](RecDatesReconciled.md) |  | 
**ResultCounts** | [**RecResultCounts**](RecResultCounts.md) |  | 
**Review** | [**RecReview**](RecReview.md) |  | 
**ApprovalStatus** | **string** | The position of this result set in the approval ceremony. Available values: UnderReview, PendingApproval, RevisionsRequested, Approved, NotApplicable. | 
**RequiredApprovals** | [**List&lt;RecRequiredApproval&gt;**](RecRequiredApproval.md) | The approval slots required for this result set, passed through from the rec definition&#39;s review configuration. May be empty. | 
**Submissions** | [**List&lt;RecSubmission&gt;**](RecSubmission.md) | An append-only log of review submissions. May be empty. | 
**Decisions** | [**List&lt;RecApprovalDecision&gt;**](RecApprovalDecision.md) | An append-only log of approver decisions. May be empty. | 
**PreviousRuns** | [**List&lt;RecSupersededRun&gt;**](RecSupersededRun.md) | Prior run snapshots, each frozen at the point of re-run. Populated only when includePreviousRuns is true. | 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string recType = "recType";
RecInstanceSummary recInstance = new RecInstanceSummary();
RecExecution execution = new RecExecution();
RecDatesReconciled datesReconciled = new RecDatesReconciled();
RecResultCounts resultCounts = new RecResultCounts();
RecReview review = new RecReview();
string approvalStatus = "approvalStatus";
List<RecRequiredApproval> requiredApprovals = new List<RecRequiredApproval>();
List<RecSubmission> submissions = new List<RecSubmission>();
List<RecApprovalDecision> decisions = new List<RecApprovalDecision>();
List<RecSupersededRun> previousRuns = new List<RecSupersededRun>();
string href = "example href";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

RecResultSet recResultSetInstance = new RecResultSet(
    recType: recType,
    recInstance: recInstance,
    runNumber: runNumber,
    runAsAt: runAsAt,
    execution: execution,
    datesReconciled: datesReconciled,
    resultCounts: resultCounts,
    review: review,
    approvalStatus: approvalStatus,
    requiredApprovals: requiredApprovals,
    submissions: submissions,
    decisions: decisions,
    previousRuns: previousRuns,
    href: href,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
