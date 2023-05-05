# Lusid.Sdk.Model.AggregatedReturnsDispersionRequest
The request used in the AggregatedReturnsDispersionMetric.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ToEffectiveAt** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The end date for when the you want the dispersion to be calculated. | [optional] 
**YearsCount** | **int** | For how many years to calculate the dispersion. Default to 10. | [optional] 
**ReturnIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The Scope and code of the returns. | [optional] 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**CompositeMethod** | **string** | The method used to calculate the Portfolio performance: Equal/Asset. | [optional] 
**AlternativeInceptionDate** | **string** | Optional - either a date, or the key for a portfolio property containing a date. If provided, the given date will override the inception date for this request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

