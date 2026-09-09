# Lusid.Sdk.Model.CurrencyGroupResponse
A currency group: a set of related currencies sharing a major unit (e.g. GBP with minor unit GBX at 100:1).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the currency group. This uniquely identifies the currency group within the tenant. | [optional] 
**DisplayName** | **string** | The name of the currency group. | [optional] 
**Description** | **string** | A description for the currency group. | [optional] 
**MajorUnitCurrency** | **string** | The three-letter, case-sensitive currency code of the group&#39;s major unit, e.g. GBP for the sterling group. | [optional] 
**CirculationDomain** | **string** | The domain in which the group&#39;s currencies circulate, e.g. an ISO 3166 country code. | [optional] 
**MinorUnits** | [**List&lt;CurrencyGroupMinorUnit&gt;**](CurrencyGroupMinorUnit.md) | The minor unit currencies belonging to this currency group. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "example code";
string displayName = "example displayName";
string description = "example description";
string majorUnitCurrency = "example majorUnitCurrency";
string circulationDomain = "example circulationDomain";
List<CurrencyGroupMinorUnit> minorUnits = new List<CurrencyGroupMinorUnit>();
ModelVersion? varVersion = new ModelVersion();

string href = "example href";
List<Link> links = new List<Link>();

CurrencyGroupResponse currencyGroupResponseInstance = new CurrencyGroupResponse(
    code: code,
    displayName: displayName,
    description: description,
    majorUnitCurrency: majorUnitCurrency,
    circulationDomain: circulationDomain,
    minorUnits: minorUnits,
    varVersion: varVersion,
    href: href,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
