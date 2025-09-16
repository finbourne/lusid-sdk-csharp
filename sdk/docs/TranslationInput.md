# Lusid.Sdk.Model.TranslationInput
The input to a translation script.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | **string** | The serialised entity to be passed to the translation script. This could represent e.g. an instrument in any  dialect. | 

```csharp
using Lusid.Sdk.Model;
using System;

string entity = "entity";

TranslationInput translationInputInstance = new TranslationInput(
    entity: entity);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
