# Lusid.Sdk.Model.FeeRuleUpsertRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** |  | [optional] 
**TransactionPropertyKey** | **string** |  | 
**TransactionType** | **string** |  | 
**Country** | **string** |  | 
**Counterparty** | **string** |  | 
**TransactionCurrency** | **string** |  | 
**SettlementCurrency** | **string** |  | 
**ExecutionBroker** | **string** |  | 
**Custodian** | **string** |  | 
**Exchange** | **string** |  | 
**Fee** | [**CalculationInfo**](CalculationInfo.md) |  | 
**MinFee** | [**CalculationInfo**](CalculationInfo.md) |  | [optional] 
**MaxFee** | [**CalculationInfo**](CalculationInfo.md) |  | [optional] 
**AdditionalKeys** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Description** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "example code";
string transactionPropertyKey = "transactionPropertyKey";
string transactionType = "transactionType";
string country = "country";
string counterparty = "counterparty";
string transactionCurrency = "transactionCurrency";
string settlementCurrency = "settlementCurrency";
string executionBroker = "executionBroker";
string custodian = "custodian";
string exchange = "exchange";
CalculationInfo fee = new CalculationInfo();
CalculationInfo? minFee = new CalculationInfo();

CalculationInfo? maxFee = new CalculationInfo();

Dictionary<string, string> additionalKeys = new Dictionary<string, string>();
string description = "example description";

FeeRuleUpsertRequest feeRuleUpsertRequestInstance = new FeeRuleUpsertRequest(
    code: code,
    transactionPropertyKey: transactionPropertyKey,
    transactionType: transactionType,
    country: country,
    counterparty: counterparty,
    transactionCurrency: transactionCurrency,
    settlementCurrency: settlementCurrency,
    executionBroker: executionBroker,
    custodian: custodian,
    exchange: exchange,
    fee: fee,
    minFee: minFee,
    maxFee: maxFee,
    additionalKeys: additionalKeys,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
