# Lusid.Sdk.Model.AggregatedReturnsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Results** | **Dictionary&lt;string, List&lt;AggregatedReturn&gt;&gt;** | Aggregated returns grouped by ReturnId | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
Dictionary<string, List<AggregatedReturn>> results = new Dictionary<string, List<AggregatedReturn>>();
List<Link> links = new List<Link>();

AggregatedReturnsResponse aggregatedReturnsResponseInstance = new AggregatedReturnsResponse(
    href: href,
    results: results,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
