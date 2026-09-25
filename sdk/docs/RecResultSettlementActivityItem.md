# Lusid.Sdk.Model.RecResultSettlementActivityItem
A settlement-activity item within a rec result.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**ActivityId** | **string** | The settlement activity identifier. | [optional] 
**TransactionId** | **string** | The transaction identifier. | [optional] 
**SettlementInstructionId** | **string** | The settlement instruction identifier. | [optional] 
**HoldingImpacts** | [**List&lt;RecResultHoldingImpact&gt;**](RecResultHoldingImpact.md) | The holdings, and where the source states them the tax lots, the item impacted. A distinct set ordered by holdingId then taxLotId; may be empty. An input transaction has not run the movements engine and impacts nothing yet. | 
**ItemType** | **string** | The polymorphic item-type discriminator: Holding, ValuedHolding, Transaction or SettlementActivity. Names the item rather than the rec type: Holding and CashHolding recs produce Holding items, a Valuation rec produces ValuedHolding items, and both transaction rec types produce Transaction items. Available values: SettlementActivity, Holding, Transaction, ValuedHolding. | 
**RuleAndAttributeValues** | **Dictionary&lt;string, string&gt;** | The core rule, aggregate rule and supplemental attribute values for the item, keyed by name. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId portfolioId = new ResourceId();
string activityId = "example activityId";
string transactionId = "example transactionId";
string settlementInstructionId = "example settlementInstructionId";
List<RecResultHoldingImpact> holdingImpacts = new List<RecResultHoldingImpact>();
string itemType = "itemType";
Dictionary<string, string> ruleAndAttributeValues = new Dictionary<string, string>();

RecResultSettlementActivityItem recResultSettlementActivityItemInstance = new RecResultSettlementActivityItem(
    portfolioId: portfolioId,
    activityId: activityId,
    transactionId: transactionId,
    settlementInstructionId: settlementInstructionId,
    holdingImpacts: holdingImpacts,
    itemType: itemType,
    ruleAndAttributeValues: ruleAndAttributeValues);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
