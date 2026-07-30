# Lusid.Sdk.Model.RecReview
A summary of the per-result review state across the result set.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CountReviewed** | **int** | The number of results with review status Reviewed. | 
**CountRequired** | **int** | The number of results with review status Required. | 
**CountNotRequired** | **int** | The number of results with review status Not Required. | 
**CompletionRatio** | **decimal** | Reviewed / (Reviewed + Required). Is 1.0 when the denominator is zero, and null when execution failed. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal completionRatio = "completionRatio";


RecReview recReviewInstance = new RecReview(
    countReviewed: countReviewed,
    countRequired: countRequired,
    countNotRequired: countNotRequired,
    completionRatio: completionRatio);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
