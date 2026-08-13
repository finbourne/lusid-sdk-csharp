# Lusid.Sdk.Model.RecUserComment
A user-authored comment attached to a rec result. Carried forward with the result across runs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CommentId** | **string** | System-generated GUID identifying the comment. Set once on creation. | 
**CommentText** | **string** | The body of the comment. | 
**UserId** | **string** | The author of the comment. | 
**AsAtCreated** | **DateTimeOffset** | The asAt time the comment was created. Set once. | 
**AsAtModified** | **DateTimeOffset** | The asAt time the comment was last modified. Equals asAtCreated until the first edit. | 

```csharp
using Lusid.Sdk.Model;
using System;

string commentId = "commentId";
string commentText = "commentText";
string userId = "userId";

RecUserComment recUserCommentInstance = new RecUserComment(
    commentId: commentId,
    commentText: commentText,
    userId: userId,
    asAtCreated: asAtCreated,
    asAtModified: asAtModified);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
