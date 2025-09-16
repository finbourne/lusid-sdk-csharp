# Lusid.Sdk.Model.PlacementRequest
A request to create or update a Placement.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**ParentPlacementId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**BlockIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The IDs of the Blocks associated with this placement. | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this order. | [optional] 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The instrument ordered. | 
**Quantity** | **decimal** | The quantity of given instrument ordered. | 
**State** | **string** | The state of this placement (typically a FIX state; Open, Filled, etc). | 
**Side** | **string** | The side (Buy, Sell, ...) of this placement. | 
**TimeInForce** | **string** | The time in force applicable to this placement (GTC, FOK, Day, etc) | 
**Type** | **string** | The type of this placement (Market, Limit, etc). | 
**CreatedDate** | **DateTimeOffset** | The active date of this placement. | 
**LimitPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**StopPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**Counterparty** | **string** | Optionally specifies the market entity this placement is placed with. | [optional] 
**ExecutionSystem** | **string** | Optionally specifies the execution system in use. | [optional] 
**EntryType** | **string** | Optionally specifies the entry type of this placement. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
ResourceId? parentPlacementId = new ResourceId();

List<ResourceId> blockIds = new List<ResourceId>();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();decimal quantity = "quantity";

string state = "state";
string side = "side";
string timeInForce = "timeInForce";
string type = "type";
CurrencyAndAmount? limitPrice = new CurrencyAndAmount();

CurrencyAndAmount? stopPrice = new CurrencyAndAmount();

string counterparty = "example counterparty";
string executionSystem = "example executionSystem";
string entryType = "example entryType";

PlacementRequest placementRequestInstance = new PlacementRequest(
    id: id,
    parentPlacementId: parentPlacementId,
    blockIds: blockIds,
    properties: properties,
    instrumentIdentifiers: instrumentIdentifiers,
    quantity: quantity,
    state: state,
    side: side,
    timeInForce: timeInForce,
    type: type,
    createdDate: createdDate,
    limitPrice: limitPrice,
    stopPrice: stopPrice,
    counterparty: counterparty,
    executionSystem: executionSystem,
    entryType: entryType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
