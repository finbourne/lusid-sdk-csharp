# Lusid.Sdk.Model.AllocationMapBasis
How an allocation event is weighted between the participants of an Allocation Map.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Kind** | **string** | How the event is weighted between the participants. ValueWeighted apportions pro rata to each participant&#39;s value; PropertyWeighted apportions pro rata to the property named in &#39;property&#39;; FixedPercentage apportions by the factors in fixedFactors; FixedAmount takes the supplied basis values as the shares themselves. Committed, CommittedExGP, UncalledCommitment, PaidIn, PaidInForDeal, Recallable and FeeWeightedCommitment apportion pro rata to the corresponding balance on each participant&#39;s register line at the event date. Available values: ValueWeighted, PropertyWeighted, FixedPercentage, Committed, CommittedExGP, UncalledCommitment, PaidIn, PaidInForDeal, Recallable, FeeWeightedCommitment, FixedAmount. | [optional] 
**Property** | [**ApportionmentMethodProperty**](ApportionmentMethodProperty.md) |  | [optional] 
**FixedFactors** | [**List&lt;AllocationMapFixedFactor&gt;**](AllocationMapFixedFactor.md) | For a FixedPercentage basis, the share of the amount each participating investor record takes. At least one is required under that kind, every factor must be positive, and the factors must sum to 1. | [optional] 
**ScopedToMember** | **bool** | Whether the basis is evaluated only over amounts booked against the structure member rather than fund-wide. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string kind = "example kind";
ApportionmentMethodProperty? property = new ApportionmentMethodProperty();

List<AllocationMapFixedFactor> fixedFactors = new List<AllocationMapFixedFactor>();
bool scopedToMember = //"True";

AllocationMapBasis allocationMapBasisInstance = new AllocationMapBasis(
    kind: kind,
    property: property,
    fixedFactors: fixedFactors,
    scopedToMember: scopedToMember);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
