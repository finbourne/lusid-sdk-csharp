# Lusid.Sdk.Model.PaymentInstruction
A Payment Instruction groups one or more Payment Records into a single block  for transmission to a downstream treasury management system via the Horizon integration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**PaymentRecordIds** | [**List&lt;PaymentRecordReference&gt;**](PaymentRecordReference.md) | One or more Payment Records batched into this instruction block. All referenced Payment Records must share the same currency as the top-level currency field. | 
**Currency** | **string** | ISO 4217 currency code. All referenced Payment Records must share this currency value. | 
**TotalPaymentAmount** | **decimal** | Total payment amount across all referenced Payment Records. | 
**PaymentDate** | **DateTimeOffset** | The value date on which settlement is due. ISO 8601 date. | 
**PayorPaymentDetailsReference** | [**PaymentDetailsReferenceResponse**](PaymentDetailsReferenceResponse.md) |  | 
**PayeePaymentDetailsReference** | [**PaymentDetailsReferenceResponse**](PaymentDetailsReferenceResponse.md) |  | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this Payment Instruction. | [optional] 
**Status** | [**PaymentInstructionStatus**](PaymentInstructionStatus.md) |  | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
List<PaymentRecordReference> paymentRecordIds = new List<PaymentRecordReference>();
string currency = "currency";decimal totalPaymentAmount = "totalPaymentAmount";

PaymentDetailsReferenceResponse payorPaymentDetailsReference = new PaymentDetailsReferenceResponse();
PaymentDetailsReferenceResponse payeePaymentDetailsReference = new PaymentDetailsReferenceResponse();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
PaymentInstructionStatus status = new PaymentInstructionStatus();
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

PaymentInstruction paymentInstructionInstance = new PaymentInstruction(
    id: id,
    paymentRecordIds: paymentRecordIds,
    currency: currency,
    totalPaymentAmount: totalPaymentAmount,
    paymentDate: paymentDate,
    payorPaymentDetailsReference: payorPaymentDetailsReference,
    payeePaymentDetailsReference: payeePaymentDetailsReference,
    properties: properties,
    status: status,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
