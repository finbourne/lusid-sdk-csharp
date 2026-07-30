# Lusid.Sdk.Model.RecApprovalDecision
An entry in the append-only log of approver decisions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApprovalCode** | **string** | The approval slot this decision satisfies. Must match a required approval code. | 
**Decision** | **string** | The decision made. Available values: Approve, RequestRevisions. | 
**Reason** | **string** | Rationale for the decision. | [optional] 
**UserId** | **string** | The approver who made the decision. | 
**AsAtDecided** | **DateTimeOffset** | The asAt datetime at which the decision was made. | 
**AsAtSuperseded** | **DateTimeOffset?** | The asAt datetime at which this entry was superseded. Null when it is the current standing entry. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string approvalCode = "approvalCode";
string decision = "decision";
string reason = "example reason";
string userId = "userId";

RecApprovalDecision recApprovalDecisionInstance = new RecApprovalDecision(
    approvalCode: approvalCode,
    decision: decision,
    reason: reason,
    userId: userId,
    asAtDecided: asAtDecided,
    asAtSuperseded: asAtSuperseded);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
