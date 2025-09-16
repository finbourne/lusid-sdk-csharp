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
**BalanceReportingCurrency** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**TranslationGainLoss** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**CostBasisReportingCurrency** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**Transaction** | [**Transaction**](Transaction.md) |  | [optional] 
**UnrealisedGainLossReportingCurrency** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
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
CurrencyAndAmount balanceReportingCurrency = new CurrencyAndAmount();
CurrencyAndAmount translationGainLoss = new CurrencyAndAmount();
CurrencyAndAmount costBasisReportingCurrency = new CurrencyAndAmount();
Transaction? transaction = new Transaction();

CurrencyAndAmount unrealisedGainLossReportingCurrency = new CurrencyAndAmount();
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
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
