# Lusid.Sdk.Model.RecReviewRequiredApproval
One approval a submitted review has to collect, and who may give it. All of a configuration's approvals are  required, they may be given in any order, and no user may give more than one of them.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApprovalCode** | **string** | The client-defined identifier for the approval, e.g. \&quot;Desk\&quot; or \&quot;Risk\&quot;. Each may appear at most once. | 
**Description** | **string** | A human-readable label for the approval. | [optional] 
**DecidingUser** | **string** | A boolean expression over the user attempting the approval, which has to hold for them to give it. They must also hold the entitlement for the decide action. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string approvalCode = "approvalCode";
string description = "example description";
string decidingUser = "example decidingUser";

RecReviewRequiredApproval recReviewRequiredApprovalInstance = new RecReviewRequiredApproval(
    approvalCode: approvalCode,
    description: description,
    decidingUser: decidingUser);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
