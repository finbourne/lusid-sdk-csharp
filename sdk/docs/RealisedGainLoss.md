# Lusid.Sdk.Model.RealisedGainLoss

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentScope** | **string** | The scope in which the instrument lies. | [optional] 
**InstrumentUid** | **string** | The unqiue Lusid Instrument Id (LUID) of the instrument that this gain or loss is associated with. | 
**Units** | **decimal** | The number of units of the associated instrument against which the gain or loss has been realised. | 
**PurchaseTradeDate** | **DateTimeOffset?** | The effective datetime that the units associated with this gain or loss where originally purchased. | [optional] [readonly] 
**PurchaseSettlementDate** | **DateTimeOffset?** | The effective datetime that the units associated with this gain or loss where originally settled. | [optional] [readonly] 
**PurchasePrice** | **decimal?** | The purchase price of each unit associated with this gain or loss. | [optional] 
**CostTradeCcy** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**CostPortfolioCcy** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**RealisedTradeCcy** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**RealisedTotal** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**RealisedMarket** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**RealisedCurrency** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

