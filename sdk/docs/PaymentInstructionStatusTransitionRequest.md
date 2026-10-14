# Lusid.Sdk.Model.PaymentInstructionStatusTransitionRequest
A request to move one Payment Instruction to a new status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Status** | **string** | The status to move the Payment Instruction to. One of: Created, Staged, Released, Instructed, Sent, Cancelled, Failed. The transition must be permitted from the instruction&#39;s current status. Available values: Created, Staged, Released, Instructed, Sent, Cancelled, Failed. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string status = "status";

PaymentInstructionStatusTransitionRequest paymentInstructionStatusTransitionRequestInstance = new PaymentInstructionStatusTransitionRequest(
    id: id,
    status: status);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
