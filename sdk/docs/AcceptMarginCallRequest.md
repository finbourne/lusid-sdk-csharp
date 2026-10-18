# Lusid.Sdk.Model.AcceptMarginCallRequest
Accepts a margin call, at its default agreed amount or the amount given.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgreedAmount** | **decimal?** | The amount to accept. Optional when the call is matched or within tolerance, when our call or the counterparty&#39;s demand is taken; required when the demand breaks tolerance or has not been recorded. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;


AcceptMarginCallRequest acceptMarginCallRequestInstance = new AcceptMarginCallRequest(
    agreedAmount: agreedAmount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
