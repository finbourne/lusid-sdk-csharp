
# Lusid.Sdk.Model.TransactionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** | The unique identifier for the transaction. | 
**Type** | **string** | The type of the transaction e.g. &#39;Buy&#39;, &#39;Sell&#39;. The transaction type should have been pre-configured via the System Configuration API endpoint. If it hasn&#39;t been pre-configured the transaction will still be updated or inserted however you will be unable to generate the resultant holdings for the portfolio that contains this transaction as LUSID does not know how to process it. | 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | A set of instrument identifiers to use to resolve the transaction to a unique instrument. | 
**TransactionDate** | **string** | The date of the transaction. | 
**SettlementDate** | **string** | The settlement date of the transaction. | 
**Units** | **double?** | The number of units transacted in the associated instrument. | 
**TransactionPrice** | [**TransactionPrice**](TransactionPrice.md) |  | 
**TotalConsideration** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**ExchangeRate** | **double?** | The exchange rate between the transaction and settlement currency. For example if the transaction currency is in USD and the settlement currency is in GBP this this the USD/GBP rate. | [optional] 
**TransactionCurrency** | **string** | The transaction currency. | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Set of unique transaction properties and associated values to store with the transaction. Each property must be from the &#39;Transaction&#39; domain. | [optional] 
**CounterpartyId** | **string** | The identifier for the counterparty of the transaction. | [optional] 
**Source** | **string** | The source of the transaction. This is used to look up the appropriate transaction group set in the transaction type configuration. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

