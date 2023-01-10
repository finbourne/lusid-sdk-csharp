# Lusid.Sdk.Model.ExerciseEventAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Instrument** | [**LusidInstrument**](LusidInstrument.md) |  | 
**EventStatus** | **string** | What is the event status, is it a known (ie historic) or unknown (ie projected) event? | 
**AnchorDate** | **DateTimeOffset** | The date the exercise window starts, or point it takes effect on. | 
**EventWindowEnd** | **DateTimeOffset** | The date the exercise window ends, or point it takes effect on. | [optional] [readonly] 
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

