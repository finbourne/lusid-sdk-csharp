# Lusid.Sdk.Model.AppendMarketData
Base class for types containing required data to append to complex market data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketDataType** | **string** | The available values are: AppendFxForwardCurveByQuoteReference, AppendFxForwardCurveData, AppendFxForwardPipsCurveData, AppendFxForwardTenorCurveData, AppendFxForwardTenorPipsCurveData | 

```csharp
using Lusid.Sdk.Model;
using System;

string marketDataType = "marketDataType";

AppendMarketData appendMarketDataInstance = new AppendMarketData(
    marketDataType: marketDataType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
