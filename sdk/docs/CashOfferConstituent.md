# Lusid.Sdk.Model.CashOfferConstituent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfferPrice** | **decimal** |  | 
**Currency** | **string** |  | 
**SettlementDate** | **DateTimeOffset** |  | 
**MinPieceSize** | **decimal?** |  | [optional] 
**MinIncrement** | **decimal?** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal offerPrice = "offerPrice";

string currency = "currency";

CashOfferConstituent cashOfferConstituentInstance = new CashOfferConstituent(
    offerPrice: offerPrice,
    currency: currency,
    settlementDate: settlementDate,
    minPieceSize: minPieceSize,
    minIncrement: minIncrement);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
