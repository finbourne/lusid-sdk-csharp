# Lusid.Sdk.Model.TransitionPaymentInstructionsResponse
The response from transitioning the status of a set of Payment Instructions. Each request key from the  incoming map appears in exactly one of Values or Failed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**Dictionary&lt;string, PaymentInstruction&gt;**](PaymentInstruction.md) | The Payment Instructions that were transitioned successfully, at their new status, keyed by the ephemeral request key supplied by the caller. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | Details of the requested transitions that failed, keyed by the ephemeral request key supplied by the caller. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, PaymentInstruction> values = new Dictionary<string, PaymentInstruction>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

TransitionPaymentInstructionsResponse transitionPaymentInstructionsResponseInstance = new TransitionPaymentInstructionsResponse(
    values: values,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
