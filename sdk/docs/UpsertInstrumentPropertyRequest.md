
# Lusid.Sdk.Model.UpsertInstrumentPropertyRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LusidInstrumentId** | **string** | The unique Lusid Instrument Identifier (LUID) of the instrument to update or insert properties on. | 
**Properties** | [**List&lt;Property&gt;**](Property.md) | Set of unique instrument properties and associated values to store with the instrument. Each property must be from the &#39;Instrument&#39; domain. | [optional] 
**DeletedProperties** | [**List&lt;DeleteInstrumentPropertyRequest&gt;**](DeleteInstrumentPropertyRequest.md) | Set of unique instrument properties to delete from the instrument. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

