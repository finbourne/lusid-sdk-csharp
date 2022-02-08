# Lusid.Sdk.Model.AggregatedReturnsRequest
The request used in the AggregatedReturns.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Metrics** | [**List&lt;PerformanceReturnsMetric&gt;**](PerformanceReturnsMetric.md) | A list of metrics to calculate in the AggregatedReturns. | 
**ReturnId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**CompositeMethod** | **string** | The method used to calculate the Portfolio performance: Equal/Asset. | [optional] 
**Period** | **string** | The type of the returns used to calculate the aggregation result: Daily/Monthly. | [optional] 
**OutputFrequency** | **string** | The type of calculated output: Daily/Weekly/Monthly/Quarterly/Half-Yearly/Yearly. | [optional] 
**AlternativeInceptionDate** | **string** | Optional - either a date, or the key for a portfolio property containing a date. If provided, the given date will override the inception date for this request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

