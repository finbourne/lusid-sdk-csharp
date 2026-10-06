# Lusid.Sdk.Model.RevertValuationPointResponse
A Valuation Point reverted to Estimate, with all of its variants. Any variant that finalising the Valuation Point  had rejected is brought back as an Estimate by the revert, and is reported here alongside it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**ValuationPointCode** | **string** | The code of the Valuation Point. | [optional] 
**NavTypeCode** | **string** | The navTypeCode of the Fund Calendar Entry. This is the code of the NAV type that this Calendar Entry is associated with. | [optional] 
**Status** | **string** | The status of the Valuation Point. Available values: Undefined, Estimate, Final, Candidate, Rejected, Unofficial. | 
**ApplyClearDown** | **bool** | Indicates whether a clear down was applied when the Valuation Point was created. | [optional] 
**EffectiveAt** | **DateTimeOffset** | The effective time of the Valuation Point. | 
**Previous** | [**PreviousValuationPoint**](PreviousValuationPoint.md) |  | [optional] 
**Variants** | [**List&lt;EstimateVariant&gt;**](EstimateVariant.md) | The variants of the Estimate Valuation Point.  | [optional] 
**StagedModifications** | [**StagedModificationsInfo**](StagedModificationsInfo.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
string valuationPointCode = "example valuationPointCode";
string navTypeCode = "example navTypeCode";
string status = "status";
bool applyClearDown = //"True";
PreviousValuationPoint? previous = new PreviousValuationPoint();

List<EstimateVariant> variants = new List<EstimateVariant>();
StagedModificationsInfo? stagedModifications = new StagedModificationsInfo();

List<Link> links = new List<Link>();

RevertValuationPointResponse revertValuationPointResponseInstance = new RevertValuationPointResponse(
    href: href,
    valuationPointCode: valuationPointCode,
    navTypeCode: navTypeCode,
    status: status,
    applyClearDown: applyClearDown,
    effectiveAt: effectiveAt,
    previous: previous,
    variants: variants,
    stagedModifications: stagedModifications,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
