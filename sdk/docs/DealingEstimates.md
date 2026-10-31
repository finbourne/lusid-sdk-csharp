# Lusid.Sdk.Model.DealingEstimates
How a fund treats estimated dealing when it strikes a valuation point before dealing is final.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sources** | **List&lt;string&gt;** | Where the Fund&#39;s dealing estimates are read from: LusidTA, orders held in LUSID Transfer Agency, or External, orders dealt outside LUSID and reported to it. At least one, each at most once. Naming both sums the two books with no de-duplication between them; each source&#39;s completeness is tracked on its own. Available values: LusidTA, External. | 
**RequireComplete** | **bool?** | Reserved; not yet enforced. Whether every source must have reported before the valuation point can be struck. Defaults to true. | [optional] 
**CountPending** | **bool?** | Whether pending orders count towards the estimated flow alongside confirmed ones. Defaults to false. | [optional] 
**UnitValuation** | **string** | The price estimated flows are turned into units at: EstimatePrice, the estimate struck at this valuation point, or LastOfficialPrice, the last official dealing price the Fund published. Available values: EstimatePrice, LastOfficialPrice. | 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> sources = new List<string>();
bool? requireComplete = //"True";
bool? countPending = //"True";
string unitValuation = "unitValuation";

DealingEstimates dealingEstimatesInstance = new DealingEstimates(
    sources: sources,
    requireComplete: requireComplete,
    countPending: countPending,
    unitValuation: unitValuation);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
