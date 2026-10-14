# Lusid.Sdk.Model.AllocationEventNoticePartner
The partner a notice is addressed to.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record identifier of the partner. | 
**DisplayName** | **string** | The display name of the partner. | [optional] 
**Commitment** | **decimal** | The partner&#39;s total commitment. | 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "investorRecordId";
string displayName = "example displayName";decimal commitment = "commitment";


AllocationEventNoticePartner allocationEventNoticePartnerInstance = new AllocationEventNoticePartner(
    investorRecordId: investorRecordId,
    displayName: displayName,
    commitment: commitment);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
