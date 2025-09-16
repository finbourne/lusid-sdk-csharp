# Lusid.Sdk.Model.Allocation
An Allocation of a certain quantity of a specific instrument against an originating  Order.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**AllocatedOrderId** | [**ResourceId**](ResourceId.md) |  | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**Quantity** | **decimal** | The quantity of given instrument allocated. | 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The instrument allocated. | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this allocation. | [optional] 
**InstrumentScope** | **string** | The scope in which the instrument lies | [optional] 
**LusidInstrumentId** | **string** | The LUSID instrument id for the instrument allocated. | 
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
**DataModelMembership** | [**DataModelMembership**](DataModelMembership.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
ResourceId allocatedOrderId = new ResourceId();
ResourceId portfolioId = new ResourceId();decimal quantity = "quantity";

Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();
ModelVersion? varVersion = new ModelVersion();

Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
string instrumentScope = "example instrumentScope";
string lusidInstrumentId = "lusidInstrumentId";
List<ResourceId> placementIds = new List<ResourceId>();
string state = "example state";
string side = "example side";
string type = "example type";
CurrencyAndAmount? price = new CurrencyAndAmount();

string settlementCurrency = "example settlementCurrency";
string counterparty = "example counterparty";
List<ResourceId> executionIds = new List<ResourceId>();
DataModelMembership? dataModelMembership = new DataModelMembership();

List<Link> links = new List<Link>();

Allocation allocationInstance = new Allocation(
    id: id,
    allocatedOrderId: allocatedOrderId,
    portfolioId: portfolioId,
    quantity: quantity,
    instrumentIdentifiers: instrumentIdentifiers,
    varVersion: varVersion,
    properties: properties,
    instrumentScope: instrumentScope,
    lusidInstrumentId: lusidInstrumentId,
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
    executionIds: executionIds,
    dataModelMembership: dataModelMembership,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
