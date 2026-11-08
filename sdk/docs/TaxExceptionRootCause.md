# Lusid.Sdk.Model.TaxExceptionRootCause

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | A stable code for the cause, for example PoolOutOfSync or MissingTreatmentLeaf. | 
**Label** | **string** | A display label for the cause. | 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string label = "label";

TaxExceptionRootCause taxExceptionRootCauseInstance = new TaxExceptionRootCause(
    code: code,
    label: label);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
