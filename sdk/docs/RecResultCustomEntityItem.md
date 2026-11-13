# Lusid.Sdk.Model.RecResultCustomEntityItem
An item within a rec result for one custom entity: one entity on a side of a LusidEntity rec of a custom entity  type. The entity unique id identifies it. The item also holds the display name and the identifiers of the entity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | The custom entity type of the entity the run read. It starts with a tilde. | 
**EntityUniqueId** | **string** | The unique id of the entity the run read. It identifies the entity across scopes. | 
**EntityDisplayName** | **string** | The display name of the entity, as it stood at the dates the run read its side. | [optional] 
**Identifiers** | **Dictionary&lt;string, string&gt;** | The unique identifiers of the entity, keyed by identifier property key. The values are as at the dates the run read the side of the item, so they can differ from the current values. | 
**ItemType** | **string** | The polymorphic item-type discriminator: Holding, ValuedHolding, Transaction, SettlementActivity, RelationalDataPoint or the entity type of a LusidEntity rec. Names the item rather than the rec type: Holding and CashHolding recs produce Holding items, a Valuation rec produces ValuedHolding items, both transaction rec types produce Transaction items, and a relational dataset side produces RelationalDataPoint items whatever the rec type. A LusidEntity rec produces items of its entity type, for example Instrument items. Available values: SettlementActivity, Holding, Transaction, ValuedHolding, RelationalDataPoint, Instrument, LegalEntity, Portfolio, CustomEntity. | 
**RuleAndAttributeValues** | **Dictionary&lt;string, string&gt;** | The core rule, aggregate rule and supplemental attribute values for the item, keyed by name. | [optional] 
**WritebackSuggestions** | [**List&lt;WritebackSuggestion&gt;**](WritebackSuggestion.md) | The writebacks suggested against this item, as configured by the matching ruleset&#39;s writebackConfigurations. Only ever populated on target-side items. Suggestions only: a user is expected to review them before acting. Required, but may be empty. | [readonly] 

```csharp
using Lusid.Sdk.Model;
using System;

string entityType = "entityType";
string entityUniqueId = "entityUniqueId";
string entityDisplayName = "example entityDisplayName";
Dictionary<string, string> identifiers = new Dictionary<string, string>();
string itemType = "itemType";
Dictionary<string, string> ruleAndAttributeValues = new Dictionary<string, string>();
List<WritebackSuggestion> writebackSuggestions = new List<WritebackSuggestion>();

RecResultCustomEntityItem recResultCustomEntityItemInstance = new RecResultCustomEntityItem(
    entityType: entityType,
    entityUniqueId: entityUniqueId,
    entityDisplayName: entityDisplayName,
    identifiers: identifiers,
    itemType: itemType,
    ruleAndAttributeValues: ruleAndAttributeValues,
    writebackSuggestions: writebackSuggestions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
