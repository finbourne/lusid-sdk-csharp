# Lusid.Sdk.Model.RecInstanceId
Identifies a rec instance, and how it was created.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstanceIdType** | **string** | How the instance was created. Available values: WorkflowServiceTaskId, Manual. | 
**InstanceIdValue** | **string** | The instance identifier value (a GUID). | 

```csharp
using Lusid.Sdk.Model;
using System;

string instanceIdType = "instanceIdType";
string instanceIdValue = "instanceIdValue";

RecInstanceId recInstanceIdInstance = new RecInstanceId(
    instanceIdType: instanceIdType,
    instanceIdValue: instanceIdValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
