
# Lusid.Sdk.Model.TargetTaxLot

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Units** | **decimal?** | The number of units of the instrument in this tax-lot. | 
**Cost** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**PortfolioCost** | **decimal?** | The total cost of the tax-lot in the transaction portfolio&#39;s base currency. | [optional] 
**Price** | **decimal?** | The purchase price of each unit of the instrument held in this tax-lot. This forms part of the unique key required for multiple tax-lots. | [optional] 
**PurchaseDate** | **DateTimeOffset?** | The purchase date of this tax-lot. This forms part of the unique key required for multiple tax-lots. | [optional] 
**SettlementDate** | **DateTimeOffset?** | The settlement date of the tax-lot&#39;s opening transaction. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

