# Lusid.Sdk.Model.RealisedGainLoss
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentUid** | **string** | The unqiue Lusid Instrument Id (LUID) of the instrument that this gain or loss is associated with. | [readonly] 
**Units** | **double** | The number of units of the associated instrument against which the gain or loss has been realised. | [readonly] 
**PurchaseTradeDate** | **DateTimeOffset** | The effective datetime that the units associated with this gain or loss where originally purchased. | [optional] [readonly] 
**PurchaseSettlementDate** | **DateTimeOffset** | The effective datetime that the units associated with this gain or loss where originally settled. | [optional] [readonly] 
**PurchasePrice** | **double** | The purchase price of each unit associated with this gain or loss. | [optional] [readonly] 
**CostTradeCcy** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**CostPortfolioCcy** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**RealisedTradeCcy** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**RealisedTotal** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**RealisedMarket** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**RealisedCurrency** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

