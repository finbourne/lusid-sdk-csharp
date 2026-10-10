# Lusid.Sdk.Model.DirectionSpreads
The tiers of spread for one direction of net cashflow and what their bounds measure.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Basis** | **string** | What the tier bounds measure: Amount, the size of the net cashflow in the fund currency, or PctOfNav, the net cashflow as a percentage of the previous valuation point&#39;s NAV. Available values: Amount, PctOfNav. | 
**Tiers** | [**List&lt;SwingSpreadTier&gt;**](SwingSpreadTier.md) | The tiers, in ascending order. Each starts where the previous one ends, and only the last is unbounded above. The first tier&#39;s lower bound is the threshold: a flow at or below it does not swing. | 

```csharp
using Lusid.Sdk.Model;
using System;

string basis = "basis";
List<SwingSpreadTier> tiers = new List<SwingSpreadTier>();

DirectionSpreads directionSpreadsInstance = new DirectionSpreads(
    basis: basis,
    tiers: tiers);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
