# Lusid.Sdk.Model.UpsertInstrumentsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Values** | [**Dictionary&lt;string, Instrument&gt;**](Instrument.md) | The instruments which have been successfully updated or created. | [optional] 
**Staged** | [**Dictionary&lt;string, Instrument&gt;**](Instrument.md) | The instruments that have been staged for updation or creation. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The instruments that could not be updated or created or were left unchanged without error along with a reason for their failure. | [optional] 
**Metadata** | **Dictionary&lt;string, List&lt;ResponseMetaData&gt;&gt;** | Meta data associated with the upsert event. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

