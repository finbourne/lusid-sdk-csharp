# Lusid.Sdk.Model.SettlementFx
The FX gain or loss on a settlement instruction, with its transaction's realised gain or loss.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SettlementCurrency** | **string** |  | [optional] 
**SettlementAmount** | **decimal** |  | [optional] 
**PortfolioCurrencyAmount** | **decimal?** |  | [optional] 
**TradeDateFxRate** | **decimal?** |  | [optional] 
**FxRateUsed** | **decimal?** |  | [optional] 
**FxRateSource** | **string** |  | [optional] 
**FxGainLossOnSettlement** | **decimal?** |  | [optional] 
**TotalRealisedGainLossOnTransaction** | **decimal** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string settlementCurrency = "example settlementCurrency";decimal? settlementAmount = "example settlementAmount";
string fxRateSource = "example fxRateSource";decimal? totalRealisedGainLossOnTransaction = "example totalRealisedGainLossOnTransaction";

SettlementFx settlementFxInstance = new SettlementFx(
    settlementCurrency: settlementCurrency,
    settlementAmount: settlementAmount,
    portfolioCurrencyAmount: portfolioCurrencyAmount,
    tradeDateFxRate: tradeDateFxRate,
    fxRateUsed: fxRateUsed,
    fxRateSource: fxRateSource,
    fxGainLossOnSettlement: fxGainLossOnSettlement,
    totalRealisedGainLossOnTransaction: totalRealisedGainLossOnTransaction);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
