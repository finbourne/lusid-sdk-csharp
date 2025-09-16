# Lusid.Sdk.Model.BlockAndOrdersRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlockId** | [**ResourceId**](ResourceId.md) |  | 
**Orders** | [**List&lt;BlockedOrderRequest&gt;**](BlockedOrderRequest.md) | An order which belongs to a block. Fields common to both entities (such as instrument) should be derived from the block. | 
**BlockProperties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this block. | [optional] 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The instrument ordered. | 
**Side** | **string** | The client&#39;s representation of the block&#39;s side (buy, sell, short, etc). BlockedOrders in the request which do not specify a side will have their side populated with this value. | [optional] 
**Type** | **string** | The block order&#39;s type (examples: Limit, Market, ...) | [optional] 
**TimeInForce** | **string** | The block orders&#39; time in force (examples: Day, GoodTilCancel, ...) | [optional] 
**Date** | **DateTimeOffset** | The date on which the block was made | [optional] 
**LimitPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**StopPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId blockId = new ResourceId();
List<BlockedOrderRequest> orders = new List<BlockedOrderRequest>();
Dictionary<string, PerpetualProperty> blockProperties = new Dictionary<string, PerpetualProperty>();
Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();
string side = "example side";
string type = "example type";
string timeInForce = "example timeInForce";
CurrencyAndAmount? limitPrice = new CurrencyAndAmount();

CurrencyAndAmount? stopPrice = new CurrencyAndAmount();


BlockAndOrdersRequest blockAndOrdersRequestInstance = new BlockAndOrdersRequest(
    blockId: blockId,
    orders: orders,
    blockProperties: blockProperties,
    instrumentIdentifiers: instrumentIdentifiers,
    side: side,
    type: type,
    timeInForce: timeInForce,
    date: date,
    limitPrice: limitPrice,
    stopPrice: stopPrice);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
