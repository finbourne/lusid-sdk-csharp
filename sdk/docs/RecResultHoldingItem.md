# Lusid.Sdk.Model.RecResultHoldingItem
A holding-shaped item within a rec result: the holding a Holding or CashHolding rec reconciled  (itemType Holding), or the one a Valuation rec valued (itemType ValuedHolding). Also holds the display names  of the portfolio and the holding's instrument.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**PortfolioDisplayName** | **string** | The display name of the item&#39;s portfolio, as it stood at the asAt the run read its data. Null where the run did not read it. | [optional] 
**HoldingId** | **string** | The holding identifier, at holding level: the same id whichever granularity the holding was read at, so that items of different rec types over one holding name it alike. | [optional] 
**TaxLotId** | **string** | The tax lot the item is, where the source row was a single lot: a lot of a position read by tax lot, or a cash commitment. Null for an aggregated position and for a cash balance. Opaque: compare it whole, do not parse it. | [optional] 
**HoldingInstrumentScope** | **string** | The scope of the holding&#39;s instrument. Null where the source does not state one. | [optional] 
**HoldingLusidInstrumentId** | **string** | The LUID of the holding&#39;s instrument. Null where the source does not state it. | [optional] 
**HoldingInstrumentName** | **string** | The name of the holding&#39;s instrument, as it stood at the asAt the run read its data. Null where the run did not resolve it. | [optional] 
**ItemType** | **string** | The polymorphic item-type discriminator: Holding, ValuedHolding, Transaction, SettlementActivity or RelationalDataPoint. Names the item rather than the rec type: Holding and CashHolding recs produce Holding items, a Valuation rec produces ValuedHolding items, both transaction rec types produce Transaction items, and a relational dataset side produces RelationalDataPoint items whatever the rec type. Available values: SettlementActivity, Holding, Transaction, ValuedHolding, RelationalDataPoint. | 
**RuleAndAttributeValues** | **Dictionary&lt;string, string&gt;** | The core rule, aggregate rule and supplemental attribute values for the item, keyed by name. | [optional] 
**WritebackSuggestions** | [**List&lt;WritebackSuggestion&gt;**](WritebackSuggestion.md) | The writebacks suggested against this item, as configured by the matching ruleset&#39;s writebackConfigurations. Only ever populated on target-side items. Suggestions only: a user is expected to review them before acting. Required, but may be empty. | [readonly] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId portfolioId = new ResourceId();
string portfolioDisplayName = "example portfolioDisplayName";
string holdingId = "example holdingId";
string taxLotId = "example taxLotId";
string holdingInstrumentScope = "example holdingInstrumentScope";
string holdingLusidInstrumentId = "example holdingLusidInstrumentId";
string holdingInstrumentName = "example holdingInstrumentName";
string itemType = "itemType";
Dictionary<string, string> ruleAndAttributeValues = new Dictionary<string, string>();
List<WritebackSuggestion> writebackSuggestions = new List<WritebackSuggestion>();

RecResultHoldingItem recResultHoldingItemInstance = new RecResultHoldingItem(
    portfolioId: portfolioId,
    portfolioDisplayName: portfolioDisplayName,
    holdingId: holdingId,
    taxLotId: taxLotId,
    holdingInstrumentScope: holdingInstrumentScope,
    holdingLusidInstrumentId: holdingLusidInstrumentId,
    holdingInstrumentName: holdingInstrumentName,
    itemType: itemType,
    ruleAndAttributeValues: ruleAndAttributeValues,
    writebackSuggestions: writebackSuggestions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
