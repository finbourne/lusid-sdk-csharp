# Lusid.Sdk.Model.DeleteTransferAgencyOrderResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**CancelledTransactionIds** | **List&lt;string&gt;** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? orderId = new ResourceId();

List<string> cancelledTransactionIds = new List<string>();

DeleteTransferAgencyOrderResult deleteTransferAgencyOrderResultInstance = new DeleteTransferAgencyOrderResult(
    orderId: orderId,
    cancelledTransactionIds: cancelledTransactionIds);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
