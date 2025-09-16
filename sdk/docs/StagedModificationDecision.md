# Lusid.Sdk.Model.StagedModificationDecision

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAt** | **DateTimeOffset** | Time the decision request is made. | [optional] 
**UserId** | **string** | ID of user that approved the request. | [optional] 
**RequestId** | **string** | ID of user that made the request. | [optional] 
**Decision** | **string** | The decision on the requested staged modification, can be &#39;Approve&#39; or &#39;Reject&#39;. | [optional] 
**Comment** | **string** | Comment on decision. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string userId = "example userId";
string requestId = "example requestId";
string decision = "example decision";
string comment = "example comment";

StagedModificationDecision stagedModificationDecisionInstance = new StagedModificationDecision(
    asAt: asAt,
    userId: userId,
    requestId: requestId,
    decision: decision,
    comment: comment);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
