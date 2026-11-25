# Lusid.Sdk.Model.FundGroupReportValuationPoint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiaryEntryCode** | **string** | The code of the valuation point the row was produced for. | [optional] 
**Status** | **string** | The status of the valuation point the row was produced for, such as Final or Estimate. | [optional] 
**EffectiveEnd** | **DateTimeOffset** | The effective end date of the valuation point the row was produced for. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string diaryEntryCode = "example diaryEntryCode";
string status = "example status";

FundGroupReportValuationPoint fundGroupReportValuationPointInstance = new FundGroupReportValuationPoint(
    diaryEntryCode: diaryEntryCode,
    status: status,
    effectiveEnd: effectiveEnd);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
