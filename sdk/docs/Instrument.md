# Lusid.Sdk.Model.Instrument
A list of instruments.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specifc Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**LusidInstrumentId** | **string** | The unique LUSID Instrument Identifier (LUID) of the instrument. | 
**Version** | [**Version**](Version.md) |  | 
**Name** | **string** | The name of the instrument. | 
**Identifiers** | **Dictionary&lt;string, string&gt;** | The set of identifiers that can be used to identify the instrument. | 
**Properties** | [**List&lt;Property&gt;**](Property.md) | The requested instrument properties. These will be from the &#39;Instrument&#39; domain. | [optional] 
**LookthroughPortfolio** | [**ResourceId**](ResourceId.md) |  | [optional] 
**InstrumentDefinition** | [**InstrumentEconomicDefinition**](InstrumentEconomicDefinition.md) |  | [optional] 
**State** | **string** | The state of of the instrument at the asAt datetime of this version of the instrument definition. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

