# Lusid.Sdk.Model.RankMarginCallRequest
Ranks a margin call's collateral again against the holdings as they stand now, keeping the assets the user chose.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Overrides** | [**List&lt;CollateralAllocationOverride&gt;**](CollateralAllocationOverride.md) | The assets and units the user chose, each validated against the agreement&#39;s constraints and kept with its reason when it fails one. Optional. | [optional] 
**FillRemainder** | **bool?** | Whether to fill what the overrides leave uncovered from the ranking, cheapest first. Defaults to true. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<CollateralAllocationOverride> overrides = new List<CollateralAllocationOverride>();
bool? fillRemainder = //"True";

RankMarginCallRequest rankMarginCallRequestInstance = new RankMarginCallRequest(
    overrides: overrides,
    fillRemainder: fillRemainder);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
