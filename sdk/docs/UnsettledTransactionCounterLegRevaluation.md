# Lusid.Sdk.Model.UnsettledTransactionCounterLegRevaluation
The receiving (counter) leg of an FX forward revalued into the fund's base currency at the valuation point's  FX rates. Populated only for FX forward transactions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocalCurrency** | **string** | The currency of the FX forward&#39;s receiving (counter) leg. | [optional] 
**LocalAmount** | **decimal** | The amount of the receiving leg in its own currency. | [optional] 
**BaseCurrency** | **string** | The fund&#39;s base currency. | [optional] 
**BookedBaseAmount** | **decimal?** | The receiving leg amount in base currency at the rate booked on the transaction. Null when no booked rate was recorded. | [optional] 
**RevaluationFxRate** | **decimal?** | The FX rate from the counter-leg currency to base currency at the valuation point&#39;s effective date. Null when the rate could not be resolved. | [optional] 
**RevaluedBaseAmount** | **decimal?** | The receiving leg amount in base currency revalued at the valuation point&#39;s FX rate. Null when the revaluation rate is unavailable. | [optional] 
**RevaluationFxRateEffectiveAt** | **DateTimeOffset?** | The effective date of the quote used for the counter-leg revaluation FX rate. Null for same-currency legs or when the rate is missing. | [optional] 
**Status** | **string** | Whether counter-leg revaluation succeeded (Revalued), was not needed (SameCurrency), or failed due to a missing FX rate (MissingFxRate). | [optional] 
**Problems** | [**List&lt;RevaluationProblem&gt;**](RevaluationProblem.md) | Reasons why any counter-leg amounts could not be populated. Empty when revaluation succeeded. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string localCurrency = "example localCurrency";decimal? localAmount = "example localAmount";
string baseCurrency = "example baseCurrency";
string status = "example status";
List<RevaluationProblem> problems = new List<RevaluationProblem>();

UnsettledTransactionCounterLegRevaluation unsettledTransactionCounterLegRevaluationInstance = new UnsettledTransactionCounterLegRevaluation(
    localCurrency: localCurrency,
    localAmount: localAmount,
    baseCurrency: baseCurrency,
    bookedBaseAmount: bookedBaseAmount,
    revaluationFxRate: revaluationFxRate,
    revaluedBaseAmount: revaluedBaseAmount,
    revaluationFxRateEffectiveAt: revaluationFxRateEffectiveAt,
    status: status,
    problems: problems);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
