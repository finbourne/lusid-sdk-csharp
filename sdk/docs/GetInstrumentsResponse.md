
# Lusid.Sdk.Model.GetInstrumentsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** |  | [optional] 
**Values** | [**Dictionary&lt;string, Instrument&gt;**](Instrument.md) | The instruments, keyed by their requested identifier. Only instruments that were found  will be contained in this collection. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | If any instruments were not found, then they will be listed in as &#39;Failed&#39;, along with the nature  of their failure. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

