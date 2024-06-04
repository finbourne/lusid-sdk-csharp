# Lusid.Sdk.Model.BondConversionSchedule
A BondConversionSchedule object represents a class containing the  information required for the creation of convertible features in a ComplexBond

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScheduleType** | **string** | The available values are: FixedSchedule, FloatSchedule, OptionalitySchedule, StepSchedule, Exercise, FxRateSchedule, FxLinkedNotionalSchedule, BondConversionSchedule, Invalid | 
**Identifiers** | **Dictionary&lt;string, string&gt;** | The market identifier(s) of the share that the bond converts to. The instrument  will not fail validation if no identifier is supplied. | [optional] 
**BondConversionEntries** | [**List&lt;BondConversionEntry&gt;**](BondConversionEntry.md) | The dates at which the bond may be converted and associated information required about the conversion. | [optional] 
**ConversionTrigger** | **string** | Corporate event that triggers a conversion    Supported string (enumeration) values are: [NextEquityFinancing, IpoConversion, KnownDates, SoftCall]. | 
**DeliveryType** | **string** | Is a conversion made into cash or into shares?    Supported string (enumeration) values are: [Cash, Physical]. | [optional] 
**ExerciseType** | **string** | The exercise type of the conversion schedule (American or European).  For American type, the bond is convertible from a given exercise date until the next date in the schedule, or until it matures.  For European type, the bond is only convertible on the given exercise date.    Supported string (enumeration) values are: [European, Bermudan, American]. | 
**IncludesAccrued** | **bool** | Set this to true if a accrued interest is included in the conversion. Defaults to true. | [optional] 
**MandatoryConversion** | **bool** | Set this to true if a conversion is mandatory if the trigger occurs. Defaults to false. | [optional] 
**NotificationPeriodEnd** | **DateTimeOffset** | The last day in the notification period for the conversion of the bond | [optional] 
**NotificationPeriodStart** | **DateTimeOffset** | The first day in the notification period for the conversion of the bond | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

