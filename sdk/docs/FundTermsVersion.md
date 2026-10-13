# Lusid.Sdk.Model.FundTermsVersion

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TermsVersionId** | **string** |  | 
**EffectiveFrom** | **DateTimeOffset** |  | 
**Fees** | [**List&lt;FeeDefinition&gt;**](FeeDefinition.md) |  | [optional] 
**Carry** | [**CarryParameters**](CarryParameters.md) |  | [optional] 
**Recycling** | [**RecyclingTerms**](RecyclingTerms.md) |  | [optional] 
**Equalisation** | [**EqualisationTerms**](EqualisationTerms.md) |  | [optional] 
**AppliesFromClosingId** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string termsVersionId = "termsVersionId";
List<FeeDefinition> fees = new List<FeeDefinition>();
CarryParameters? carry = new CarryParameters();

RecyclingTerms? recycling = new RecyclingTerms();

EqualisationTerms? equalisation = new EqualisationTerms();

string appliesFromClosingId = "example appliesFromClosingId";

FundTermsVersion fundTermsVersionInstance = new FundTermsVersion(
    termsVersionId: termsVersionId,
    effectiveFrom: effectiveFrom,
    fees: fees,
    carry: carry,
    recycling: recycling,
    equalisation: equalisation,
    appliesFromClosingId: appliesFromClosingId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
