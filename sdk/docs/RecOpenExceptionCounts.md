# Lusid.Sdk.Model.RecOpenExceptionCounts
Counts for results that are exceptions with an Open status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Total** | **int** | The total number of results in this category. | 
**ByResultType** | [**RecExceptionCountByResultType**](RecExceptionCountByResultType.md) |  | 
**ByReviewStatus** | [**RecResultCountByReviewStatus**](RecResultCountByReviewStatus.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

RecExceptionCountByResultType byResultType = new RecExceptionCountByResultType();
RecResultCountByReviewStatus byReviewStatus = new RecResultCountByReviewStatus();

RecOpenExceptionCounts recOpenExceptionCountsInstance = new RecOpenExceptionCounts(
    total: total,
    byResultType: byResultType,
    byReviewStatus: byReviewStatus);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
