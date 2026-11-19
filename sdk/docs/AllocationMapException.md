# Lusid.Sdk.Model.AllocationMapException
A departure from the default participation of an Allocation Map for one investor record or one of its register lines.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record the exception applies to. | 
**Treatment** | **string** | What the exception does. Excluded removes the investor record from every allocation; FixedPercentage gives it participationPercent of each event off the top, before the remainder is shared pro rata between the other participants. Available values: Excluded, FixedPercentage. | 
**ParticipationPercent** | **decimal?** | For a FixedPercentage exception, the fixed share as a fraction in the range (0, 1]. Not allowed on an Excluded exception. The fixed shares of all exceptions may not sum to more than 1. | [optional] 
**Reason** | **string** | Why the exception exists, for example a side letter or regulatory restriction. Required. | 
**EffectiveFrom** | **DateTimeOffset?** | The datetime from which the exception is in force. Defaults to always if not specified. | [optional] 
**CommitmentLineId** | **string** | The register line of the investor record the exception applies to, when it applies to one line rather than the record as a whole. The record&#39;s other lines take part as usual: an Excluded line&#39;s basis leaves the event&#39;s basis total, and a FixedPercentage line takes its fixed share off the top. Optional. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "investorRecordId";
string treatment = "treatment";
string reason = "reason";
string commitmentLineId = "example commitmentLineId";

AllocationMapException allocationMapExceptionInstance = new AllocationMapException(
    investorRecordId: investorRecordId,
    treatment: treatment,
    participationPercent: participationPercent,
    reason: reason,
    effectiveFrom: effectiveFrom,
    commitmentLineId: commitmentLineId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
