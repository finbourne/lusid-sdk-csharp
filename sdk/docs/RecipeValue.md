# Lusid.Sdk.Model.RecipeValue
Recipe value represents a data that is then used to perform an atomic operation which is then used in composition of Configuration Recipe.  This object either includes the data itself (in json form or as simple string) or is a reference where the data can be obtained from (from a Configuration Recipe say).  Only one field is to be populated.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsJson** | **string** | Field to allow providing a potentially complex json value. | [optional] 
**AsString** | **string** | For simple value, a single input value, note complex nested objects are not allowed here. | [optional] 
**FromRecipe** | [**FromRecipe**](FromRecipe.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

