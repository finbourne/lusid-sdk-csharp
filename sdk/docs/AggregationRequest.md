# Lusid.Sdk.Model.AggregationRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecipeId** | [**ResourceId**](ResourceId.md) |  | 
**LoadReferencePortfolio** | **bool?** |  | [optional] 
**AsAt** | **DateTimeOffset?** | The asAt date to use | [optional] 
**EffectiveAt** | **DateTimeOffset?** |  | 
**Metrics** | [**List&lt;AggregateSpec&gt;**](AggregateSpec.md) |  | 
**GroupBy** | **List&lt;string&gt;** |  | [optional] 
**Filters** | [**List&lt;PropertyFilter&gt;**](PropertyFilter.md) |  | [optional] 
**Limit** | **int?** |  | [optional] 
**Sort** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

