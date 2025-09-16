# Lusid.Sdk.Model.BatchUpdateUserReviewForComparisonResultRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComparisonResultId** | **string** | Comparison result identifier, encoded value for core attribute results, aggregate attribute results, reconciliation type and run instanceId. | 
**UserReviewAdd** | [**GroupReconciliationUserReviewAdd**](GroupReconciliationUserReviewAdd.md) |  | [optional] 
**UserReviewRemove** | [**GroupReconciliationUserReviewRemove**](GroupReconciliationUserReviewRemove.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string comparisonResultId = "comparisonResultId";
GroupReconciliationUserReviewAdd? userReviewAdd = new GroupReconciliationUserReviewAdd();

GroupReconciliationUserReviewRemove? userReviewRemove = new GroupReconciliationUserReviewRemove();


BatchUpdateUserReviewForComparisonResultRequest batchUpdateUserReviewForComparisonResultRequestInstance = new BatchUpdateUserReviewForComparisonResultRequest(
    comparisonResultId: comparisonResultId,
    userReviewAdd: userReviewAdd,
    userReviewRemove: userReviewRemove);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
