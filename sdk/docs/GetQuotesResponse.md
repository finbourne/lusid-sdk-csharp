# Lusid.Sdk.Model.GetQuotesResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Values** | [**Dictionary&lt;string, Quote&gt;**](Quote.md) | The quotes which have been successfully retrieved. | [optional] 
**NotFound** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The quotes that could not be found along with a reason why. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The quotes that could not be retrieved due to an error along with a reason for their failure. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
Dictionary<string, Quote> values = new Dictionary<string, Quote>();
Dictionary<string, ErrorDetail> notFound = new Dictionary<string, ErrorDetail>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

GetQuotesResponse getQuotesResponseInstance = new GetQuotesResponse(
    href: href,
    values: values,
    notFound: notFound,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
