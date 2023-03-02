# Lusid.Sdk.Model.Order
An Order for a certain quantity of a specific instrument

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this order. | [optional] 
**Version** | [**Version**](Version.md) |  | [optional] 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The instrument ordered. | 
**Quantity** | **decimal** | The quantity of given instrument ordered. | 
**Side** | **string** | The client&#39;s representation of the order&#39;s side (buy, sell, short, etc) | 
**OrderBookId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**InstrumentScope** | **string** | The scope in which the instrument lies | [optional] 
**LusidInstrumentId** | **string** | The LUSID instrument id for the instrument ordered. | 
**State** | **string** | The order&#39;s state (examples: New, PartiallyFilled, ...) | [optional] 
**Type** | **string** | The order&#39;s type (examples: Limit, Market, ...) | [optional] 
**TimeInForce** | **string** | The order&#39;s time in force (examples: Day, GoodTilCancel, ...) | [optional] 
**Date** | **DateTimeOffset** | The date on which the order was made | [optional] 
**Price** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**LimitPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**StopPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**OrderInstructionId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**PackageId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | Collection of links. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

