# Lusid.Sdk.Model.AllocationMapBasisValue
The value one investor record is weighted by when an Allocation Map is resolved.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record the basis value belongs to. | 
**BasisValue** | **decimal** | The value the investor record is weighted by, for example its commitment. | 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "investorRecordId";decimal basisValue = "basisValue";


AllocationMapBasisValue allocationMapBasisValueInstance = new AllocationMapBasisValue(
    investorRecordId: investorRecordId,
    basisValue: basisValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
