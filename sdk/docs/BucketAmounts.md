# Lusid.Sdk.Model.BucketAmounts
An amount in the payment currency.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Local** | **decimal** | The amount in the payment currency. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal? local = "example local";
List<Link> links = new List<Link>();

BucketAmounts bucketAmountsInstance = new BucketAmounts(
    local: local,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
