# Lusid.Sdk.Model.Strategy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Keys** | [**List&lt;PerpetualProperty&gt;**](PerpetualProperty.md) |  | 
**ValueType** | **string** |  | 
**Value** | **decimal** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

List<PerpetualProperty> keys = new List<PerpetualProperty>();
string valueType = "valueType";decimal value = "value";


Strategy strategyInstance = new Strategy(
    keys: keys,
    valueType: valueType,
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
