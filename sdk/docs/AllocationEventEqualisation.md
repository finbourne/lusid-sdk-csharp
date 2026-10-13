# Lusid.Sdk.Model.AllocationEventEqualisation
The terms of a subsequent close an Equalisation Allocation Event applies: the booked prior calls to equalise, the  partners admitted, and how interest, excess and profit and loss are treated.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PriorCallIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The booked capital calls to equalise, and any earlier equalisation on the same map whose catch-up the admitted partners must also be brought level with. Each must be booked, on the same allocation map and in the same currency. | 
**NewInvestorRecordIds** | **List&lt;string&gt;** | The investor records admitted at this close. Each must be on the register with its commitment at the event date. | 
**InterestRate** | **decimal?** | The simple annual rate of equalisation interest the admitted partners pay on each catch-up from the prior call&#39;s due date to the event date. Defaults to 0.08. | [optional] 
**DayCountConvention** | **string** | The day count of the equalisation interest: ACT/365 or ACT/360. Defaults to ACT/365. | [optional] 
**InterestOnFees** | **bool?** | Whether equalisation interest is also charged on the management fee catch-ups, from each fee&#39;s due date. Defaults to false. | [optional] 
**Treatment** | **string** | How the existing partners&#39; excess is returned: ReturnOfExcess restores it to their uncalled commitment; RecallableDistribution distributes it as recallable capital. Defaults to ReturnOfExcess. Available values: ReturnOfExcess, RecallableDistribution. | [optional] 
**Pnl** | **string** | Whether profit and loss already allocated is re-trued between partners with no cash so each holds its post-close share (ReTrue), or the equalisation is kept to capital (CapitalOnly). Defaults to ReTrue. Available values: ReTrue, CapitalOnly. | [optional] 
**FeeCatchUps** | [**List&lt;AllocationEventEqualisationFeeCatchUp&gt;**](AllocationEventEqualisationFeeCatchUp.md) | The management fees each admitted partner owes from the first fee date to the close, including any stub period, as explicit amounts. Paid to the manager and allocated to that partner only. | [optional] 
**Marks** | [**List&lt;AllocationEventEqualisationMark&gt;**](AllocationEventEqualisationMark.md) | The valuation moves already allocated to the existing partners, by the member of the structure they belong to, to re-true to the admitted partners. Ignored when the profit and loss treatment is CapitalOnly. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ResourceId> priorCallIds = new List<ResourceId>();
List<string> newInvestorRecordIds = new List<string>();
string dayCountConvention = "example dayCountConvention";
bool? interestOnFees = //"True";
string treatment = "example treatment";
string pnl = "example pnl";
List<AllocationEventEqualisationFeeCatchUp> feeCatchUps = new List<AllocationEventEqualisationFeeCatchUp>();
List<AllocationEventEqualisationMark> marks = new List<AllocationEventEqualisationMark>();

AllocationEventEqualisation allocationEventEqualisationInstance = new AllocationEventEqualisation(
    priorCallIds: priorCallIds,
    newInvestorRecordIds: newInvestorRecordIds,
    interestRate: interestRate,
    dayCountConvention: dayCountConvention,
    interestOnFees: interestOnFees,
    treatment: treatment,
    pnl: pnl,
    feeCatchUps: feeCatchUps,
    marks: marks);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
