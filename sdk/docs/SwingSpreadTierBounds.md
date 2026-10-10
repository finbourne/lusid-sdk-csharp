# Lusid.Sdk.Model.SwingSpreadTierBounds
The bounds of the spread tier a net cashflow fell in.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LowerBoundExclusive** | **decimal** | The tier&#39;s lower bound, which the net cashflow was above. | 
**UpperBoundInclusive** | **decimal?** | The tier&#39;s upper bound, which the net cashflow was at or below. Absent for the unbounded last tier. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal lowerBoundExclusive = "lowerBoundExclusive";


SwingSpreadTierBounds swingSpreadTierBoundsInstance = new SwingSpreadTierBounds(
    lowerBoundExclusive: lowerBoundExclusive,
    upperBoundInclusive: upperBoundInclusive);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
