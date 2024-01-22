# Lusid.Sdk.Model.InstrumentEventHolder
An instrument event equipped with additional metadata.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventId** | **string** | The unique identifier of this corporate action. | 
**CorporateActionSourceId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The set of identifiers which determine the instrument this event relates to. | 
**LusidInstrumentId** | **string** | The LUID for the instrument. | 
**InstrumentScope** | **string** | The scope of the instrument. | 
**Description** | **string** | The description of the instrument event. | 
**EventDateRange** | [**EventDateRange**](EventDateRange.md) |  | 
**InstrumentEvent** | [**InstrumentEvent**](InstrumentEvent.md) |  | 
**Properties** | [**List&lt;PerpetualProperty&gt;**](PerpetualProperty.md) | The properties attached to this instrument event. | [optional] 
**SequenceNumber** | **int** | The order of the instrument event relative others on the same date (0 being processed first). Must be non negative. | [optional] 
**ParticipationType** | **string** | Is participation in this event Mandatory, MandatoryWithChoices, or Voluntary. | [optional] [default to "Mandatory"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

