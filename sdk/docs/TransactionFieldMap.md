# Lusid.Sdk.Model.TransactionFieldMap

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** |  | 
**Type** | **string** |  | 
**Source** | **string** |  | 
**Instrument** | **string** |  | 
**TransactionDate** | **string** |  | 
**SettlementDate** | **string** |  | 
**Units** | **string** |  | 
**TransactionPrice** | [**TransactionPriceAndType**](TransactionPriceAndType.md) |  | [optional] 
**TransactionCurrency** | **string** |  | 
**ExchangeRate** | **string** |  | [optional] 
**TotalConsideration** | [**TransactionCurrencyAndAmount**](TransactionCurrencyAndAmount.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string transactionId = "transactionId";
string type = "type";
string source = "source";
string instrument = "instrument";
string transactionDate = "transactionDate";
string settlementDate = "settlementDate";
string units = "units";
TransactionPriceAndType? transactionPrice = new TransactionPriceAndType();

string transactionCurrency = "transactionCurrency";
string exchangeRate = "example exchangeRate";
TransactionCurrencyAndAmount totalConsideration = new TransactionCurrencyAndAmount();

TransactionFieldMap transactionFieldMapInstance = new TransactionFieldMap(
    transactionId: transactionId,
    type: type,
    source: source,
    instrument: instrument,
    transactionDate: transactionDate,
    settlementDate: settlementDate,
    units: units,
    transactionPrice: transactionPrice,
    transactionCurrency: transactionCurrency,
    exchangeRate: exchangeRate,
    totalConsideration: totalConsideration);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
