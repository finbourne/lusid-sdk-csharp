# Lusid.Sdk.Model.UnsettledTransaction
A transaction that remains unsettled as at the valuation point, with per-bucket settlement status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Transaction** | [**OutputTransaction**](OutputTransaction.md) |  | [optional] 
**PortfolioId** | [**PortfolioId**](PortfolioId.md) |  | [optional] 
**OverallSettlementStatus** | **string** | The overall settlement status of the transaction (Unsettled, PartSettled, Settled, None). | [optional] 
**OverallIsOverdue** | **bool** | Whether the transaction is overdue for settlement. | [optional] 
**CashSettlementStatus** | **string** | The settlement status of the cash component. | [optional] 
**CashIsOverdue** | **bool** | Whether the cash component is overdue for settlement. | [optional] 
**StockSettlementStatus** | **string** | The settlement status of the stock component. | [optional] 
**StockIsOverdue** | **bool** | Whether the stock component is overdue for settlement. | [optional] 
**DeferredCashSettlementStatus** | **string** | The settlement status of the deferred cash component. | [optional] 
**DeferredCashIsOverdue** | **bool** | Whether the deferred cash component is overdue for settlement. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

OutputTransaction? transaction = new OutputTransaction();

PortfolioId? portfolioId = new PortfolioId();

string overallSettlementStatus = "example overallSettlementStatus";
bool overallIsOverdue = //"True";
string cashSettlementStatus = "example cashSettlementStatus";
bool cashIsOverdue = //"True";
string stockSettlementStatus = "example stockSettlementStatus";
bool stockIsOverdue = //"True";
string deferredCashSettlementStatus = "example deferredCashSettlementStatus";
bool deferredCashIsOverdue = //"True";

UnsettledTransaction unsettledTransactionInstance = new UnsettledTransaction(
    transaction: transaction,
    portfolioId: portfolioId,
    overallSettlementStatus: overallSettlementStatus,
    overallIsOverdue: overallIsOverdue,
    cashSettlementStatus: cashSettlementStatus,
    cashIsOverdue: cashIsOverdue,
    stockSettlementStatus: stockSettlementStatus,
    stockIsOverdue: stockIsOverdue,
    deferredCashSettlementStatus: deferredCashSettlementStatus,
    deferredCashIsOverdue: deferredCashIsOverdue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
