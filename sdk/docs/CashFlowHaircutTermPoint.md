# Lusid.Sdk.Model.CashFlowHaircutTermPoint
A point on a cashflow haircut term structure: the haircut rate applying at a given tenor from  the valuation date. Rates are linearly interpolated on time-to-payment between points and  extrapolated flat beyond either end of the term structure.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tenor** | **string** | The tenor from the valuation date at which the rate applies, e.g. &#39;6M&#39; or &#39;5Y&#39;. | 
**Rate** | **decimal** | The haircut rate applying at the tenor, as a fraction in the range [0, 1]. | 

```csharp
using Lusid.Sdk.Model;
using System;

string tenor = "tenor";decimal rate = "rate";


CashFlowHaircutTermPoint cashFlowHaircutTermPointInstance = new CashFlowHaircutTermPoint(
    tenor: tenor,
    rate: rate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
