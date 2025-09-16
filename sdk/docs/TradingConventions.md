# Lusid.Sdk.Model.TradingConventions
Common Trading details for exchange traded instruments like Futures and Bonds

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PriceScaleFactor** | **decimal** | The factor used to scale prices for the instrument. Currently used by LUSID when calculating cost  and notional amounts on transactions. Note this factor does not yet impact Valuation, PV, exposure,  all of which use the scale factor attached to the price quotes in the QuoteStore.  Must be positive and defaults to 1 if not set. | [optional] 
**MinimumOrderSize** | **decimal** | The Minimum Order Size  Must be non-negative and defaults to 0 if not set. | [optional] 
**MinimumOrderIncrement** | **decimal** | The Minimum Order Increment  Must be non-negative and defaults to 0 if not set. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal? priceScaleFactor = "example priceScaleFactor";decimal? minimumOrderSize = "example minimumOrderSize";decimal? minimumOrderIncrement = "example minimumOrderIncrement";

TradingConventions tradingConventionsInstance = new TradingConventions(
    priceScaleFactor: priceScaleFactor,
    minimumOrderSize: minimumOrderSize,
    minimumOrderIncrement: minimumOrderIncrement);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
