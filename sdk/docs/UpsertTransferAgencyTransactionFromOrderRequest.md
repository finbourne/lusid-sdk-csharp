# Lusid.Sdk.Model.UpsertTransferAgencyTransactionFromOrderRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | [**ResourceId**](ResourceId.md) |  | 
**PriceDate** | **DateTimeOffset** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId orderId = new ResourceId();

UpsertTransferAgencyTransactionFromOrderRequest upsertTransferAgencyTransactionFromOrderRequestInstance = new UpsertTransferAgencyTransactionFromOrderRequest(
    orderId: orderId,
    priceDate: priceDate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
