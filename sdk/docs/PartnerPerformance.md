# Lusid.Sdk.Model.PartnerPerformance
The ILPA performance measures for one partner, or for the fund as a whole: paid-in to commitment, the  distribution, residual value and total value multiples, and the net IRR, together with the cash flows the IRR  was solved from. When the fund financed deals through a subscription facility, the measures are also given  with the facility-funded calls re-dated to when the deals were actually funded.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundId** | [**ResourceId**](ResourceId.md) |  | 
**InvestorRecordId** | **string** | The investor record identifier of the partner, or null when the figures are for the fund as a whole. | [optional] 
**Currency** | **string** | The currency the cash flows and residual value are expressed in. | 
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
**WithFacility** | [**PartnerPerformanceMeasures**](PartnerPerformanceMeasures.md) |  | [optional] 
**WithoutFacility** | [**PartnerPerformanceMeasures**](PartnerPerformanceMeasures.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId fundId = new ResourceId();
string investorRecordId = "example investorRecordId";
string currency = "currency";decimal commitment = "commitment";
decimal paidIn = "paidIn";
decimal distributed = "distributed";

List<PartnerPerformanceCashFlow> cashFlows = new List<PartnerPerformanceCashFlow>();decimal residualValue = "residualValue";

PartnerPerformanceMeasures? withFacility = new PartnerPerformanceMeasures();

PartnerPerformanceMeasures? withoutFacility = new PartnerPerformanceMeasures();


PartnerPerformance partnerPerformanceInstance = new PartnerPerformance(
    fundId: fundId,
    investorRecordId: investorRecordId,
    currency: currency,
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
    residualValueDate: residualValueDate,
    withFacility: withFacility,
    withoutFacility: withoutFacility);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
