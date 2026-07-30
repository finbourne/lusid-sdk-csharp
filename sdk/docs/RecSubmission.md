# Lusid.Sdk.Model.RecSubmission
An entry in the append-only log of review submissions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **string** | The user who submitted the review. | 
**CommentText** | **string** | An optional comment from the submitter. | [optional] 
**AsAtSubmitted** | **DateTimeOffset** | The asAt datetime at which the submission was made. | 
**AsAtSuperseded** | **DateTimeOffset?** | The asAt datetime at which this entry was superseded. Null when it is the current standing entry. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string userId = "userId";
string commentText = "example commentText";

RecSubmission recSubmissionInstance = new RecSubmission(
    userId: userId,
    commentText: commentText,
    asAtSubmitted: asAtSubmitted,
    asAtSuperseded: asAtSuperseded);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
