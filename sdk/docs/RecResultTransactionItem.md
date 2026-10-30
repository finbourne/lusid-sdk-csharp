# Lusid.Sdk.Model.RecResultTransactionItem
A transaction item within a rec result. Names the portfolio and the transaction's resolved instrument alongside,  for display.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**PortfolioDisplayName** | **string** | The display name of the item&#39;s portfolio, as it stood at the asAt the run read its data. Null where the run did not read it. | [optional] 
**TransactionId** | **string** | The transaction identifier. | [optional] 
**TransactionInstrumentScope** | **string** | The scope of the transaction&#39;s resolved instrument. Null where the source does not state one. | [optional] 
**TransactionLusidInstrumentId** | **string** | The LUID of the transaction&#39;s resolved instrument. Null where the source does not state it. | [optional] 
**TransactionInstrumentName** | **string** | The name of the transaction&#39;s resolved instrument, as it stood at the asAt the run read its data. Null where the run did not resolve it. | [optional] 
**HoldingImpacts** | [**List&lt;RecResultHoldingImpact&gt;**](RecResultHoldingImpact.md) | The holdings, and where the source states them the tax lots, the item impacted. A distinct set ordered by holdingId then taxLotId; may be empty. An input transaction has not run the movements engine and impacts nothing yet. | 
**ItemType** | **string** | The polymorphic item-type discriminator: Holding, ValuedHolding, Transaction, SettlementActivity, RelationalDataPoint or Instrument. Names the item rather than the rec type: Holding and CashHolding recs produce Holding items, a Valuation rec produces ValuedHolding items, both transaction rec types produce Transaction items, and a relational dataset side produces RelationalDataPoint items whatever the rec type. An instrument side of a LusidEntity rec produces Instrument items. Available values: SettlementActivity, Holding, Transaction, ValuedHolding, RelationalDataPoint, Instrument. | 
**RuleAndAttributeValues** | **Dictionary&lt;string, string&gt;** | The core rule, aggregate rule and supplemental attribute values for the item, keyed by name. | [optional] 
**WritebackSuggestions** | [**List&lt;WritebackSuggestion&gt;**](WritebackSuggestion.md) | The writebacks suggested against this item, as configured by the matching ruleset&#39;s writebackConfigurations. Only ever populated on target-side items. Suggestions only: a user is expected to review them before acting. Required, but may be empty. | [readonly] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId portfolioId = new ResourceId();
string portfolioDisplayName = "example portfolioDisplayName";
string transactionId = "example transactionId";
string transactionInstrumentScope = "example transactionInstrumentScope";
string transactionLusidInstrumentId = "example transactionLusidInstrumentId";
string transactionInstrumentName = "example transactionInstrumentName";
List<RecResultHoldingImpact> holdingImpacts = new List<RecResultHoldingImpact>();
string itemType = "itemType";
Dictionary<string, string> ruleAndAttributeValues = new Dictionary<string, string>();
List<WritebackSuggestion> writebackSuggestions = new List<WritebackSuggestion>();

RecResultTransactionItem recResultTransactionItemInstance = new RecResultTransactionItem(
    portfolioId: portfolioId,
    portfolioDisplayName: portfolioDisplayName,
    transactionId: transactionId,
    transactionInstrumentScope: transactionInstrumentScope,
    transactionLusidInstrumentId: transactionLusidInstrumentId,
    transactionInstrumentName: transactionInstrumentName,
    holdingImpacts: holdingImpacts,
    itemType: itemType,
    ruleAndAttributeValues: ruleAndAttributeValues,
    writebackSuggestions: writebackSuggestions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
