# Lusid.Sdk.Model.OrderGraphPlacement

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Placement** | [**Placement**](Placement.md) |  | 
**BlockId** | [**ResourceId**](ResourceId.md) |  | 
**Ordered** | [**OrderGraphPlacementOrderSynopsis**](OrderGraphPlacementOrderSynopsis.md) |  | 
**Placed** | [**OrderGraphPlacementPlacementSynopsis**](OrderGraphPlacementPlacementSynopsis.md) |  | 
**Executed** | [**OrderGraphPlacementExecutionSynopsis**](OrderGraphPlacementExecutionSynopsis.md) |  | 
**Allocated** | [**OrderGraphPlacementAllocationSynopsis**](OrderGraphPlacementAllocationSynopsis.md) |  | 
**DerivedState** | **string** | A simple description of the overall state of a placement. | 
**CalculatedAveragePrice** | **decimal?** | Average price realised on executions for a given placement | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Placement placement = new Placement();
ResourceId blockId = new ResourceId();
OrderGraphPlacementOrderSynopsis ordered = new OrderGraphPlacementOrderSynopsis();
OrderGraphPlacementPlacementSynopsis placed = new OrderGraphPlacementPlacementSynopsis();
OrderGraphPlacementExecutionSynopsis executed = new OrderGraphPlacementExecutionSynopsis();
OrderGraphPlacementAllocationSynopsis allocated = new OrderGraphPlacementAllocationSynopsis();
string derivedState = "derivedState";

OrderGraphPlacement orderGraphPlacementInstance = new OrderGraphPlacement(
    placement: placement,
    blockId: blockId,
    ordered: ordered,
    placed: placed,
    executed: executed,
    allocated: allocated,
    derivedState: derivedState,
    calculatedAveragePrice: calculatedAveragePrice);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
