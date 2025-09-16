# Lusid.Sdk.Model.AppendFxForwardCurveData
Used to append a new point to an FX curve defined using `FxForwardCurveData`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketDataType** | **string** | The available values are: AppendFxForwardCurveByQuoteReference, AppendFxForwardCurveData, AppendFxForwardPipsCurveData, AppendFxForwardTenorCurveData, AppendFxForwardTenorPipsCurveData | 
**Date** | **DateTimeOffset** | Date for which the forward rate applies. | 
**Rate** | **decimal** | Rate provided for the fx forward (price in FgnCcy per unit of DomCcy). | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal rate = "rate";


AppendFxForwardCurveData appendFxForwardCurveDataInstance = new AppendFxForwardCurveData(
    date: date,
    rate: rate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
