# Lusid.Sdk.Model.TaxClassificationDetail
A single instrument's classification with the version history of every input behind it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Classification** | [**TaxClassification**](TaxClassification.md) |  | 
**History** | [**List&lt;TaxClassificationFieldVersion&gt;**](TaxClassificationFieldVersion.md) | Every version of every classification input and override for the instrument, oldest first. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
TaxClassification classification = new TaxClassification();
List<TaxClassificationFieldVersion> history = new List<TaxClassificationFieldVersion>();
List<Link> links = new List<Link>();

TaxClassificationDetail taxClassificationDetailInstance = new TaxClassificationDetail(
    href: href,
    classification: classification,
    history: history,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
