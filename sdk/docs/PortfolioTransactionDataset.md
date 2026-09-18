# Lusid.Sdk.Model.PortfolioTransactionDataset
Contains the run-time parameters that are appropriate for check definitions  with datasetSchema.type = \"PortfolioContents\" and datasetSchema.entityType = \"Transaction\"

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAt** | **DateTimeOffset?** | The asAt date to fetch the data. Nullable. Defaults to latest. | [optional] 
**FromEffectiveDate** | **DateTimeOffset?** | The earliest transaction date to check, inclusive. Nullable. Unbounded if not provided. | [optional] 
**ToEffectiveDate** | **DateTimeOffset?** | The latest transaction date to check, inclusive. Nullable — the window is unbounded above if not  provided. This value also resolves as the run&#39;s effectiveAt, so portfolios are resolved and transactions  decorated as of it; when not provided, that defaults to latest. Must be on or after fromEffectiveDate  when both are provided. | [optional] 
**PortfolioScope** | **string** | The scope of the portfolios whose transactions to check. Nullable. Every scope is checked if not provided. | [optional] 
**PortfolioSelectorAttribute** | **string** | An attribute (field name or propertyKey) to use to narrow down the portfolios whose transactions are  checked. Cannot be provided without portfolioSelectorValue, and vice versa. | [optional] 
**PortfolioSelectorValue** | **string** | The value of the above attribute used to narrow down the portfolios. Cannot be provided without  portfolioSelectorAttribute, and vice versa. | [optional] 
**TransactionSelectorAttribute** | **string** | An attribute (field name or propertyKey) to use to narrow down the transactions checked within those  portfolios. Cannot be provided without transactionSelectorValue, and vice versa. | [optional] 
**TransactionSelectorValue** | **string** | The value of the above attribute used to narrow down the transactions. Cannot be provided without  transactionSelectorAttribute, and vice versa. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string portfolioScope = "example portfolioScope";
string portfolioSelectorAttribute = "example portfolioSelectorAttribute";
string portfolioSelectorValue = "example portfolioSelectorValue";
string transactionSelectorAttribute = "example transactionSelectorAttribute";
string transactionSelectorValue = "example transactionSelectorValue";

PortfolioTransactionDataset portfolioTransactionDatasetInstance = new PortfolioTransactionDataset(
    asAt: asAt,
    fromEffectiveDate: fromEffectiveDate,
    toEffectiveDate: toEffectiveDate,
    portfolioScope: portfolioScope,
    portfolioSelectorAttribute: portfolioSelectorAttribute,
    portfolioSelectorValue: portfolioSelectorValue,
    transactionSelectorAttribute: transactionSelectorAttribute,
    transactionSelectorValue: transactionSelectorValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
