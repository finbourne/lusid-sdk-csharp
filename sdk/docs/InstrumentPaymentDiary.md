# Lusid.Sdk.Model.InstrumentPaymentDiary
A payment diary containing all the cashflows on a single instrument.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentIdType** | **string** | The identifier type of the instrument. | [optional] 
**InstrumentId** | **string** | The identifier for the instrument. | [optional] 
**InstrumentScope** | **string** | The scope of the instrument. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Legs** | [**List&lt;InstrumentPaymentDiaryLeg&gt;**](InstrumentPaymentDiaryLeg.md) | Aggregated sets of Cashflows. | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentIdType = "example instrumentIdType";
string instrumentId = "example instrumentId";
string instrumentScope = "example instrumentScope";
ModelVersion? varVersion = new ModelVersion();

List<InstrumentPaymentDiaryLeg> legs = new List<InstrumentPaymentDiaryLeg>();
string href = "example href";
List<Link> links = new List<Link>();

InstrumentPaymentDiary instrumentPaymentDiaryInstance = new InstrumentPaymentDiary(
    instrumentIdType: instrumentIdType,
    instrumentId: instrumentId,
    instrumentScope: instrumentScope,
    varVersion: varVersion,
    legs: legs,
    href: href,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
