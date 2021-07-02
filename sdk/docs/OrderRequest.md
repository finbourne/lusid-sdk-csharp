
# Lusid.Sdk.Model.OrderRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this order. | [optional] 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The instrument ordered. | 
**Quantity** | **int?** | The quantity of given instrument ordered. | 
**Side** | **string** | The client&#39;s representation of the order&#39;s side (buy, sell, short, etc) | 
**OrderBookId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**State** | **string** | The order&#39;s state (examples: New, PartiallyFilled, ...) | [optional] 
**Type** | **string** | The order&#39;s type (examples: Limit, Market, ...) | [optional] 
**TimeInForce** | **string** | The order&#39;s time in force (examples: Day, GoodTilCancel, ...) | [optional] 
**Date** | **DateTimeOffset?** | The date on which the order was made | [optional] 
**Price** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**OrderInstruction** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Package** | [**ResourceId**](ResourceId.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

