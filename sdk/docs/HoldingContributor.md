# Lusid.Sdk.Model.HoldingContributor
A list of transactions contributed to a holding.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Transaction** | [**Transaction**](Transaction.md) |  | 
**HoldingId** | **long?** | The unique holding identifier | [optional] 
**Movements** | [**List&lt;MovementSettlementSummary&gt;**](MovementSettlementSummary.md) | Movements contributed to holding | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Transaction transaction = new Transaction();
List<MovementSettlementSummary> movements = new List<MovementSettlementSummary>();

HoldingContributor holdingContributorInstance = new HoldingContributor(
    transaction: transaction,
    holdingId: holdingId,
    movements: movements);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
