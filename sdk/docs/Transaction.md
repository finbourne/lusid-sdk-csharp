# Lusid.Sdk.Model.Transaction
A list of transactions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** | The unique identifier for the transaction. | 
**Type** | **string** | The type of the transaction e.g. &#39;Buy&#39;, &#39;Sell&#39;. The transaction type should have been pre-configured via the System Configuration API endpoint. | 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | A set of instrument identifiers that can resolve the transaction to a unique instrument. | [optional] 
**InstrumentScope** | **string** | The scope in which the transaction&#39;s instrument lies. | [optional] 
**InstrumentUid** | **string** | The unique Lusid Instrument Id (LUID) of the instrument that the transaction is in. | 
**TransactionDate** | **DateTimeOffset** | The date of the transaction. | 
**SettlementDate** | **DateTimeOffset** | The settlement date of the transaction. | 
**Units** | **decimal** | The number of units transacted in the associated instrument. | 
**TransactionPrice** | [**TransactionPrice**](TransactionPrice.md) |  | [optional] 
**TotalConsideration** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**ExchangeRate** | **decimal?** | The exchange rate between the transaction and settlement currency (settlement currency being represented by the TotalConsideration.Currency). For example if the transaction currency is in USD and the settlement currency is in GBP this this the USD/GBP rate. | [optional] 
**TransactionCurrency** | **string** | The transaction currency. | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Set of unique transaction properties and associated values to stored with the transaction. Each property will be from the &#39;Transaction&#39; domain. | [optional] 
**CounterpartyId** | **string** | The identifier for the counterparty of the transaction. | [optional] 
**Source** | **string** | The source of the transaction. This is used to look up the appropriate transaction group set in the transaction type configuration. | [optional] 
**EntryDateTime** | **DateTimeOffset** | The asAt datetime that the transaction was added to LUSID. | [optional] 
**OtcConfirmation** | [**OtcConfirmation**](OtcConfirmation.md) |  | [optional] 
**TransactionStatus** | **string** | The status of the transaction. The available values are: Active, Amended, Cancelled, ActiveReversal, ActiveTrueUp, CancelledTrueUp | [optional] 
**CancelDateTime** | **DateTimeOffset?** | If the transaction has been cancelled, the asAt datetime that the transaction was cancelled. | [optional] 
**OrderId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**AllocationId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**CustodianAccount** | [**CustodianAccount**](CustodianAccount.md) |  | [optional] 
**TransactionGroupId** | **string** | The identifier for grouping economic events across multiple transactions | [optional] 
**StrategyTag** | [**List&lt;Strategy&gt;**](Strategy.md) | A list of strategies representing the allocation of units across multiple sub-holding keys | [optional] 
**ResolvedTransactionTypeDetails** | [**TransactionTypeDetails**](TransactionTypeDetails.md) |  | [optional] 
**DataModelMembership** | [**DataModelMembership**](DataModelMembership.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string transactionId = "transactionId";
string type = "type";
Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();
string instrumentScope = "example instrumentScope";
string instrumentUid = "instrumentUid";decimal units = "units";

TransactionPrice? transactionPrice = new TransactionPrice();

CurrencyAndAmount totalConsideration = new CurrencyAndAmount();
string transactionCurrency = "example transactionCurrency";
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
string counterpartyId = "example counterpartyId";
string source = "example source";
OtcConfirmation? otcConfirmation = new OtcConfirmation();

string transactionStatus = "example transactionStatus";
ResourceId? orderId = new ResourceId();

ResourceId? allocationId = new ResourceId();

CustodianAccount? custodianAccount = new CustodianAccount();

string transactionGroupId = "example transactionGroupId";
List<Strategy> strategyTag = new List<Strategy>();
TransactionTypeDetails? resolvedTransactionTypeDetails = new TransactionTypeDetails();

DataModelMembership? dataModelMembership = new DataModelMembership();


Transaction transactionInstance = new Transaction(
    transactionId: transactionId,
    type: type,
    instrumentIdentifiers: instrumentIdentifiers,
    instrumentScope: instrumentScope,
    instrumentUid: instrumentUid,
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
    entryDateTime: entryDateTime,
    otcConfirmation: otcConfirmation,
    transactionStatus: transactionStatus,
    cancelDateTime: cancelDateTime,
    orderId: orderId,
    allocationId: allocationId,
    custodianAccount: custodianAccount,
    transactionGroupId: transactionGroupId,
    strategyTag: strategyTag,
    resolvedTransactionTypeDetails: resolvedTransactionTypeDetails,
    dataModelMembership: dataModelMembership);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
