# Lusid.Sdk.Model.ManagementFeeTotals
The management fee totals over every partner.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gross** | **decimal** | The fee before offsets. | 
**Offset** | **decimal** | The offset applied to the fee. | 
**Net** | **decimal** | The fee after offsets. | 
**CarriedForward** | **decimal** | Offset in excess of the fee, carried forward to the next period. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal gross = "gross";
decimal offset = "offset";
decimal net = "net";
decimal carriedForward = "carriedForward";


ManagementFeeTotals managementFeeTotalsInstance = new ManagementFeeTotals(
    gross: gross,
    offset: offset,
    net: net,
    carriedForward: carriedForward);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
