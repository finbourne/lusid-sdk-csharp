# Lusid.Sdk.Model.GroupReconciliationUserReviewAdd

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BreakCode** | **string** | The break code of the reconciliation result. | [optional] 
**MatchKey** | **string** | The match key of the reconciliation result. | [optional] 
**CommentText** | **string** | User&#39;s comment regarding the reconciliation result. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string breakCode = "example breakCode";
string matchKey = "example matchKey";
string commentText = "example commentText";

GroupReconciliationUserReviewAdd groupReconciliationUserReviewAddInstance = new GroupReconciliationUserReviewAdd(
    breakCode: breakCode,
    matchKey: matchKey,
    commentText: commentText);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
