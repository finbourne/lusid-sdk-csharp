# Lusid.Sdk.Model.DisputeMarginCallRequest
Disputes a margin call: moves the agreed amount now and leaves the rest of the demand in dispute.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgreedAmount** | **decimal** | The amount to move now; the rest of the counterparty&#39;s demand is left in dispute. | 
**Reason** | **string** | Why the call is disputed. | 
**Owner** | **string** | Who owns the dispute. Defaults to the caller if not specified. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal agreedAmount = "agreedAmount";

string reason = "reason";
string owner = "example owner";

DisputeMarginCallRequest disputeMarginCallRequestInstance = new DisputeMarginCallRequest(
    agreedAmount: agreedAmount,
    reason: reason,
    owner: owner);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
