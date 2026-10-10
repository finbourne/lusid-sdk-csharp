# Lusid.Sdk.Model.SwingSpreadTier
One tier of spread: the band of net cashflow it covers and the spread applied when the flow falls in it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LowerBoundExclusive** | **decimal** | The size of net cashflow, as a magnitude, above which the tier applies. Zero or more; zero on the first tier swings on any net flow. | 
**UpperBoundInclusive** | **decimal?** | The size of net cashflow, as a magnitude, up to and including which the tier applies. Omit it on the last tier, which covers every larger flow. | [optional] 
**Bps** | **decimal** | The spread, in basis points of the baseline price, applied when the net cashflow falls in the tier. Zero or more. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal lowerBoundExclusive = "lowerBoundExclusive";
decimal bps = "bps";


SwingSpreadTier swingSpreadTierInstance = new SwingSpreadTier(
    lowerBoundExclusive: lowerBoundExclusive,
    upperBoundInclusive: upperBoundInclusive,
    bps: bps);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
