# Lusid.Sdk.Model.CompositeBreakdown
A list of Composite Breakdowns.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveAt** | **DateTimeOffset** | The effectiveAt for the calculation. | 
**Composite** | [**PortfolioReturnBreakdown**](PortfolioReturnBreakdown.md) |  | [optional] 
**Constituents** | [**List&lt;PortfolioReturnBreakdown&gt;**](PortfolioReturnBreakdown.md) | The constituents with their information which are part of the composite. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

PortfolioReturnBreakdown? composite = new PortfolioReturnBreakdown();

List<PortfolioReturnBreakdown> constituents = new List<PortfolioReturnBreakdown>();

CompositeBreakdown compositeBreakdownInstance = new CompositeBreakdown(
    effectiveAt: effectiveAt,
    composite: composite,
    constituents: constituents);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
