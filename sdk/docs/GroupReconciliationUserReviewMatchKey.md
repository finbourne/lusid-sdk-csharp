# Lusid.Sdk.Model.GroupReconciliationUserReviewMatchKey

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MatchKey** | **string** | The match key of the reconciliation result. | 
**UserId** | **string** | Id of the user who made a User Review input. | [optional] 
**AsAtAdded** | **DateTimeOffset** | The timestamp of the added User Review input. | [optional] 
**AsAtInvalid** | **DateTimeOffset** | The timestamp when User Review input became invalid e.g. because of the different attribute values within the new run. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string matchKey = "matchKey";
string userId = "example userId";

GroupReconciliationUserReviewMatchKey groupReconciliationUserReviewMatchKeyInstance = new GroupReconciliationUserReviewMatchKey(
    matchKey: matchKey,
    userId: userId,
    asAtAdded: asAtAdded,
    asAtInvalid: asAtInvalid);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
