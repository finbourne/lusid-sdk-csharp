# Lusid.Sdk.Model.GetPaymentInstructionsResponse
The response from getting Payment Instructions by payment record id. Each requested payment record id  appears in exactly one of Values or Failed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**Dictionary&lt;string, PaymentInstruction&gt;**](PaymentInstruction.md) | The Payment Instructions that were found, keyed by the payment record id used to retrieve them. Only Payment Instructions that were found will be contained in this collection. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The payment record ids that did not resolve to a Payment Instruction, along with the nature of the failure. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, PaymentInstruction> values = new Dictionary<string, PaymentInstruction>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

GetPaymentInstructionsResponse getPaymentInstructionsResponseInstance = new GetPaymentInstructionsResponse(
    values: values,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
