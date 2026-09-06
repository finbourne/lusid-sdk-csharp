# Lusid.Sdk.Model.PikSchedule
A PikSchedule represents Payment-in-Kind features for a ComplexBond.  It works in conjunction with existing FixedSchedules or FloatSchedules to define  how interest is paid during duration of the schedule.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScheduleType** | **string** | Available values: FixedSchedule, FloatSchedule, OptionalitySchedule, StepSchedule, Exercise, FxRateSchedule, FxLinkedNotionalSchedule, BondConversionSchedule, PikSchedule, CommodityCalendarSchedule, Invalid, CancelSchedule. | 
**StartDate** | **DateTimeOffset** | The start date of the PIK schedule period. | 
**MaturityDate** | **DateTimeOffset** | The end date of the PIK schedule period. | 
**IsPikFractionElectable** | **bool** | If true, the PIK fraction is electable at each payment date.  Defaults to false. | [optional] 
**PikFraction** | **decimal?** | The fraction of the coupon that is paid in kind, where 0 means fully cash and 1 means fully PIK.  Required if IsPikFractionElectable is false or null. Must satisfy 0 &lt;&#x3D; pikFraction &lt;&#x3D; 1. | [optional] 
**PikMargin** | **decimal?** | The portion of the coupon that is paid in kind, stated in the leg&#39;s own rate units (an annualised  rate on the notional) rather than as a fraction of the coupon. The in-kind leg accrues at this flat  rate and the cash leg accrues the remainder of the coupon, so on a floating leg the in-kind portion  stays constant across fixings — the shape of a loan quoted as \&quot;index + 700bp, of which 250bp paid  in kind\&quot;. On a fixed leg it is equivalent to pikFraction &#x3D; pikMargin / couponRate. Should the  period&#39;s whole coupon fall below the margin, the in-kind portion is capped at the whole  (non-negative) coupon and the cash leg floors at zero.  Mutually exclusive with pikFraction, pikRate, pikSpread and isPikFractionElectable.  Must be greater than or equal to zero. null indicates the split is stated by pikFraction instead. | [optional] 
**PikPaymentType** | **string** | The type of PIK payment to be used for the duration of this schedule.  InterestCapitalisation adds the paid-in-kind portion to the bond&#39;s current face;  AdditionalSecurities settles it by delivering units of another instrument, named on each  period&#39;s PikBondInterestEvent; Electable leaves the choice to a per-period election.                Supported string (enumeration) values are: [Electable, InterestCapitalisation, AdditionalSecurities]. | [optional] 
**PikRate** | **decimal?** | The PIK interest rate. Must be greater than or equal to zero.  null indicates no override PIK interest rate. | [optional] 
**PikSpread** | **decimal?** | The PIK spread to be added to the base rate for the final PIK rate.  null indicates no spread on base rate. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool isPikFractionElectable = //"True";
string pikPaymentType = "example pikPaymentType";

PikSchedule pikScheduleInstance = new PikSchedule(
    startDate: startDate,
    maturityDate: maturityDate,
    isPikFractionElectable: isPikFractionElectable,
    pikFraction: pikFraction,
    pikMargin: pikMargin,
    pikPaymentType: pikPaymentType,
    pikRate: pikRate,
    pikSpread: pikSpread);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
