# Lusid.Sdk.Model.RecReviewSubmission
When the reviewer is allowed to submit their work for approval. Omit it to let them submit at any time.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompletionRatioThreshold** | **decimal** | The review completion ratio a result set has to reach before it can be submitted, between 0.0 and 1.0 inclusive. | 
**AutoSubmit** | **bool** | Whether the system submits on the reviewer&#39;s behalf as soon as the completion ratio threshold is met, rather than waiting to be asked. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal completionRatioThreshold = "completionRatioThreshold";

bool autoSubmit = //"True";

RecReviewSubmission recReviewSubmissionInstance = new RecReviewSubmission(
    completionRatioThreshold: completionRatioThreshold,
    autoSubmit: autoSubmit);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
