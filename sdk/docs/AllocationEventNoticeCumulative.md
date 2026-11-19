# Lusid.Sdk.Model.AllocationEventNoticeCumulative
Cumulative balances to date for a partner on a notice.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Contributions** | **decimal** | Cumulative contributions after the event. | 
**Distributions** | **decimal** | Cumulative distributions after the event, tax withheld on the partner&#39;s behalf included, as the capital account&#39;s distributions row counts them. | 
**Recallable** | **decimal** | Cumulative recallable distributions after the event. | 
**TaxWithheld** | **decimal** | Tax withheld from the partner&#39;s distributions to date and paid to the tax authority on its behalf: counted in the cumulative distributions, so the cash the partner actually received is distributions less this. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal contributions = "contributions";
decimal distributions = "distributions";
decimal recallable = "recallable";
decimal taxWithheld = "taxWithheld";


AllocationEventNoticeCumulative allocationEventNoticeCumulativeInstance = new AllocationEventNoticeCumulative(
    contributions: contributions,
    distributions: distributions,
    recallable: recallable,
    taxWithheld: taxWithheld);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
