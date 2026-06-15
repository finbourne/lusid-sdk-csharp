# Lusid.Sdk.Model.GetAddressKeyAliasResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** |  | [optional] 
**Value** | [**AddressKeyAlias**](AddressKeyAlias.md) |  | [optional] 
**Failed** | [**ErrorDetail**](ErrorDetail.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
AddressKeyAlias? value = new AddressKeyAlias();

ErrorDetail? failed = new ErrorDetail();

List<Link> links = new List<Link>();

GetAddressKeyAliasResponse getAddressKeyAliasResponseInstance = new GetAddressKeyAliasResponse(
    href: href,
    value: value,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
