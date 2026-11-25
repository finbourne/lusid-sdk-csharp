# Lusid.Sdk.Model.PortfolioCashFlow
The details for the cashflow for a given portfolio.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupById** | **int** | The groupBy subHoldings and currency. | 
**SequenceNumber** | **int** | Sequence number determining the order of the cash flow records. | 
**EffectiveDate** | **DateTimeOffset** | Indicates the date when the cash-flow settles. | [optional] 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured on a transaction portfolio. | [optional] 
**Type** | **string** | Indicates the record type (Closed, Open, Activity). | 
**MovementName** | **string** | Indicates the specific movement of the transaction that generated this cash flow. | 
**Cashflow** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**Balance** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**FxRate** | **decimal** | Exchange rate between the currency of this cash flow and the reporting currency. | 
**CashflowReportingCurrency** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**BalanceReportingCurrency** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**TranslationGainLoss** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**CostBasisReportingCurrency** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**Transaction** | [**Transaction**](Transaction.md) |  | [optional] 
**UnrealisedGainLossReportingCurrency** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**TradeDateToSettlementDateGainLossReportingCurrency** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**BalanceFxRate** | **decimal?** | The exchange rate the balance in the reporting currency was struck at: on an Activity row the recipe&#39;s quote for the row&#39;s date, after the recipe&#39;s quote lookback. Differs from FxRate when the cash flow was booked at another rate. The cash flow&#39;s own rate (FxRate) when no quote could be found; see BalanceFailureReason. | [optional] 
**BalanceFailureReason** | **string** | Why the balance in the reporting currency could not be struck at the recipe&#39;s quote for the row&#39;s date and is at the cash flow&#39;s own rate instead; absent when it was struck at the quote, including on a row whose local balance is zero. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, PerpetualProperty> subHoldingKeys = new Dictionary<string, PerpetualProperty>();
string type = "type";
string movementName = "movementName";
CurrencyAndAmount cashflow = new CurrencyAndAmount();
CurrencyAndAmount balance = new CurrencyAndAmount();decimal fxRate = "fxRate";

CurrencyAndAmount cashflowReportingCurrency = new CurrencyAndAmount();
CurrencyAndAmount? balanceReportingCurrency = new CurrencyAndAmount();

CurrencyAndAmount translationGainLoss = new CurrencyAndAmount();
CurrencyAndAmount costBasisReportingCurrency = new CurrencyAndAmount();
Transaction? transaction = new Transaction();

CurrencyAndAmount? unrealisedGainLossReportingCurrency = new CurrencyAndAmount();

CurrencyAndAmount tradeDateToSettlementDateGainLossReportingCurrency = new CurrencyAndAmount();
string balanceFailureReason = "example balanceFailureReason";
List<Link> links = new List<Link>();

PortfolioCashFlow portfolioCashFlowInstance = new PortfolioCashFlow(
    groupById: groupById,
    sequenceNumber: sequenceNumber,
    effectiveDate: effectiveDate,
    subHoldingKeys: subHoldingKeys,
    type: type,
    movementName: movementName,
    cashflow: cashflow,
    balance: balance,
    fxRate: fxRate,
    cashflowReportingCurrency: cashflowReportingCurrency,
    balanceReportingCurrency: balanceReportingCurrency,
    translationGainLoss: translationGainLoss,
    costBasisReportingCurrency: costBasisReportingCurrency,
    transaction: transaction,
    unrealisedGainLossReportingCurrency: unrealisedGainLossReportingCurrency,
    tradeDateToSettlementDateGainLossReportingCurrency: tradeDateToSettlementDateGainLossReportingCurrency,
    balanceFxRate: balanceFxRate,
    balanceFailureReason: balanceFailureReason,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
