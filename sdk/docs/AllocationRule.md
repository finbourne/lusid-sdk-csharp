# Lusid.Sdk.Model.AllocationRule
The allocation character of one P&L or fees bucket of the allocation bucket set, and optionally how its pools  are shared, echoed as stored. The effective block, overridden fields and source are derived on the way out and  ignored on the way in, so a read written back pins nothing.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BucketId** | **string** | The bucket of the allocation bucket set the rule applies to. | 
**Character** | **string** | The allocation character of the bucket&#39;s lines, which decides the capital account row. Available values: Income, RealisedGain, UnrealisedGain, OtherIncome, ManagementFee, Expense. Fixed by the set, and so omitted, when the allocation bucket set is a system set. | [optional] 
**Basis** | **string** | The register balance the bucket&#39;s pools are shared on. Available values: CommittedCapital, PaidInCapital. Omit to take the character&#39;s default from allocationBases or the built-in default; returned as stored, with what the fund uses under effective. A pool that names its origin member is shared on deal paid-in unless its rule names a basis, and a rule may not ask for deal paid-in. Available values: CommittedCapital, PaidInCapital. | [optional] 
**Exemption** | **string** | Which register flag sits a partner out of the bucket&#39;s pools. Available values: None, FeeExempt, ExpenseExempt. Omit to take the character&#39;s default (FeeExempt for ManagementFee, ExpenseExempt for Expense, otherwise None); returned as stored, with what the fund uses under effective. Available values: None, FeeExempt, ExpenseExempt. | [optional] 
**ExcludedInvestorRecordIds** | **List&lt;string&gt;** | Investor records that sit out every pool of the bucket. Optional. | [optional] 
**Effective** | [**AllocationRuleEffective**](AllocationRuleEffective.md) |  | [optional] 
**OverriddenFields** | **List&lt;string&gt;** | On a system set&#39;s rule, the fields this configuration overrides; absent on a configuration&#39;s own rule. Read-only. | [optional] 
**Source** | **string** | Where the rule&#39;s character comes from: System for a released system set, Configuration for the configuration&#39;s own set. Read-only. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string bucketId = "bucketId";
string character = "example character";
string basis = "example basis";
string exemption = "example exemption";
List<string> excludedInvestorRecordIds = new List<string>();
AllocationRuleEffective? effective = new AllocationRuleEffective();

List<string> overriddenFields = new List<string>();
string source = "example source";

AllocationRule allocationRuleInstance = new AllocationRule(
    bucketId: bucketId,
    character: character,
    basis: basis,
    exemption: exemption,
    excludedInvestorRecordIds: excludedInvestorRecordIds,
    effective: effective,
    overriddenFields: overriddenFields,
    source: source);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
