# Lusid.Sdk.Model.SubmitRecResultSetReviewRequest
The request to submit a result set review for approval (or resubmit after addressing revisions).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CommentText** | **string** | An optional comment recorded on the submission. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string commentText = "example commentText";

SubmitRecResultSetReviewRequest submitRecResultSetReviewRequestInstance = new SubmitRecResultSetReviewRequest(
    commentText: commentText);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
