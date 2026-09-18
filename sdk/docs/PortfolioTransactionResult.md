# Lusid.Sdk.Model.PortfolioTransactionResult
Represents transaction details for a data quality check result.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | The type of the entity. Always \&quot;Transaction\&quot;. | [optional] 
**TransactionView** | **string** | Whether this is an input or an output transaction | [optional] 
**AsAt** | **DateTimeOffset** | The as-at timestamp for the transaction | [optional] 
**TransactionDate** | **DateTimeOffset** | The transaction date | [optional] 
**TransactionId** | **string** | The transaction&#39;s identifier within its portfolio | [optional] 
**EntityUniqueId** | **string** | The transaction&#39;s unique identifier across portfolios | [optional] 
**SourcePortfolioScope** | **string** | The scope of the portfolio this transaction came from | [optional] 
**SourcePortfolioCode** | **string** | The code of the portfolio this transaction came from | [optional] 
**SourcePortfolioEntityUniqueId** | **string** | The unique identifier of the portfolio this transaction came from | [optional] 
**SourcePortfolioDisplayName** | **string** | The display name of the portfolio this transaction came from | [optional] 
**LusidInstrumentId** | **string** | The LUSID instrument identifier of the instrument transacted | [optional] 
**InstrumentDisplayName** | **string** | The name of the instrument transacted | [optional] 
**TransactionType** | **string** | The transaction type, e.g. Buy, Sell | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string entityType = "example entityType";
string transactionView = "example transactionView";
string transactionId = "example transactionId";
string entityUniqueId = "example entityUniqueId";
string sourcePortfolioScope = "example sourcePortfolioScope";
string sourcePortfolioCode = "example sourcePortfolioCode";
string sourcePortfolioEntityUniqueId = "example sourcePortfolioEntityUniqueId";
string sourcePortfolioDisplayName = "example sourcePortfolioDisplayName";
string lusidInstrumentId = "example lusidInstrumentId";
string instrumentDisplayName = "example instrumentDisplayName";
string transactionType = "example transactionType";

PortfolioTransactionResult portfolioTransactionResultInstance = new PortfolioTransactionResult(
    entityType: entityType,
    transactionView: transactionView,
    asAt: asAt,
    transactionDate: transactionDate,
    transactionId: transactionId,
    entityUniqueId: entityUniqueId,
    sourcePortfolioScope: sourcePortfolioScope,
    sourcePortfolioCode: sourcePortfolioCode,
    sourcePortfolioEntityUniqueId: sourcePortfolioEntityUniqueId,
    sourcePortfolioDisplayName: sourcePortfolioDisplayName,
    lusidInstrumentId: lusidInstrumentId,
    instrumentDisplayName: instrumentDisplayName,
    transactionType: transactionType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
