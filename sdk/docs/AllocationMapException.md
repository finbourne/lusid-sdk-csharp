# Lusid.Sdk.Model.AllocationMapException
A departure from the default participation of an Allocation Map for one investor record.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record the exception applies to. | 
**Treatment** | **string** | What the exception does. Excluded removes the investor record from every allocation; FixedPercentage gives it participationPercent of each event off the top, before the remainder is shared pro rata between the other participants. Available values: Excluded, FixedPercentage. | 
**ParticipationPercent** | **decimal?** | For a FixedPercentage exception, the fixed share as a fraction in the range (0, 1]. Not allowed on an Excluded exception. The fixed shares of all exceptions may not sum to more than 1. | [optional] 
**Reason** | **string** | Why the exception exists, for example a side letter or regulatory restriction. Required. | 
**EffectiveFrom** | **DateTimeOffset?** | The datetime from which the exception is in force. Defaults to always if not specified. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "investorRecordId";
string treatment = "treatment";
string reason = "reason";

AllocationMapException allocationMapExceptionInstance = new AllocationMapException(
    investorRecordId: investorRecordId,
    treatment: treatment,
    participationPercent: participationPercent,
    reason: reason,
    effectiveFrom: effectiveFrom);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
