# Lusid.Sdk.Model.GetCreditSupportAnnexResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Value** | [**CreditSupportAnnex**](CreditSupportAnnex.md) |  | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The credit support annex that could not be updated or inserted along with a reason for failure. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
CreditSupportAnnex? value = new CreditSupportAnnex();

Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

GetCreditSupportAnnexResponse getCreditSupportAnnexResponseInstance = new GetCreditSupportAnnexResponse(
    href: href,
    value: value,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
