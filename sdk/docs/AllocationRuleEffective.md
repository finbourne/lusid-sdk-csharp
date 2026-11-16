# Lusid.Sdk.Model.AllocationRuleEffective
What a rule's pools actually use once the defaults are applied. Read-only: derived on the way out and ignored on  the way in.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Basis** | **string** | The basis the bucket&#39;s fund-level pools are shared on. Available values: CommittedCapital, PaidInCapital. | 
**Exemption** | **string** | The register flag that sits partners out of the bucket&#39;s pools. Available values: None, FeeExempt, ExpenseExempt. | 
**ReportRow** | **string** | The capital account row the bucket&#39;s allocations land on, derived from the character. Available values: NetOperatingIncome, ManagementFeesGross, RealisedGainLoss, UnrealisedGainLoss. | [optional] 
**BasisLevel** | **string** | Which level of the basis precedence decided the basis. Available values: Rule, CharacterDefault, BuiltIn. | 

```csharp
using Lusid.Sdk.Model;
using System;

string basis = "basis";
string exemption = "exemption";
string reportRow = "example reportRow";
string basisLevel = "basisLevel";

AllocationRuleEffective allocationRuleEffectiveInstance = new AllocationRuleEffective(
    basis: basis,
    exemption: exemption,
    reportRow: reportRow,
    basisLevel: basisLevel);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
