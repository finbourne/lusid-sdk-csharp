
# Lusid.Sdk.Model.TransactionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** | Unique transaction identifier | 
**Type** | **string** | LUSID transaction type code - Buy, Sell, StockIn, StockOut, etc | 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | Unique instrument identifiers | 
**TransactionDate** | **string** | Transaction date | 
**SettlementDate** | **string** | Settlement date | 
**Units** | **double?** | Quantity of trade in units of the instrument | 
**TransactionPrice** | [**TransactionPrice**](TransactionPrice.md) |  | 
**TotalConsideration** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**ExchangeRate** | **double?** | Rate between transaction and settlement currency | [optional] 
**TransactionCurrency** | **string** | Transaction currency | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualPropertyValue&gt;**](PerpetualPropertyValue.md) |  | [optional] 
**CounterpartyId** | **string** | Counterparty identifier | [optional] 
**Source** | **string** | Where this transaction came from | [optional] 
**NettingSet** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

