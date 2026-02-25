# Lusid.Sdk.Model.QuoteActivity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NavActivityAdjustmentType** | **string** | . The available values are: PortfolioTransaction, PortfolioSettlementInstruction, InstrumentActivity, QuoteActivity | 
**AsAt** | **DateTimeOffset** | The asAt time for which the adjustment is being applied. | 
**EffectiveAt** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The EffectiveAt time of the quote event that need to be added to the closed period. | 
**EntityUniqueId** | **string** | The EntityUniqueId from the quote which needs to be added as a post close activity. | 
**InstrumentId** | **string** | The InstrumentId from the quote which needs to be added as a post close activity. | 

```csharp
using Lusid.Sdk.Model;
using System;

DateTimeOrCutLabel effectiveAt = "effectiveAt";
string entityUniqueId = "entityUniqueId";
string instrumentId = "instrumentId";

QuoteActivity quoteActivityInstance = new QuoteActivity(
    asAt: asAt,
    effectiveAt: effectiveAt,
    entityUniqueId: entityUniqueId,
    instrumentId: instrumentId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
