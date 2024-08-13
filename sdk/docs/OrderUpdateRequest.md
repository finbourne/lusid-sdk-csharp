# Lusid.Sdk.Model.OrderUpdateRequest
A request to create or update a Order.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Quantity** | **decimal** | The quantity of given instrument ordered. | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this order. | [optional] 
**Price** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**LimitPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**StopPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

