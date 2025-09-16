# Lusid.Sdk.Model.UpsertRecipeComposerRequest
A recipe composer that is to be stored in the recipe composer data store or used for inline resolving.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecipeComposer** | [**RecipeComposer**](RecipeComposer.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

RecipeComposer? recipeComposer = new RecipeComposer();


UpsertRecipeComposerRequest upsertRecipeComposerRequestInstance = new UpsertRecipeComposerRequest(
    recipeComposer: recipeComposer);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
