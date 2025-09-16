# Lusid.Sdk.Model.OpaqueModelOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelOptionsType** | **string** | The available values are: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, CdsModelOptions | 
**Data** | **Dictionary&lt;string, Object&gt;** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, Object> data = new Dictionary<string, Object>();

OpaqueModelOptions opaqueModelOptionsInstance = new OpaqueModelOptions(
    data: data);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
