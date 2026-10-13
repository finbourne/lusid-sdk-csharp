# Lusid.Sdk.Model.AllocationMapEventBasis
The basis an Allocation Map applies to one kind of allocation event.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventType** | **string** | The kind of allocation event the basis applies to: CapitalCall, Distribution, FeeExpense, ValuationMove, Equalisation, RecallExpiry, Transfer, Default, Commitment or DealFunding. Available values: CapitalCall, Distribution, FeeExpense, ValuationMove, Commitment, Equalisation, RecallExpiry, Transfer, Default, DealFunding. | 
**Basis** | [**AllocationMapBasis**](AllocationMapBasis.md) |  | 
**Component** | **string** | The component of the event the basis applies to, for example MgmtFee or OrgCost. Absent means the entry is the default for every component of the event type without an entry of its own. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string eventType = "eventType";
AllocationMapBasis basis = new AllocationMapBasis();
string component = "example component";

AllocationMapEventBasis allocationMapEventBasisInstance = new AllocationMapEventBasis(
    eventType: eventType,
    basis: basis,
    component: component);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
