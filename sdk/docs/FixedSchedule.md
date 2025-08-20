# Lusid.Sdk.Model.FixedSchedule
Schedule for fixed coupon payments

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScheduleType** | **string** | The available values are: FixedSchedule, FloatSchedule, OptionalitySchedule, StepSchedule, Exercise, FxRateSchedule, FxLinkedNotionalSchedule, BondConversionSchedule, Invalid | 
**StartDate** | **DateTimeOffset** | Date from which LUSID starts generating the payment schedule. | 
**MaturityDate** | **DateTimeOffset** | Last date of the payment generation schedule. May not necessarily be the maturity date of the underlying instrument (e.g. in case the instrument has multiple payment schedules). | 
**FlowConventions** | [**FlowConventions**](FlowConventions.md) |  | [optional] 
**CouponRate** | **decimal** | Coupon rate given as a fraction. | [optional] 
**ConventionName** | [**FlowConventionName**](FlowConventionName.md) |  | [optional] 
**ExDividendDays** | **int?** | Optional. Number of calendar days in the ex-dividend period. If the settlement date falls in the ex-dividend period then the coupon paid is zero and the accrued interest is negative. If set, this must be a non-negative number. If not set, or set to 0, then there is no ex-dividend period.              NOTE: This field is deprecated.  If you wish to set the ExDividendDays on a bond, please use the ExDividendConfiguration. | [optional] 
**Notional** | **decimal** | Scaling factor, the quantity outstanding on which the rate will be paid. | [optional] 
**PaymentCurrency** | **string** | Payment currency. This does not have to be the same as the nominal bond or observation/reset currency. | 
**StubType** | **string** | When a payment schedule doesn&#39;t have regular payment intervals just because of the first and/or last coupons of the schedule, we call those irregular coupons stubs. This configuration specifies what type of stub is used when building the schedule Supported values are: None &#x3D; this is a regular payment schedule with no stubs. DO NOT use it with irregular schedules or you will get incorrect and unexpected behaviour. ShortFront &#x3D; this is an irregular payment schedule where only the first coupon is irregular, and covers a payment period that is shorter than the regular payment period. ShortBack &#x3D; this is an irregular payment schedule where only the last coupon is irregular, and covers a payment period that is shorter than the regular payment period. LongFront &#x3D; this is an irregular payment schedule where only the first coupon is irregular, and covers a payment period that is longer than the regular payment period. LongBack &#x3D; this is an irregular payment schedule where only the last coupon is irregular, and covers a payment period that is longer than the regular payment period. Both &#x3D; this is an irregular payment schedule where both the first and the last coupons are irregular, and the length of these periods is calculated based on the first coupon payment date that should have been explicitly set. | [optional] 
**ExDividendConfiguration** | [**ExDividendConfiguration**](ExDividendConfiguration.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

