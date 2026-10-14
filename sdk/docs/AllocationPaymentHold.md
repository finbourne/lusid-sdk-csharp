# Lusid.Sdk.Model.AllocationPaymentHold
A hold placed on a partner's payment against an allocation event, blocking receipt until it is released  by a second user.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllocationEventId** | [**ResourceId**](ResourceId.md) |  | 
**InvestorRecordId** | **string** | The investor record identifier of the partner whose payment is held. | 
**Status** | **string** | The hold status: Blocked, Escrow or Released. | 
**Reason** | **string** | The reason for the hold. | [optional] 
**Reference** | **string** | An external reference for the hold, such as a compliance case number. | [optional] 
**PlacedBy** | **string** | The user who placed the hold. | 
**PlacedAt** | **DateTimeOffset** | When the hold was placed. | 
**ReleasedBy** | **string** | The user who released the hold, or null while it is active. | [optional] 
**ReleasedAt** | **DateTimeOffset?** | When the hold was released, or null while it is active. | [optional] 
**Active** | **bool** | Whether the hold is currently blocking receipt of the partner&#39;s payment. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId allocationEventId = new ResourceId();
string investorRecordId = "investorRecordId";
string status = "status";
string reason = "example reason";
string reference = "example reference";
string placedBy = "placedBy";
string releasedBy = "example releasedBy";
bool active = //"True";

AllocationPaymentHold allocationPaymentHoldInstance = new AllocationPaymentHold(
    allocationEventId: allocationEventId,
    investorRecordId: investorRecordId,
    status: status,
    reason: reason,
    reference: reference,
    placedBy: placedBy,
    placedAt: placedAt,
    releasedBy: releasedBy,
    releasedAt: releasedAt,
    active: active);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
