# Lusid.Sdk.Model.QualifyingInvestmentsHistory
The daily qualifying-investments history of one collective investment scheme and the flips within it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Luid** | **string** | The LUSID instrument identifier of the collective investment scheme. | 
**ThresholdPercent** | **decimal** | The qualifying investments percentage the scheme must exceed to be a bond fund. | 
**Observations** | [**List&lt;QualifyingInvestmentsObservation&gt;**](QualifyingInvestmentsObservation.md) | The daily qualifying investments observations in the requested window, oldest first. | 
**Crossings** | [**List&lt;QualifyingInvestmentsCrossing&gt;**](QualifyingInvestmentsCrossing.md) | Each pair of consecutive observations where the bond fund result flipped. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
string luid = "luid";decimal thresholdPercent = "thresholdPercent";

List<QualifyingInvestmentsObservation> observations = new List<QualifyingInvestmentsObservation>();
List<QualifyingInvestmentsCrossing> crossings = new List<QualifyingInvestmentsCrossing>();
List<Link> links = new List<Link>();

QualifyingInvestmentsHistory qualifyingInvestmentsHistoryInstance = new QualifyingInvestmentsHistory(
    href: href,
    luid: luid,
    thresholdPercent: thresholdPercent,
    observations: observations,
    crossings: crossings,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
