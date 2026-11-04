# Lusid.Sdk.Model.ExternalDealingEstimateLine
One order within an external order set: a share class, a direction and either a number of units or an amount.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentIdentifierType** | **string** |  | 
**InstrumentIdentifier** | **string** |  | 
**InstrumentScope** | **string** |  | [optional] 
**TradeType** | **string** | Available values: Subscription, Redemption, SwitchOut, SwitchIn, TransferOut, TransferIn. | 
**Units** | **decimal?** |  | [optional] 
**Amount** | [**ExternalDealingEstimateAmount**](ExternalDealingEstimateAmount.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentIdentifierType = "instrumentIdentifierType";
string instrumentIdentifier = "instrumentIdentifier";
string instrumentScope = "example instrumentScope";
string tradeType = "tradeType";
ExternalDealingEstimateAmount? amount = new ExternalDealingEstimateAmount();


ExternalDealingEstimateLine externalDealingEstimateLineInstance = new ExternalDealingEstimateLine(
    instrumentIdentifierType: instrumentIdentifierType,
    instrumentIdentifier: instrumentIdentifier,
    instrumentScope: instrumentScope,
    tradeType: tradeType,
    units: units,
    amount: amount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
