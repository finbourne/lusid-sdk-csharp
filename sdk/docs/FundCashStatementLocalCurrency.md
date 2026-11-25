# Lusid.Sdk.Model.FundCashStatementLocalCurrency
A single row in the local-currency Fund Cash Statement report. Each row is a settled cash  movement with a running balance in local currency, and the base-currency cash flow, realised FX  (split into its trade-date-to-settlement-date and cash pool parts), cost basis, balance at the  recipe's rate on the row's date and the unrealised FX between the two.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupById** | **int** | The groupBy subHoldings and currency. | [optional] 
**SequenceNumber** | **int** | Sequence number determining the order of the cash flow records. | [optional] 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured on a transaction portfolio. | [optional] 
**SourceId** | **string** | The transaction ID that sourced this cash movement. | [optional] 
**CashStatementActionType** | **string** | The action type: Default, Reversal, TrueUp, SystemCorrection, Opening, or Closing. | [optional] 
**EntryType** | **string** | What drove the row: SystemGenerated (accounting-engine housekeeping such as a reversal/true-up around a backdated transaction) or UserEntered (a real cash movement booked by a user, e.g. a late trade or amendment). | [optional] 
**AccountingDate** | **DateTimeOffset** | The accounting date of the cash movement. | [optional] 
**ActivityDate** | **DateTimeOffset** | The activity date (trade/settlement date) of the cash movement. | [optional] 
**MovementName** | **string** | The movement type (e.g. Receivable_Cash_Trade, Payable_Cash_Trade). | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**InstructionType** | **string** | The settlement instruction type: Automatic, Instructed_Complete, Instructed - Cancel Automatic. | [optional] 
**DiaryEntryCode** | **string** | The diary entry code of the valuation point this row belongs to. | [optional] 
**OriginDiaryEntryCode** | **string** | For Reversal/TrueUp rows: the diary entry code of the period the original row belonged to. | [optional] 
**CashflowLocal** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**BalanceLocal** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The requested properties decorated onto the cash statement row. | [optional] 
**CashflowBase** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**TradeDateToSettlementDateFxPnlBase** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**CashPoolFxPnlBase** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**CostBasisBase** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**BalanceBase** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**UnrealisedFxPnlBase** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**BalanceFxRate** | **decimal?** | The FX rate BalanceBase was struck at, from the row&#39;s currency to the base currency, or 1 for a balance already in the base currency. Not returned when BalanceBase is not, nor when BalanceLocal is zero and no rate was found. | [optional] 
**BalanceBaseFailureReason** | **string** | Why BalanceBase, BalanceFxRate and UnrealisedFxPnlBase are not returned on this row: no FX rate was found for the row&#39;s currency at its accounting date within the recipe&#39;s quote interval, the rate found was not positive, or the rates could not be read. Null when the balance was struck, and on a row whose BalanceLocal is zero, which is zero in the base currency without a rate. | [optional] 
**AvgRate** | **decimal?** | Weighted average FX rate (costBasisBase / balanceLocal). Null when balance is zero. | [optional] 
**FxRateMovement** | **decimal?** | FX rate for this specific movement (CashflowBase / CashFlowLocal). Null when localAmount is zero. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, PerpetualProperty> subHoldingKeys = new Dictionary<string, PerpetualProperty>();
string sourceId = "example sourceId";
string cashStatementActionType = "example cashStatementActionType";
string entryType = "example entryType";
string movementName = "example movementName";
ResourceId? portfolioId = new ResourceId();

string instructionType = "example instructionType";
string diaryEntryCode = "example diaryEntryCode";
string originDiaryEntryCode = "example originDiaryEntryCode";
CurrencyAndAmount? cashflowLocal = new CurrencyAndAmount();

CurrencyAndAmount? balanceLocal = new CurrencyAndAmount();

Dictionary<string, Property> properties = new Dictionary<string, Property>();
CurrencyAndAmount? cashflowBase = new CurrencyAndAmount();

CurrencyAndAmount? tradeDateToSettlementDateFxPnlBase = new CurrencyAndAmount();

CurrencyAndAmount? cashPoolFxPnlBase = new CurrencyAndAmount();

CurrencyAndAmount? costBasisBase = new CurrencyAndAmount();

CurrencyAndAmount? balanceBase = new CurrencyAndAmount();

CurrencyAndAmount? unrealisedFxPnlBase = new CurrencyAndAmount();

string balanceBaseFailureReason = "example balanceBaseFailureReason";
List<Link> links = new List<Link>();

FundCashStatementLocalCurrency fundCashStatementLocalCurrencyInstance = new FundCashStatementLocalCurrency(
    groupById: groupById,
    sequenceNumber: sequenceNumber,
    subHoldingKeys: subHoldingKeys,
    sourceId: sourceId,
    cashStatementActionType: cashStatementActionType,
    entryType: entryType,
    accountingDate: accountingDate,
    activityDate: activityDate,
    movementName: movementName,
    portfolioId: portfolioId,
    instructionType: instructionType,
    diaryEntryCode: diaryEntryCode,
    originDiaryEntryCode: originDiaryEntryCode,
    cashflowLocal: cashflowLocal,
    balanceLocal: balanceLocal,
    properties: properties,
    cashflowBase: cashflowBase,
    tradeDateToSettlementDateFxPnlBase: tradeDateToSettlementDateFxPnlBase,
    cashPoolFxPnlBase: cashPoolFxPnlBase,
    costBasisBase: costBasisBase,
    balanceBase: balanceBase,
    unrealisedFxPnlBase: unrealisedFxPnlBase,
    balanceFxRate: balanceFxRate,
    balanceBaseFailureReason: balanceBaseFailureReason,
    avgRate: avgRate,
    fxRateMovement: fxRateMovement,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
