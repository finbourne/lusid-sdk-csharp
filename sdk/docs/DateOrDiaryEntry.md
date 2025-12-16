# Lusid.Sdk.Model.DateOrDiaryEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | A date. If specified, DiaryEntry must not be specified. | [optional] 
**DiaryEntry** | **string** | The code of a diary entry. If specified, Date must not be specified. | [optional] 
**DiaryEntryVariant** | **string** | Unique Variant for the given Diary Entry Code. If not provided, defaults to empty string. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DateTimeOrCutLabel date = "example date";
string diaryEntry = "example diaryEntry";
string diaryEntryVariant = "example diaryEntryVariant";

DateOrDiaryEntry dateOrDiaryEntryInstance = new DateOrDiaryEntry(
    date: date,
    diaryEntry: diaryEntry,
    diaryEntryVariant: diaryEntryVariant);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
