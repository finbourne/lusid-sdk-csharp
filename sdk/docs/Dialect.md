# Lusid.Sdk.Model.Dialect
The language/format of a translatable entity. Entities can be LUSID native or external and the Dialect describes  1) the system that understands the entity and  2) applicable validation for the entity, in the form of a schema.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**DialectId**](DialectId.md) |  | 
**Schema** | [**DialectSchema**](DialectSchema.md) |  | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DialectId id = new DialectId();
DialectSchema schema = new DialectSchema();
ModelVersion? varVersion = new ModelVersion();


Dialect dialectInstance = new Dialect(
    id: id,
    schema: schema,
    varVersion: varVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
