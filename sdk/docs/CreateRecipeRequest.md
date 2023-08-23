# Lusid.Sdk.Model.CreateRecipeRequest
Specification class to request for the creation/supplementing of a configuration recipe

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecipeCreationMarketDataScopes** | **List&lt;string&gt;** | The scopes in which the recipe creation would look for quotes/data. | 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**InlineRecipe** | [**ConfigurationRecipe**](ConfigurationRecipe.md) |  | [optional] 
**AsAt** | **DateTimeOffset?** | The asAt date to use | [optional] 
**EffectiveAt** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The market data time, i.e. the recipe generated will look for rules with this effectiveAt. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

