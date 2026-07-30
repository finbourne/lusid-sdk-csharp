# Lusid.Sdk.Model.RecExceptionCountByResultType
Exception result counts broken down by result type.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Break** | **int** | The number of Break results. | 
**PartialMatch** | **int** | The number of Partial Match results. | 
**PartialCross** | **int** | The number of Partial Cross results. | 

```csharp
using Lusid.Sdk.Model;
using System;


RecExceptionCountByResultType recExceptionCountByResultTypeInstance = new RecExceptionCountByResultType(
    break: break,
    partialMatch: partialMatch,
    partialCross: partialCross);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
