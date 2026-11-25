# Lusid.Sdk.Model.CollateralSubstitutionConstituent
A single collateral instrument taking part in a FlexibleRepoCollateralSubstitutionEvent, either as outgoing  collateral being returned or as incoming collateral replacing it. Contains a reference to the instrument as a  NewInstrument object, an optional amount and the type of that amount (Units or Percentage of current units).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Instrument** | [**NewInstrument**](NewInstrument.md) |  | 
**Amount** | **decimal?** | If AmountType is set to Units, this field represents the number of units of the instrument being transferred.  If AmountType is set to Percentage, this field represents the percentage of the repoed units of the instrument being transferred.  Required for outgoing collateral. For incoming collateral it is required when AdjustCollateralUnits is false;  the instrument is then held in the units given, so its AmountType must be Units. | [optional] 
**AmountType** | **string** | The type of amount represented by the Amount field.  I.e., does it represent a number of units or a percentage of the repoed units of the instrument?  Supported string (enumeration) values are: [Percentage, Units]. Defaults to Units. Must be Units for incoming  collateral. Available values: Percentage, Units. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

NewInstrument instrument = new NewInstrument();
string amountType = "example amountType";

CollateralSubstitutionConstituent collateralSubstitutionConstituentInstance = new CollateralSubstitutionConstituent(
    instrument: instrument,
    amount: amount,
    amountType: amountType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
