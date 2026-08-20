# Lusid.Sdk.Model.RecResultItem
An individual item that makes up (one side of) a rec result. Polymorphic by rec type / item type.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemType** | **string** | The polymorphic item-type discriminator (e.g. SettlementActivity, Holding, Transaction). Available values: SettlementActivity, Holding, Transaction. | 
**RuleAndAttributeValues** | **Dictionary&lt;string, string&gt;** | The core rule, aggregate rule and supplemental attribute values for the item, keyed by name. | [optional] [readonly] 

```csharp
using Lusid.Sdk.Model;
using System;

string itemType = "itemType";
Dictionary<string, string> ruleAndAttributeValues = new Dictionary<string, string>();

RecResultItem recResultItemInstance = new RecResultItem(
    itemType: itemType,
    ruleAndAttributeValues: ruleAndAttributeValues);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
