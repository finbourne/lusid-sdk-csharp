# Lusid.Sdk.Model.TargetTaxLotRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Units** | **decimal** | The number of units of the instrument in this tax-lot. | 
**Cost** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**PortfolioCost** | **decimal?** | The total cost of the tax-lot in the transaction portfolio&#39;s base currency. | [optional] 
**Price** | **decimal?** | The purchase price of each unit of the instrument held in this tax-lot. This forms part of the unique key required for multiple tax-lots. | [optional] 
**PurchaseDate** | **DateTimeOffset?** | The purchase date of this tax-lot. This forms part of the unique key required for multiple tax-lots. | [optional] 
**SettlementDate** | **DateTimeOffset?** | The settlement date of the tax-lot&#39;s opening transaction. | [optional] 
**NotionalCost** | **decimal?** | The notional cost of the tax-lot&#39;s opening transaction. | [optional] 
**VariationMargin** | **decimal?** | The variation margin of the tax-lot&#39;s opening transaction. | [optional] 
**VariationMarginPortfolioCcy** | **decimal?** | The variation margin in portfolio currency of the tax-lot&#39;s opening transaction. | [optional] 
**AmortisedCost** | **decimal?** | The amortised cost of the tax-lot in the settlement currency, for example a supplied amortised cost at migration. If supplied, this value seeds the tax-lot&#39;s amortised cost at the adjustment date and amortisation continues forward from it; if not supplied, the amortised cost defaults to the cost of the tax-lot. | [optional] 
**CurrentFace** | **decimal?** | The current face of the tax-lot, i.e. its outstanding notional after any reduction by the instrument&#39;s pool factor. If supplied, this value seeds the tax-lot&#39;s current face, so that later paydowns on an asset-backed instrument reduce the cost against it; if not supplied, a tax-lot that already has a current face keeps its pool factor as its units change. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal units = "units";

CurrencyAndAmount? cost = new CurrencyAndAmount();


TargetTaxLotRequest targetTaxLotRequestInstance = new TargetTaxLotRequest(
    units: units,
    cost: cost,
    portfolioCost: portfolioCost,
    price: price,
    purchaseDate: purchaseDate,
    settlementDate: settlementDate,
    notionalCost: notionalCost,
    variationMargin: variationMargin,
    variationMarginPortfolioCcy: variationMarginPortfolioCcy,
    amortisedCost: amortisedCost,
    currentFace: currentFace);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
