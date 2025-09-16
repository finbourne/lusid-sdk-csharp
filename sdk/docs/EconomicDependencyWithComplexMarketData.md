# Lusid.Sdk.Model.EconomicDependencyWithComplexMarketData
Container class pairing economic dependency and complex market data (i.e. discounting curves, etc.)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EconomicDependency** | [**EconomicDependency**](EconomicDependency.md) |  | 
**ComplexMarketData** | [**ComplexMarketData**](ComplexMarketData.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

EconomicDependency economicDependency = new EconomicDependency();
ComplexMarketData complexMarketData = new ComplexMarketData();

EconomicDependencyWithComplexMarketData economicDependencyWithComplexMarketDataInstance = new EconomicDependencyWithComplexMarketData(
    economicDependency: economicDependency,
    complexMarketData: complexMarketData);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
