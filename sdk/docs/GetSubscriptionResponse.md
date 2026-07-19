# Lusid.Sdk.Model.GetSubscriptionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** |  | [optional] 
**Value** | [**SubscriptionDefinition**](SubscriptionDefinition.md) |  | [optional] 
**Failed** | [**ErrorDetail**](ErrorDetail.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
SubscriptionDefinition? value = new SubscriptionDefinition();

ErrorDetail? failed = new ErrorDetail();

List<Link> links = new List<Link>();

GetSubscriptionResponse getSubscriptionResponseInstance = new GetSubscriptionResponse(
    href: href,
    value: value,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
