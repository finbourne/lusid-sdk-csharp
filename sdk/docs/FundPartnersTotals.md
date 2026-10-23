# Lusid.Sdk.Model.FundPartnersTotals
Totals across every register line of the fund, independent of paging. Commitments are totalled per commitment  currency; amounts in different currencies are never added together.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CommittedByCurrency** | **Dictionary&lt;string, decimal&gt;** | The total committed capital across all partners, per commitment currency, keyed by currency code. Commitments in different currencies are not added together. | 
**PartnerCount** | **int** | The number of partners (register lines) in the fund. | 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, decimal> committedByCurrency = new Dictionary<string, decimal>();

FundPartnersTotals fundPartnersTotalsInstance = new FundPartnersTotals(
    committedByCurrency: committedByCurrency,
    partnerCount: partnerCount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
