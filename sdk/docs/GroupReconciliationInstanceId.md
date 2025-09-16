# Lusid.Sdk.Model.GroupReconciliationInstanceId

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstanceIdType** | **string** | Type of the reconciliation run, manual or automatic (via the workflow). \&quot;Manual\&quot; | \&quot;WorkflowServiceTaskId\&quot; | 
**InstanceIdValue** | **string** | Reconciliation run identifier: a manually-provided key or taskId. | 

```csharp
using Lusid.Sdk.Model;
using System;

string instanceIdType = "instanceIdType";
string instanceIdValue = "instanceIdValue";

GroupReconciliationInstanceId groupReconciliationInstanceIdInstance = new GroupReconciliationInstanceId(
    instanceIdType: instanceIdType,
    instanceIdValue: instanceIdValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
