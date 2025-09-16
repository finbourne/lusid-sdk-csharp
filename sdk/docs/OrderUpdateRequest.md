# Lusid.Sdk.Model.OrderUpdateRequest
A request to create or update a Order.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Quantity** | **decimal?** | The quantity of the given instrument ordered. | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this order. | [optional] 
**Price** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**LimitPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**StopPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**Date** | **DateTimeOffset?** | The date on which the order was made | [optional] 
**Side** | **string** | The client&#39;s representation of the order&#39;s side (buy, sell, short, etc) | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
ResourceId? portfolioId = new ResourceId();

Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
CurrencyAndAmount? price = new CurrencyAndAmount();

CurrencyAndAmount? limitPrice = new CurrencyAndAmount();

CurrencyAndAmount? stopPrice = new CurrencyAndAmount();

string side = "example side";

OrderUpdateRequest orderUpdateRequestInstance = new OrderUpdateRequest(
    id: id,
    quantity: quantity,
    portfolioId: portfolioId,
    properties: properties,
    price: price,
    limitPrice: limitPrice,
    stopPrice: stopPrice,
    date: date,
    side: side);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
