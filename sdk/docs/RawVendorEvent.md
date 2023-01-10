# Lusid.Sdk.Model.RawVendorEvent
A generic event derived from the economic definition of an instrument. This should be considered purely  informational; any data provided by this event is not guaranteed to be processable by LUSID.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent | 
**EffectiveAt** | **DateTimeOffset** | The effective date of the event | 
**EventValue** | [**LifeCycleEventValue**](LifeCycleEventValue.md) |  | 
**EventType** | **string** | What type of internal event does this represent; reset, exercise, amortisation etc. | 
**EventStatus** | **string** | What is the event status, is it a known (ie historic) or unknown (ie projected) event? | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

