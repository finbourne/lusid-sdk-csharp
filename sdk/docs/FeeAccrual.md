# Lusid.Sdk.Model.FeeAccrual

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveAt** | **DateTimeOffset** | The effective date for which the fee accrual has been calculated. | 
**Code** | **string** | The code of the fee for which the accrual has been calculated. | 
**Name** | **string** | The name of the fee for which the accrual has been calculated. | 
**CalculationBase** | **decimal** | The result of the evaluating the fee&#39;s calculation base expression. | [optional] 
**Amount** | **decimal** | The result of applying the fee to the calculation base, and scaled down to a day. | [optional] 
**PreviousAccrual** | **decimal** | The previous valuation point&#39;s total accrual. | [optional] 
**PreviousTotalAccrual** | **decimal** | The previous valuation point&#39;s total accrual. | [optional] 
**TotalAccrual** | **decimal** | The sum of the PreviousAccrual and Amount. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string name = "name";decimal? calculationBase = "example calculationBase";decimal? amount = "example amount";decimal? previousAccrual = "example previousAccrual";decimal? previousTotalAccrual = "example previousTotalAccrual";decimal? totalAccrual = "example totalAccrual";
List<Link> links = new List<Link>();

FeeAccrual feeAccrualInstance = new FeeAccrual(
    effectiveAt: effectiveAt,
    code: code,
    name: name,
    calculationBase: calculationBase,
    amount: amount,
    previousAccrual: previousAccrual,
    previousTotalAccrual: previousTotalAccrual,
    totalAccrual: totalAccrual,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
