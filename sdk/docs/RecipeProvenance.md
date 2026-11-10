# Lusid.Sdk.Model.RecipeProvenance
The recipe a fund valuation was priced with, and where it came from. Absent when the fund has no portfolios  at the effective date, as nothing is priced and no recipe is resolved.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecipeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Source** | **string** | Where the recipe came from. &#39;NavType&#39; when it is the recipe on the nominated NAV type&#39;s definition;  &#39;Request&#39; when the request named a recipeId that replaced it for pricing in that request only. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? recipeId = new ResourceId();

string source = "example source";

RecipeProvenance recipeProvenanceInstance = new RecipeProvenance(
    recipeId: recipeId,
    source: source);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
