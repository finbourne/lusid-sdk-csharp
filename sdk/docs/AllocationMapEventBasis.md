# Lusid.Sdk.Model.AllocationMapEventBasis
The basis an Allocation Map applies to one kind of allocation event.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventType** | **string** | The kind of allocation event the basis applies to: CapitalCall, Distribution, FeeExpense or ValuationMove. Available values: CapitalCall, Distribution, FeeExpense, ValuationMove. | 
**Basis** | [**AllocationMapBasis**](AllocationMapBasis.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string eventType = "eventType";
AllocationMapBasis basis = new AllocationMapBasis();

AllocationMapEventBasis allocationMapEventBasisInstance = new AllocationMapEventBasis(
    eventType: eventType,
    basis: basis);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
