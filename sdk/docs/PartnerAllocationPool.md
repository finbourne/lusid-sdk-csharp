# Lusid.Sdk.Model.PartnerAllocationPool
One pool of an allocation run: an amount of a given character, split across the partners on a basis.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Character** | **string** | The character of the pool&#39;s amount, for example Income, RealisedGain or Expense. | 
**OriginMemberShortCode** | **string** | For a deal-linked pool, the short code of the member fund the amount originates from. | [optional] 
**PoolAmount** | **decimal** | The amount in the pool. | 
**Basis** | **string** | The basis the pool was shared on. Available values: CommittedCapital, PaidInCapital, DealPaidIn. | 
**BasisSource** | **string** | Where the figures a deal pool was shared on came from; absent on a fund-level pool, which is shared on the register&#39;s balances. Available values: DealContributions (what each partner paid into the pool&#39;s deal, from the booked allocation events), Fallback (a deal pool no partner has paid into, shared on its character&#39;s fund-level basis instead). | [optional] 
**Allocations** | [**List&lt;PartnerAllocation&gt;**](PartnerAllocation.md) | Each partner&#39;s share of the pool. | 
**Residual** | **decimal** | The rounding residual, carried by the largest allocation. | 
**PoolId** | **string** | The pool&#39;s identifier: the allocation rule&#39;s bucket id, or TAG: followed by the character for lines pooled by their distribution character tag. | 
**BucketSet** | **string** | The code of the allocation bucket set the pool was classified by, with its version, for example PA-ALLOCATION-v1. | 
**BasisLevel** | **string** | Which level of the basis precedence decided the pool&#39;s basis. Available values: Rule (the bucket rule&#39;s own basis), CharacterDefault (the configuration&#39;s allocationBases entry for the character), BuiltIn (the built-in default for the character). | 
**Exemption** | **string** | The register flag that sat partners out of the pool. Available values: None, FeeExempt, ExpenseExempt. | 
**ExcludedInvestorRecordIds** | **List&lt;string&gt;** | The partners the pool&#39;s rule left out of it. | [optional] 
**ReportRow** | **string** | The capital account row the pool&#39;s allocations land on, derived from the character. Available values: NetOperatingIncome, ManagementFeesGross, RealisedGainLoss, UnrealisedGainLoss. | [optional] 
**Sources** | [**PartnerAllocationPoolSources**](PartnerAllocationPoolSources.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string character = "character";
string originMemberShortCode = "example originMemberShortCode";decimal poolAmount = "poolAmount";

string basis = "basis";
string basisSource = "example basisSource";
List<PartnerAllocation> allocations = new List<PartnerAllocation>();decimal residual = "residual";

string poolId = "poolId";
string bucketSet = "bucketSet";
string basisLevel = "basisLevel";
string exemption = "exemption";
List<string> excludedInvestorRecordIds = new List<string>();
string reportRow = "example reportRow";
PartnerAllocationPoolSources sources = new PartnerAllocationPoolSources();

PartnerAllocationPool partnerAllocationPoolInstance = new PartnerAllocationPool(
    character: character,
    originMemberShortCode: originMemberShortCode,
    poolAmount: poolAmount,
    basis: basis,
    basisSource: basisSource,
    allocations: allocations,
    residual: residual,
    poolId: poolId,
    bucketSet: bucketSet,
    basisLevel: basisLevel,
    exemption: exemption,
    excludedInvestorRecordIds: excludedInvestorRecordIds,
    reportRow: reportRow,
    sources: sources);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
