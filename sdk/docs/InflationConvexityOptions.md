# Lusid.Sdk.Model.InflationConvexityOptions
Parameters of the Jarrow-Yildirim convexity correction applied to projected inflation index  values. Unlike most option blocks there is no defaulting here: nothing in the pricing chain  infers an index volatility, a nominal volatility or a correlation from market data, so an armed  correction is entirely the caller's stated view and every member must be supplied.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NominalIndexCorrelation** | **decimal?** | Correlation between the inflation index and the nominal short rate, in [-1, 1]. A positive  correlation makes the factor greater than one for a projection funded later than the curve&#39;s  own observation basis. | [optional] 
**IndexVolatility** | **decimal?** | Lognormal volatility of the inflation index, as a decimal (0.0095 is 0.95%). Must be  strictly positive - a zero volatility disarms the correction arithmetically, which is what  omitting the whole block already expresses. | [optional] 
**NominalVolatility** | **decimal?** | Volatility of the nominal short rate in the Hull-White dynamics the correction assumes, as a  decimal (0.008 is 80bp). Must be strictly positive. | [optional] 
**NominalMeanReversion** | **decimal?** | Mean reversion speed of the nominal short rate, per year. Must be strictly positive: the  closed form divides by it. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;


InflationConvexityOptions inflationConvexityOptionsInstance = new InflationConvexityOptions(
    nominalIndexCorrelation: nominalIndexCorrelation,
    indexVolatility: indexVolatility,
    nominalVolatility: nominalVolatility,
    nominalMeanReversion: nominalMeanReversion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
