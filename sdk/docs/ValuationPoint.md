# Lusid.Sdk.Model.ValuationPoint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**ValuationPointCode** | **string** | The code of the Valuation Point. | [optional] 
**Variant** | **string** | The Variant name for the Valuation Point. | [optional] 
**Name** | **string** | Identifiable Name assigned to the Valuation Point. | [optional] 
**Status** | **string** | The status of the Valuation Point. Available values: Undefined, Estimate, Final, Candidate, Unofficial. | 
**ApplyClearDown** | **bool** | Indicates whether a clear down was applied when the Valuation Point was created. | [optional] 
**EffectiveAt** | **DateTimeOffset** | The effective time of the Valuation Point. | 
**QueryAsAt** | **DateTimeOffset** | The AsAt time of the Valuation Point. This is the AsAt time that will be used when requests are made using the entry. | [optional] 
**HoldingsAsAt** | **DateTimeOffset** | The AsAt time used for building holdings in the Valuation Point. | [optional] 
**ValuationAsAt** | **DateTimeOffset** | The AsAt time used for performing valuations in the Valuation Point. | [optional] 
**Previous** | [**PreviousValuationPoint**](PreviousValuationPoint.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The Valuation Point properties. These are from the &#39;DiaryEntry&#39; domain. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
string valuationPointCode = "example valuationPointCode";
string variant = "example variant";
string name = "example name";
string status = "status";
bool applyClearDown = //"True";
PreviousValuationPoint? previous = new PreviousValuationPoint();

Dictionary<string, Property> properties = new Dictionary<string, Property>();
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

ValuationPoint valuationPointInstance = new ValuationPoint(
    href: href,
    valuationPointCode: valuationPointCode,
    variant: variant,
    name: name,
    status: status,
    applyClearDown: applyClearDown,
    effectiveAt: effectiveAt,
    queryAsAt: queryAsAt,
    holdingsAsAt: holdingsAsAt,
    valuationAsAt: valuationAsAt,
    previous: previous,
    properties: properties,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
