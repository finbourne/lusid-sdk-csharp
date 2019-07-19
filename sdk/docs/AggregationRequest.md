
# Lusid.Sdk.Model.AggregationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecipeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**InlineRecipe** | [**ConfigurationRecipe**](ConfigurationRecipe.md) |  | [optional] 
**AsAt** | **DateTimeOffset?** | The asAt date to use | [optional] 
**EffectiveAt** | **DateTimeOffset?** | The market data time, i.e. the time to run the aggregation request effective of. | 
**Metrics** | [**List&lt;AggregateSpec&gt;**](AggregateSpec.md) | The set of specifications for items to calculate or retrieve during the aggregation and present in the results.  This is logically equivalent to the set of operations in a Sql select statement  select [operation1(field1), operation2(field2), ... ] from results | 
**GroupBy** | **List&lt;string&gt;** | The set of items by which to perform grouping. This primarily matters when one or more of the metric operators is a mapping  that reduces set size, e.g. sum or proportion. The group-by statement determines the set of keys by which to break the results out. | [optional] 
**Filters** | [**List&lt;PropertyFilter&gt;**](PropertyFilter.md) | A set of filters to use to reduce the data found in a request. Equivalent to the &#39;where ...&#39; part of a Sql select statement.  For example, filter a set of values within a given range or matching a particular value. | [optional] 
**Limit** | **int?** | limit the results to a particular number of values. | [optional] 
**Sort** | [**List&lt;OrderBySpec&gt;**](OrderBySpec.md) | A (possibly empty/null) set of specifications for how to order the results. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

