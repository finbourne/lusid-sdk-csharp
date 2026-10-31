# Lusid.Sdk.Model.UpsertExternalTransferAgencyOrderResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**DealingPoint** | **DateTimeOffset** |  | [optional] 
**Late** | **bool** |  | [optional] 
**UpsertedOrders** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | [optional] 
**DeletedOrders** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? fundId = new ResourceId();

bool late = //"True";
List<ResourceId> upsertedOrders = new List<ResourceId>();
List<ResourceId> deletedOrders = new List<ResourceId>();

UpsertExternalTransferAgencyOrderResult upsertExternalTransferAgencyOrderResultInstance = new UpsertExternalTransferAgencyOrderResult(
    fundId: fundId,
    dealingPoint: dealingPoint,
    late: late,
    upsertedOrders: upsertedOrders,
    deletedOrders: deletedOrders);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
