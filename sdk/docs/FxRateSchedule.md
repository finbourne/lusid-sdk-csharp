# Lusid.Sdk.Model.FxRateSchedule
Schedule to define fx conversion of cashflows on complex bonds. If an fx schedule is defined then  on payment schedule generation the coupon and principal payoffs will be wrapped in an fx rate payoff method.  Either the fx rate is predefined (fixed) or relies on fx resets (floating).  Used in representation of dual currency bond.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScheduleType** | **string** | The available values are: FixedSchedule, FloatSchedule, OptionalitySchedule, StepSchedule, Exercise, FxRateSchedule, Invalid | 
**FlowConventions** | [**FlowConventions**](FlowConventions.md) |  | [optional] 
**FxConversionTypes** | **List&lt;string&gt;** | List of flags to indicate if coupon payments, principal payments or both are converted | [optional] 
**Rate** | **decimal** | FxRate used to convert payments. Assumed to be in units of the ToCurrency so conversion is paymentAmount x fxRate | [optional] 
**ToCurrency** | **string** | Currency that payments are converted to | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

