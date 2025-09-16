# Lusid.Sdk.Model.DataScope

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarClient** | [**ModelClient**](ModelClient.md) |  | [optional] 
**Scope** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ModelClient? varClient = new ModelClient();

string scope = "example scope";

DataScope dataScopeInstance = new DataScope(
    varClient: varClient,
    scope: scope);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
