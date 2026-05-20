# Lusid.Sdk.Model.TransferAgencyOrderResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**TransactionId** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? orderId = new ResourceId();

string transactionId = "example transactionId";

TransferAgencyOrderResult transferAgencyOrderResultInstance = new TransferAgencyOrderResult(
    orderId: orderId,
    transactionId: transactionId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
