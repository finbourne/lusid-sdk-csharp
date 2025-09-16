# Lusid.Sdk.Model.FeeRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** |  | 
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
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
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
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

FeeRule feeRuleInstance = new FeeRule(
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
    description: description,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
