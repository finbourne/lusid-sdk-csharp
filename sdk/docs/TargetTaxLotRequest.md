
# Lusid.Sdk.Model.TargetTaxLotRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Units** | **double?** | Quantity of holding | 
**Cost** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**PortfolioCost** | **double?** | Book cost of holding in portfolio currency | [optional] 
**Price** | **double?** | Purchase price. Part of the unique key required for multiple taxlots | [optional] 
**PurchaseDate** | **DateTimeOffset?** | Purchase Date. Part of the unique key required for multiple taxlots | [optional] 
**SettlementDate** | **DateTimeOffset?** | Original settlement date of the tax-lot&#39;s opening transaction. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

