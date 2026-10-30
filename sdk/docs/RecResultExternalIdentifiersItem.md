# Lusid.Sdk.Model.RecResultExternalIdentifiersItem
An item within a rec result for one LUSID entity that external identifiers identify: one entity on a side of a  LusidEntity rec (itemType Instrument). The entity unique id identifies it. The item also holds the display name of  the entity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityScope** | **string** | The scope of the entity the run read. Null for an entity type that has no scope. | [optional] 
**EntityUniqueId** | **string** | The unique id of the entity the run read. It identifies the entity across scopes. | 
**EntityDisplayName** | **string** | The display name of the entity, as it stood at the dates the run read its side. | [optional] 
**Identifiers** | **Dictionary&lt;string, string&gt;** | The unique identifiers of the entity, keyed by identifier property key. The values are as at the dates the run read the side of the item, so they can differ from the current values. | 
**ItemType** | **string** | The polymorphic item-type discriminator: Holding, ValuedHolding, Transaction, SettlementActivity, RelationalDataPoint or Instrument. Names the item rather than the rec type: Holding and CashHolding recs produce Holding items, a Valuation rec produces ValuedHolding items, both transaction rec types produce Transaction items, and a relational dataset side produces RelationalDataPoint items whatever the rec type. An instrument side of a LusidEntity rec produces Instrument items. Available values: SettlementActivity, Holding, Transaction, ValuedHolding, RelationalDataPoint, Instrument. | 
**RuleAndAttributeValues** | **Dictionary&lt;string, string&gt;** | The core rule, aggregate rule and supplemental attribute values for the item, keyed by name. | [optional] 
**WritebackSuggestions** | [**List&lt;WritebackSuggestion&gt;**](WritebackSuggestion.md) | The writebacks suggested against this item, as configured by the matching ruleset&#39;s writebackConfigurations. Only ever populated on target-side items. Suggestions only: a user is expected to review them before acting. Required, but may be empty. | [readonly] 

```csharp
using Lusid.Sdk.Model;
using System;

string entityScope = "example entityScope";
string entityUniqueId = "entityUniqueId";
string entityDisplayName = "example entityDisplayName";
Dictionary<string, string> identifiers = new Dictionary<string, string>();
string itemType = "itemType";
Dictionary<string, string> ruleAndAttributeValues = new Dictionary<string, string>();
List<WritebackSuggestion> writebackSuggestions = new List<WritebackSuggestion>();

RecResultExternalIdentifiersItem recResultExternalIdentifiersItemInstance = new RecResultExternalIdentifiersItem(
    entityScope: entityScope,
    entityUniqueId: entityUniqueId,
    entityDisplayName: entityDisplayName,
    identifiers: identifiers,
    itemType: itemType,
    ruleAndAttributeValues: ruleAndAttributeValues,
    writebackSuggestions: writebackSuggestions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
