# Lusid.Sdk.Model.OrderGraphBlock

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Block** | [**Block**](Block.md) |  | 
**Ordered** | [**OrderGraphBlockOrderSynopsis**](OrderGraphBlockOrderSynopsis.md) |  | 
**Placed** | [**OrderGraphBlockPlacementSynopsis**](OrderGraphBlockPlacementSynopsis.md) |  | 
**Executed** | [**OrderGraphBlockExecutionSynopsis**](OrderGraphBlockExecutionSynopsis.md) |  | 
**Allocated** | [**OrderGraphBlockAllocationSynopsis**](OrderGraphBlockAllocationSynopsis.md) |  | 
**Booked** | [**OrderGraphBlockTransactionSynopsis**](OrderGraphBlockTransactionSynopsis.md) |  | 
**DerivedState** | **string** | A simple description of the overall state of a block. | 
**DerivedComplianceState** | **string** | The overall compliance state of a block, derived from the block&#39;s orders. Available values: Pending, Failed, Passed, ManuallyApproved, PartiallyOverridden, Warning. | 
**DerivedApprovalState** | **string** | The overall approval state of a block, derived from approval of the block&#39;s orders. Available values: Pending, Rejected, Approved. | 

```csharp
using Lusid.Sdk.Model;
using System;

Block block = new Block();
OrderGraphBlockOrderSynopsis ordered = new OrderGraphBlockOrderSynopsis();
OrderGraphBlockPlacementSynopsis placed = new OrderGraphBlockPlacementSynopsis();
OrderGraphBlockExecutionSynopsis executed = new OrderGraphBlockExecutionSynopsis();
OrderGraphBlockAllocationSynopsis allocated = new OrderGraphBlockAllocationSynopsis();
OrderGraphBlockTransactionSynopsis booked = new OrderGraphBlockTransactionSynopsis();
string derivedState = "derivedState";
string derivedComplianceState = "derivedComplianceState";
string derivedApprovalState = "derivedApprovalState";

OrderGraphBlock orderGraphBlockInstance = new OrderGraphBlock(
    block: block,
    ordered: ordered,
    placed: placed,
    executed: executed,
    allocated: allocated,
    booked: booked,
    derivedState: derivedState,
    derivedComplianceState: derivedComplianceState,
    derivedApprovalState: derivedApprovalState);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
