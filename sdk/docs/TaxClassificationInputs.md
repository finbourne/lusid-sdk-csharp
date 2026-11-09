# Lusid.Sdk.Model.TaxClassificationInputs
The instrument static the decision tree reads. A missing flag is a missing input, not a false.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoanRelationshipAsset** | **bool?** | Whether the instrument is a loan relationship asset. | [optional] 
**IndexLinkedGilt** | **bool?** | Whether the instrument is an index-linked gilt. | [optional] 
**ChargeableAsset** | **bool?** | Whether disposals of the instrument give rise to chargeable gains. | [optional] 
**CisNonTransparent** | **bool?** | Whether the instrument is a non-transparent collective investment scheme. | [optional] 
**CisTransparent** | **bool?** | Whether the instrument is a transparent collective investment scheme. | [optional] 
**Derivative** | **bool?** | Whether the instrument is a derivative contract. | [optional] 
**DerivativeFinancialFuture** | **bool?** | Whether the derivative is a financial future or option within the chargeable gains rules. | [optional] 
**DerivativePooledSecurity** | **bool?** | Whether the derivative is pooled as a security. | [optional] 
**PrivateEquity** | **bool?** | Whether the instrument is a private equity holding. | [optional] 
**RealEstate** | **bool?** | Whether the instrument is a real estate holding. | [optional] 
**QualifyingInvestmentsPercent** | **decimal?** | The percentage of the scheme&#39;s assets that are qualifying (non-equity) investments; more than 60 percent makes the scheme a bond fund. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool? loanRelationshipAsset = //"True";
bool? indexLinkedGilt = //"True";
bool? chargeableAsset = //"True";
bool? cisNonTransparent = //"True";
bool? cisTransparent = //"True";
bool? derivative = //"True";
bool? derivativeFinancialFuture = //"True";
bool? derivativePooledSecurity = //"True";
bool? privateEquity = //"True";
bool? realEstate = //"True";

TaxClassificationInputs taxClassificationInputsInstance = new TaxClassificationInputs(
    loanRelationshipAsset: loanRelationshipAsset,
    indexLinkedGilt: indexLinkedGilt,
    chargeableAsset: chargeableAsset,
    cisNonTransparent: cisNonTransparent,
    cisTransparent: cisTransparent,
    derivative: derivative,
    derivativeFinancialFuture: derivativeFinancialFuture,
    derivativePooledSecurity: derivativePooledSecurity,
    privateEquity: privateEquity,
    realEstate: realEstate,
    qualifyingInvestmentsPercent: qualifyingInvestmentsPercent);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
