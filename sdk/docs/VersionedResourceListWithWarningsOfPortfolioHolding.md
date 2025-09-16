# Lusid.Sdk.Model.VersionedResourceListWithWarningsOfPortfolioHolding

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | 
**Values** | [**List&lt;PortfolioHolding&gt;**](PortfolioHolding.md) | The resources to list. | 
**Href** | **string** | The URI of the resource list. | [optional] 
**NextPage** | **string** | The next page of results. | [optional] 
**PreviousPage** | **string** | The previous page of results. | [optional] 
**Warnings** | [**List&lt;Warning&gt;**](Warning.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ModelVersion varVersion = new ModelVersion();
List<PortfolioHolding> values = new List<PortfolioHolding>();
string href = "example href";
string nextPage = "example nextPage";
string previousPage = "example previousPage";
List<Warning> warnings = new List<Warning>();
List<Link> links = new List<Link>();

VersionedResourceListWithWarningsOfPortfolioHolding versionedResourceListWithWarningsOfPortfolioHoldingInstance = new VersionedResourceListWithWarningsOfPortfolioHolding(
    varVersion: varVersion,
    values: values,
    href: href,
    nextPage: nextPage,
    previousPage: previousPage,
    warnings: warnings,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
