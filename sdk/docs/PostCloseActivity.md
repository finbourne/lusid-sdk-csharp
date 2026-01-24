# Lusid.Sdk.Model.PostCloseActivity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | The type of the entity, possible values are: * &#x60;PortfolioTransaction&#x60;, * &#x60;Instrument&#x60;, * &#x60;InstrumentEvent&#x60;, * &#x60;InstrumentEventInstruction&#x60;, * &#x60;PortfolioSettlementInstruction&#x60;, and, * &#x60;Quote&#x60;. | 
**EntityUniqueId** | **string** | The entity unique ID. The expected format for each entity is: | entityType                       | entityUniqueId                                    | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | &#x60;PortfolioTransaction&#x60;           | &#x60;portfolioUniqueId_transactionId&#x60;                 | | &#x60;Instrument&#x60;                     | &#x60;instrumentUniqueId&#x60;                              | | &#x60;InstrumentEvent&#x60;                | &#x60;corporateActionSourceUniqueId_instrumentEventId&#x60; | | &#x60;InstrumentEventInstruction&#x60;     | &#x60;portfolioUniqueId_instructionId&#x60;                 | | &#x60;PortfolioSettlementInstruction&#x60; | &#x60;portfolioUniqueId_settlementInstructionId&#x60;       | | &#x60;Quote&#x60;                          | &#x60;quoteSeriesUniqueId_quoteSeriesInstrumentId&#x60;     | | 
**AsAt** | **DateTimeOffset** | The &#x60;AsAt&#x60; time of the event that needs to be added to the closed period. | 
**EffectiveAt** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The &#x60;EffectiveAt&#x60; time of the event that need to be added to the closed period. This can be a date or cut label. Only applicable for &#x60;Quote&#x60; post-close activities. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string entityType = "entityType";
string entityUniqueId = "entityUniqueId";
DateTimeOrCutLabel effectiveAt = "example effectiveAt";

PostCloseActivity postCloseActivityInstance = new PostCloseActivity(
    entityType: entityType,
    entityUniqueId: entityUniqueId,
    asAt: asAt,
    effectiveAt: effectiveAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
