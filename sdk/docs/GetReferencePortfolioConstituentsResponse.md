# Lusid.Sdk.Model.GetReferencePortfolioConstituentsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveFrom** | **DateTimeOffset** |  | 
**WeightType** | **string** | The available values are: Static, Floating, Periodical | 
**PeriodType** | **string** | The available values are: Daily, Weekly, Monthly, Quarterly, Annually | [optional] 
**PeriodCount** | **int?** |  | [optional] 
**Constituents** | [**List&lt;ReferencePortfolioConstituent&gt;**](ReferencePortfolioConstituent.md) | Set of constituents (instrument/weight pairings) | 
**Href** | **string** | The Uri that returns the same result as the original request,  but may include resolved as at time(s). | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string weightType = "weightType";
string periodType = "example periodType";
List<ReferencePortfolioConstituent> constituents = new List<ReferencePortfolioConstituent>();
string href = "example href";
List<Link> links = new List<Link>();

GetReferencePortfolioConstituentsResponse getReferencePortfolioConstituentsResponseInstance = new GetReferencePortfolioConstituentsResponse(
    effectiveFrom: effectiveFrom,
    weightType: weightType,
    periodType: periodType,
    periodCount: periodCount,
    constituents: constituents,
    href: href,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
