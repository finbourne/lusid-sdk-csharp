# Lusid.Sdk.Model.OptionalitySchedule
Optionality Schedule represents a class for creation of schedules for optionality (call, put)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScheduleType** | **string** | The available values are: FixedSchedule, FloatSchedule, OptionalitySchedule, StepSchedule, Exercise, FxRateSchedule, FxLinkedNotionalSchedule, Invalid | 
**ExerciseType** | **string** | The exercise type of the optionality schedule (American or European).  For American type, the bond is perpetually callable from a given exercise date until it matures, or the next date in the schedule.  For European type, the bond is only callable on a given exercise date.    Supported string (enumeration) values are: [European, American]. | [optional] 
**OptionEntries** | [**List&lt;OptionEntry&gt;**](OptionEntry.md) | The dates at which the bond call/put may be actioned, and associated strikes. | [optional] 
**OptionType** | **string** | Type of optionality for the schedule.    Supported string (enumeration) values are: [Call, Put]. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

