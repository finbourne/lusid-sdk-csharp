# Lusid.Sdk.Model.FundGroupTrialBalance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**NavTypeCode** | **string** | The code of the NAV type the row, or result, was produced for. | [optional] 
**DiaryEntryCode** | **string** | The code of the valuation point the row was produced for. | [optional] 
**ValuationPointStatus** | **string** | The status of the valuation point the row was produced for, such as Final or Estimate. | [optional] 
**EffectiveEnd** | **DateTimeOffset** | The effective end date of the valuation point the row was produced for. | [optional] 
**TrialBalance** | [**TrialBalance**](TrialBalance.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? fundId = new ResourceId();

string navTypeCode = "example navTypeCode";
string diaryEntryCode = "example diaryEntryCode";
string valuationPointStatus = "example valuationPointStatus";
TrialBalance? trialBalance = new TrialBalance();


FundGroupTrialBalance fundGroupTrialBalanceInstance = new FundGroupTrialBalance(
    fundId: fundId,
    navTypeCode: navTypeCode,
    diaryEntryCode: diaryEntryCode,
    valuationPointStatus: valuationPointStatus,
    effectiveEnd: effectiveEnd,
    trialBalance: trialBalance);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
