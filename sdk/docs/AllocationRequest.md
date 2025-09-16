# Lusid.Sdk.Model.AllocationRequest
A request to create or update an Allocation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this allocation. | [optional] 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The instrument allocated. | 
**Quantity** | **decimal** | The quantity of given instrument allocated. | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**AllocatedOrderId** | [**ResourceId**](ResourceId.md) |  | 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**PlacementIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | A placement - also known as an order placed in the market - associated with this allocation. | [optional] 
**State** | **string** | The state of this allocation. | [optional] 
**Side** | **string** | The side of this allocation (examples: Buy, Sell, ...). | [optional] 
**Type** | **string** | The type of order associated with this allocation (examples: Limit, Market, ...). | [optional] 
**SettlementDate** | **DateTimeOffset?** | The settlement date for this allocation. | [optional] 
**Date** | **DateTimeOffset** | The date of this allocation. | [optional] 
**Price** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**SettlementCurrency** | **string** | The settlement currency of this allocation. | [optional] 
**SettlementCurrencyFxRate** | **decimal?** | The settlement currency to allocation currency FX rate. | [optional] 
**Counterparty** | **string** | The counterparty for this allocation. | [optional] 
**ExecutionIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The executions associated with this allocation | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();decimal quantity = "quantity";

ResourceId portfolioId = new ResourceId();
ResourceId allocatedOrderId = new ResourceId();
ResourceId id = new ResourceId();
List<ResourceId> placementIds = new List<ResourceId>();
string state = "example state";
string side = "example side";
string type = "example type";
CurrencyAndAmount? price = new CurrencyAndAmount();

string settlementCurrency = "example settlementCurrency";
string counterparty = "example counterparty";
List<ResourceId> executionIds = new List<ResourceId>();

AllocationRequest allocationRequestInstance = new AllocationRequest(
    properties: properties,
    instrumentIdentifiers: instrumentIdentifiers,
    quantity: quantity,
    portfolioId: portfolioId,
    allocatedOrderId: allocatedOrderId,
    id: id,
    placementIds: placementIds,
    state: state,
    side: side,
    type: type,
    settlementDate: settlementDate,
    date: date,
    price: price,
    settlementCurrency: settlementCurrency,
    settlementCurrencyFxRate: settlementCurrencyFxRate,
    counterparty: counterparty,
    executionIds: executionIds);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
