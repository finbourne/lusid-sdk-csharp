# Lusid.Sdk.Model.FeeAccrual

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveAt** | **DateTimeOffset** | The effective date for which the fee accrual has been calculated. | 
**Code** | **string** | The code of the fee for which the accrual has been calculated. | 
**Name** | **string** | The name of the fee for which the accrual has been calculated. | 
**CalculationBase** | **decimal** | The basis the annual accrual derives from: the result of evaluating the fee&#39;s calculation base expression, or the configured annual amount for a fixed-amount fee. | [optional] 
**Amount** | **decimal** | The result of applying the fee to the calculation base, and scaled down to a day. | [optional] 
**PreviousAccrual** | **decimal** | The previous valuation point&#39;s total accrual. | [optional] 
**PreviousTotalAccrual** | **decimal** | The previous valuation point&#39;s total accrual. | [optional] 
**TotalAccrual** | **decimal** | The sum of the PreviousAccrual and Amount. | [optional] 
**CapPeriodAccrual** | **decimal** | The amount accrued so far in the current fee year (from the fee&#39;s AnchorDate), in the fund currency, against which an annual FeeCap is assessed. | [optional] 
**FeeCapApplied** | **bool** | Whether the FeeCap reduced the amount accrued at this valuation point. | [optional] 
**FeeFloorApplied** | **bool** | Whether the FeeFloor raised the amount accrued at this valuation point. | [optional] 
**IsPayableDate** | **bool** | Whether the valuation point&#39;s window, from the day after the previous valuation point to this one, holds one of the fee&#39;s payable dates, set by its PayableFrequency and AnchorDate and rolled by its BusinessDayConvention. | [optional] 
**PayableDate** | **DateTimeOffset?** | The latest payable date of the fee in the valuation point&#39;s window, after business day adjustment. Null when the window holds no payable date. | [optional] 
**PayableAmount** | **decimal** | The accrued balance that became payable at this valuation point: the previous valuation point&#39;s AccruedBalance plus the accrual through the end of the PayableDate, less what the fund&#39;s own transactions tagged with the fee&#39;s code in a Transaction/&lt;fund scope&gt;/FeeCode property deemed payable on or before it. Several payable dates in one window give one combined payable. Never negative: zero when the window holds no payable date, or when the balance due is not positive, as when tagged transactions already deemed more than was due. A share class&#39;s PayableAmount is its share of the fund&#39;s, apportioned by each class&#39;s balance due before deems, so the classes&#39; add up to the fund&#39;s. | [optional] 
**AccruedBalance** | **decimal** | The amount accrued and not yet payable. It resets on a payable date, unlike TotalAccrual, and the total consideration of each of the fund&#39;s transactions in the valuation point&#39;s window tagged with the fee&#39;s code in a Transaction/&lt;fund scope&gt;/FeeCode property comes off it. A negative balance, from deeming more than was due, nets off later accruals before anything is payable again, as a prepaid fee does. | [optional] 
**PreviousAccruedBalance** | **decimal** | The previous valuation point&#39;s AccruedBalance. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string name = "name";decimal? calculationBase = "example calculationBase";decimal? amount = "example amount";decimal? previousAccrual = "example previousAccrual";decimal? previousTotalAccrual = "example previousTotalAccrual";decimal? totalAccrual = "example totalAccrual";decimal? capPeriodAccrual = "example capPeriodAccrual";
bool feeCapApplied = //"True";
bool feeFloorApplied = //"True";
bool isPayableDate = //"True";decimal? payableAmount = "example payableAmount";decimal? accruedBalance = "example accruedBalance";decimal? previousAccruedBalance = "example previousAccruedBalance";
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
    capPeriodAccrual: capPeriodAccrual,
    feeCapApplied: feeCapApplied,
    feeFloorApplied: feeFloorApplied,
    isPayableDate: isPayableDate,
    payableDate: payableDate,
    payableAmount: payableAmount,
    accruedBalance: accruedBalance,
    previousAccruedBalance: previousAccruedBalance,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
