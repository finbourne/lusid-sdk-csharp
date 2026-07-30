# Lusid.Sdk.Model.RecClosedExceptionCounts
Counts for results that are exceptions with a Closed status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Total** | **int** | The total number of results in this category. | 
**ByClosureType** | [**RecExceptionCountByClosureType**](RecExceptionCountByClosureType.md) |  | 
**ByReviewStatus** | [**RecResultCountByReviewStatus**](RecResultCountByReviewStatus.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

RecExceptionCountByClosureType byClosureType = new RecExceptionCountByClosureType();
RecResultCountByReviewStatus byReviewStatus = new RecResultCountByReviewStatus();

RecClosedExceptionCounts recClosedExceptionCountsInstance = new RecClosedExceptionCounts(
    total: total,
    byClosureType: byClosureType,
    byReviewStatus: byReviewStatus);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
