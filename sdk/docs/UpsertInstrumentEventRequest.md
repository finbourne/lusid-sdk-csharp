# Lusid.Sdk.Model.UpsertInstrumentEventRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventId** | **string** | Free string that uniquely identifies the event within the corporate action source | 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The set of identifiers which determine the instrument this event relates to. | 
**Description** | **string** | The description of the instrument event. | [optional] 
**InstrumentEvent** | [**InstrumentEvent**](InstrumentEvent.md) |  | 
**Properties** | [**List&lt;PerpetualProperty&gt;**](PerpetualProperty.md) | The properties attached to this instrument event. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

