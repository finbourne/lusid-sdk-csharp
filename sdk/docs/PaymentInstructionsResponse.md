# Lusid.Sdk.Model.PaymentInstructionsResponse
The response from upserting a set of Payment Instructions. Each request key from the  incoming map appears in exactly one of Successes or Failed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successes** | [**Dictionary&lt;string, PaymentInstruction&gt;**](PaymentInstruction.md) | The Payment Instructions that were created or updated successfully, keyed by the ephemeral request key supplied by the caller. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | Details of the requests that failed, keyed by the ephemeral request key supplied by the caller. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, PaymentInstruction> successes = new Dictionary<string, PaymentInstruction>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

PaymentInstructionsResponse paymentInstructionsResponseInstance = new PaymentInstructionsResponse(
    successes: successes,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
