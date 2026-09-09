# Lusid.Sdk.Model.TransferAgencyExcludedOrder
An order left out of the sizing an estimate was struck from, with the reason it was left out.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Reason** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? orderId = new ResourceId();

string reason = "example reason";

TransferAgencyExcludedOrder transferAgencyExcludedOrderInstance = new TransferAgencyExcludedOrder(
    orderId: orderId,
    reason: reason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
