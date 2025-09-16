# Lusid.Sdk.Model.EquityModelOptions
Model options for equity related pricing.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelOptionsType** | **string** | The available values are: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, CdsModelOptions | 
**EquityForwardProjectionType** | **string** | Determines how forward equity prices should be projected.                Supported string (enumeration) values are: [FlatForwardCurveFromSpot, EquityCurveByPrices, ForwardProjectedFromRatesCurve]. | 

```csharp
using Lusid.Sdk.Model;
using System;

string equityForwardProjectionType = "equityForwardProjectionType";

EquityModelOptions equityModelOptionsInstance = new EquityModelOptions(
    equityForwardProjectionType: equityForwardProjectionType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
