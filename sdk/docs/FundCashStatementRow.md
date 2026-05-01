# Lusid.Sdk.Model.FundCashStatementRow
A single row in a Fund Cash Statement report.  Each row represents a settled cash movement with running balance, cost basis,  average rate, and realised FX PnL.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupById** | **int** | The groupBy subHoldings and currency. | [optional] 
**SequenceNumber** | **int** | Sequence number determining the order of the cash flow records. | [optional] 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured on a transaction portfolio. | [optional] 
**SourceId** | **string** | The transaction ID that sourced this cash movement. | [optional] 
**CashStatementActionType** | **string** | The action type: Default, Reversal, TrueUp, AvgRateCorrection, Opening, or Closing. | [optional] 
**AccountingDate** | **DateTimeOffset** | The accounting date of the cash movement. | [optional] 
**ActivityDate** | **DateTimeOffset** | The activity date (trade/settlement date) of the cash movement. | [optional] 
**MovementName** | **string** | The movement type (e.g. Receivable_Cash_Trade, Payable_Cash_Trade). | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**InstructionType** | **string** | The settlement instruction type: Automatic, Instructed_Complete, Instructed - Cancel Automatic. | [optional] 
**DiaryEntryCode** | **string** | The diary entry code of the valuation point this row belongs to. | [optional] 
**OriginDiaryEntryCode** | **string** | For Reversal/TrueUp rows: the diary entry code of the period the original row belonged to. | [optional] 
**CashflowLocal** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**BalanceLocal** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**CashflowBase** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**RealisedFxPnl** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**CostBasisBase** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**AvgRate** | **decimal?** | Weighted average FX rate (costBasisBase / balanceLocal). Null when balance is zero. | [optional] 
**FxRateMovement** | **decimal?** | FX rate for this specific movement (CashflowBase / CashFlowLocal). Null when localAmount is zero. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, PerpetualProperty> subHoldingKeys = new Dictionary<string, PerpetualProperty>();
string sourceId = "example sourceId";
string cashStatementActionType = "example cashStatementActionType";
string movementName = "example movementName";
ResourceId? portfolioId = new ResourceId();

string instructionType = "example instructionType";
string diaryEntryCode = "example diaryEntryCode";
string originDiaryEntryCode = "example originDiaryEntryCode";
CurrencyAndAmount? cashflowLocal = new CurrencyAndAmount();

CurrencyAndAmount? balanceLocal = new CurrencyAndAmount();

CurrencyAndAmount? cashflowBase = new CurrencyAndAmount();

CurrencyAndAmount? realisedFxPnl = new CurrencyAndAmount();

CurrencyAndAmount? costBasisBase = new CurrencyAndAmount();

List<Link> links = new List<Link>();

FundCashStatementRow fundCashStatementRowInstance = new FundCashStatementRow(
    groupById: groupById,
    sequenceNumber: sequenceNumber,
    subHoldingKeys: subHoldingKeys,
    sourceId: sourceId,
    cashStatementActionType: cashStatementActionType,
    accountingDate: accountingDate,
    activityDate: activityDate,
    movementName: movementName,
    portfolioId: portfolioId,
    instructionType: instructionType,
    diaryEntryCode: diaryEntryCode,
    originDiaryEntryCode: originDiaryEntryCode,
    cashflowLocal: cashflowLocal,
    balanceLocal: balanceLocal,
    cashflowBase: cashflowBase,
    realisedFxPnl: realisedFxPnl,
    costBasisBase: costBasisBase,
    avgRate: avgRate,
    fxRateMovement: fxRateMovement,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
