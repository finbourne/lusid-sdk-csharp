# Lusid.Sdk.Model.RecSupersededRun
A prior run snapshot, frozen at the point of re-run. Has the same shape as the root-level run  fields on the result set, plus the asAt at which the run was superseded.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunNumber** | **int** | The run number within the instance. Increments with each re-run. | 
**RunAsAt** | **DateTimeOffset** | The asAt datetime at which the run happened. | 
**SupersededAsAt** | **DateTimeOffset** | The asAt datetime at which this run was superseded by a subsequent run. | 
**Execution** | [**RecExecution**](RecExecution.md) |  | 
**DatesReconciled** | [**RecDatesReconciled**](RecDatesReconciled.md) |  | 
**ResultCounts** | [**RecResultCounts**](RecResultCounts.md) |  | 
**Review** | [**RecReview**](RecReview.md) |  | 
**ApprovalStatus** | **string** | The position of this result set in the approval ceremony. Available values: UnderReview, PendingApproval, RevisionsRequested, Approved, NotApplicable. | 
**RequiredApprovals** | [**List&lt;RecRequiredApproval&gt;**](RecRequiredApproval.md) | The approval slots required for this result set, passed through from the rec definition&#39;s review configuration. May be empty. | 
**Submissions** | [**List&lt;RecSubmission&gt;**](RecSubmission.md) | An append-only log of review submissions. May be empty. | 
**Decisions** | [**List&lt;RecApprovalDecision&gt;**](RecApprovalDecision.md) | An append-only log of approver decisions. May be empty. | 

```csharp
using Lusid.Sdk.Model;
using System;

RecExecution execution = new RecExecution();
RecDatesReconciled datesReconciled = new RecDatesReconciled();
RecResultCounts resultCounts = new RecResultCounts();
RecReview review = new RecReview();
string approvalStatus = "approvalStatus";
List<RecRequiredApproval> requiredApprovals = new List<RecRequiredApproval>();
List<RecSubmission> submissions = new List<RecSubmission>();
List<RecApprovalDecision> decisions = new List<RecApprovalDecision>();

RecSupersededRun recSupersededRunInstance = new RecSupersededRun(
    runNumber: runNumber,
    runAsAt: runAsAt,
    supersededAsAt: supersededAsAt,
    execution: execution,
    datesReconciled: datesReconciled,
    resultCounts: resultCounts,
    review: review,
    approvalStatus: approvalStatus,
    requiredApprovals: requiredApprovals,
    submissions: submissions,
    decisions: decisions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
