# Lusid.Sdk.Model.PostCloseActivitiesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PostCloseActivities** | [**List&lt;PostCloseActivity&gt;**](PostCloseActivity.md) | A collection of post-close activities. | 

```csharp
using Lusid.Sdk.Model;
using System;

List<PostCloseActivity> postCloseActivities = new List<PostCloseActivity>();

PostCloseActivitiesRequest postCloseActivitiesRequestInstance = new PostCloseActivitiesRequest(
    postCloseActivities: postCloseActivities);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
