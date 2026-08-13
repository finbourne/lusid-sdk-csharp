# Lusid.Sdk.Model.RecResultAssignmentUpdate
An assignment update (assigned user or role) within a batch review item. Omitting the object leaves  the existing value untouched; a null value nullifies it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **string** | The value to set, or null to nullify. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string value = "example value";

RecResultAssignmentUpdate recResultAssignmentUpdateInstance = new RecResultAssignmentUpdate(
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
