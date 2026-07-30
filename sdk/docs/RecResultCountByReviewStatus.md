# Lusid.Sdk.Model.RecResultCountByReviewStatus
Result counts broken down by review status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Required** | **int** | The number of results with review status Required. | 
**NotRequired** | **int** | The number of results with review status Not Required. | 
**Reviewed** | **int** | The number of results with review status Reviewed. | 

```csharp
using Lusid.Sdk.Model;
using System;


RecResultCountByReviewStatus recResultCountByReviewStatusInstance = new RecResultCountByReviewStatus(
    required: required,
    notRequired: notRequired,
    reviewed: reviewed);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
