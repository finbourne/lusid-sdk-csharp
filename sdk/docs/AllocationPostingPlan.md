# Lusid.Sdk.Model.AllocationPostingPlan
Everything booking an Allocation Event writes, in write order: the investors' lines, the roll-ups above them and  the fund side. Returned by a dry run, so a caller sees exactly what a booking would post before it does.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LpSide** | [**List&lt;AllocationPostingLpLine&gt;**](AllocationPostingLpLine.md) | The instrument events written on each investor&#39;s commitment line, one per component. | [optional] 
**RollUps** | [**List&lt;AllocationPostingRollUp&gt;**](AllocationPostingRollUp.md) | The roll-ups written on each vehicle&#39;s line on the register above it, summing the lines beneath. | [optional] 
**FundSide** | [**List&lt;AllocationPostingFundLine&gt;**](AllocationPostingFundLine.md) | The transactions written on the fund&#39;s own books. | [optional] 
**Counts** | [**AllocationPostingCounts**](AllocationPostingCounts.md) |  | [optional] 
**Warnings** | [**List&lt;AllocationEventBookingWarning&gt;**](AllocationEventBookingWarning.md) | The validation rules the booking would be allowed to proceed through under the map&#39;s policy. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<AllocationPostingLpLine> lpSide = new List<AllocationPostingLpLine>();
List<AllocationPostingRollUp> rollUps = new List<AllocationPostingRollUp>();
List<AllocationPostingFundLine> fundSide = new List<AllocationPostingFundLine>();
AllocationPostingCounts? counts = new AllocationPostingCounts();

List<AllocationEventBookingWarning> warnings = new List<AllocationEventBookingWarning>();

AllocationPostingPlan allocationPostingPlanInstance = new AllocationPostingPlan(
    lpSide: lpSide,
    rollUps: rollUps,
    fundSide: fundSide,
    counts: counts,
    warnings: warnings);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
