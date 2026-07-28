# Lusid.Sdk.Model.PaymentInstructionStatus
The current status of a Payment Instruction. Managed exclusively via the dedicated  status transition API — not accepted on upsert.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentValue** | **string** | The current status value. One of: Created, Staged, Released, Instructed, Sent, Cancelled. | 
**AsAtLastTransition** | **DateTimeOffset** | The as-at timestamp of the most recent status transition. | 
**UserIdLastTransition** | **string** | The ID of the user who made the most recent status transition. | 

```csharp
using Lusid.Sdk.Model;
using System;

string currentValue = "currentValue";
string userIdLastTransition = "userIdLastTransition";

PaymentInstructionStatus paymentInstructionStatusInstance = new PaymentInstructionStatus(
    currentValue: currentValue,
    asAtLastTransition: asAtLastTransition,
    userIdLastTransition: userIdLastTransition);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
