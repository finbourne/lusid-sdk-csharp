# Lusid.Sdk.Model.DiaryEntryRequest
The request to add a diary entry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiaryEntryCode** | **string** | The code of the diary entry. | 
**Name** | **string** | The name of the diary entry. | [optional] 
**Status** | **string** | The status of a Diary Entry of Type &#39;Other&#39;. Defaults to &#39;Undefined&#39; and supports &#39;Undefined&#39;, &#39;Estimate&#39;, &#39;Candidate&#39;, and &#39;Final&#39;. | [optional] 
**EffectiveAt** | **DateTimeOffset** | The effective time of the diary entry. | 
**QueryAsAt** | **DateTimeOffset?** | The query time of the diary entry. Defaults to latest. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the diary entry. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string diaryEntryCode = "diaryEntryCode";
string name = "example name";
string status = "example status";
Dictionary<string, Property> properties = new Dictionary<string, Property>();

DiaryEntryRequest diaryEntryRequestInstance = new DiaryEntryRequest(
    diaryEntryCode: diaryEntryCode,
    name: name,
    status: status,
    effectiveAt: effectiveAt,
    queryAsAt: queryAsAt,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
