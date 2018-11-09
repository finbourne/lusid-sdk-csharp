# LusidSdk.Model.RealisedGainLoss
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentUid** | **string** | Unique instrument identifier | [optional] 
**Units** | **double?** | Quantity against which gain has been made in units of the instrument | [optional] 
**PurchaseTradeDate** | **DateTimeOffset?** | Date the position was originally purchased | [optional] 
**PurchaseSettlementDate** | **DateTimeOffset?** | Date the position originally settled | [optional] 
**PurchasePrice** | **double?** | Price the instrument was purchased at | [optional] 
**CostTradeCcy** | [**CurrencyAndAmount**](CurrencyAndAmount.md) | Purchase cost in the trade currency | [optional] 
**CostPortfolioCcy** | [**CurrencyAndAmount**](CurrencyAndAmount.md) | Purchase cost in the trade currency | [optional] 
**RealisedTradeCcy** | [**CurrencyAndAmount**](CurrencyAndAmount.md) | Gains or losses in the trade currency | [optional] 
**RealisedTotal** | [**CurrencyAndAmount**](CurrencyAndAmount.md) | Total gains or losses in the portfolio currency | [optional] 
**RealisedMarket** | [**CurrencyAndAmount**](CurrencyAndAmount.md) | Market gains or losses in the portfolio currency | [optional] 
**RealisedCurrency** | [**CurrencyAndAmount**](CurrencyAndAmount.md) | Currency gains or losses in the portfolio currency | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

