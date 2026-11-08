# Lusid.Sdk.Model.RealisedGainLossMatchedLot
The lot a realised chargeable-gains leg was matched against: its cost in the portfolio currency, the date of the  acquisition that opened it and its chargeable-gains role.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OriginalCost** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**PurchaseDate** | **DateTimeOffset?** |  | [optional] 
**Role** | **string** | Available values: DayLot, Section104Pool, Holding1982, Holding1965, FutureAcquisition. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

CurrencyAndAmount? originalCost = new CurrencyAndAmount();

string role = "example role";

RealisedGainLossMatchedLot realisedGainLossMatchedLotInstance = new RealisedGainLossMatchedLot(
    originalCost: originalCost,
    purchaseDate: purchaseDate,
    role: role);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
