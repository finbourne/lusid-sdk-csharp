# Lusid.Sdk.Model.EstimateTransferAgencyOrderRequest
A request to estimate the values of one order. `OrderId` is required whether or not the order has been  saved, because it is the identity the estimate is returned against. Supply `Order` to estimate values  that differ from - or do not yet exist in - the saved order.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | [**ResourceId**](ResourceId.md) |  | 
**Order** | [**TransferAgencyOrderToEstimate**](TransferAgencyOrderToEstimate.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId orderId = new ResourceId();
TransferAgencyOrderToEstimate? order = new TransferAgencyOrderToEstimate();


EstimateTransferAgencyOrderRequest estimateTransferAgencyOrderRequestInstance = new EstimateTransferAgencyOrderRequest(
    orderId: orderId,
    order: order);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
