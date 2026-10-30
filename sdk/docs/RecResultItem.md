# Lusid.Sdk.Model.RecResultItem
An individual item that makes up (one side of) a rec result. Polymorphic by itemType; each value has a  corresponding inherited class.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemType** | **string** | The polymorphic item-type discriminator: Holding, ValuedHolding, Transaction, SettlementActivity, RelationalDataPoint or Instrument. Names the item rather than the rec type: Holding and CashHolding recs produce Holding items, a Valuation rec produces ValuedHolding items, both transaction rec types produce Transaction items, and a relational dataset side produces RelationalDataPoint items whatever the rec type. An instrument side of a LusidEntity rec produces Instrument items. Available values: SettlementActivity, Holding, Transaction, ValuedHolding, RelationalDataPoint, Instrument. | 
**RuleAndAttributeValues** | **Dictionary&lt;string, string&gt;** | The core rule, aggregate rule and supplemental attribute values for the item, keyed by name. | [optional] 
**WritebackSuggestions** | [**List&lt;WritebackSuggestion&gt;**](WritebackSuggestion.md) | The writebacks suggested against this item, as configured by the matching ruleset&#39;s writebackConfigurations. Only ever populated on target-side items. Suggestions only: a user is expected to review them before acting. Required, but may be empty. | [readonly] 
**EntityScope** | **string** | The scope of the entity the run read. Null for an entity type that has no scope. | [optional] 
**EntityUniqueId** | **string** | The unique id of the entity the run read. It identifies the entity across scopes. | 
**EntityDisplayName** | **string** | The display name of the entity, as it stood at the dates the run read its side. | [optional] 
**Identifiers** | **Dictionary&lt;string, string&gt;** | The unique identifiers of the entity, keyed by identifier property key. The values are as at the dates the run read the side of the item, so they can differ from the current values. | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**PortfolioDisplayName** | **string** | The display name of the item&#39;s portfolio, as it stood at the asAt the run read its data. Null where the run did not read it. | [optional] 
**HoldingId** | **string** | The holding identifier, at holding level: the same id whichever granularity the holding was read at, so that items of different rec types over one holding name it alike. | [optional] 
**TaxLotId** | **string** | The tax lot the item is, where the source row was a single lot: a lot of a position read by tax lot, or a cash commitment. Null for an aggregated position and for a cash balance. Opaque: compare it whole, do not parse it. | [optional] 
**HoldingInstrumentScope** | **string** | The scope of the holding&#39;s instrument. Null where the source does not state one. | [optional] 
**HoldingLusidInstrumentId** | **string** | The LUID of the holding&#39;s instrument. Null where the source does not state it. | [optional] 
**HoldingInstrumentName** | **string** | The name of the holding&#39;s instrument, as it stood at the asAt the run read its data. Null where the run did not resolve it. | [optional] 
**RelationalDatasetDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**RelationalDatasetDefinitionDisplayName** | **string** | The display name of the relational dataset definition the item&#39;s row belongs to, as it stood at the asAt the run read its data. Null where the run did not read it. | [optional] 
**RelationalDataPointUniqueId** | **string** | The unique id of the relational data point the run read, as minted by the relational dataset store. Opaque: compare it whole, do not parse it. | 
**ActivityId** | **string** | The settlement activity identifier. | [optional] 
**ActivityInstrumentScope** | **string** | The scope of the settlement activity&#39;s instrument. Null where the source does not state one. | [optional] 
**ActivityLusidInstrumentId** | **string** | The LUID of the settlement activity&#39;s instrument. Null where the source does not state it. | [optional] 
**ActivityInstrumentName** | **string** | The name of the settlement activity&#39;s instrument, as it stood at the asAt the run read its data. Null where the run did not resolve it. | [optional] 
**TransactionId** | **string** | The transaction identifier. | [optional] 
**TransactionInstrumentScope** | **string** | The scope of the transaction&#39;s resolved instrument. Null where the source does not state one. | [optional] 
**TransactionLusidInstrumentId** | **string** | The LUID of the transaction&#39;s resolved instrument. Null where the source does not state it. | [optional] 
**TransactionInstrumentName** | **string** | The name of the transaction&#39;s resolved instrument, as it stood at the asAt the run read its data. Null where the run did not resolve it. | [optional] 
**SettlementInstructionId** | **string** | The settlement instruction identifier. | [optional] 
**HoldingImpacts** | [**List&lt;RecResultHoldingImpact&gt;**](RecResultHoldingImpact.md) | The holdings, and where the source states them the tax lots, the item impacted. A distinct set ordered by holdingId then taxLotId; may be empty. An input transaction has not run the movements engine and impacts nothing yet. | 

```csharp
using Lusid.Sdk.Model;
using System;
```
 [RecResultExternalIdentifiersItem](./RecResultExternalIdentifiersItem.md)See all compatible oneOf types with RecResultItem

# Example with RecResultItem
{
     Type  =  "RecResultExternalIdentifiersItem"
};
//Create RecResultItem Instance
var recResultItemInstance = new recResultItem(recResultExternalIdentifiersItemInstance)


 * [RecResultHoldingItem](./RecResultHoldingItem.md)
 * [RecResultRelationalDataItem](./RecResultRelationalDataItem.md)
 * [RecResultSettlementActivityItem](./RecResultSettlementActivityItem.md)
 * [RecResultTransactionItem](./RecResultTransactionItem.md)

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
