# Lusid.Sdk.Model.UpsertExternalDealingEstimateResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**DealingPoint** | **DateTimeOffset** |  | [optional] 
**Late** | **bool** |  | [optional] 
**UpsertedEstimates** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | [optional] 
**DeletedEstimates** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? fundId = new ResourceId();

bool late = //"True";
List<ResourceId> upsertedEstimates = new List<ResourceId>();
List<ResourceId> deletedEstimates = new List<ResourceId>();

UpsertExternalDealingEstimateResult upsertExternalDealingEstimateResultInstance = new UpsertExternalDealingEstimateResult(
    fundId: fundId,
    dealingPoint: dealingPoint,
    late: late,
    upsertedEstimates: upsertedEstimates,
    deletedEstimates: deletedEstimates);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
