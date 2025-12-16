# Lusid.Sdk.Model.ValuationPointOverview

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**DiaryEntryCode** | **string** | The code for the Valuation Point. | 
**DiaryEntryVariant** | **string** | The Variant for the Valuation Point. Together with the valuation point code marks the unique branch for the NavType. | [optional] 
**EffectiveFrom** | **DateTimeOffset** | The effective time of the last Valuation Point. | 
**EffectiveTo** | **DateTimeOffset** | The effective time of the current Valuation Point. | 
**QueryAsAt** | **DateTimeOffset** | The query time of the Valuation Point. Defaults to latest. | [optional] 
**Type** | **string** | The type of the diary entry. This is &#39;ValuationPoint&#39;. | 
**Status** | **string** | The status of the Valuation Point. Can be &#39;Estimate&#39;, &#39;Candidate&#39; or &#39;Final&#39;. | 
**Gav** | **decimal** | The Gross Asset Value of the Fund or Share Class at the Valuation Point. This is effectively a summation of all Trial balance entries linked to accounts of types &#39;Asset&#39; and &#39;Liabilities&#39;. | 
**Nav** | **decimal** | The Net Asset Value of the Fund or Share Class at the Valuation Point. This represents the GAV with any fees applied in the period. | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The Fee properties. These will be from the &#39;Fee&#39; domain. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
string diaryEntryCode = "diaryEntryCode";
string diaryEntryVariant = "example diaryEntryVariant";
string type = "type";
string status = "status";decimal gav = "gav";
decimal nav = "nav";

Dictionary<string, Property> properties = new Dictionary<string, Property>();
List<Link> links = new List<Link>();

ValuationPointOverview valuationPointOverviewInstance = new ValuationPointOverview(
    href: href,
    diaryEntryCode: diaryEntryCode,
    diaryEntryVariant: diaryEntryVariant,
    effectiveFrom: effectiveFrom,
    effectiveTo: effectiveTo,
    queryAsAt: queryAsAt,
    type: type,
    status: status,
    gav: gav,
    nav: nav,
    properties: properties,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
