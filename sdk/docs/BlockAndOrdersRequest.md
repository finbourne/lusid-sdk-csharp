# Lusid.Sdk.Model.BlockAndOrdersRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlockId** | [**ResourceId**](ResourceId.md) |  | 
**Orders** | [**List&lt;BlockedOrderRequest&gt;**](BlockedOrderRequest.md) | An order which belongs to a block. Fields common to both entities (such as instrument) should be derived from the block. | 
**BlockProperties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this block. | [optional] 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The instrument ordered. | 
**Side** | **string** | The client&#39;s representation of the block&#39;s side (buy, sell, short, etc) | 
**Type** | **string** | The block order&#39;s type (examples: Limit, Market, ...) | [optional] 
**TimeInForce** | **string** | The block orders&#39; time in force (examples: Day, GoodTilCancel, ...) | [optional] 
**Date** | **DateTimeOffset** | The date on which the block was made | [optional] 
**LimitPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**StopPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

