# Lusid.Sdk.Model.PartnerPerformanceMeasures
One set of performance measures: the multiples, the net IRR and the cash flows it was solved from.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Commitment** | **decimal** | The total commitment the paid-in-capital ratio is measured against. | 
**PaidIn** | **decimal** | The contributions paid in to the fund. | 
**Distributed** | **decimal** | The distributions paid out of the fund. | 
**Pic** | **decimal?** | Paid-in capital as a multiple of commitment, or null when there is no commitment. | [optional] 
**Dpi** | **decimal?** | Distributions as a multiple of paid-in capital, or null when nothing has been paid in. | [optional] 
**Rvpi** | **decimal?** | Residual value as a multiple of paid-in capital, or null when nothing has been paid in. | [optional] 
**Tvpi** | **decimal?** | Total value as a multiple of paid-in capital, being DPI plus RVPI. | [optional] 
**NetIrr** | **decimal?** | The annualised net internal rate of return solved from the dated cash flows, or null when no rate can be solved. | [optional] 
**CashFlows** | [**List&lt;PartnerPerformanceCashFlow&gt;**](PartnerPerformanceCashFlow.md) | The dated cash flows the net IRR was solved from, including the terminal residual value. | 
**ResidualValue** | **decimal** | The partner&#39;s residual value in the fund at the valuation date. | 
**ResidualValueDate** | **DateTimeOffset** | The date the residual value is taken as at. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal commitment = "commitment";
decimal paidIn = "paidIn";
decimal distributed = "distributed";

List<PartnerPerformanceCashFlow> cashFlows = new List<PartnerPerformanceCashFlow>();decimal residualValue = "residualValue";


PartnerPerformanceMeasures partnerPerformanceMeasuresInstance = new PartnerPerformanceMeasures(
    commitment: commitment,
    paidIn: paidIn,
    distributed: distributed,
    pic: pic,
    dpi: dpi,
    rvpi: rvpi,
    tvpi: tvpi,
    netIrr: netIrr,
    cashFlows: cashFlows,
    residualValue: residualValue,
    residualValueDate: residualValueDate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
