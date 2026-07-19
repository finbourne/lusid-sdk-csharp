# Lusid.Sdk.Model.ComplexMarketDataActivityAdjustment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NavActivityAdjustmentType** | **string** | The type of the entity being applied, for example a PortfolioTransaction. Available values: PortfolioTransactionAdjustment, PortfolioSettlementInstructionAdjustment, InstrumentActivityAdjustment, QuoteActivityAdjustment, ComplexMarketDataActivityAdjustment. | 
**NavActivityAdjustmentSource** | **string** | The post closed activity source of the given entity, for example Manual. Available values: Undefined, Manual, Auto. | 
**AsAt** | **DateTimeOffset** | The asAt time for which the adjustment is being applied. | 
**EffectiveAt** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The EffectiveAt time of the entity event that need to be added to the closed period. | 
**EntityUniqueId** | **string** | The EntityUniqueId from the entity which needs to be added as a post close activity. | 

```csharp
using Lusid.Sdk.Model;
using System;

string navActivityAdjustmentSource = "navActivityAdjustmentSource";
DateTimeOrCutLabel effectiveAt = "effectiveAt";
string entityUniqueId = "entityUniqueId";

ComplexMarketDataActivityAdjustment complexMarketDataActivityAdjustmentInstance = new ComplexMarketDataActivityAdjustment(
    navActivityAdjustmentSource: navActivityAdjustmentSource,
    asAt: asAt,
    effectiveAt: effectiveAt,
    entityUniqueId: entityUniqueId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
