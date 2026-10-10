# Lusid.Sdk.Model.SwingSpreadApplied
The stored spread applied to a share class's baseline price and the tier it came from.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bps** | **decimal** | The spread applied, in basis points. | 
**TierMatched** | [**SwingSpreadTierBounds**](SwingSpreadTierBounds.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal bps = "bps";

SwingSpreadTierBounds tierMatched = new SwingSpreadTierBounds();

SwingSpreadApplied swingSpreadAppliedInstance = new SwingSpreadApplied(
    bps: bps,
    tierMatched: tierMatched);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
