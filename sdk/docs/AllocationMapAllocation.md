# Lusid.Sdk.Model.AllocationMapAllocation
One investor record's share of a resolved allocation event.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record that receives the share. | [optional] 
**BasisValue** | **decimal?** | The basis value the pro rata share was weighted by. Absent for a fixed or excluded investor record. | [optional] 
**Weight** | **decimal** | The fraction of the remainder the investor record receives, or the fixed fraction of the whole amount for a FixedPercentage exception. | [optional] 
**Amount** | **decimal** | The amount allocated to the investor record. | [optional] 
**Treatment** | **string** | How the share was found. Derived means pro rata from the basis; FixedPercentage means off the top from an exception; Excluded means an exception removed the investor record and it receives nothing. Available values: Derived, FixedPercentage, Excluded. | [optional] 
**CommitmentLineId** | **string** | For a Commitment event, the commitment line the share is recorded against. Absent for other event types. | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Component** | **string** | The component of the event the share belongs to. Absent when the event was resolved whole. | [optional] 
**OriginMemberShortCode** | **string** | The deal the share is for, when a capital call&#39;s use of proceeds split one component across deals. Absent when the component&#39;s own origin applies. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "example investorRecordId";decimal? weight = "example weight";decimal? amount = "example amount";
string treatment = "example treatment";
string commitmentLineId = "example commitmentLineId";
ResourceId? portfolioId = new ResourceId();

string component = "example component";
string originMemberShortCode = "example originMemberShortCode";

AllocationMapAllocation allocationMapAllocationInstance = new AllocationMapAllocation(
    investorRecordId: investorRecordId,
    basisValue: basisValue,
    weight: weight,
    amount: amount,
    treatment: treatment,
    commitmentLineId: commitmentLineId,
    portfolioId: portfolioId,
    component: component,
    originMemberShortCode: originMemberShortCode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
