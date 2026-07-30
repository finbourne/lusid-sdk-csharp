# Lusid.Sdk.Model.RecMatchCounts
Counts for non-exception results (Match, Cross).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Total** | **int** | The total number of results in this category. | 
**ByResultType** | [**RecMatchCountByResultType**](RecMatchCountByResultType.md) |  | 
**ByReviewStatus** | [**RecResultCountByReviewStatus**](RecResultCountByReviewStatus.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

RecMatchCountByResultType byResultType = new RecMatchCountByResultType();
RecResultCountByReviewStatus byReviewStatus = new RecResultCountByReviewStatus();

RecMatchCounts recMatchCountsInstance = new RecMatchCounts(
    total: total,
    byResultType: byResultType,
    byReviewStatus: byReviewStatus);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
