# Lusid.Sdk.Model.UnsettledTransactionRevaluation
The transaction's total consideration in base currency, both at the rate it was booked at and revalued at the  valuation point's FX rate. Rates and amounts are null when they could not be resolved; Problems explains why.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocalCurrency** | **string** | The settlement currency of the transaction (the &#39;local&#39; currency for revaluation purposes). | [optional] 
**LocalAmount** | **decimal** | The total consideration in the settlement currency, as booked. | [optional] 
**BaseCurrency** | **string** | The fund&#39;s base currency. | [optional] 
**BaseFxRate** | **decimal?** | The FX rate from settlement currency to base currency at the time the transaction was booked. Null when no booked rate was recorded. | [optional] 
**BaseAmount** | **decimal?** | The total consideration in base currency at the booked FX rate. Null when the booked rate is unavailable. | [optional] 
**RevaluationFxRate** | **decimal?** | The FX rate from settlement currency to base currency at the valuation point&#39;s effective date. Null when the rate could not be resolved. | [optional] 
**RevaluedBaseAmount** | **decimal?** | The total consideration in base currency revalued at the valuation point&#39;s FX rate. Null when the revaluation rate is unavailable. | [optional] 
**RevaluationFxRateEffectiveAt** | **DateTimeOffset?** | The effective date of the quote used for the revaluation FX rate. Null for same-currency transactions or when the rate is missing. | [optional] 
**Status** | **string** | Whether revaluation succeeded (Revalued), was not needed (SameCurrency), or failed due to a missing FX rate (MissingFxRate). | [optional] 
**Problems** | [**List&lt;RevaluationProblem&gt;**](RevaluationProblem.md) | Reasons why any of the amounts could not be populated. Empty when revaluation succeeded. | [optional] 
**CounterLeg** | [**UnsettledTransactionCounterLegRevaluation**](UnsettledTransactionCounterLegRevaluation.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string localCurrency = "example localCurrency";decimal? localAmount = "example localAmount";
string baseCurrency = "example baseCurrency";
string status = "example status";
List<RevaluationProblem> problems = new List<RevaluationProblem>();
UnsettledTransactionCounterLegRevaluation? counterLeg = new UnsettledTransactionCounterLegRevaluation();


UnsettledTransactionRevaluation unsettledTransactionRevaluationInstance = new UnsettledTransactionRevaluation(
    localCurrency: localCurrency,
    localAmount: localAmount,
    baseCurrency: baseCurrency,
    baseFxRate: baseFxRate,
    baseAmount: baseAmount,
    revaluationFxRate: revaluationFxRate,
    revaluedBaseAmount: revaluedBaseAmount,
    revaluationFxRateEffectiveAt: revaluationFxRateEffectiveAt,
    status: status,
    problems: problems,
    counterLeg: counterLeg);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
