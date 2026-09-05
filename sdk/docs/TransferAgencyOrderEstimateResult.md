# Lusid.Sdk.Model.TransferAgencyOrderEstimateResult
The estimated values for one order, together with the market facts they were struck from. The market facts  are repeated on every order priced against the same share class so that each result stands alone.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**MostRecentValuationDate** | **DateTimeOffset** |  | [optional] 
**PricePerShare** | **decimal** |  | [optional] 
**PriceCurrency** | **string** |  | [optional] 
**EstimatedUnits** | **decimal** |  | [optional] 
**EstimatedAmount** | **decimal** |  | [optional] 
**EstimatedAmountCurrency** | **string** |  | [optional] 
**FxRateUsed** | **decimal** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? orderId = new ResourceId();
decimal? pricePerShare = "example pricePerShare";
string priceCurrency = "example priceCurrency";decimal? estimatedUnits = "example estimatedUnits";decimal? estimatedAmount = "example estimatedAmount";
string estimatedAmountCurrency = "example estimatedAmountCurrency";decimal? fxRateUsed = "example fxRateUsed";

TransferAgencyOrderEstimateResult transferAgencyOrderEstimateResultInstance = new TransferAgencyOrderEstimateResult(
    orderId: orderId,
    mostRecentValuationDate: mostRecentValuationDate,
    pricePerShare: pricePerShare,
    priceCurrency: priceCurrency,
    estimatedUnits: estimatedUnits,
    estimatedAmount: estimatedAmount,
    estimatedAmountCurrency: estimatedAmountCurrency,
    fxRateUsed: fxRateUsed);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
