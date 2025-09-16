# Lusid.Sdk.Model.BlockRequest
A request to create or update an Order.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**OrderIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The related order ids. | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this block. | [optional] 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The instrument ordered. | 
**Quantity** | **decimal** | The total quantity of given instrument ordered. | 
**Side** | **string** | The client&#39;s representation of the block&#39;s side (buy, sell, short, etc) | 
**Type** | **string** | The block order&#39;s type (examples: Limit, Market, ...) | 
**TimeInForce** | **string** | The block orders&#39; time in force (examples: Day, GoodTilCancel, ...) | 
**CreatedDate** | **DateTimeOffset** | The date on which the block was made | 
**LimitPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**StopPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**IsSwept** | **bool** | Swept blocks are considered no longer of active interest, and no longer take part in various order management processes | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
List<ResourceId> orderIds = new List<ResourceId>();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();decimal quantity = "quantity";

string side = "side";
string type = "type";
string timeInForce = "timeInForce";
CurrencyAndAmount? limitPrice = new CurrencyAndAmount();

CurrencyAndAmount? stopPrice = new CurrencyAndAmount();

bool isSwept = //"True";

BlockRequest blockRequestInstance = new BlockRequest(
    id: id,
    orderIds: orderIds,
    properties: properties,
    instrumentIdentifiers: instrumentIdentifiers,
    quantity: quantity,
    side: side,
    type: type,
    timeInForce: timeInForce,
    createdDate: createdDate,
    limitPrice: limitPrice,
    stopPrice: stopPrice,
    isSwept: isSwept);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
