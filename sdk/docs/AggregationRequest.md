# Lusid.Sdk.Model.AggregationRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecipeId** | [**ResourceId**](ResourceId.md) | The configuration recipe, consisting of recipe scope and recipe name, to use in performing the aggregation. | [optional] 
**InlineRecipe** | [**ConfigurationRecipe**](ConfigurationRecipe.md) | Target Method for providing a non-named recipe.  If given, this replaces the &#39;RecipeId&#39; used with the bespoke recipe. This is intended to allow use of non-named  recipes to iterate quickly for design purposes. Ultimately it is recommended that production recipes would be stored  in Lusid.    USE OF ANY (INLINE) RECIPE IS AT PRESENT LIABLE TO CHANGE. | [optional] 
**AsAt** | **DateTimeOffset?** | The asAt date to use | [optional] 
**EffectiveAt** | **DateTimeOffset?** | The market data time, i.e. the time to run the aggregation request effective of. | 
**Metrics** | [**List&lt;AggregateSpec&gt;**](AggregateSpec.md) | The set of specifications for items to calculate or retrieve during the aggregation and present in the results.  This is logically equivalent to the set of operations in a Sql select statement  select [operation1(field1), operation2(field2), ... ] from results | 
**GroupBy** | **List&lt;string&gt;** | The set of items by which to perform grouping. This primarily matters when one or more of the metric operators is a mapping  that reduces set size, e.g. sum or proportion. The group-by statement determines the set of keys by which to break the results out. | [optional] 
**Filters** | [**List&lt;PropertyFilter&gt;**](PropertyFilter.md) | A set of filters to use to reduce the data found in a request. Equivalent to the &#39;where ...&#39; part of a Sql select statement.  For example, filter a set of values within a given range or matching a particular value. | [optional] 
**Limit** | **int?** | limit the results to a particular number of values. | [optional] 
**Sort** | **string** | Sort the results or not. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

