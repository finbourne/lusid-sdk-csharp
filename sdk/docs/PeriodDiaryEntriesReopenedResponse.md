# Lusid.Sdk.Model.PeriodDiaryEntriesReopenedResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**EffectiveFrom** | **DateTimeOffset?** | The effective datetime at which the deletion became valid. May be null in the case where multiple date times are applicable. | [optional] 
**AsAt** | **DateTimeOffset** | The asAt datetime at which the deletion was committed to LUSID. | 
**PeriodDiaryEntriesRemoved** | **int** | Number of Diary Entries removed as a result of reopening periods | 
**PeriodDiaryEntriesFrom** | **DateTimeOffset** | The start point where periods were removed from | 
**PeriodDiaryEntriesTo** | **DateTimeOffset** | The end point where periods were removed to | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
List<Link> links = new List<Link>();

PeriodDiaryEntriesReopenedResponse periodDiaryEntriesReopenedResponseInstance = new PeriodDiaryEntriesReopenedResponse(
    href: href,
    effectiveFrom: effectiveFrom,
    asAt: asAt,
    periodDiaryEntriesRemoved: periodDiaryEntriesRemoved,
    periodDiaryEntriesFrom: periodDiaryEntriesFrom,
    periodDiaryEntriesTo: periodDiaryEntriesTo,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
