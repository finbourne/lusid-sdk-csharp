# Lusid.Sdk.Model.PartnerAllocationPool
One pool of an allocation run: an amount of a given character, split across the partners on a basis.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Character** | **string** | The character of the pool&#39;s amount, for example Income, RealisedGain or Expense. | 
**OriginMemberShortCode** | **string** | For a deal-linked pool, the short code of the member fund the amount originates from. | [optional] 
**PoolAmount** | **decimal** | The amount in the pool. | 
**Basis** | **string** | The basis the pool was shared on. Available values: CommittedCapital, PaidInCapital, DealPaidIn. | 
**Allocations** | [**List&lt;PartnerAllocation&gt;**](PartnerAllocation.md) | Each partner&#39;s share of the pool. | 
**Residual** | **decimal** | The rounding residual, carried by the largest allocation. | 

```csharp
using Lusid.Sdk.Model;
using System;

string character = "character";
string originMemberShortCode = "example originMemberShortCode";decimal poolAmount = "poolAmount";

string basis = "basis";
List<PartnerAllocation> allocations = new List<PartnerAllocation>();decimal residual = "residual";


PartnerAllocationPool partnerAllocationPoolInstance = new PartnerAllocationPool(
    character: character,
    originMemberShortCode: originMemberShortCode,
    poolAmount: poolAmount,
    basis: basis,
    allocations: allocations,
    residual: residual);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
