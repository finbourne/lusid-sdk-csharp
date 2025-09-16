# Lusid.Sdk.Model.GroupReconciliationUserReviewComment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CommentText** | **string** | User&#39;s comment regarding the reconciliation result. | 
**UserId** | **string** | Id of the user who made a User Review input. | [optional] 
**AsAtAdded** | **DateTimeOffset** | The timestamp of the added User Review input. | [optional] 
**AsAtInvalid** | **DateTimeOffset** | The timestamp when User Review input became invalid e.g. because of the different attribute values within the new run. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string commentText = "commentText";
string userId = "example userId";

GroupReconciliationUserReviewComment groupReconciliationUserReviewCommentInstance = new GroupReconciliationUserReviewComment(
    commentText: commentText,
    userId: userId,
    asAtAdded: asAtAdded,
    asAtInvalid: asAtInvalid);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
