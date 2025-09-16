# Lusid.Sdk.Model.TransactionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** | The unique identifier of the transaction. | 
**Type** | **string** | The type of the transaction, for example &#39;Buy&#39; or &#39;Sell&#39;. The transaction type must have been pre-configured using the System Configuration API. If not, this operation will succeed but you are not able to calculate holdings for the portfolio that include this transaction. | 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | A set of instrument identifiers that can resolve the transaction to a unique instrument. | 
**TransactionDate** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The date of the transaction. | 
**SettlementDate** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The settlement date of the transaction. | 
**Units** | **decimal** | The number of units of the transacted instrument. | 
**TransactionPrice** | [**TransactionPrice**](TransactionPrice.md) |  | [optional] 
**TotalConsideration** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**ExchangeRate** | **decimal?** | The exchange rate between the transaction and settlement currency (settlement currency being represented by TotalConsideration.Currency). For example, if the transaction currency is USD and the settlement currency is GBP, this would be the appropriate USD/GBP rate. | [optional] 
**TransactionCurrency** | **string** | The transaction currency. | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | A list of unique transaction properties and associated values to store for the transaction. Each property must be from the &#39;Transaction&#39; domain. | [optional] 
**CounterpartyId** | **string** | The identifier for the counterparty of the transaction. | [optional] 
**Source** | **string** | The source of the transaction. This is used to look up the appropriate transaction group set in the transaction type configuration. | [optional] 
**OtcConfirmation** | [**OtcConfirmation**](OtcConfirmation.md) |  | [optional] 
**OrderId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**AllocationId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**CustodianAccountId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**TransactionGroupId** | **string** | The identifier for grouping economic events across multiple transactions | [optional] 
**StrategyTag** | [**List&lt;Strategy&gt;**](Strategy.md) | A list of strategies representing the allocation of units across multiple sub-holding keys | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string transactionId = "transactionId";
string type = "type";
Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();
DateTimeOrCutLabel transactionDate = "transactionDate";
DateTimeOrCutLabel settlementDate = "settlementDate";decimal units = "units";

TransactionPrice? transactionPrice = new TransactionPrice();

CurrencyAndAmount totalConsideration = new CurrencyAndAmount();
string transactionCurrency = "example transactionCurrency";
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
string counterpartyId = "example counterpartyId";
string source = "example source";
OtcConfirmation? otcConfirmation = new OtcConfirmation();

ResourceId? orderId = new ResourceId();

ResourceId? allocationId = new ResourceId();

ResourceId? custodianAccountId = new ResourceId();

string transactionGroupId = "example transactionGroupId";
List<Strategy> strategyTag = new List<Strategy>();

TransactionRequest transactionRequestInstance = new TransactionRequest(
    transactionId: transactionId,
    type: type,
    instrumentIdentifiers: instrumentIdentifiers,
    transactionDate: transactionDate,
    settlementDate: settlementDate,
    units: units,
    transactionPrice: transactionPrice,
    totalConsideration: totalConsideration,
    exchangeRate: exchangeRate,
    transactionCurrency: transactionCurrency,
    properties: properties,
    counterpartyId: counterpartyId,
    source: source,
    otcConfirmation: otcConfirmation,
    orderId: orderId,
    allocationId: allocationId,
    custodianAccountId: custodianAccountId,
    transactionGroupId: transactionGroupId,
    strategyTag: strategyTag);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
