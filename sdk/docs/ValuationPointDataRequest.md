# Lusid.Sdk.Model.ValuationPointDataRequest
The ValuationPointDataRequest.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiaryEntryCode** | **string** | Unique code for the Valuation Point. | 
**DiaryEntryVariant** | **string** | Unique Variant for the given Diary Entry Code. Together with the valuation point code marks the unique branch for the NavType. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string diaryEntryCode = "diaryEntryCode";
string diaryEntryVariant = "example diaryEntryVariant";

ValuationPointDataRequest valuationPointDataRequestInstance = new ValuationPointDataRequest(
    diaryEntryCode: diaryEntryCode,
    diaryEntryVariant: diaryEntryVariant);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
