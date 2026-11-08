# Lusid.Sdk.Model.RealisedGainLossChargeableGains
The UK chargeable-gains figures the engine worked for a realised-gain/loss leg: the chargeable gain, the  indexation allowance and the part of it taken, the proceeds the leg was worked on, both sides of the s.35  kink test on a 1982 holding, the basis and identification rule the leg was matched under, the lot it was  matched against, whether its transaction stands reversed, and the treatment applied. All amounts are in  the portfolio currency.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChargeableGain** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**IndexationAllowance** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**IndexationAllowanceTaken** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**Proceeds** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**GainOnOriginalCost** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**GainOnMarketValue1982** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**Basis** | **string** | Available values: IndexedCost, MarketValue1982, OriginalCost, NilGain. | [optional] 
**MatchRule** | **string** | Available values: SameDay, TenDay, Section210B, Section104Pool, Holding1982, Holding1965. | [optional] 
**MatchedLot** | [**RealisedGainLossMatchedLot**](RealisedGainLossMatchedLot.md) |  | [optional] 
**MarketValue1965** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**Reversed** | **bool** |  | [optional] 
**TaxTreatment** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

CurrencyAndAmount? chargeableGain = new CurrencyAndAmount();

CurrencyAndAmount? indexationAllowance = new CurrencyAndAmount();

CurrencyAndAmount? indexationAllowanceTaken = new CurrencyAndAmount();

CurrencyAndAmount? proceeds = new CurrencyAndAmount();

CurrencyAndAmount? gainOnOriginalCost = new CurrencyAndAmount();

CurrencyAndAmount? gainOnMarketValue1982 = new CurrencyAndAmount();

string basis = "example basis";
string matchRule = "example matchRule";
RealisedGainLossMatchedLot? matchedLot = new RealisedGainLossMatchedLot();

CurrencyAndAmount? marketValue1965 = new CurrencyAndAmount();

bool reversed = //"True";
string taxTreatment = "example taxTreatment";

RealisedGainLossChargeableGains realisedGainLossChargeableGainsInstance = new RealisedGainLossChargeableGains(
    chargeableGain: chargeableGain,
    indexationAllowance: indexationAllowance,
    indexationAllowanceTaken: indexationAllowanceTaken,
    proceeds: proceeds,
    gainOnOriginalCost: gainOnOriginalCost,
    gainOnMarketValue1982: gainOnMarketValue1982,
    basis: basis,
    matchRule: matchRule,
    matchedLot: matchedLot,
    marketValue1965: marketValue1965,
    reversed: reversed,
    taxTreatment: taxTreatment);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
