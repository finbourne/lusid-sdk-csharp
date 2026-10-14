# Lusid.Sdk.Model.AllocationPaymentHoldRequest
The request used to place, move or release a hold on a partner's payment against an allocation event.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The hold status to set: Blocked, Escrow or Released. A hold may only be released by a different user from the one who placed it. | 
**Reason** | **string** | The reason for the hold. | [optional] 
**Reference** | **string** | An external reference for the hold, such as a compliance case number. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string status = "status";
string reason = "example reason";
string reference = "example reference";

AllocationPaymentHoldRequest allocationPaymentHoldRequestInstance = new AllocationPaymentHoldRequest(
    status: status,
    reason: reason,
    reference: reference);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
