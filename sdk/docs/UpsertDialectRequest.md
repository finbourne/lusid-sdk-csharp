# Lusid.Sdk.Model.UpsertDialectRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**DialectId**](DialectId.md) |  | 
**Schema** | [**DialectSchema**](DialectSchema.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

DialectId id = new DialectId();
DialectSchema schema = new DialectSchema();

UpsertDialectRequest upsertDialectRequestInstance = new UpsertDialectRequest(
    id: id,
    schema: schema);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
