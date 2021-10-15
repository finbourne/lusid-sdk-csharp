# Lusid.Sdk.Model.PerformanceReturnsMetric
The request used in the AggregatedReturns.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of the metric. Default to Return | [optional] 
**Window** | **string** | The given metric for the calculation i.e. 1Y, 1D. | [optional] 
**AllowPartial** | **bool** | Bool if the metric is allowed partial results. Deafult to false. | [optional] 
**Annualised** | **bool** | Bool if the metric is annualized. Default to false. | [optional] 
**WithFee** | **bool** | Bool if the metric should consider the fees when is calculated. Default to false. | [optional] 
**SeedAmount** | **decimal?** | The given seed amount for the calculation of the indicative amount metrics. | [optional] 
**Alias** | **string** | The alias for the metric. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

