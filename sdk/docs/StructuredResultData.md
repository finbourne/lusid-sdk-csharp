# Lusid.Sdk.Model.StructuredResultData
An item of structured result data that is to be inserted into Lusid. This will typically be a Json or Xml document that  contains a set of result data appropriate to a specific entity such as an instrument or potentially an index.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentFormat** | **string** | The format of the accompanying document. | 
**Version** | **string** | The semantic version of the document format; MAJOR.MINOR.PATCH | [optional] 
**Name** | **string** | The name or description for the document | [optional] 
**Document** | **string** | The document that will be stored (or retrieved) and which describes a unit result data entity such as a set of prices or yields | 
**DataMap** | [**DataMapping**](DataMapping.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

