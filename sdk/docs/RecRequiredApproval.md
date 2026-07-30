# Lusid.Sdk.Model.RecRequiredApproval
An approval slot required for a result set, passed through from the rec definition's review configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApprovalCode** | **string** | Client-defined identifier for the approval slot (e.g. &#39;Desk&#39;, &#39;Risk&#39;). | 
**Description** | **string** | Human-readable label for the approval slot. | [optional] 
**CurrentUserCanDecide** | **bool** | Whether the calling user may decide this approval slot, pre-evaluated at request time. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string approvalCode = "approvalCode";
string description = "example description";
bool currentUserCanDecide = //"True";

RecRequiredApproval recRequiredApprovalInstance = new RecRequiredApproval(
    approvalCode: approvalCode,
    description: description,
    currentUserCanDecide: currentUserCanDecide);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
