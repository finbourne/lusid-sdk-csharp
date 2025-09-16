# Lusid.Sdk.Model.TranslationScript

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**TranslationScriptId**](TranslationScriptId.md) |  | 
**Body** | **string** | Body of the translation script, i.e. the actual translation code. | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

TranslationScriptId id = new TranslationScriptId();
string body = "body";
ModelVersion? varVersion = new ModelVersion();


TranslationScript translationScriptInstance = new TranslationScript(
    id: id,
    body: body,
    varVersion: varVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
