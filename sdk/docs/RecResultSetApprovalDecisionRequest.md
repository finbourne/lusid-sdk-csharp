# Lusid.Sdk.Model.RecResultSetApprovalDecisionRequest
The request for an approver to approve a submitted review or request revisions. Each call satisfies  (or rejects) one approval slot from the result set's required approvals.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApprovalCode** | **string** | The approval slot being decided. Must match a required approval code. | 
**Decision** | **string** | The decision made. Available values: Approve, RequestRevisions. | 
**Reason** | **string** | Rationale for the decision. | [optional] 
**RequestedResultRevisions** | [**List&lt;RecRequestedResultRevision&gt;**](RecRequestedResultRevision.md) | The results flagged for re-review. Only applicable when the decision is Request Revisions. Each result must be Reviewed. A flagged result returns to Required and keeps its decision. The reviewer must affirm or change that decision before the review can be resubmitted. Clearing the decision does not count. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string approvalCode = "approvalCode";
string decision = "decision";
string reason = "example reason";
List<RecRequestedResultRevision> requestedResultRevisions = new List<RecRequestedResultRevision>();

RecResultSetApprovalDecisionRequest recResultSetApprovalDecisionRequestInstance = new RecResultSetApprovalDecisionRequest(
    approvalCode: approvalCode,
    decision: decision,
    reason: reason,
    requestedResultRevisions: requestedResultRevisions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
