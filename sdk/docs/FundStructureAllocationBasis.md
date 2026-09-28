# Lusid.Sdk.Model.FundStructureAllocationBasis
The default apportionment basis of a Fund Structure member.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Kind** | **string** | How the apportionment is weighted. ValueWeighted apportions pro rata to each investing member&#39;s value; PropertyWeighted apportions pro rata to the property named in &#39;property&#39;; FixedPercentage defers to factors held on an allocation map. A ValueWeighted basis is rejected where a holder of this member also holds an unrelated member, because the member could not be finalised before that sibling is valued. Available values: ValueWeighted, PropertyWeighted, FixedPercentage. | [optional] 
**Property** | [**ApportionmentMethodProperty**](ApportionmentMethodProperty.md) |  | [optional] 
**ScopedToMember** | **bool** | Whether the basis is evaluated only over amounts booked against this member rather than fund-wide. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string kind = "example kind";
ApportionmentMethodProperty? property = new ApportionmentMethodProperty();

bool scopedToMember = //"True";

FundStructureAllocationBasis fundStructureAllocationBasisInstance = new FundStructureAllocationBasis(
    kind: kind,
    property: property,
    scopedToMember: scopedToMember);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
