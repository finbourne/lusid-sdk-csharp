# Lusid.Sdk.Model.TranslationContext
Options for overriding default scripted translation configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisableScriptedTranslation** | **bool** |  | [optional] 
**ScriptMap** | [**ScriptMapReference**](ScriptMapReference.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool disableScriptedTranslation = //"True";
ScriptMapReference? scriptMap = new ScriptMapReference();


TranslationContext translationContextInstance = new TranslationContext(
    disableScriptedTranslation: disableScriptedTranslation,
    scriptMap: scriptMap);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
