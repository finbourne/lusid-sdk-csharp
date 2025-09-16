# Lusid.Sdk.Model.AppendFxForwardTenorPipsCurveData
Used to append a new point to an FX curve defined using `FxForwardTenorPipsCurveData`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketDataType** | **string** | The available values are: AppendFxForwardCurveByQuoteReference, AppendFxForwardCurveData, AppendFxForwardPipsCurveData, AppendFxForwardTenorCurveData, AppendFxForwardTenorPipsCurveData | 
**Tenor** | **string** | Tenor for which the forward rate applies. | 
**PipRate** | **decimal** | Rate provided for the fx forward (price in FgnCcy per unit of DomCcy), expressed in pips. | 

```csharp
using Lusid.Sdk.Model;
using System;

string tenor = "tenor";decimal pipRate = "pipRate";


AppendFxForwardTenorPipsCurveData appendFxForwardTenorPipsCurveDataInstance = new AppendFxForwardTenorPipsCurveData(
    tenor: tenor,
    pipRate: pipRate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
