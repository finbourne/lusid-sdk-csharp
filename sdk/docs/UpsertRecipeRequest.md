# Lusid.Sdk.Model.UpsertRecipeRequest
A recipe that is to be stored in the recipe structured data store.  Only one of these must be present.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigurationRecipe** | [**ConfigurationRecipe**](ConfigurationRecipe.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ConfigurationRecipe? configurationRecipe = new ConfigurationRecipe();


UpsertRecipeRequest upsertRecipeRequestInstance = new UpsertRecipeRequest(
    configurationRecipe: configurationRecipe);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
