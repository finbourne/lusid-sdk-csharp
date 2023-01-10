# Lusid.Sdk.Model.Block
A block of orders for the same instrument, intended to record for example a trader's aggregation  of outstanding orders at a given time.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**OrderIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The related order ids. | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this block. | [optional] 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The instrument ordered. | 
**LusidInstrumentId** | **string** | The LUSID instrument id for the instrument ordered. | 
**Quantity** | **decimal** | The total quantity of given instrument ordered. | 
**Side** | **string** | The client&#39;s representation of the block&#39;s side (buy, sell, short, etc) | 
**Type** | **string** | The block order&#39;s type (examples: Limit, Market, ...) | 
**TimeInForce** | **string** | The block orders&#39; time in force (examples: Day, GoodTilCancel, ...) | 
**CreatedDate** | **DateTimeOffset** | The date on which the block was made | 
**LimitPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**StopPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**Version** | [**Version**](Version.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | Collection of links. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

