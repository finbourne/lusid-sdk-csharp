# Lusid.Sdk.Model.ReconciliationTransactions
Specification for the transactions of a scheduled reconciliation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionWindow** | [**DateRange**](DateRange.md) |  | [optional] 
**MappingId** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DateRange? transactionWindow = new DateRange();

ResourceId? mappingId = new ResourceId();


ReconciliationTransactions reconciliationTransactionsInstance = new ReconciliationTransactions(
    transactionWindow: transactionWindow,
    mappingId: mappingId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
