# Lusid.Sdk.Model.MarketDataOverrides
Class which holds market data overrides to be used in valuation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComplexMarketData** | [**List&lt;EconomicDependencyWithComplexMarketData&gt;**](EconomicDependencyWithComplexMarketData.md) | A list of EconomicDependency paired with quote data satisfying that economic dependency | [optional] 
**Quotes** | [**List&lt;EconomicDependencyWithQuote&gt;**](EconomicDependencyWithQuote.md) | A list of EconomicDependency paired with a ComplexMarketData satisfying that economic dependency | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<EconomicDependencyWithComplexMarketData> complexMarketData = new List<EconomicDependencyWithComplexMarketData>();
List<EconomicDependencyWithQuote> quotes = new List<EconomicDependencyWithQuote>();

MarketDataOverrides marketDataOverridesInstance = new MarketDataOverrides(
    complexMarketData: complexMarketData,
    quotes: quotes);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
