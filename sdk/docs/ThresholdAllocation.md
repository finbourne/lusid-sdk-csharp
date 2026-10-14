# Lusid.Sdk.Model.ThresholdAllocation
How a threshold is split between the two parties.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**We** | **decimal** | Our share of the threshold. | 
**They** | **decimal** | The counterparty&#39;s share of the threshold. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal we = "we";
decimal they = "they";


ThresholdAllocation thresholdAllocationInstance = new ThresholdAllocation(
    we: we,
    they: they);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
