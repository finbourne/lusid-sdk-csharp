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
**Completeness** | **string** | Is the event Economically Complete, or is it missing some DataDependent fields (Incomplete). Available values: Complete, Incomplete. | [optional] [readonly] 
**InstrumentEvent** | [**InstrumentEvent**](InstrumentEvent.md) |  | 
**Properties** | [**List&lt;PerpetualProperty&gt;**](PerpetualProperty.md) | The properties attached to this instrument event. | [optional] 
**SequenceNumber** | **int** | The order of the instrument event relative others on the same date (0 being processed first). Must be non negative. | [optional] 
**ParticipationType** | **string** | Indicates the type of participation in this event. Default value: Mandatory. Available values: Mandatory, MandatoryWithChoices, Voluntary. | [optional] [default to "Mandatory"]
**AsAt** | **DateTimeOffset?** | The AsAt time of the instrument event, if available. This is a readonly field and should not be provided on upsert. | [optional] [readonly] 
**GroupCode** | **string** | The group code that determines the processing order of instrument events with the same effective datetime. Available values: Tier1, Tier2, Tier3, Legacy. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentEventId = "instrumentEventId";
ResourceId? corporateActionSourceId = new ResourceId();

Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();
string lusidInstrumentId = "lusidInstrumentId";
string instrumentScope = "instrumentScope";
string description = "description";
EventDateRange eventDateRange = new EventDateRange();
string completeness = "example completeness";
InstrumentEvent instrumentEvent = new InstrumentEvent();
List<PerpetualProperty> properties = new List<PerpetualProperty>();
string participationType = "example participationType";
string groupCode = "example groupCode";

InstrumentEventHolder instrumentEventHolderInstance = new InstrumentEventHolder(
    instrumentEventId: instrumentEventId,
    corporateActionSourceId: corporateActionSourceId,
    instrumentIdentifiers: instrumentIdentifiers,
    lusidInstrumentId: lusidInstrumentId,
    instrumentScope: instrumentScope,
    description: description,
    eventDateRange: eventDateRange,
    completeness: completeness,
    instrumentEvent: instrumentEvent,
    properties: properties,
    sequenceNumber: sequenceNumber,
    participationType: participationType,
    asAt: asAt,
    groupCode: groupCode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
