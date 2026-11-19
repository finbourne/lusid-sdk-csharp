# Lusid.Sdk.Model.AllocationEventNoticePartner
The partner a notice is addressed to.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record identifier of the partner. | 
**DisplayName** | **string** | The display name of the partner. | [optional] 
**Commitment** | **decimal** | The partner&#39;s committed capital on the fund the event allocates over at the event date, summed over the lines the event allocates to there; for a partner looked through to, its line on the feeder. Never the partner&#39;s total across funds. | 
**Lines** | [**List&lt;AllocationEventNoticePartnerLine&gt;**](AllocationEventNoticePartnerLine.md) | The register lines the partner was allocated on, one per line, each with the fund whose register holds it, its commitment at the event date and the partner&#39;s share landing on it. The shares sum to the net amount due before tax withheld. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "investorRecordId";
string displayName = "example displayName";decimal commitment = "commitment";

List<AllocationEventNoticePartnerLine> lines = new List<AllocationEventNoticePartnerLine>();

AllocationEventNoticePartner allocationEventNoticePartnerInstance = new AllocationEventNoticePartner(
    investorRecordId: investorRecordId,
    displayName: displayName,
    commitment: commitment,
    lines: lines);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
