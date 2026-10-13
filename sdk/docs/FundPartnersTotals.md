# Lusid.Sdk.Model.FundPartnersTotals
Totals across every register line of the fund, independent of paging.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Committed** | **decimal** | The total committed capital across all partners. | 
**PartnerCount** | **int** | The number of partners (register lines) in the fund. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal committed = "committed";


FundPartnersTotals fundPartnersTotalsInstance = new FundPartnersTotals(
    committed: committed,
    partnerCount: partnerCount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
