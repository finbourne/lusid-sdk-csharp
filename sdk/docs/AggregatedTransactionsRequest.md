# Lusid.Sdk.Model.AggregatedTransactionsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromTransactionDate** | **DateTimeOffset** |  | 
**ToTransactionDate** | **DateTimeOffset** |  | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**AsAt** | **DateTimeOffset?** |  | [optional] 
**Metrics** | [**List&lt;AggregateSpec&gt;**](AggregateSpec.md) |  | 
**GroupBy** | **List&lt;string&gt;** |  | [optional] 
**Filters** | [**List&lt;PropertyFilter&gt;**](PropertyFilter.md) |  | [optional] 
**Sort** | [**List&lt;OrderBySpec&gt;**](OrderBySpec.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

