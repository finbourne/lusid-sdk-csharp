# Lusid.Sdk.Model.RealisedGainLoss

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentScope** | **string** | The scope in which the instrument lies. | [optional] 
**InstrumentUid** | **string** | The unique Lusid Instrument Id (LUID) of the instrument that this gain or loss is associated with. | 
**Units** | **decimal** | The number of units of the associated instrument against which the gain or loss has been realised. | 
**PurchaseTradeDate** | **DateTimeOffset?** | The effective datetime at which the units associated with this gain or loss were originally purchased. | [optional] [readonly] 
**PurchaseSettlementDate** | **DateTimeOffset?** | The effective datetime at which the units associated with this gain or loss were originally settled. | [optional] [readonly] 
**PurchasePrice** | **decimal?** | The purchase price of each unit associated with this gain or loss. | [optional] 
**CostTradeCcy** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**CostPortfolioCcy** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**RealisedTradeCcy** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**RealisedTotal** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**RealisedMarket** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**RealisedCurrency** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**TaxLotId** | **string** | The identifier of the tax lot with which this gain or loss is associated. | [optional] 
**RealisedAmortisation** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentScope = "example instrumentScope";
string instrumentUid = "instrumentUid";decimal units = "units";

CurrencyAndAmount costTradeCcy = new CurrencyAndAmount();
CurrencyAndAmount costPortfolioCcy = new CurrencyAndAmount();
CurrencyAndAmount realisedTradeCcy = new CurrencyAndAmount();
CurrencyAndAmount realisedTotal = new CurrencyAndAmount();
CurrencyAndAmount? realisedMarket = new CurrencyAndAmount();

CurrencyAndAmount? realisedCurrency = new CurrencyAndAmount();

string taxLotId = "example taxLotId";
CurrencyAndAmount? realisedAmortisation = new CurrencyAndAmount();


RealisedGainLoss realisedGainLossInstance = new RealisedGainLoss(
    instrumentScope: instrumentScope,
    instrumentUid: instrumentUid,
    units: units,
    purchaseTradeDate: purchaseTradeDate,
    purchaseSettlementDate: purchaseSettlementDate,
    purchasePrice: purchasePrice,
    costTradeCcy: costTradeCcy,
    costPortfolioCcy: costPortfolioCcy,
    realisedTradeCcy: realisedTradeCcy,
    realisedTotal: realisedTotal,
    realisedMarket: realisedMarket,
    realisedCurrency: realisedCurrency,
    taxLotId: taxLotId,
    realisedAmortisation: realisedAmortisation);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
