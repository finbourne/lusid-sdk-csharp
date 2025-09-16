# Lusid.Sdk.Model.ResourceId
Identifiers of an entity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope used to identify an entity | 
**Code** | **string** | The code used to identify an entity | 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "code";

ResourceId resourceIdInstance = new ResourceId(
    scope: scope,
    code: code);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
