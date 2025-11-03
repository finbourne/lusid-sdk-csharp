# Lusid.Sdk.Model.TransactionSettlementSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OverallStatus** | [**CategorySettlementStatus**](CategorySettlementStatus.md) |  | 
**StockStatus** | [**CategorySettlementStatus**](CategorySettlementStatus.md) |  | 
**CashStatus** | [**CategorySettlementStatus**](CategorySettlementStatus.md) |  | 
**DeferredCashReceiptStatus** | [**CategorySettlementStatus**](CategorySettlementStatus.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

CategorySettlementStatus overallStatus = new CategorySettlementStatus();
CategorySettlementStatus stockStatus = new CategorySettlementStatus();
CategorySettlementStatus cashStatus = new CategorySettlementStatus();
CategorySettlementStatus deferredCashReceiptStatus = new CategorySettlementStatus();

TransactionSettlementSummary transactionSettlementSummaryInstance = new TransactionSettlementSummary(
    overallStatus: overallStatus,
    stockStatus: stockStatus,
    cashStatus: cashStatus,
    deferredCashReceiptStatus: deferredCashReceiptStatus);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
