# Lusid.Sdk.Model.BucketBalanceFigures
A bucket's opening balance, activity and closing balance, which always satisfy opening + activity = closing.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Open** | **decimal** | The balance at the start of the bucket. | [optional] 
**Activity** | **decimal** | The sum of the bucket&#39;s cash flows. | [optional] 
**Close** | **decimal** | The balance at the end of the bucket: Open + Activity. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal? open = "example open";decimal? activity = "example activity";decimal? close = "example close";
List<Link> links = new List<Link>();

BucketBalanceFigures bucketBalanceFiguresInstance = new BucketBalanceFigures(
    open: open,
    activity: activity,
    close: close,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
