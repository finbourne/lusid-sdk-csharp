
# Lusid.Sdk.Model.AllocationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this allocation. | [optional] 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The instrument allocated. | 
**Quantity** | **int?** | The quantity of given instrument allocated. | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**AllocatedOrderId** | [**ResourceId**](ResourceId.md) |  | 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**PlacementIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | A placement - also known as an order placed in the market - associated with this allocation. | [optional] 
**State** | **string** | The state of this allocation. | [optional] 
**Side** | **string** | The side of this allocation (examples: Buy, Sell, ...). | [optional] 
**Type** | **string** | The type of order associated with this allocation (examples: Limit, Market, ...). | [optional] 
**SettlementDate** | **DateTimeOffset?** | The settlement date for this allocation. | [optional] 
**Date** | **DateTimeOffset?** | The date of this allocation. | [optional] 
**Price** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**SettlementCurrency** | **string** | The settlement currency of this allocation. | [optional] 
**SettlementCurrencyFxRate** | **decimal?** | The settlement currency to allocation currency FX rate. | [optional] 
**Counterparty** | **string** | The counterparty for this allocation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

