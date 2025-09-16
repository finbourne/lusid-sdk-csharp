# Lusid.Sdk.Model.TranslationScriptId
Id of the Translation Script.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | Scope of the translation script. | 
**Code** | **string** | Code of the translation script. | 
**VarVersion** | **string** | Semantic Version of the translation script of the form MAJOR.MINOR.PATCH. | 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "code";
string varVersion = "varVersion";

TranslationScriptId translationScriptIdInstance = new TranslationScriptId(
    scope: scope,
    code: code,
    varVersion: varVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
