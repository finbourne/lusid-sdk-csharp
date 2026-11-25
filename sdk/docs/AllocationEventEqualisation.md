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
**Treatment** | **string** | How the existing partners&#39; excess is returned: ReturnOfExcess restores it to their uncalled commitment; RecallableDistribution distributes it as recallable capital; CreditAgainstFutureCalls restores it to their uncalled commitment and keeps the cash in the fund as a credit their next calls draw down; RetainedByFund hands nothing back and instead calls the admitted partners up to the existing partners&#39; level on the commitments before the close. Defaults to ReturnOfExcess. Available values: ReturnOfExcess, RecallableDistribution, CreditAgainstFutureCalls, RetainedByFund. | [optional] 
**Pnl** | **string** | Whether profit and loss already allocated is re-trued between partners with no cash so each holds its post-close share (ReTrue), or the equalisation is kept to capital (CapitalOnly). Defaults to CapitalOnly when omitted on a request. An equalisation stored before this default was introduced keeps the treatment it was stored with, which is ReTrue. Available values: ReTrue, CapitalOnly. | [optional] 
**FeeCatchUps** | [**List&lt;AllocationEventEqualisationFeeCatchUp&gt;**](AllocationEventEqualisationFeeCatchUp.md) | The management fees each admitted partner owes from the first fee date to the close, including any stub period, as explicit amounts. Paid to the manager and allocated to that partner only. | [optional] 
**Marks** | [**List&lt;AllocationEventEqualisationMark&gt;**](AllocationEventEqualisationMark.md) | The valuation moves already allocated to the existing partners, by the member of the structure they belong to, to re-true to the admitted partners. Ignored when the profit and loss treatment is CapitalOnly. | [optional] 
**PriorDistributionIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The booked distributions on the same allocation map, dated before the close, whose return of capital is re-spread net of the prior calls. When omitted, every booked distribution on the map dated before the close counts. | [optional] 
**InterestTreatment** | **string** | How the equalisation interest reaches the existing partners: Cash pays it to them; CapitalCredit credits it to their capital accounts with no cash; None charges and pays no equalisation interest. Defaults to Cash. Available values: Cash, CapitalCredit, None. | [optional] 
**ExcludedComponents** | **List&lt;string&gt;** | The call components left out of the re-spread: ManagementFee, OtherFee, Expense, OrganisationCost or Recall. Defaults to ManagementFee. A component no prior call carries, other than ManagementFee, is refused. Available values: ManagementFee, OtherFee, Expense, OrganisationCost, Recall. | [optional] 

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
List<ResourceId> priorDistributionIds = new List<ResourceId>();
string interestTreatment = "example interestTreatment";
List<string> excludedComponents = new List<string>();

AllocationEventEqualisation allocationEventEqualisationInstance = new AllocationEventEqualisation(
    priorCallIds: priorCallIds,
    newInvestorRecordIds: newInvestorRecordIds,
    interestRate: interestRate,
    dayCountConvention: dayCountConvention,
    interestOnFees: interestOnFees,
    treatment: treatment,
    pnl: pnl,
    feeCatchUps: feeCatchUps,
    marks: marks,
    priorDistributionIds: priorDistributionIds,
    interestTreatment: interestTreatment,
    excludedComponents: excludedComponents);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
