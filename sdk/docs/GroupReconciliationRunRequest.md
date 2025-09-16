# Lusid.Sdk.Model.GroupReconciliationRunRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstanceId** | **string** | Reconciliation run Id. Consists of run type (manual or workflow) and identifier. | 
**DatesToReconcile** | [**GroupReconciliationDates**](GroupReconciliationDates.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string instanceId = "instanceId";
GroupReconciliationDates? datesToReconcile = new GroupReconciliationDates();


GroupReconciliationRunRequest groupReconciliationRunRequestInstance = new GroupReconciliationRunRequest(
    instanceId: instanceId,
    datesToReconcile: datesToReconcile);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
