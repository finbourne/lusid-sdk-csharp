# Lusid.Sdk.Model.ReturnsEntity
Returns entity, used for configuring the calculation of aggregated returns.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**RecipeEntity** | **string** | Entity a recipe is retrieved from for use in the aggregated returns calculation. Either RecipeId or RecipeEntity must be specified. | [optional] 
**FeeHandling** | **string** | Configures how fees are handled in the aggregated returns calculation. | [optional] 
**FlowHandling** | **string** | Configures how flows are handled in the aggregated returns calculation. | [optional] 
**BusinessCalendar** | **string** | Calendar used in the aggregated returns calculation. | [optional] 
**HandleFlowDiscrepancy** | **string** | Configures handling for the case where net flows do not match the sum of tagged flows. | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

