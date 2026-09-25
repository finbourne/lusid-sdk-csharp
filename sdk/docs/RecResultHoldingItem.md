# Lusid.Sdk.Model.RecResultHoldingItem
A holding-shaped item within a rec result: the holding a Holding or CashHolding rec reconciled  (itemType Holding), or the one a Valuation rec valued (itemType ValuedHolding).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**HoldingId** | **string** | The holding identifier, at holding level: the same id whichever granularity the holding was read at, so that items of different rec types over one holding name it alike. | [optional] 
**TaxLotId** | **string** | The tax lot the item is, where the source row was a single lot: a lot of a position read by tax lot, or a cash commitment. Null for an aggregated position and for a cash balance. Opaque: compare it whole, do not parse it. | [optional] 
**ItemType** | **string** | The polymorphic item-type discriminator: Holding, ValuedHolding, Transaction or SettlementActivity. Names the item rather than the rec type: Holding and CashHolding recs produce Holding items, a Valuation rec produces ValuedHolding items, and both transaction rec types produce Transaction items. Available values: SettlementActivity, Holding, Transaction, ValuedHolding. | 
**RuleAndAttributeValues** | **Dictionary&lt;string, string&gt;** | The core rule, aggregate rule and supplemental attribute values for the item, keyed by name. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId portfolioId = new ResourceId();
string holdingId = "example holdingId";
string taxLotId = "example taxLotId";
string itemType = "itemType";
Dictionary<string, string> ruleAndAttributeValues = new Dictionary<string, string>();

RecResultHoldingItem recResultHoldingItemInstance = new RecResultHoldingItem(
    portfolioId: portfolioId,
    holdingId: holdingId,
    taxLotId: taxLotId,
    itemType: itemType,
    ruleAndAttributeValues: ruleAndAttributeValues);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
