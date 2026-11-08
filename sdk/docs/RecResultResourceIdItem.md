# Lusid.Sdk.Model.RecResultResourceIdItem
An item within a rec result for one LUSID entity that a scope and a code identify: one entity on a side of a  LusidEntity rec. The itemType is the entity type. The entity unique id identifies it. The item also holds the  display name of the entity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**EntityUniqueId** | **string** | The unique id of the entity the run read. It identifies the entity across scopes. | 
**EntityDisplayName** | **string** | The display name of the entity, as it stood at the dates the run read its side. | [optional] 
**ItemType** | **string** | The polymorphic item-type discriminator: Holding, ValuedHolding, Transaction, SettlementActivity, RelationalDataPoint or the entity type of a LusidEntity rec. Names the item rather than the rec type: Holding and CashHolding recs produce Holding items, a Valuation rec produces ValuedHolding items, both transaction rec types produce Transaction items, and a relational dataset side produces RelationalDataPoint items whatever the rec type. A LusidEntity rec produces items of its entity type, for example Instrument items. Available values: SettlementActivity, Holding, Transaction, ValuedHolding, RelationalDataPoint, Instrument, LegalEntity, Portfolio. | 
**RuleAndAttributeValues** | **Dictionary&lt;string, string&gt;** | The core rule, aggregate rule and supplemental attribute values for the item, keyed by name. | [optional] 
**WritebackSuggestions** | [**List&lt;WritebackSuggestion&gt;**](WritebackSuggestion.md) | The writebacks suggested against this item, as configured by the matching ruleset&#39;s writebackConfigurations. Only ever populated on target-side items. Suggestions only: a user is expected to review them before acting. Required, but may be empty. | [readonly] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string entityUniqueId = "entityUniqueId";
string entityDisplayName = "example entityDisplayName";
string itemType = "itemType";
Dictionary<string, string> ruleAndAttributeValues = new Dictionary<string, string>();
List<WritebackSuggestion> writebackSuggestions = new List<WritebackSuggestion>();

RecResultResourceIdItem recResultResourceIdItemInstance = new RecResultResourceIdItem(
    id: id,
    entityUniqueId: entityUniqueId,
    entityDisplayName: entityDisplayName,
    itemType: itemType,
    ruleAndAttributeValues: ruleAndAttributeValues,
    writebackSuggestions: writebackSuggestions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
