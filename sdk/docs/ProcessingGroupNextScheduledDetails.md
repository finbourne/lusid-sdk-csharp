# Lusid.Sdk.Model.ProcessingGroupNextScheduledDetails
The next scheduled occurrence of a Processing Group: the next execution date after the requested date,  together with the executed (resolved) contents of the reference list the Processing Group operates over.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NextScheduleDate** | **DateTimeOffset** | The next execution date strictly after the requested date. | [optional] 
**ResolvedReferenceList** | [**ReferenceList**](ReferenceList.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ReferenceList? resolvedReferenceList = new ReferenceList();


ProcessingGroupNextScheduledDetails processingGroupNextScheduledDetailsInstance = new ProcessingGroupNextScheduledDetails(
    nextScheduleDate: nextScheduleDate,
    resolvedReferenceList: resolvedReferenceList);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
