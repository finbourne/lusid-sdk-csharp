# Lusid.Sdk.Model.AccountedTransaction
The Valuation Point Data Response for the Fund and specified date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountingDate** | **DateTimeOffset** | The transaction&#39;s accounting date. | [optional] 
**JournalEntryAction** | **string** | The journal entry line action associated with this transaction. | [optional] 
**Transaction** | [**OutputTransaction**](OutputTransaction.md) |  | [optional] 
**PortfolioId** | [**PortfolioId**](PortfolioId.md) |  | [optional] 
**ValuationPointOrigin** | **string** | Designates if the transaction was originally part of the Valuation Point or if it was added as part of a Complex Close action. | [optional] 
**AddedOriginValuationPointCode** | **string** | The Valuation Point, only for transaction added as part of a Complex Close action. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string journalEntryAction = "example journalEntryAction";
OutputTransaction? transaction = new OutputTransaction();

PortfolioId? portfolioId = new PortfolioId();

string valuationPointOrigin = "example valuationPointOrigin";
string addedOriginValuationPointCode = "example addedOriginValuationPointCode";

AccountedTransaction accountedTransactionInstance = new AccountedTransaction(
    accountingDate: accountingDate,
    journalEntryAction: journalEntryAction,
    transaction: transaction,
    portfolioId: portfolioId,
    valuationPointOrigin: valuationPointOrigin,
    addedOriginValuationPointCode: addedOriginValuationPointCode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
