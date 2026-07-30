# Lusid.Sdk.Model.RecRequestedResultRevision
A result flagged for re-review as part of a Request Revisions decision.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecResultId** | **string** | The identifier of the result to flag for re-review. | 
**CommentText** | **string** | An optional per-result comment added to the result&#39;s user comments. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string recResultId = "recResultId";
string commentText = "example commentText";

RecRequestedResultRevision recRequestedResultRevisionInstance = new RecRequestedResultRevision(
    recResultId: recResultId,
    commentText: commentText);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
