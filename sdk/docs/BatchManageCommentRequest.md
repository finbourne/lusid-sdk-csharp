# Lusid.Sdk.Model.BatchManageCommentRequest
One item of a batch comment request. The operation (add/edit/delete) is inferred from the  combination of commentId and commentText.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecResultId** | **string** | The rec result the comment operation targets. | 
**CommentId** | **string** | The comment id. Null with text &#x3D; add; provided with text &#x3D; edit; provided with null text &#x3D; delete. | [optional] 
**CommentText** | **string** | The comment body. See operation inference. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string recResultId = "recResultId";
string commentId = "example commentId";
string commentText = "example commentText";

BatchManageCommentRequest batchManageCommentRequestInstance = new BatchManageCommentRequest(
    recResultId: recResultId,
    commentId: commentId,
    commentText: commentText);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
