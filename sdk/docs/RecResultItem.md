# Lusid.Sdk.Model.RecResultItem
An individual item that makes up (one side of) a rec result. Polymorphic by itemType; each value has a  corresponding inherited class.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemType** | **string** | The polymorphic item-type discriminator: Holding, ValuedHolding, Transaction or SettlementActivity. Names the item rather than the rec type: Holding and CashHolding recs produce Holding items, a Valuation rec produces ValuedHolding items, and both transaction rec types produce Transaction items. Available values: SettlementActivity, Holding, Transaction, ValuedHolding. | 
**RuleAndAttributeValues** | **Dictionary&lt;string, string&gt;** | The core rule, aggregate rule and supplemental attribute values for the item, keyed by name. | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**HoldingId** | **string** | The holding identifier, at holding level: the same id whichever granularity the holding was read at, so that items of different rec types over one holding name it alike. | [optional] 
**TaxLotId** | **string** | The tax lot the item is, where the source row was a single lot: a lot of a position read by tax lot, or a cash commitment. Null for an aggregated position and for a cash balance. Opaque: compare it whole, do not parse it. | [optional] 
**ActivityId** | **string** | The settlement activity identifier. | [optional] 
**TransactionId** | **string** | The transaction identifier. | [optional] 
**SettlementInstructionId** | **string** | The settlement instruction identifier. | [optional] 
**HoldingImpacts** | [**List&lt;RecResultHoldingImpact&gt;**](RecResultHoldingImpact.md) | The holdings, and where the source states them the tax lots, the item impacted. A distinct set ordered by holdingId then taxLotId; may be empty. An input transaction has not run the movements engine and impacts nothing yet. | 

```csharp
using Lusid.Sdk.Model;
using System;
```
 [RecResultHoldingItem](./RecResultHoldingItem.md)See all compatible oneOf types with RecResultItem

# Example with RecResultItem
{
     Type  =  "RecResultHoldingItem"
};
//Create RecResultItem Instance
var recResultItemInstance = new recResultItem(recResultHoldingItemInstance)


 * [RecResultSettlementActivityItem](./RecResultSettlementActivityItem.md)
 * [RecResultTransactionItem](./RecResultTransactionItem.md)

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
