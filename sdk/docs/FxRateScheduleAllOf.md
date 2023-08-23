# Lusid.Sdk.Model.FxRateScheduleAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FlowConventions** | [**FlowConventions**](FlowConventions.md) |  | [optional] 
**FxConversionTypes** | **List&lt;string&gt;** | List of flags to indicate if coupon payments, principal payments or both are converted | [optional] 
**Rate** | **decimal** | FxRate used to convert payments. Assumed to be in units of the ToCurrency so conversion is paymentAmount x fxRate | [optional] 
**ToCurrency** | **string** | Currency that payments are converted to | [optional] 
**ScheduleType** | **string** | The available values are: FixedSchedule, FloatSchedule, OptionalitySchedule, StepSchedule, Exercise, FxRateSchedule, Invalid | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

