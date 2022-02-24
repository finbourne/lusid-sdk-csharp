# Lusid.Sdk.Model.Quote
The quote id, value and lineage of the quotes all keyed by a unique correlation id.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuoteId** | [**QuoteId**](QuoteId.md) |  | 
**MetricValue** | [**MetricValue**](MetricValue.md) |  | [optional] 
**Lineage** | **string** | Description of the quote&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;. | [optional] 
**CutLabel** | **string** | The cut label that this quote was updated or inserted with. | [optional] 
**UploadedBy** | **string** | The unique id of the user that updated or inserted the quote. | 
**AsAt** | **DateTimeOffset** | The asAt datetime at which the quote was committed to LUSID. | 
**ScaleFactor** | **decimal?** | An optional scale factor for non-standard scaling of quotes against the instrument. For example, if you wish the quote&#39;s Value to be scaled down by a factor of 100, enter 100. If not supplied, the default ScaleFactor is 1. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

