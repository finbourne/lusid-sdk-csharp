# Lusid.Sdk.Model.GetSubscriptionResponse
The response to a singular subscription read. There is deliberately no failure block on this  type: every route returning it is a singular (or list-of-singular) read, never a batch keyed  lookup, so there is no per-key error to report - an invalid entity is rejected at upsert and  a failed read fails the whole request. The IGetResponse batch members below throw for the  same reason; do not reintroduce a Failed property when copying this shape.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** |  | [optional] 
**Value** | [**SubscriptionDefinition**](SubscriptionDefinition.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
SubscriptionDefinition? value = new SubscriptionDefinition();

List<Link> links = new List<Link>();

GetSubscriptionResponse getSubscriptionResponseInstance = new GetSubscriptionResponse(
    href: href,
    value: value,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
