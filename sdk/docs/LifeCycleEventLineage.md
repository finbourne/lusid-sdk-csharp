# Lusid.Sdk.Model.LifeCycleEventLineage
The lineage of the event value

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventType** | **string** | The type of the event | [optional] 
**InstrumentType** | **string** | The instrument type of the instrument for the event. | [optional] 
**InstrumentId** | **string** | The LUID of the instrument for the event. | [optional] 
**LegId** | **string** | Leg id for the event. | [optional] 
**SourceTransactionId** | **string** | The source transaction of the instrument for the event. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string eventType = "example eventType";
string instrumentType = "example instrumentType";
string instrumentId = "example instrumentId";
string legId = "example legId";
string sourceTransactionId = "example sourceTransactionId";

LifeCycleEventLineage lifeCycleEventLineageInstance = new LifeCycleEventLineage(
    eventType: eventType,
    instrumentType: instrumentType,
    instrumentId: instrumentId,
    legId: legId,
    sourceTransactionId: sourceTransactionId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
