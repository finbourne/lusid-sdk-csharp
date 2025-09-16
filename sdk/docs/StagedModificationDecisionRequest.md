# Lusid.Sdk.Model.StagedModificationDecisionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Decision** | **string** | The decision on the requested staged modification, can be &#39;Approve&#39; or &#39;Reject&#39;. | 
**Comment** | **string** | Comment on decision. | 

```csharp
using Lusid.Sdk.Model;
using System;

string decision = "decision";
string comment = "comment";

StagedModificationDecisionRequest stagedModificationDecisionRequestInstance = new StagedModificationDecisionRequest(
    decision: decision,
    comment: comment);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
