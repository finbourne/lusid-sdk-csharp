# Lusid.Sdk.Model.BlockedOrderRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this order. | [optional] 
**Quantity** | **decimal** | The quantity of the given instrument ordered. | 
**OrderBookId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**State** | **string** | The order&#39;s state (examples: New, PartiallyFilled, ...) | [optional] 
**Date** | **DateTimeOffset** | The date on which the order was made | [optional] 
**Price** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**OrderInstruction** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Package** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Side** | **string** | The client&#39;s representation of the order&#39;s side (buy, sell, short, etc) | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();decimal quantity = "quantity";

ResourceId? orderBookId = new ResourceId();

ResourceId? portfolioId = new ResourceId();

ResourceId id = new ResourceId();
string state = "example state";
CurrencyAndAmount? price = new CurrencyAndAmount();

ResourceId? orderInstruction = new ResourceId();

ResourceId? package = new ResourceId();

string side = "example side";

BlockedOrderRequest blockedOrderRequestInstance = new BlockedOrderRequest(
    properties: properties,
    quantity: quantity,
    orderBookId: orderBookId,
    portfolioId: portfolioId,
    id: id,
    state: state,
    date: date,
    price: price,
    orderInstruction: orderInstruction,
    package: package,
    side: side);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
