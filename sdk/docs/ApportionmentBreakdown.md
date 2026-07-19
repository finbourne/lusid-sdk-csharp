# Lusid.Sdk.Model.ApportionmentBreakdown
The apportionment result for one level - the fund (apportioning the non-class-specific P&L across all  share classes) or a single allocation group (apportioning its tagged P&L across its members) - with the  per-member base values and factors the method produced.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApportionmentLevel** | **string** | Whether this result is the fund-level apportionment (across all share classes) or an allocation group&#39;s (across its share classes). Available values: Fund, AllocationGroup. | 
**AllocationGroupCode** | **string** | The ShareClassShortCode identifying the allocation group this result is for, or null for the fund-level result. | [optional] 
**ApportionmentMethodPropertyKey** | **string** | The apportionment method property key that produced the factors. | 
**Factors** | [**List&lt;ApportionmentMemberFactor&gt;**](ApportionmentMemberFactor.md) | The per-member base values and apportionment factors produced by the method. | 

```csharp
using Lusid.Sdk.Model;
using System;

string apportionmentLevel = "apportionmentLevel";
string allocationGroupCode = "example allocationGroupCode";
string apportionmentMethodPropertyKey = "apportionmentMethodPropertyKey";
List<ApportionmentMemberFactor> factors = new List<ApportionmentMemberFactor>();

ApportionmentBreakdown apportionmentBreakdownInstance = new ApportionmentBreakdown(
    apportionmentLevel: apportionmentLevel,
    allocationGroupCode: allocationGroupCode,
    apportionmentMethodPropertyKey: apportionmentMethodPropertyKey,
    factors: factors);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
