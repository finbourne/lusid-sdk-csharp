# Lusid.Sdk.Model.AllocationEventBasisWarning
One thing the basis source had to work around when it read the register for an Allocation Event.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The warning, for example MissingFeeRate or RoundingPartnerNotParticipant. | [optional] 
**InvestorRecordId** | **string** | The investor record the warning concerns, or absent when it concerns the event as a whole. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "example code";
string investorRecordId = "example investorRecordId";

AllocationEventBasisWarning allocationEventBasisWarningInstance = new AllocationEventBasisWarning(
    code: code,
    investorRecordId: investorRecordId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
