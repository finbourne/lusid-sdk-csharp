# Lusid.Sdk.Model.AllocationEventNoticeCumulative
Cumulative balances to date for a partner on a notice.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Contributions** | **decimal** | Cumulative contributions after the event. | 
**Distributions** | **decimal** | Cumulative distributions after the event. | 
**Recallable** | **decimal** | Cumulative recallable distributions after the event. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal contributions = "contributions";
decimal distributions = "distributions";
decimal recallable = "recallable";


AllocationEventNoticeCumulative allocationEventNoticeCumulativeInstance = new AllocationEventNoticeCumulative(
    contributions: contributions,
    distributions: distributions,
    recallable: recallable);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
