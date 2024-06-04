# Lusid.Sdk.Model.FxLinkedNotionalSchedule
Schedule for notional changes based on the change in FX rate.  Used in the representation of a resettable cross currency interest rate swap.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScheduleType** | **string** | The available values are: FixedSchedule, FloatSchedule, OptionalitySchedule, StepSchedule, Exercise, FxRateSchedule, FxLinkedNotionalSchedule, BondConversionSchedule, Invalid | 
**FxConventions** | [**FxConventions**](FxConventions.md) |  | 
**VaryingNotionalCurrency** | **string** | The currency of the varying notional amount. | 
**VaryingNotionalFixingDates** | [**RelativeDateOffset**](RelativeDateOffset.md) |  | 
**VaryingNotionalInterimExchangePaymentDates** | [**RelativeDateOffset**](RelativeDateOffset.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

