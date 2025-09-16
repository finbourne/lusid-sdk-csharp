# Lusid.Sdk.Model.ScriptMapReference
Provides information about the location of a script map within the configuration store

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope of the configuration store entry where the translation map is located. | 
**Code** | **string** | The code of the configuration store entry where the translation map is located. | 
**Key** | **string** | The key of the configuration store entry where the translation map is located. | 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "code";
string key = "key";

ScriptMapReference scriptMapReferenceInstance = new ScriptMapReference(
    scope: scope,
    code: code,
    key: key);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
