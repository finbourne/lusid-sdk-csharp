# Lusid.Sdk.Model.UpsertTranslationScriptRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**TranslationScriptId**](TranslationScriptId.md) |  | 
**Body** | **string** | Body of the translation script, i.e. the actual translation code. | 

```csharp
using Lusid.Sdk.Model;
using System;

TranslationScriptId id = new TranslationScriptId();
string body = "body";

UpsertTranslationScriptRequest upsertTranslationScriptRequestInstance = new UpsertTranslationScriptRequest(
    id: id,
    body: body);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
