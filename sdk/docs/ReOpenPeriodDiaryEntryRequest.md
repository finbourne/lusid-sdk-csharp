# Lusid.Sdk.Model.ReOpenPeriodDiaryEntryRequest
A definition for the period you wish to re open

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiaryEntryCode** | **string** | Unique code assigned to a period. When left blank last period will be used. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string diaryEntryCode = "example diaryEntryCode";

ReOpenPeriodDiaryEntryRequest reOpenPeriodDiaryEntryRequestInstance = new ReOpenPeriodDiaryEntryRequest(
    diaryEntryCode: diaryEntryCode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
