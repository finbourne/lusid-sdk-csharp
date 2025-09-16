# Lusid.Sdk.Model.UpsertInstrumentEventRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventId** | **string** | Free string that uniquely identifies the event within the corporate action source | 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The set of identifiers which determine the instrument this event relates to. | 
**Description** | **string** | The description of the instrument event. | [optional] 
**InstrumentEvent** | [**InstrumentEvent**](InstrumentEvent.md) |  | 
**Properties** | [**List&lt;PerpetualProperty&gt;**](PerpetualProperty.md) | The properties attached to this instrument event. | [optional] 
**SequenceNumber** | **int** | The order of the instrument event relative others on the same date (0 being processed first). Must be non negative. | [optional] 
**ParticipationType** | **string** | Is participation in this event Mandatory, MandatoryWithChoices, or Voluntary. | [optional] [default to "Mandatory"]
**EventDateStamps** | [**Dictionary&lt;string, YearMonthDay&gt;**](YearMonthDay.md) | The date stamps corresponding to the relevant date-time fields for the instrument event. The key for each provided date stamp must match the field name of a valid datetime field from the InstrumentEvent DTO. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentEventId = "instrumentEventId";
Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();
string description = "example description";
InstrumentEvent instrumentEvent = new InstrumentEvent();
List<PerpetualProperty> properties = new List<PerpetualProperty>();
string participationType = "example participationType";
Dictionary<string, YearMonthDay> eventDateStamps = new Dictionary<string, YearMonthDay>();

UpsertInstrumentEventRequest upsertInstrumentEventRequestInstance = new UpsertInstrumentEventRequest(
    instrumentEventId: instrumentEventId,
    instrumentIdentifiers: instrumentIdentifiers,
    description: description,
    instrumentEvent: instrumentEvent,
    properties: properties,
    sequenceNumber: sequenceNumber,
    participationType: participationType,
    eventDateStamps: eventDateStamps);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
