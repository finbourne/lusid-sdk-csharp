# Lusid.Sdk.Model.GetAddressKeyAliasResponse
The response to a singular address key alias read. There is deliberately no failure block on this  type: every route returning it is a singular (or list-of-singular) read, never a batch keyed  lookup, so there is no per-key error to report - an invalid entity is rejected at upsert and  a failed read fails the whole request. The IGetResponse batch members below throw for the  same reason; do not reintroduce a Failed property when copying this shape.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** |  | [optional] 
**Value** | [**AddressKeyAlias**](AddressKeyAlias.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
AddressKeyAlias? value = new AddressKeyAlias();

List<Link> links = new List<Link>();

GetAddressKeyAliasResponse getAddressKeyAliasResponseInstance = new GetAddressKeyAliasResponse(
    href: href,
    value: value,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
