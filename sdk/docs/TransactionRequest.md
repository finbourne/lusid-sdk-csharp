# Lusid.Sdk.Model.TransactionRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** | Unique transaction identifier | 
**Type** | **string** | LUSID transaction type code - Buy, Sell, StockIn, StockOut, etc | 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | Unique instrument identifiers. | 
**TransactionDate** | **DateTimeOffset?** | Transaction date | 
**SettlementDate** | **DateTimeOffset?** | Settlement date | 
**Units** | **double?** | Quantity of transaction in units of the instrument | 
**TransactionPrice** | [**TransactionPrice**](TransactionPrice.md) | Execution price for the transaction | 
**TotalConsideration** | [**CurrencyAndAmount**](CurrencyAndAmount.md) | Total value of the transaction, in settlement currency | 
**ExchangeRate** | **double?** | Rate between transaction and settle currency | [optional] 
**TransactionCurrency** | **string** | Transaction currency | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualPropertyValue&gt;**](PerpetualPropertyValue.md) |  | [optional] 
**CounterpartyId** | **string** | Counterparty identifier | [optional] 
**Source** | **string** | Where this transaction came from | 
**NettingSet** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

