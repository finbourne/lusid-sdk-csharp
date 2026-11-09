# Lusid.Sdk.Model.UpsertTaxTreatmentOverrideRequest
Pins an instrument to a treatment leaf in place of the system-derived one.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Treatment** | **string** | The treatment leaf to pin the instrument to, replacing the system-derived one. Available values: OutsideBlagab, LoanRelationship, IndexLinkedGilt, PrivateEquity, RealEstate, FinancialFuture, PooledDerivative, DerivativeProfitAndLoss, NonTransparentScheme, BondFund, TransparentScheme, StandardEquity, Exempt. | 
**EffectiveAt** | **DateTimeOffset?** | The effective date the override applies from. Defaults to the start of time if not specified. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string treatment = "treatment";

UpsertTaxTreatmentOverrideRequest upsertTaxTreatmentOverrideRequestInstance = new UpsertTaxTreatmentOverrideRequest(
    treatment: treatment,
    effectiveAt: effectiveAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
