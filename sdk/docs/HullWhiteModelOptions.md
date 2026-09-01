# Lusid.Sdk.Model.HullWhiteModelOptions
Model options for the Hull-White one-factor lattice pricer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelOptionsType** | **string** | Available values: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, CdsModelOptions, FlexibleLoanPricerOptions, HullWhiteModelOptions, BondLookupModelOptions. | 
**MeanReversion** | **decimal** | The mean reversion speed of the short rate. Must be strictly positive. Defaults to 0.03. | [optional] 
**Volatility** | **decimal** | The normal (absolute) volatility of the short rate, e.g. 0.008 for 80bp per year. Defaults to 0.008. | [optional] 
**LatticeSteps** | **int** | The number of uniform time steps in the lattice. More steps give a finer discretisation  of the short-rate process at greater computational cost. Defaults to 200. | [optional] 
**EffectiveRateBumpSize** | **decimal?** | The parallel curve shift, as an absolute rate, used for the central-difference effective  duration and convexity, e.g. 0.0001 for a 1bp bump. Must be strictly positive.  Defaults to 0.0025 (25bp, the market convention for option-adjusted risk) when not supplied. | [optional] 
**MeanReversionByCurrency** | **Dictionary&lt;string, decimal&gt;** | Per-currency mean-reversion overrides, keyed by ISO currency code.  A currency absent from this map uses MeanReversion. | [optional] 
**VolatilityByCurrency** | **Dictionary&lt;string, decimal&gt;** | Per-currency short-rate volatility overrides, keyed by ISO currency code.  A currency absent from this map uses Volatility. Short-rate volatility is a per-currency  quantity in practice, so a book spanning several currencies can calibrate each currency  separately instead of sharing a single global figure. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal? meanReversion = "example meanReversion";decimal? volatility = "example volatility";
Dictionary<string, decimal> meanReversionByCurrency = new Dictionary<string, decimal>();
Dictionary<string, decimal> volatilityByCurrency = new Dictionary<string, decimal>();

HullWhiteModelOptions hullWhiteModelOptionsInstance = new HullWhiteModelOptions(
    meanReversion: meanReversion,
    volatility: volatility,
    latticeSteps: latticeSteps,
    effectiveRateBumpSize: effectiveRateBumpSize,
    meanReversionByCurrency: meanReversionByCurrency,
    volatilityByCurrency: volatilityByCurrency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
