# Lusid.Sdk.Model.UpsertReferencePortfolioConstituentPropertiesResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The updated collection of properties of the constituent. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ModelVersion? varVersion = new ModelVersion();

Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
List<Link> links = new List<Link>();

UpsertReferencePortfolioConstituentPropertiesResponse upsertReferencePortfolioConstituentPropertiesResponseInstance = new UpsertReferencePortfolioConstituentPropertiesResponse(
    href: href,
    varVersion: varVersion,
    properties: properties,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
