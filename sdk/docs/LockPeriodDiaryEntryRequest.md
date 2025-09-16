# Lusid.Sdk.Model.LockPeriodDiaryEntryRequest
A definition for the period you wish to lock

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiaryEntryCode** | **string** | Unique code assigned to a period. When left blank last closed period will be located. | [optional] 
**ClosingOptions** | **List&lt;string&gt;** | The options which will be executed once a period is closed or locked. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string diaryEntryCode = "example diaryEntryCode";
List<string> closingOptions = new List<string>();

LockPeriodDiaryEntryRequest lockPeriodDiaryEntryRequestInstance = new LockPeriodDiaryEntryRequest(
    diaryEntryCode: diaryEntryCode,
    closingOptions: closingOptions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
