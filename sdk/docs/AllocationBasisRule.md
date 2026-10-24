# Lusid.Sdk.Model.AllocationBasisRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Character** | **string** |  | 
**Basis** | **string** | Available values: CommittedCapital, PaidInCapital, DealPaidIn. | 

```csharp
using Lusid.Sdk.Model;
using System;

string character = "character";
string basis = "basis";

AllocationBasisRule allocationBasisRuleInstance = new AllocationBasisRule(
    character: character,
    basis: basis);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
