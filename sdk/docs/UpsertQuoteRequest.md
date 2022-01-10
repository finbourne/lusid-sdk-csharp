# Lusid.Sdk.Model.UpsertQuoteRequest
The details of the quote including its unique identifier, value and lineage.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuoteId** | [**QuoteId**](QuoteId.md) |  | 
**MetricValue** | [**MetricValue**](MetricValue.md) |  | [optional] 
**Lineage** | **string** | Description of the quote&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;. | [optional] 
**ScaleFactor** | **decimal?** | An optional scale factor for non-standard scaling of quotes against the instrument. If not supplied, the default ScaleFactor is 1. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

