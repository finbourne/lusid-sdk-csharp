# Lusid.Sdk.Model.UpsertReferencePortfolioConstituentsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveFrom** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The first date from which the weights will apply | 
**WeightType** | **string** | The available values are: Static, Floating, Periodical | 
**PeriodType** | **string** | The available values are: Daily, Weekly, Monthly, Quarterly, Annually | [optional] 
**PeriodCount** | **int?** |  | [optional] 
**Constituents** | [**List&lt;ReferencePortfolioConstituentRequest&gt;**](ReferencePortfolioConstituentRequest.md) | Set of constituents (instrument/weight pairings) | 

```csharp
using Lusid.Sdk.Model;
using System;

DateTimeOrCutLabel effectiveFrom = "effectiveFrom";
string weightType = "weightType";
string periodType = "example periodType";
List<ReferencePortfolioConstituentRequest> constituents = new List<ReferencePortfolioConstituentRequest>();

UpsertReferencePortfolioConstituentsRequest upsertReferencePortfolioConstituentsRequestInstance = new UpsertReferencePortfolioConstituentsRequest(
    effectiveFrom: effectiveFrom,
    weightType: weightType,
    periodType: periodType,
    periodCount: periodCount,
    constituents: constituents);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
