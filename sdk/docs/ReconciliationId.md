# Lusid.Sdk.Model.ReconciliationId

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | [**DataScope**](DataScope.md) |  | [optional] 
**Identifier** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DataScope? scope = new DataScope();

string identifier = "example identifier";

ReconciliationId reconciliationIdInstance = new ReconciliationId(
    scope: scope,
    identifier: identifier);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
