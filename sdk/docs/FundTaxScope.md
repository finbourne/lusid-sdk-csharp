# Lusid.Sdk.Model.FundTaxScope
The UK chargeable-gains tax scope of a fund at a point in time: the portfolios inside the regime and what the  regime's figures leave out.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Portfolios** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The portfolios within the UK chargeable-gains regime. A fund portfolio is in scope when its own details elect the regime. A NAV type that elects the regime puts its derived portfolio for each fund portfolio in scope. | 
**Exclusions** | [**FundTaxScopeExclusions**](FundTaxScopeExclusions.md) |  | 
**EffectiveAt** | **DateTimeOffset** | The effective datetime at which the tax scope was read. | 
**AsAt** | **DateTimeOffset** | The asAt datetime at which the tax scope was read. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
List<ResourceId> portfolios = new List<ResourceId>();
FundTaxScopeExclusions exclusions = new FundTaxScopeExclusions();
List<Link> links = new List<Link>();

FundTaxScope fundTaxScopeInstance = new FundTaxScope(
    href: href,
    portfolios: portfolios,
    exclusions: exclusions,
    effectiveAt: effectiveAt,
    asAt: asAt,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
