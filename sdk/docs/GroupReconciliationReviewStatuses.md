# Lusid.Sdk.Model.GroupReconciliationReviewStatuses

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CountPending** | **int** | The number of comparison results of reviewStatus \&quot;Pending\&quot; with this instanceId and reconciliationType | 
**LinkPending** | [**Link**](Link.md) |  | 
**CountReviewed** | **int** | The number of comparison results of reviewStatus \&quot;Reviewed\&quot; with this instanceId and reconciliationType | 
**LinkReviewed** | [**Link**](Link.md) |  | 
**CountMatched** | **int** | The number of comparison results of reviewStatus \&quot;Matched\&quot; with this instanceId and reconciliationType | 
**LinkMatched** | [**Link**](Link.md) |  | 
**CountInvalid** | **int** | The number of comparison results of reviewStatus \&quot;Invalid\&quot; with this instanceId and reconciliationType | 
**LinkInvalid** | [**Link**](Link.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

Link linkPending = new Link();
Link linkReviewed = new Link();
Link linkMatched = new Link();
Link linkInvalid = new Link();

GroupReconciliationReviewStatuses groupReconciliationReviewStatusesInstance = new GroupReconciliationReviewStatuses(
    countPending: countPending,
    linkPending: linkPending,
    countReviewed: countReviewed,
    linkReviewed: linkReviewed,
    countMatched: countMatched,
    linkMatched: linkMatched,
    countInvalid: countInvalid,
    linkInvalid: linkInvalid);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
