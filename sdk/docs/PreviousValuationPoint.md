# Lusid.Sdk.Model.PreviousValuationPoint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ValuationPointCode** | **string** | The code of the Valuation Point. | 
**Name** | **string** | Identifiable Name assigned to the Valuation Point. | [optional] 
**EffectiveAt** | **DateTimeOffset** | The effective time of the Valuation Point. | 
**QueryAsAt** | **DateTimeOffset** | The AsAt time of the Valuation Point. This is the AsAt time that will be used when requests are made using the entry. | 
**HoldingsAsAt** | **DateTimeOffset** | The AsAt time used for building holdings in the Valuation Point. | [optional] 
**ValuationAsAt** | **DateTimeOffset** | The AsAt time used for performing valuations in the Valuation Point. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string valuationPointCode = "valuationPointCode";
string name = "example name";

PreviousValuationPoint previousValuationPointInstance = new PreviousValuationPoint(
    valuationPointCode: valuationPointCode,
    name: name,
    effectiveAt: effectiveAt,
    queryAsAt: queryAsAt,
    holdingsAsAt: holdingsAsAt,
    valuationAsAt: valuationAsAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
