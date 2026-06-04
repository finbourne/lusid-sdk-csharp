# Lusid.Sdk.Model.SecurityOfferConstituent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NewInstrument** | [**NewInstrument**](NewInstrument.md) |  | 
**UnitsRatio** | [**UnitsRatio**](UnitsRatio.md) |  | 
**SettlementDate** | **DateTimeOffset** |  | 
**MinPieceSize** | **decimal?** |  | [optional] 
**MinIncrement** | **decimal?** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

NewInstrument newInstrument = new NewInstrument();
UnitsRatio unitsRatio = new UnitsRatio();

SecurityOfferConstituent securityOfferConstituentInstance = new SecurityOfferConstituent(
    newInstrument: newInstrument,
    unitsRatio: unitsRatio,
    settlementDate: settlementDate,
    minPieceSize: minPieceSize,
    minIncrement: minIncrement);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
